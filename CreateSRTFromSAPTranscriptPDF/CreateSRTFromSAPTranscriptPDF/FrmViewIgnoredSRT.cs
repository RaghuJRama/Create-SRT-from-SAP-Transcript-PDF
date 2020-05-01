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
    public partial class FrmViewIgnoredSRT : Form
    {

        public FrmViewIgnoredSRT(List<SRTInfo> sRTInfos )
        {
            InitializeComponent();

            updateDataGridViewUI(sRTInfos);
        }

        private void updateDataGridViewUI(List<SRTInfo> sRTInfos )
        {
            dgvSRT.Rows.Clear();

            DataGridViewRow row;

            foreach(SRTInfo sRTInfo in sRTInfos)
            {
                row = new DataGridViewRow();
                row.CreateCells(dgvSRT);

                row.Cells[0].Value = sRTInfo.Index;
                row.Cells[1].Value = sRTInfo.StartTime.ToString("HH:mm:ss");
                row.Cells[2].Value = sRTInfo.EndTime.ToString("HH:mm:ss");
                row.Cells[3].Value = (sRTInfo.EndTime - sRTInfo.StartTime).TotalSeconds ;
                row.Cells[4].Value = sRTInfo.SRT_Text ;

                dgvSRT.Rows.Add(row);
            }
        }
    }
}
