namespace PassShed.GUI
{
    partial class frmCsvGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCsvGuide));
            this.chkStopShowing = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblFormattingGuide = new System.Windows.Forms.Label();
            this.txtPractice = new System.Windows.Forms.TextBox();
            this.lblPractice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkStopShowing
            // 
            this.chkStopShowing.AutoSize = true;
            this.chkStopShowing.Location = new System.Drawing.Point(16, 256);
            this.chkStopShowing.Name = "chkStopShowing";
            this.chkStopShowing.Size = new System.Drawing.Size(140, 20);
            this.chkStopShowing.TabIndex = 6;
            this.chkStopShowing.Text = "&Don\'t tell me again.";
            this.chkStopShowing.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(324, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(406, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(52, 26);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblFormattingGuide
            // 
            this.lblFormattingGuide.Location = new System.Drawing.Point(13, 13);
            this.lblFormattingGuide.Name = "lblFormattingGuide";
            this.lblFormattingGuide.Size = new System.Drawing.Size(445, 138);
            this.lblFormattingGuide.TabIndex = 7;
            this.lblFormattingGuide.Text = resources.GetString("lblFormattingGuide.Text");
            // 
            // txtPractice
            // 
            this.txtPractice.Location = new System.Drawing.Point(16, 154);
            this.txtPractice.Multiline = true;
            this.txtPractice.Name = "txtPractice";
            this.txtPractice.Size = new System.Drawing.Size(442, 85);
            this.txtPractice.TabIndex = 9;
            this.txtPractice.Text = "field1,field2,field3\r\ncredential1,credential2,credential3\r\nhey,dude,guesswhat,Thi" +
    "sWon\'tBeAdded";
            // 
            // lblPractice
            // 
            this.lblPractice.AutoSize = true;
            this.lblPractice.Location = new System.Drawing.Point(13, 135);
            this.lblPractice.Name = "lblPractice";
            this.lblPractice.Size = new System.Drawing.Size(143, 16);
            this.lblPractice.TabIndex = 10;
            this.lblPractice.Text = "Useless practice area:\r\n";
            // 
            // frmCsvGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 331);
            this.Controls.Add(this.lblPractice);
            this.Controls.Add(this.txtPractice);
            this.Controls.Add(this.lblFormattingGuide);
            this.Controls.Add(this.chkStopShowing);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCsvGuide";
            this.Text = "CSV Formatting Guide";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCsvGuide_FormClosed);
            this.Load += new System.EventHandler(this.frmCsvGuide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStopShowing;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblFormattingGuide;
        private System.Windows.Forms.TextBox txtPractice;
        private System.Windows.Forms.Label lblPractice;
    }
}