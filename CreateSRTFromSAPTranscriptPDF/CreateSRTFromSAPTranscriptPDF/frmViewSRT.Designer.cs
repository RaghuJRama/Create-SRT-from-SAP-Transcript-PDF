namespace CreateSRTFromSAPTranscriptPDF
{
    partial class FrmViewSRT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewSRT));
            this.dgvSRTContent = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRTText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRTContent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSRTContent
            // 
            this.dgvSRTContent.AllowUserToAddRows = false;
            this.dgvSRTContent.AllowUserToDeleteRows = false;
            this.dgvSRTContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSRTContent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSRTContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSRTContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.StartTime,
            this.EndTime,
            this.Diff,
            this.SRTText});
            this.dgvSRTContent.Location = new System.Drawing.Point(12, 12);
            this.dgvSRTContent.Name = "dgvSRTContent";
            this.dgvSRTContent.RowHeadersVisible = false;
            this.dgvSRTContent.Size = new System.Drawing.Size(776, 426);
            this.dgvSRTContent.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 40;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 60;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 50;
            // 
            // Diff
            // 
            this.Diff.HeaderText = "Diff";
            this.Diff.Name = "Diff";
            this.Diff.ReadOnly = true;
            this.Diff.Width = 50;
            // 
            // SRTText
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SRTText.DefaultCellStyle = dataGridViewCellStyle1;
            this.SRTText.HeaderText = "SRTText";
            this.SRTText.Name = "SRTText";
            this.SRTText.Width = 540;
            // 
            // FrmViewSRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSRTContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmViewSRT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View SRT";
            this.Load += new System.EventHandler(this.FrmViewSRT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRTContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSRTContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTText;
    }
}