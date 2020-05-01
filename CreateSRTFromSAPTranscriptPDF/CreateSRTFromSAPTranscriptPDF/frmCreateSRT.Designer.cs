namespace CreateSRTFromSAPTranscriptPDF
{
    partial class FrmCreateSRT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateSRT));
            this.dgvSRTContent = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRTText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputTranscriptPath = new System.Windows.Forms.TextBox();
            this.btnBrowseMP4File = new System.Windows.Forms.Button();
            this.txtMP4Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSRTPath = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.dgvSRTContent.Location = new System.Drawing.Point(12, 32);
            this.dgvSRTContent.Name = "dgvSRTContent";
            this.dgvSRTContent.RowHeadersVisible = false;
            this.dgvSRTContent.Size = new System.Drawing.Size(776, 292);
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
            this.EndTime.Width = 55;
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
            this.SRTText.HeaderText = "SRT Text";
            this.SRTText.Name = "SRTText";
            this.SRTText.ReadOnly = true;
            this.SRTText.Width = 550;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MP4 Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transcript Path";
            // 
            // txtInputTranscriptPath
            // 
            this.txtInputTranscriptPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtInputTranscriptPath.Location = new System.Drawing.Point(97, 6);
            this.txtInputTranscriptPath.Name = "txtInputTranscriptPath";
            this.txtInputTranscriptPath.ReadOnly = true;
            this.txtInputTranscriptPath.Size = new System.Drawing.Size(691, 20);
            this.txtInputTranscriptPath.TabIndex = 3;
            // 
            // btnBrowseMP4File
            // 
            this.btnBrowseMP4File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMP4File.Location = new System.Drawing.Point(713, 339);
            this.btnBrowseMP4File.Name = "btnBrowseMP4File";
            this.btnBrowseMP4File.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseMP4File.TabIndex = 4;
            this.btnBrowseMP4File.Text = "Browse";
            this.btnBrowseMP4File.UseVisualStyleBackColor = true;
            this.btnBrowseMP4File.Click += new System.EventHandler(this.btnBrowseMP4File_Click);
            // 
            // txtMP4Path
            // 
            this.txtMP4Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMP4Path.Location = new System.Drawing.Point(72, 341);
            this.txtMP4Path.Name = "txtMP4Path";
            this.txtMP4Path.ReadOnly = true;
            this.txtMP4Path.Size = new System.Drawing.Size(635, 20);
            this.txtMP4Path.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SRT Path";
            // 
            // txtSRTPath
            // 
            this.txtSRTPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSRTPath.Location = new System.Drawing.Point(72, 368);
            this.txtSRTPath.Name = "txtSRTPath";
            this.txtSRTPath.ReadOnly = true;
            this.txtSRTPath.Size = new System.Drawing.Size(716, 20);
            this.txtSRTPath.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(713, 394);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FrmCreateSRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSRTPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMP4Path);
            this.Controls.Add(this.btnBrowseMP4File);
            this.Controls.Add(this.txtInputTranscriptPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSRTContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmCreateSRT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create SRT";
            this.Load += new System.EventHandler(this.FrmCreateSRT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRTContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSRTContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputTranscriptPath;
        private System.Windows.Forms.Button btnBrowseMP4File;
        private System.Windows.Forms.TextBox txtMP4Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSRTPath;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTText;
    }
}