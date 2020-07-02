namespace MainSurface
{
    partial class BootLoader
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
            this.buttonSendFile = new System.Windows.Forms.Button();
            this.openFileDialogSendFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFileContent = new System.Windows.Forms.TextBox();
            this.labelFileContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSendFile
            // 
            this.buttonSendFile.Location = new System.Drawing.Point(12, 26);
            this.buttonSendFile.Name = "buttonSendFile";
            this.buttonSendFile.Size = new System.Drawing.Size(80, 26);
            this.buttonSendFile.TabIndex = 0;
            this.buttonSendFile.Text = "发送文件";
            this.buttonSendFile.UseVisualStyleBackColor = true;
            this.buttonSendFile.Click += new System.EventHandler(this.buttonSendFile_Click);
            // 
            // openFileDialogSendFile
            // 
            this.openFileDialogSendFile.FileName = "openFileDialog1";
            // 
            // textBoxFileContent
            // 
            this.textBoxFileContent.Location = new System.Drawing.Point(15, 90);
            this.textBoxFileContent.Multiline = true;
            this.textBoxFileContent.Name = "textBoxFileContent";
            this.textBoxFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFileContent.Size = new System.Drawing.Size(711, 307);
            this.textBoxFileContent.TabIndex = 1;
            this.textBoxFileContent.WordWrap = false;
            // 
            // labelFileContent
            // 
            this.labelFileContent.AutoSize = true;
            this.labelFileContent.Location = new System.Drawing.Point(12, 72);
            this.labelFileContent.Name = "labelFileContent";
            this.labelFileContent.Size = new System.Drawing.Size(82, 15);
            this.labelFileContent.TabIndex = 2;
            this.labelFileContent.Text = "文件内容：";
            // 
            // BootLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 409);
            this.Controls.Add(this.labelFileContent);
            this.Controls.Add(this.textBoxFileContent);
            this.Controls.Add(this.buttonSendFile);
            this.KeyPreview = true;
            this.Name = "BootLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BootLoader";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BootLoader_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogSendFile;
        private System.Windows.Forms.TextBox textBoxFileContent;
        private System.Windows.Forms.Label labelFileContent;
    }
}