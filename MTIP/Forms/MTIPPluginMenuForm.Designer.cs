
namespace MTIP.Forms
{
    partial class MTIPPluginMenuForm
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
            this.menuLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(9, 26);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(296, 18);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Modeling Tool Integration Plugin Menu";
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(69, 73);
            this.importButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(168, 32);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import from HUDS XML";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.ImportMTIP);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(69, 125);
            this.exportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(168, 30);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export to HUDS XML";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportMTIP);
            // 
            // MTIPPluginMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 189);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.menuLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MTIPPluginMenuForm";
            this.Text = "MTIP Sparx Plugin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
    }
}