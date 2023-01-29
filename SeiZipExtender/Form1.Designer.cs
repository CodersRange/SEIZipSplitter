namespace SeiZipExtender
{
    partial class Form1
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
            this.btn_ProcessZipFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OutputPath = new System.Windows.Forms.TextBox();
            this.txt_UploadLocation = new System.Windows.Forms.TextBox();
            this.lbl_UploadLocation = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_FileBatchCount = new System.Windows.Forms.Label();
            this.txt_PdfFileCounter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TempPath = new System.Windows.Forms.TextBox();
            this.lbl_ZipStatus = new System.Windows.Forms.Label();
            this.lbl_UploadStatus = new System.Windows.Forms.Label();
            this.lbl_FileStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ProcessZipFiles
            // 
            this.btn_ProcessZipFiles.Location = new System.Drawing.Point(558, 181);
            this.btn_ProcessZipFiles.Name = "btn_ProcessZipFiles";
            this.btn_ProcessZipFiles.Size = new System.Drawing.Size(75, 30);
            this.btn_ProcessZipFiles.TabIndex = 0;
            this.btn_ProcessZipFiles.Text = "Start";
            this.btn_ProcessZipFiles.UseVisualStyleBackColor = true;
            this.btn_ProcessZipFiles.Click += new System.EventHandler(this.btn_ProcessZipFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Zip Files";
            // 
            // txt_FolderPath
            // 
            this.txt_FolderPath.Location = new System.Drawing.Point(287, 45);
            this.txt_FolderPath.Name = "txt_FolderPath";
            this.txt_FolderPath.Size = new System.Drawing.Size(346, 22);
            this.txt_FolderPath.TabIndex = 2;
            this.txt_FolderPath.Text = "C:\\ZipLocation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source Zip File Directory Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target Zip File Directory Location";
            // 
            // txt_OutputPath
            // 
            this.txt_OutputPath.Location = new System.Drawing.Point(287, 131);
            this.txt_OutputPath.Name = "txt_OutputPath";
            this.txt_OutputPath.Size = new System.Drawing.Size(346, 22);
            this.txt_OutputPath.TabIndex = 5;
            this.txt_OutputPath.Text = "C:\\ZipLocationOutput";
            // 
            // txt_UploadLocation
            // 
            this.txt_UploadLocation.Location = new System.Drawing.Point(195, 314);
            this.txt_UploadLocation.Name = "txt_UploadLocation";
            this.txt_UploadLocation.Size = new System.Drawing.Size(189, 22);
            this.txt_UploadLocation.TabIndex = 7;
            // 
            // lbl_UploadLocation
            // 
            this.lbl_UploadLocation.AutoSize = true;
            this.lbl_UploadLocation.Location = new System.Drawing.Point(39, 317);
            this.lbl_UploadLocation.Name = "lbl_UploadLocation";
            this.lbl_UploadLocation.Size = new System.Drawing.Size(150, 17);
            this.lbl_UploadLocation.TabIndex = 8;
            this.lbl_UploadLocation.Text = "SFTP Upload Location";
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(555, 313);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 25);
            this.btn_Upload.TabIndex = 9;
            this.btn_Upload.Text = "Start";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Upload to SFTP Location";
            // 
            // lbl_FileBatchCount
            // 
            this.lbl_FileBatchCount.AutoSize = true;
            this.lbl_FileBatchCount.Location = new System.Drawing.Point(42, 185);
            this.lbl_FileBatchCount.Name = "lbl_FileBatchCount";
            this.lbl_FileBatchCount.Size = new System.Drawing.Size(284, 17);
            this.lbl_FileBatchCount.TabIndex = 11;
            this.lbl_FileBatchCount.Text = "File Batch Count (Default is 10 PDF in a zip)";
            // 
            // txt_PdfFileCounter
            // 
            this.txt_PdfFileCounter.Location = new System.Drawing.Point(330, 182);
            this.txt_PdfFileCounter.Name = "txt_PdfFileCounter";
            this.txt_PdfFileCounter.Size = new System.Drawing.Size(65, 22);
            this.txt_PdfFileCounter.TabIndex = 12;
            this.txt_PdfFileCounter.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zip File Temp Directory Location";
            // 
            // txt_TempPath
            // 
            this.txt_TempPath.Location = new System.Drawing.Point(287, 87);
            this.txt_TempPath.Name = "txt_TempPath";
            this.txt_TempPath.Size = new System.Drawing.Size(346, 22);
            this.txt_TempPath.TabIndex = 14;
            this.txt_TempPath.Text = "C:\\ZipLocationTemp";
            // 
            // lbl_ZipStatus
            // 
            this.lbl_ZipStatus.AutoSize = true;
            this.lbl_ZipStatus.Location = new System.Drawing.Point(42, 238);
            this.lbl_ZipStatus.Name = "lbl_ZipStatus";
            this.lbl_ZipStatus.Size = new System.Drawing.Size(0, 17);
            this.lbl_ZipStatus.TabIndex = 15;
            // 
            // lbl_UploadStatus
            // 
            this.lbl_UploadStatus.AutoSize = true;
            this.lbl_UploadStatus.Location = new System.Drawing.Point(42, 359);
            this.lbl_UploadStatus.Name = "lbl_UploadStatus";
            this.lbl_UploadStatus.Size = new System.Drawing.Size(0, 17);
            this.lbl_UploadStatus.TabIndex = 16;
            // 
            // lbl_FileStatus
            // 
            this.lbl_FileStatus.AutoSize = true;
            this.lbl_FileStatus.Location = new System.Drawing.Point(45, 274);
            this.lbl_FileStatus.Name = "lbl_FileStatus";
            this.lbl_FileStatus.Size = new System.Drawing.Size(0, 17);
            this.lbl_FileStatus.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 402);
            this.Controls.Add(this.lbl_FileStatus);
            this.Controls.Add(this.lbl_UploadStatus);
            this.Controls.Add(this.lbl_ZipStatus);
            this.Controls.Add(this.txt_TempPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PdfFileCounter);
            this.Controls.Add(this.lbl_FileBatchCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.lbl_UploadLocation);
            this.Controls.Add(this.txt_UploadLocation);
            this.Controls.Add(this.txt_OutputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ProcessZipFiles);
            this.Name = "Form1";
            this.Text = "SEI Zip Splitter - Ver 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ProcessZipFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OutputPath;
        private System.Windows.Forms.TextBox txt_UploadLocation;
        private System.Windows.Forms.Label lbl_UploadLocation;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_FileBatchCount;
        private System.Windows.Forms.TextBox txt_PdfFileCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TempPath;
        private System.Windows.Forms.Label lbl_ZipStatus;
        private System.Windows.Forms.Label lbl_UploadStatus;
        private System.Windows.Forms.Label lbl_FileStatus;
    }
}

