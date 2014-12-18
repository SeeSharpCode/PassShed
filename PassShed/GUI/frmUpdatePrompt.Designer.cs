namespace PassShed.GUI
{
    partial class frmUpdatePrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePrompt));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUpdatePrompt = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblNewestVersion = new System.Windows.Forms.Label();
            this.btnDownloadAutomatically = new System.Windows.Forms.Button();
            this.btnDownloadPage = new System.Windows.Forms.Button();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.txtChangelog = new System.Windows.Forms.RichTextBox();
            this.lblChangelog = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(383, 102);
            this.pnlLogo.TabIndex = 7;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(13, 4);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(265, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblUpdatePrompt
            // 
            this.lblUpdatePrompt.AutoSize = true;
            this.lblUpdatePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePrompt.Location = new System.Drawing.Point(12, 106);
            this.lblUpdatePrompt.Name = "lblUpdatePrompt";
            this.lblUpdatePrompt.Size = new System.Drawing.Size(285, 16);
            this.lblUpdatePrompt.TabIndex = 8;
            this.lblUpdatePrompt.Text = "A new version of PassShed is available!";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(12, 132);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(102, 16);
            this.lblCurrentVersion.TabIndex = 9;
            this.lblCurrentVersion.Text = "Current Version:";
            // 
            // lblNewestVersion
            // 
            this.lblNewestVersion.AutoSize = true;
            this.lblNewestVersion.Location = new System.Drawing.Point(12, 150);
            this.lblNewestVersion.Name = "lblNewestVersion";
            this.lblNewestVersion.Size = new System.Drawing.Size(105, 16);
            this.lblNewestVersion.TabIndex = 10;
            this.lblNewestVersion.Text = "Newest Version:";
            // 
            // btnDownloadAutomatically
            // 
            this.btnDownloadAutomatically.AutoSize = true;
            this.btnDownloadAutomatically.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadAutomatically.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDownloadAutomatically.Image = ((System.Drawing.Image)(resources.GetObject("btnDownloadAutomatically.Image")));
            this.btnDownloadAutomatically.Location = new System.Drawing.Point(15, 368);
            this.btnDownloadAutomatically.Name = "btnDownloadAutomatically";
            this.btnDownloadAutomatically.Size = new System.Drawing.Size(241, 26);
            this.btnDownloadAutomatically.TabIndex = 11;
            this.btnDownloadAutomatically.Text = "Download and Install Automatically";
            this.btnDownloadAutomatically.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadAutomatically.UseVisualStyleBackColor = true;
            this.btnDownloadAutomatically.Click += new System.EventHandler(this.btnDownloadAutomatically_Click);
            // 
            // btnDownloadPage
            // 
            this.btnDownloadPage.AutoSize = true;
            this.btnDownloadPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadPage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDownloadPage.Image = ((System.Drawing.Image)(resources.GetObject("btnDownloadPage.Image")));
            this.btnDownloadPage.Location = new System.Drawing.Point(15, 400);
            this.btnDownloadPage.Name = "btnDownloadPage";
            this.btnDownloadPage.Size = new System.Drawing.Size(172, 26);
            this.btnDownloadPage.TabIndex = 12;
            this.btnDownloadPage.Text = "Go To Download Page";
            this.btnDownloadPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadPage.UseVisualStyleBackColor = true;
            this.btnDownloadPage.Click += new System.EventHandler(this.btnDownloadPage_Click);
            // 
            // btnIgnore
            // 
            this.btnIgnore.AutoSize = true;
            this.btnIgnore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnIgnore.Image = ((System.Drawing.Image)(resources.GetObject("btnIgnore.Image")));
            this.btnIgnore.Location = new System.Drawing.Point(15, 432);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(120, 26);
            this.btnIgnore.TabIndex = 13;
            this.btnIgnore.Text = "Ignore Update";
            this.btnIgnore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // txtChangelog
            // 
            this.txtChangelog.Location = new System.Drawing.Point(15, 200);
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.Size = new System.Drawing.Size(355, 162);
            this.txtChangelog.TabIndex = 14;
            this.txtChangelog.Text = "";
            // 
            // lblChangelog
            // 
            this.lblChangelog.AutoSize = true;
            this.lblChangelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangelog.Location = new System.Drawing.Point(12, 181);
            this.lblChangelog.Name = "lblChangelog";
            this.lblChangelog.Size = new System.Drawing.Size(83, 16);
            this.lblChangelog.TabIndex = 15;
            this.lblChangelog.Text = "Changelog";
            // 
            // frmUpdatePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 466);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.btnDownloadPage);
            this.Controls.Add(this.lblUpdatePrompt);
            this.Controls.Add(this.btnDownloadAutomatically);
            this.Controls.Add(this.txtChangelog);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.lblChangelog);
            this.Controls.Add(this.lblNewestVersion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUpdatePrompt";
            this.Text = "Update Available";
            this.Load += new System.EventHandler(this.frmUpdatePrompt_Load);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUpdatePrompt;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblNewestVersion;
        private System.Windows.Forms.Button btnDownloadAutomatically;
        private System.Windows.Forms.Button btnDownloadPage;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.RichTextBox txtChangelog;
        private System.Windows.Forms.Label lblChangelog;
    }
}