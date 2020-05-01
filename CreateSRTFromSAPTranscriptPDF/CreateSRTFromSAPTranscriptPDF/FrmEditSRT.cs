using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateSRTFromSAPTranscriptPDF
{
    public partial class FrmEditSRT : Form
    {
        private SRTInfo _originalSRTs;

        public FrmEditSRT(SRTInfo sRTInfos )
        {
            InitializeComponent();

            _originalSRTs = sRTInfos;
            UpdateUI();
        }

        private void UpdateUI()
        {
            dtpStartTime.Value = _originalSRTs.StartTime;
            dtpEndTime.Value = _originalSRTs.EndTime;

            DataGridViewRow row;

            dgvSRTText.Rows.Clear();
            foreach(string strText in _originalSRTs.SRT_Lines)
            {
                row = new DataGridViewRow();
                row.CreateCells(dgvSRTText);
                row.Cells[0].Value = strText;

                dgvSRTText.Rows.Add(row);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Helpers.isSRTModified = true;

            SRTInfo sRTInfo = new SRTInfo();
            sRTInfo.Index = _originalSRTs.Index;
            sRTInfo.StartTime = dtpStartTime.Value;
            sRTInfo.EndTime = dtpEndTime.Value;

            sRTInfo.SRT_Lines = new List<string>();
            sRTInfo.SRT_Text = "";

            string srtText = "";
            foreach(DataGridViewRow row in dgvSRTText.Rows)
            {
                if(row.Cells[0].Value == null)
                {
                    continue;
                }

                srtText  = row.Cells[0].Value.ToString().Trim();

                if (srtText == "") continue;

                sRTInfo.SRT_Lines.Add(srtText);
                if(sRTInfo.SRT_Text != "")
                {
                    sRTInfo.SRT_Text += " ";
                }
                sRTInfo.SRT_Text += srtText;
            }
                       
            Helpers.ModifiedSRT = sRTInfo;

            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
