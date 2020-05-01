using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace CreateSRTFromSAPTranscriptPDF
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private List<SRTInfo> sRTInfos;
        private List<SRTInfo> ignoredSRTInfos;
        private List<GroupedSRT> groupedSRTs;

        private void btnBrowsePDFFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            ofd.DefaultExt = "pdf";
            ofd.Filter = "PDF files (*.pdf)|*.pdf";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPDFFilePath.Text = ofd.FileName;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            sRTInfos = new List<SRTInfo>();
            ignoredSRTInfos = new List<SRTInfo>();
            groupedSRTs = new List<GroupedSRT>();

            btnAddSRT.Enabled = true;
            btnRemoveSRT.Enabled = true;
            btnViewIgnoredSRT.Enabled = true;

            dgvReadSRTContent.Rows.Clear();
            dgvSRTList.Rows.Clear();

            SRTInfo sRTInfo = null;

            FileInfo fileInfo = new FileInfo(txtPDFFilePath.Text);
            txtFileName.Text = fileInfo.Name;

            int pageIndex = 1;
            string pageContent = "";
            string[] lines;
            string strLine;
            int lineIndex = 0;
            bool isSRT = false;
            bool isSRTStartedInPage = false;
            DateTime tmStart = new DateTime();
            DateTime tmEnd = new DateTime();
            string strSubtitlte = "";
            bool blIsNewSRTScript = false;

            PdfReader pdfReader = new PdfReader(txtPDFFilePath.Text);
            int pageCount = pdfReader.NumberOfPages;
            int SRTIndex = 0;

            //loops throughtthe pages
            for (pageIndex = 1; pageIndex <= pageCount; pageIndex++)
            {
                pageContent = PdfTextExtractor.GetTextFromPage(pdfReader, pageIndex, new LocationTextExtractionStrategy());

                lines = pageContent.Split('\n');

                isSRT = false;
                isSRTStartedInPage = false;

                sRTInfo = null;

                //Loops through the lines
                for (lineIndex = 0; lineIndex < lines.Length; lineIndex++)
                {
                    strLine = lines[lineIndex].Trim();
                    isSRT = Helpers.isSRT(strLine);

                    //Checks line is SRT
                    if (isSRT)
                    {
                        if (isSRTStartedInPage == false)
                        {
                            isSRTStartedInPage = true;
                        }

                        if (sRTInfo != null)
                        {
                            sRTInfos.Add(sRTInfo);
                        }

                        tmStart = Helpers.getTimeFromSRT(strLine);
                        tmEnd = tmStart.AddMinutes(5);
                        strSubtitlte = Helpers.getTextFromSRT(strLine);

                        blIsNewSRTScript = isNewSRTScript(sRTInfos, tmStart);

                        if (blIsNewSRTScript)
                        {
                            //sRTInfos = new List<SRTInfo>();
                        }
                        else
                        {
                            if (sRTInfos.Count > 0)
                            {
                                sRTInfos[sRTInfos.Count - 1].EndTime = tmStart.AddSeconds(-1).AddMilliseconds(999);
                            }
                        }

                        sRTInfo = null;

                        SRTIndex++;
                        sRTInfo = new SRTInfo();
                        sRTInfo.isRemoved = false;
                        sRTInfo.Index = SRTIndex;
                        sRTInfo.StartTime = tmStart;
                        sRTInfo.EndTime = tmEnd;
                        sRTInfo.SRT_Text = strSubtitlte;
                        sRTInfo.SRT_Lines = new List<string>();
                        sRTInfo.SRT_Lines.Add(strSubtitlte);
                    }
                    else
                    {
                        if (isSRTStartedInPage)
                        {
                            if (Helpers.isFooterContent(strLine.Trim()))
                            {
                                ignoredSRTInfos.Add(new SRTInfo
                                {
                                    Index = sRTInfo.Index,
                                    StartTime = sRTInfo.StartTime,
                                    EndTime = sRTInfo.EndTime,
                                    SRT_Text = strLine.Trim(),
                                    SRT_Lines = new List<string>()
                                    {
                                        strLine.Trim()
                                    },
                                });
                            }
                            else
                            {
                                sRTInfo.SRT_Text += " " + strLine.Trim();
                                sRTInfo.SRT_Lines.Add(strLine.Trim());
                            }
                        }
                    }
                }

                if (sRTInfo != null)
                {
                    sRTInfos.Add(sRTInfo);
                    sRTInfo = null;
                }
            }


            int groupedSRTIndex = 0;
            GroupedSRT groupedSRT = null;

            foreach (SRTInfo objSRTInfo in sRTInfos)
            {
                if (groupedSRTs.Count == 0 ||
                    objSRTInfo.StartTime < groupedSRT.sRTInfos[groupedSRT.sRTInfos.Count -1].EndTime)
                {
                    groupedSRTIndex++;
                    groupedSRT = new GroupedSRT();
                    groupedSRT.GroupName = "Unit " + groupedSRTIndex;
                    groupedSRT.sRTInfos = new List<SRTInfo>();
                    groupedSRTs.Add(groupedSRT);
                }
                groupedSRT.sRTInfos.Add(objSRTInfo);

                objSRTInfo.isRemoved = true;
            }

            foreach(GroupedSRT objGroupedSRT in groupedSRTs)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(dgvSRTList);
                dataGridViewRow.Cells[0].Value = objGroupedSRT.GroupName;
                dataGridViewRow.Cells[1].Value = objGroupedSRT.sRTInfos.Count;

                dgvSRTList.Rows.Add(dataGridViewRow);
            }

            updateSRTDataGridView();
        }

        private bool isNewSRTScript(List<SRTInfo> sRTInfos, DateTime startTime)
        {
            if (sRTInfos.Count == 0) return false;

            SRTInfo sRTInfo = sRTInfos.Last();

            if (sRTInfo == null)
            {
                return false;
            }
            else if (sRTInfo.StartTime > startTime)
            {
                return true;
            }

            return false;
        }

        private void updateSRTDataGridView()
        {
            DataGridViewRow dgvRow;

            dgvReadSRTContent.Rows.Clear();

            foreach (SRTInfo objSRTInfo in sRTInfos)
            {
                dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(dgvReadSRTContent);

                dgvRow.Cells[0].Value = objSRTInfo.Index;
                dgvRow.Cells[1].Value = objSRTInfo.StartTime.ToString("HH:mm:ss");
                dgvRow.Cells[2].Value = objSRTInfo.EndTime.ToString("HH:mm:ss");
                dgvRow.Cells[3].Value = (objSRTInfo.EndTime - objSRTInfo.StartTime).TotalSeconds;
                dgvRow.Cells[4].Value = objSRTInfo.SRT_Text;
                dgvRow.Visible = !objSRTInfo.isRemoved;

                dgvReadSRTContent.Rows.Add(dgvRow);
            }
        }

        private void btnAddSRT_Click(object sender, EventArgs e)
        {
            if (dgvReadSRTContent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select rows.", "SRT");
                return;
            }

            retry:
            string SRTName = Microsoft.VisualBasic.Interaction.InputBox("Enter name of the SRT", "SRTName");
            if (SRTName.Trim() == "")
            {
                goto retry;
            }

            foreach (GroupedSRT objGroupedSRT in groupedSRTs)
            {
                if (objGroupedSRT.GroupName.Trim().ToLower() == SRTName.Trim().ToLower())
                {
                    MessageBox.Show("SRTName already exists");
                    goto retry;
                }
            }

            GroupedSRT groupedSRT = new GroupedSRT();
            groupedSRT.sRTInfos = new List<SRTInfo>();
            groupedSRT.GroupName = SRTName;
            SRTInfo sRTInfo = null;

            int rowSRTIndex = 0;
            foreach (DataGridViewRow row in dgvReadSRTContent.Rows)
            {
                if (row.Selected)
                {
                    rowSRTIndex = (int)row.Cells[0].Value;

                    foreach (SRTInfo objSRTInfo in sRTInfos)
                    {
                        if (objSRTInfo.Index == rowSRTIndex)
                        {
                            sRTInfo = new SRTInfo();

                            sRTInfo.Index = objSRTInfo.Index;
                            sRTInfo.StartTime = objSRTInfo.StartTime;
                            sRTInfo.EndTime = objSRTInfo.EndTime;
                            sRTInfo.SRT_Lines = objSRTInfo.SRT_Lines;
                            sRTInfo.SRT_Text = objSRTInfo.SRT_Text;

                            groupedSRT.sRTInfos.Add(sRTInfo);

                            objSRTInfo.isRemoved = true;
                            break;
                        }
                    }
                }
            }

            groupedSRTs.Add(groupedSRT);

            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dgvSRTList);
            dataGridViewRow.Cells[0].Value = groupedSRT.GroupName;
            dataGridViewRow.Cells[1].Value = groupedSRT.sRTInfos.Count;

            dgvSRTList.Rows.Add(dataGridViewRow);

            foreach (SRTInfo objSRTInfo in sRTInfos)
            {
                foreach (DataGridViewRow row in dgvReadSRTContent.Rows)
                {
                    rowSRTIndex = (int)row.Cells[0].Value;

                    if (rowSRTIndex == objSRTInfo.Index)
                    {
                        if (objSRTInfo.isRemoved == true)
                        {
                            row.Visible = false;
                        }
                        break;
                    }
                }

            }
        }

        private void btnRemoveSRT_Click(object sender, EventArgs e)
        {
            if (dgvSRTList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select rows.", "SRT");
                return;
            }

            DataGridViewRow groupedRow = dgvSRTList.SelectedRows[0];
            string srtName = groupedRow.Cells[0].Value.ToString();

            foreach (GroupedSRT groupedSRT in groupedSRTs)
            {
                if (groupedSRT.GroupName.Trim().ToLower() == srtName.Trim().ToLower())
                {
                    foreach (SRTInfo sRTInfo in groupedSRT.sRTInfos)
                    {
                        foreach (DataGridViewRow readSRTRow in dgvReadSRTContent.Rows)
                        {
                            if ((int)readSRTRow.Cells[0].Value == sRTInfo.Index)
                            {
                                readSRTRow.Visible = true;

                                foreach(SRTInfo rTInfo in sRTInfos)
                                {
                                    if(rTInfo.Index == sRTInfo.Index)
                                    {
                                        rTInfo.isRemoved = false;
                                    }
                                }

                                break;
                            }
                        }
                    }

                    dgvSRTList.Rows.Remove(groupedRow);
                    groupedSRTs.Remove(groupedSRT);
                    break;
                }
            }
        }

        private void dgvReadSRTContent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Helpers.isSRTModified = false;
            Helpers.ModifiedSRT = null;

            SRTInfo sRTInfo = null;
            int srtIndex = (int)dgvReadSRTContent.Rows[e.RowIndex].Cells[0].Value;

            foreach (SRTInfo objSRTInfo in sRTInfos)
            {
                if (objSRTInfo.Index == srtIndex)
                {
                    sRTInfo = new SRTInfo();

                    sRTInfo.Index = objSRTInfo.Index;
                    sRTInfo.StartTime = objSRTInfo.StartTime;
                    sRTInfo.EndTime = objSRTInfo.EndTime;
                    sRTInfo.SRT_Text = objSRTInfo.SRT_Text;
                    sRTInfo.SRT_Lines = objSRTInfo.SRT_Lines;

                    break;
                }
            }

            FrmEditSRT frmEditSRT = new FrmEditSRT(sRTInfo);
            frmEditSRT.ShowDialog();

            if (Helpers.isSRTModified)
            {
                foreach (SRTInfo objSRTInfo in sRTInfos)
                {
                    if (objSRTInfo.Index == srtIndex)
                    {
                        objSRTInfo.StartTime = Helpers.ModifiedSRT.StartTime;
                        objSRTInfo.EndTime = Helpers.ModifiedSRT.EndTime;
                        objSRTInfo.SRT_Text = Helpers.ModifiedSRT.SRT_Text;
                        objSRTInfo.SRT_Lines = Helpers.ModifiedSRT.SRT_Lines;

                        break;
                    }
                }

                foreach (DataGridViewRow row in dgvReadSRTContent.Rows)
                {
                    if (row.Cells[0].Value.ToString().Trim() == srtIndex.ToString())
                    {
                        row.Cells[1].Value = Helpers.ModifiedSRT.StartTime.ToString("HH:mm:ss");
                        row.Cells[2].Value = Helpers.ModifiedSRT.EndTime.ToString("HH:mm:ss");
                        row.Cells[3].Value = (Helpers.ModifiedSRT.EndTime - Helpers.ModifiedSRT.StartTime).TotalSeconds;
                        row.Cells[4].Value = Helpers.ModifiedSRT.SRT_Text;

                        break;
                    }
                }

            }
        }

        private void btnViewIgnoredSRT_Click(object sender, EventArgs e)
        {
            FrmViewIgnoredSRT frmViewIgnoredSRT = new FrmViewIgnoredSRT(ignoredSRTInfos);
            frmViewIgnoredSRT.ShowDialog();

            frmViewIgnoredSRT.Dispose();
        }

        private void dgvSRTList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow srtRow = dgvSRTList.Rows[e.RowIndex];

            foreach (GroupedSRT groupedSRT in groupedSRTs)
            {
                if (srtRow.Cells[0].Value.ToString().Trim().ToLower() == groupedSRT.GroupName.Trim().ToLower())
                {
                    FrmCreateSRT frmCreateSRT = new FrmCreateSRT(groupedSRT, txtPDFFilePath.Text);
                    frmCreateSRT.WindowState = FormWindowState.Maximized;
                    frmCreateSRT.ShowDialog();

                    break;
                }
            }
        }

        private void dgvSRTList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSRTList.SelectedRows.Count == 0)
            {
                btnViewGroupedSRT.Enabled = false;
                return;
            }

            btnViewGroupedSRT.Enabled = true;
        }

        private void btnViewGroupedSRT_Click(object sender, EventArgs e)
        {
            DataGridViewRow groupedRow = dgvSRTList.SelectedRows[0];

            foreach (GroupedSRT groupedSRT in groupedSRTs)
            {
                if (groupedRow.Cells[0].Value.ToString().Trim().ToLower() == groupedSRT.GroupName.Trim().ToLower())
                {
                    FrmViewSRT frmViewSRT = new FrmViewSRT(groupedSRT);
                    frmViewSRT.WindowState = FormWindowState.Maximized;
                    frmViewSRT.ShowDialog();

                    break;
                }
            }
        }
    }
}
