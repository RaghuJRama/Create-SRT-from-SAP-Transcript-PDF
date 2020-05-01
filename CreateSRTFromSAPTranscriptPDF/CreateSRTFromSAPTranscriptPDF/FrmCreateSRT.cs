using System;
using System.IO;
using System.Windows.Forms;

namespace CreateSRTFromSAPTranscriptPDF
{
    public partial class FrmCreateSRT : Form
    {
        private GroupedSRT _groupedSRT;
        private string _transcriptPDFPath;

        public FrmCreateSRT(GroupedSRT groupedSRT, string transcriptPDFPath)
        {
            InitializeComponent();

            _groupedSRT = groupedSRT;
            _transcriptPDFPath = transcriptPDFPath;

            UpdateUI();
        }

        private void UpdateUI()
        {
            this.Text = "Create - " + _groupedSRT.GroupName + " - SRT";
            txtInputTranscriptPath.Text = _transcriptPDFPath;

            dgvSRTContent.Rows.Clear();
            DataGridViewRow dgvRow;

            foreach (SRTInfo objSRTInfo in _groupedSRT.sRTInfos)
            {
                dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(dgvSRTContent);

                dgvRow.Cells[0].Value = objSRTInfo.Index;
                dgvRow.Cells[1].Value = objSRTInfo.StartTime.ToString("HH:mm:ss");
                dgvRow.Cells[2].Value = objSRTInfo.EndTime.ToString("HH:mm:ss");
                dgvRow.Cells[3].Value = (objSRTInfo.EndTime - objSRTInfo.StartTime).TotalSeconds;
                dgvRow.Cells[4].Value = objSRTInfo.SRT_Text;


                dgvSRTContent.Rows.Add(dgvRow);
            }
        }

        private void btnBrowseMP4File_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            ofd.DefaultExt = "mp4";
            ofd.Filter = "MP4 files (*.mp4)|*.mp4";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = Path.GetDirectoryName(txtInputTranscriptPath.Text);

            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtMP4Path.Text = ofd.FileName;
                txtSRTPath.Text = Path.Combine(Path.GetDirectoryName(ofd.FileName), Path.GetFileNameWithoutExtension(ofd.FileName) + ".srt");
            }
            else
            {
                txtMP4Path.Text = "";
                txtSRTPath.Text = "";
            }
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            int srtIndex = 0;
            string strContent = "";
            string txtFileName = "";
            string txtContent = "";

            txtFileName = txtSRTPath.Text.Left(txtSRTPath.Text.Length - 3) + "txt";

            foreach(SRTInfo sRTInfo in _groupedSRT.sRTInfos)
            {
                srtIndex = srtIndex + 1;

                strContent += srtIndex.ToString() + Environment.NewLine;
                strContent += Helpers.getSRTTimeFormat(sRTInfo);
                strContent += Environment.NewLine;
                strContent += sRTInfo.SRT_Text;
                txtContent += sRTInfo.SRT_Text + Environment.NewLine + Environment.NewLine;
                strContent += Environment.NewLine + Environment.NewLine;
            }

            File.WriteAllText(txtSRTPath.Text, strContent,System.Text.Encoding.UTF8);
            File.WriteAllText(txtFileName, txtContent, System.Text.Encoding.UTF8);

            MessageBox.Show("SRT created successfully");
        }

        private void FrmCreateSRT_Load(object sender, EventArgs e)
        {
            int width = dgvSRTContent.Width;
            dgvSRTContent.Columns[4].Width = width - 230;
        }
    }
}
