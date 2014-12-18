namespace PassShed.GUI
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.btnMenuColor = new System.Windows.Forms.Button();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnRowColor = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.menuPreview = new System.Windows.Forms.MenuStrip();
            this.menuItemPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.grpShed = new System.Windows.Forms.GroupBox();
            this.lblColumnSizeMode = new System.Windows.Forms.Label();
            this.cboAutosizeColumnsMode = new System.Windows.Forms.ComboBox();
            this.lblGridlines = new System.Windows.Forms.Label();
            this.cboGridlines = new System.Windows.Forms.ComboBox();
            this.btnAlternatingRowColor = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpMenu.SuspendLayout();
            this.menuPreview.SuspendLayout();
            this.grpShed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuColor
            // 
            this.btnMenuColor.AutoSize = true;
            this.btnMenuColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenuColor.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuColor.Image")));
            this.btnMenuColor.Location = new System.Drawing.Point(6, 21);
            this.btnMenuColor.Name = "btnMenuColor";
            this.btnMenuColor.Size = new System.Drawing.Size(102, 26);
            this.btnMenuColor.TabIndex = 2;
            this.btnMenuColor.Text = "&Menu Color";
            this.btnMenuColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuColor.UseVisualStyleBackColor = true;
            this.btnMenuColor.Click += new System.EventHandler(this.btnMenuColor_Click);
            // 
            // btnFontColor
            // 
            this.btnFontColor.AutoSize = true;
            this.btnFontColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("btnFontColor.Image")));
            this.btnFontColor.Location = new System.Drawing.Point(6, 53);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(131, 26);
            this.btnFontColor.TabIndex = 3;
            this.btnFontColor.Text = "Menu &Font Color";
            this.btnFontColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnRowColor
            // 
            this.btnRowColor.AutoSize = true;
            this.btnRowColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRowColor.Image = ((System.Drawing.Image)(resources.GetObject("btnRowColor.Image")));
            this.btnRowColor.Location = new System.Drawing.Point(6, 21);
            this.btnRowColor.Name = "btnRowColor";
            this.btnRowColor.Size = new System.Drawing.Size(96, 26);
            this.btnRowColor.TabIndex = 4;
            this.btnRowColor.Text = "&Row Color";
            this.btnRowColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRowColor.UseVisualStyleBackColor = true;
            this.btnRowColor.Click += new System.EventHandler(this.btnRowColor_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblPreview);
            this.grpMenu.Controls.Add(this.btnFontColor);
            this.grpMenu.Controls.Add(this.btnMenuColor);
            this.grpMenu.Controls.Add(this.menuPreview);
            this.grpMenu.Location = new System.Drawing.Point(12, 12);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(195, 135);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(3, 82);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(59, 16);
            this.lblPreview.TabIndex = 4;
            this.lblPreview.Text = "Preview:";
            // 
            // menuPreview
            // 
            this.menuPreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPreview});
            this.menuPreview.Location = new System.Drawing.Point(3, 108);
            this.menuPreview.Name = "menuPreview";
            this.menuPreview.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPreview.Size = new System.Drawing.Size(189, 24);
            this.menuPreview.TabIndex = 5;
            this.menuPreview.Text = "menuStrip";
            // 
            // menuItemPreview
            // 
            this.menuItemPreview.Name = "menuItemPreview";
            this.menuItemPreview.Size = new System.Drawing.Size(77, 20);
            this.menuItemPreview.Text = "Menu Item";
            // 
            // grpShed
            // 
            this.grpShed.Controls.Add(this.lblColumnSizeMode);
            this.grpShed.Controls.Add(this.cboAutosizeColumnsMode);
            this.grpShed.Controls.Add(this.lblGridlines);
            this.grpShed.Controls.Add(this.cboGridlines);
            this.grpShed.Controls.Add(this.btnAlternatingRowColor);
            this.grpShed.Controls.Add(this.btnRowColor);
            this.grpShed.Location = new System.Drawing.Point(12, 153);
            this.grpShed.Name = "grpShed";
            this.grpShed.Size = new System.Drawing.Size(280, 150);
            this.grpShed.TabIndex = 6;
            this.grpShed.TabStop = false;
            this.grpShed.Text = "Shed";
            // 
            // lblColumnSizeMode
            // 
            this.lblColumnSizeMode.AutoSize = true;
            this.lblColumnSizeMode.Location = new System.Drawing.Point(3, 117);
            this.lblColumnSizeMode.Name = "lblColumnSizeMode";
            this.lblColumnSizeMode.Size = new System.Drawing.Size(123, 16);
            this.lblColumnSizeMode.TabIndex = 11;
            this.lblColumnSizeMode.Text = "Column Size Mode:";
            // 
            // cboAutosizeColumnsMode
            // 
            this.cboAutosizeColumnsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutosizeColumnsMode.FormattingEnabled = true;
            this.cboAutosizeColumnsMode.Items.AddRange(new object[] {
            "Fill",
            "Fit To Cells"});
            this.cboAutosizeColumnsMode.Location = new System.Drawing.Point(132, 114);
            this.cboAutosizeColumnsMode.Name = "cboAutosizeColumnsMode";
            this.cboAutosizeColumnsMode.Size = new System.Drawing.Size(136, 24);
            this.cboAutosizeColumnsMode.TabIndex = 10;
            this.cboAutosizeColumnsMode.SelectedIndexChanged += new System.EventHandler(this.cboColumnSizeMode_SelectedIndexChanged);
            // 
            // lblGridlines
            // 
            this.lblGridlines.AutoSize = true;
            this.lblGridlines.Location = new System.Drawing.Point(6, 87);
            this.lblGridlines.Name = "lblGridlines";
            this.lblGridlines.Size = new System.Drawing.Size(64, 16);
            this.lblGridlines.TabIndex = 9;
            this.lblGridlines.Text = "Gridlines:";
            // 
            // cboGridlines
            // 
            this.cboGridlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGridlines.FormattingEnabled = true;
            this.cboGridlines.Items.AddRange(new object[] {
            "None",
            "Horizontal",
            "Vertical & Horizontal"});
            this.cboGridlines.Location = new System.Drawing.Point(132, 84);
            this.cboGridlines.Name = "cboGridlines";
            this.cboGridlines.Size = new System.Drawing.Size(136, 24);
            this.cboGridlines.TabIndex = 8;
            this.cboGridlines.SelectedIndexChanged += new System.EventHandler(this.cboGridlines_SelectedIndexChanged);
            // 
            // btnAlternatingRowColor
            // 
            this.btnAlternatingRowColor.AutoSize = true;
            this.btnAlternatingRowColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlternatingRowColor.Image = ((System.Drawing.Image)(resources.GetObject("btnAlternatingRowColor.Image")));
            this.btnAlternatingRowColor.Location = new System.Drawing.Point(6, 53);
            this.btnAlternatingRowColor.Name = "btnAlternatingRowColor";
            this.btnAlternatingRowColor.Size = new System.Drawing.Size(162, 26);
            this.btnAlternatingRowColor.TabIndex = 5;
            this.btnAlternatingRowColor.Text = "&Alternating Row Color";
            this.btnAlternatingRowColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlternatingRowColor.UseVisualStyleBackColor = true;
            this.btnAlternatingRowColor.Click += new System.EventHandler(this.btnAlternatingRowColor_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(240, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(52, 26);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.AutoSize = true;
            this.btnDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnDefault.Image")));
            this.btnDefault.Location = new System.Drawing.Point(69, 309);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(83, 26);
            this.btnDefault.TabIndex = 9;
            this.btnDefault.Text = "&Defaults";
            this.btnDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(158, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpShed);
            this.Controls.Add(this.grpMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPreview;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Customize";
            this.Load += new System.EventHandler(this.frmCustomize_Load);
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.menuPreview.ResumeLayout(false);
            this.menuPreview.PerformLayout();
            this.grpShed.ResumeLayout(false);
            this.grpShed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuColor;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnRowColor;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.MenuStrip menuPreview;
        private System.Windows.Forms.GroupBox grpShed;
        private System.Windows.Forms.ToolStripMenuItem menuItemPreview;
        private System.Windows.Forms.Button btnAlternatingRowColor;
        private System.Windows.Forms.ComboBox cboGridlines;
        private System.Windows.Forms.Label lblGridlines;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblColumnSizeMode;
        private System.Windows.Forms.ComboBox cboAutosizeColumnsMode;
    }
}