namespace CreateSRTFromSAPTranscriptPDF
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDFFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowsePDFFilePath = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dgvReadSRTContent = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.dgvSRTList = new System.Windows.Forms.DataGridView();
            this.SRTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSRT = new System.Windows.Forms.Button();
            this.btnRemoveSRT = new System.Windows.Forms.Button();
            this.btnViewIgnoredSRT = new System.Windows.Forms.Button();
            this.btnViewGroupedSRT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadSRTContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRTList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF File Path:";
            // 
            // txtPDFFilePath
            // 
            this.txtPDFFilePath.Location = new System.Drawing.Point(93, 6);
            this.txtPDFFilePath.Name = "txtPDFFilePath";
            this.txtPDFFilePath.ReadOnly = true;
            this.txtPDFFilePath.Size = new System.Drawing.Size(586, 20);
            this.txtPDFFilePath.TabIndex = 1;
            // 
            // btnBrowsePDFFilePath
            // 
            this.btnBrowsePDFFilePath.Location = new System.Drawing.Point(685, 4);
            this.btnBrowsePDFFilePath.Name = "btnBrowsePDFFilePath";
            this.btnBrowsePDFFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePDFFilePath.TabIndex = 2;
            this.btnBrowsePDFFilePath.Text = "Browse";
            this.btnBrowsePDFFilePath.UseVisualStyleBackColor = true;
            this.btnBrowsePDFFilePath.Click += new System.EventHandler(this.btnBrowsePDFFilePath_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(604, 32);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dgvReadSRTContent
            // 
            this.dgvReadSRTContent.AllowUserToAddRows = false;
            this.dgvReadSRTContent.AllowUserToDeleteRows = false;
            this.dgvReadSRTContent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReadSRTContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadSRTContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.StartTime,
            this.EndTime,
            this.Diff,
            this.SRT});
            this.dgvReadSRTContent.Location = new System.Drawing.Point(15, 97);
            this.dgvReadSRTContent.Name = "dgvReadSRTContent";
            this.dgvReadSRTContent.Size = new System.Drawing.Size(514, 341);
            this.dgvReadSRTContent.TabIndex = 4;
            this.dgvReadSRTContent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReadSRTContent_CellDoubleClick);
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.Width = 40;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 55;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 50;
            // 
            // Diff
            // 
            this.Diff.HeaderText = "Diff";
            this.Diff.Name = "Diff";
            this.Diff.ReadOnly = true;
            this.Diff.Width = 50;
            // 
            // SRT
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SRT.DefaultCellStyle = dataGridViewCellStyle1;
            this.SRT.HeaderText = "SRTText";
            this.SRT.Name = "SRT";
            this.SRT.ReadOnly = true;
            this.SRT.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(93, 61);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(667, 20);
            this.txtFileName.TabIndex = 8;
            // 
            // dgvSRTList
            // 
            this.dgvSRTList.AllowUserToAddRows = false;
            this.dgvSRTList.AllowUserToDeleteRows = false;
            this.dgvSRTList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSRTList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRTName,
            this.Count});
            this.dgvSRTList.Location = new System.Drawing.Point(581, 97);
            this.dgvSRTList.MultiSelect = false;
            this.dgvSRTList.Name = "dgvSRTList";
            this.dgvSRTList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSRTList.RowHeadersWidth = 20;
            this.dgvSRTList.Size = new System.Drawing.Size(179, 315);
            this.dgvSRTList.TabIndex = 9;
            this.dgvSRTList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSRTList_CellDoubleClick);
            this.dgvSRTList.SelectionChanged += new System.EventHandler(this.dgvSRTList_SelectionChanged);
            // 
            // SRTName
            // 
            this.SRTName.HeaderText = "SRT Name";
            this.SRTName.Name = "SRTName";
            this.SRTName.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 50;
            // 
            // btnAddSRT
            // 
            this.btnAddSRT.Enabled = false;
            this.btnAddSRT.Location = new System.Drawing.Point(535, 132);
            this.btnAddSRT.Name = "btnAddSRT";
            this.btnAddSRT.Size = new System.Drawing.Size(40, 23);
            this.btnAddSRT.TabIndex = 10;
            this.btnAddSRT.Text = ">>";
            this.btnAddSRT.UseVisualStyleBackColor = true;
            this.btnAddSRT.Click += new System.EventHandler(this.btnAddSRT_Click);
            // 
            // btnRemoveSRT
            // 
            this.btnRemoveSRT.Enabled = false;
            this.btnRemoveSRT.Location = new System.Drawing.Point(535, 348);
            this.btnRemoveSRT.Name = "btnRemoveSRT";
            this.btnRemoveSRT.Size = new System.Drawing.Size(40, 23);
            this.btnRemoveSRT.TabIndex = 11;
            this.btnRemoveSRT.Text = "<<";
            this.btnRemoveSRT.UseVisualStyleBackColor = true;
            this.btnRemoveSRT.Click += new System.EventHandler(this.btnRemoveSRT_Click);
            // 
            // btnViewIgnoredSRT
            // 
            this.btnViewIgnoredSRT.Enabled = false;
            this.btnViewIgnoredSRT.Location = new System.Drawing.Point(535, 415);
            this.btnViewIgnoredSRT.Name = "btnViewIgnoredSRT";
            this.btnViewIgnoredSRT.Size = new System.Drawing.Size(106, 23);
            this.btnViewIgnoredSRT.TabIndex = 12;
            this.btnViewIgnoredSRT.Text = "View Ignored SRT";
            this.btnViewIgnoredSRT.UseVisualStyleBackColor = true;
            this.btnViewIgnoredSRT.Click += new System.EventHandler(this.btnViewIgnoredSRT_Click);
            // 
            // btnViewGroupedSRT
            // 
            this.btnViewGroupedSRT.Enabled = false;
            this.btnViewGroupedSRT.Location = new System.Drawing.Point(649, 415);
            this.btnViewGroupedSRT.Name = "btnViewGroupedSRT";
            this.btnViewGroupedSRT.Size = new System.Drawing.Size(111, 23);
            this.btnViewGroupedSRT.TabIndex = 13;
            this.btnViewGroupedSRT.Text = "View Grouped SRT";
            this.btnViewGroupedSRT.UseVisualStyleBackColor = true;
            this.btnViewGroupedSRT.Click += new System.EventHandler(this.btnViewGroupedSRT_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btnViewGroupedSRT);
            this.Controls.Add(this.btnViewIgnoredSRT);
            this.Controls.Add(this.btnRemoveSRT);
            this.Controls.Add(this.btnAddSRT);
            this.Controls.Add(this.dgvSRTList);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReadSRTContent);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnBrowsePDFFilePath);
            this.Controls.Add(this.txtPDFFilePath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create SRT From SAP Transcript PDF";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadSRTContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSRTList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDFFilePath;
        private System.Windows.Forms.Button btnBrowsePDFFilePath;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dgvReadSRTContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.DataGridView dgvSRTList;
        private System.Windows.Forms.Button btnAddSRT;
        private System.Windows.Forms.Button btnRemoveSRT;
        private System.Windows.Forms.Button btnViewIgnoredSRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button btnViewGroupedSRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRT;
    }
}

