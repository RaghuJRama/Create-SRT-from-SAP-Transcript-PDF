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
    public partial class FrmViewSRT : Form
    {
        private GroupedSRT _groupedSRT;

        public FrmViewSRT(GroupedSRT groupedSRT)
        {
            InitializeComponent();

            _groupedSRT = groupedSRT;

            UpdateUI();
        }

        private void UpdateUI()
        {
            this.Text = _groupedSRT.GroupName + " SRT";

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

        private void FrmViewSRT_Load(object sender, EventArgs e)
        {
            int width = dgvSRTContent.Width;
            dgvSRTContent.Columns[4].Width = width - 230;
        }
    }
}
