
namespace MTIP.Forms
{
    partial class MTIPImportForm
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
            this.selectXMLButton = new System.Windows.Forms.Button();
            this.selectedFiles = new System.Windows.Forms.ListBox();
            this.importButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectXMLButton
            // 
            this.selectXMLButton.Location = new System.Drawing.Point(79, 25);
            this.selectXMLButton.Name = "selectXMLButton";
            this.selectXMLButton.Size = new System.Drawing.Size(224, 46);
            this.selectXMLButton.TabIndex = 0;
            this.selectXMLButton.Text = "Select Input XML(s)";
            this.selectXMLButton.UseVisualStyleBackColor = true;
            this.selectXMLButton.Click += new System.EventHandler(this.SelectInputXml);
            // 
            // selectedFiles
            // 
            this.selectedFiles.FormattingEnabled = true;
            this.selectedFiles.ItemHeight = 16;
            this.selectedFiles.Location = new System.Drawing.Point(79, 77);
            this.selectedFiles.Name = "selectedFiles";
            this.selectedFiles.Size = new System.Drawing.Size(224, 260);
            this.selectedFiles.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.Enabled = false;
            this.importButton.Location = new System.Drawing.Point(79, 343);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(222, 53);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.Import);
            // 
            // MTIPImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.selectedFiles);
            this.Controls.Add(this.selectXMLButton);
            this.Name = "MTIPImportForm";
            this.Text = "MTIP XML Import";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectXMLButton;
        private System.Windows.Forms.ListBox selectedFiles;
        private System.Windows.Forms.Button importButton;
    }
}