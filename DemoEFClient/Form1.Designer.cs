namespace DemoEFClient
{
    partial class UploadFile
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
            this.uploadFile_label = new System.Windows.Forms.Label();
            this.file_label = new System.Windows.Forms.Label();
            this.filePath_label = new System.Windows.Forms.Label();
            this.upload_button = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadFile_label
            // 
            this.uploadFile_label.AutoSize = true;
            this.uploadFile_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadFile_label.Location = new System.Drawing.Point(159, 37);
            this.uploadFile_label.Name = "uploadFile_label";
            this.uploadFile_label.Size = new System.Drawing.Size(106, 24);
            this.uploadFile_label.TabIndex = 0;
            this.uploadFile_label.Text = "Upload File";
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(56, 98);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(54, 13);
            this.file_label.TabIndex = 1;
            this.file_label.Text = "File Path :";
            // 
            // filePath_label
            // 
            this.filePath_label.AutoSize = true;
            this.filePath_label.Location = new System.Drawing.Point(117, 98);
            this.filePath_label.Name = "filePath_label";
            this.filePath_label.Size = new System.Drawing.Size(0, 13);
            this.filePath_label.TabIndex = 2;
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(163, 122);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 23);
            this.upload_button.TabIndex = 3;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(31, 166);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result_textBox.Size = new System.Drawing.Size(346, 39);
            this.result_textBox.TabIndex = 6;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 236);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.filePath_label);
            this.Controls.Add(this.file_label);
            this.Controls.Add(this.uploadFile_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UploadFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload File";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uploadFile_label;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.Label filePath_label;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.TextBox result_textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

