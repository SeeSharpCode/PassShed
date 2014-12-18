namespace PassShed.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvShed = new System.Windows.Forms.DataGridView();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.grpCategories = new System.Windows.Forms.GroupBox();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.catToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAddCategory = new System.Windows.Forms.ToolStripButton();
            this.btnRenameCategory = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCategory = new System.Windows.Forms.ToolStripButton();
            this.grpFields = new System.Windows.Forms.GroupBox();
            this.lstFields = new System.Windows.Forms.ListBox();
            this.fieldToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAddField = new System.Windows.Forms.ToolStripButton();
            this.btnRenameField = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteField = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCsvImporter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMetadata = new System.Windows.Forms.ToolStrip();
            this.lblCreated = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lblModified = new System.Windows.Forms.ToolStripLabel();
            this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShed)).BeginInit();
            this.grpCategories.SuspendLayout();
            this.catToolStrip.SuspendLayout();
            this.grpFields.SuspendLayout();
            this.fieldToolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStripMetadata.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShed
            // 
            this.dgvShed.AllowUserToAddRows = false;
            this.dgvShed.AllowUserToDeleteRows = false;
            this.dgvShed.AllowUserToOrderColumns = true;
            this.dgvShed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvShed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShed.Location = new System.Drawing.Point(221, 62);
            this.dgvShed.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShed.Name = "dgvShed";
            this.dgvShed.RowHeadersVisible = false;
            this.dgvShed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShed.Size = new System.Drawing.Size(585, 379);
            this.dgvShed.TabIndex = 1;
            this.dgvShed.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShed_CellEndEdit);
            this.dgvShed.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShed_CellEnter);
            this.dgvShed.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvShed_ColumnDisplayIndexChanged);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.AutoSize = true;
            this.btnNewAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAccount.Image")));
            this.btnNewAccount.Location = new System.Drawing.Point(221, 28);
            this.btnNewAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(112, 26);
            this.btnNewAccount.TabIndex = 4;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // grpCategories
            // 
            this.grpCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpCategories.Controls.Add(this.lstCategories);
            this.grpCategories.Controls.Add(this.catToolStrip);
            this.grpCategories.Controls.Add(this.grpFields);
            this.grpCategories.Location = new System.Drawing.Point(13, 28);
            this.grpCategories.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategories.Name = "grpCategories";
            this.grpCategories.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategories.Size = new System.Drawing.Size(200, 446);
            this.grpCategories.TabIndex = 7;
            this.grpCategories.TabStop = false;
            this.grpCategories.Text = "Categories";
            // 
            // lstCategories
            // 
            this.lstCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 16;
            this.lstCategories.Location = new System.Drawing.Point(4, 42);
            this.lstCategories.Margin = new System.Windows.Forms.Padding(4);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(192, 141);
            this.lstCategories.TabIndex = 8;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // catToolStrip
            // 
            this.catToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCategory,
            this.btnRenameCategory,
            this.btnDeleteCategory});
            this.catToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.catToolStrip.Location = new System.Drawing.Point(4, 19);
            this.catToolStrip.Name = "catToolStrip";
            this.catToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.catToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.catToolStrip.Size = new System.Drawing.Size(192, 23);
            this.catToolStrip.TabIndex = 7;
            this.catToolStrip.Text = "toolStrip1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(49, 20);
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnRenameCategory
            // 
            this.btnRenameCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnRenameCategory.Image")));
            this.btnRenameCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRenameCategory.Name = "btnRenameCategory";
            this.btnRenameCategory.Size = new System.Drawing.Size(70, 20);
            this.btnRenameCategory.Text = "Rename";
            this.btnRenameCategory.Click += new System.EventHandler(this.btnRenameCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(60, 20);
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // grpFields
            // 
            this.grpFields.Controls.Add(this.lstFields);
            this.grpFields.Controls.Add(this.fieldToolStrip);
            this.grpFields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFields.Location = new System.Drawing.Point(4, 183);
            this.grpFields.Margin = new System.Windows.Forms.Padding(4);
            this.grpFields.Name = "grpFields";
            this.grpFields.Padding = new System.Windows.Forms.Padding(4);
            this.grpFields.Size = new System.Drawing.Size(192, 259);
            this.grpFields.TabIndex = 9;
            this.grpFields.TabStop = false;
            this.grpFields.Text = "Fields";
            // 
            // lstFields
            // 
            this.lstFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFields.FormattingEnabled = true;
            this.lstFields.ItemHeight = 16;
            this.lstFields.Location = new System.Drawing.Point(4, 42);
            this.lstFields.Margin = new System.Windows.Forms.Padding(4);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(184, 213);
            this.lstFields.TabIndex = 10;
            // 
            // fieldToolStrip
            // 
            this.fieldToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddField,
            this.btnRenameField,
            this.btnDeleteField});
            this.fieldToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.fieldToolStrip.Location = new System.Drawing.Point(4, 19);
            this.fieldToolStrip.Name = "fieldToolStrip";
            this.fieldToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fieldToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fieldToolStrip.Size = new System.Drawing.Size(184, 23);
            this.fieldToolStrip.TabIndex = 9;
            this.fieldToolStrip.Text = "toolStrip1";
            // 
            // btnAddField
            // 
            this.btnAddField.Image = ((System.Drawing.Image)(resources.GetObject("btnAddField.Image")));
            this.btnAddField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(49, 20);
            this.btnAddField.Text = "Add";
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnRenameField
            // 
            this.btnRenameField.Image = ((System.Drawing.Image)(resources.GetObject("btnRenameField.Image")));
            this.btnRenameField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRenameField.Name = "btnRenameField";
            this.btnRenameField.Size = new System.Drawing.Size(70, 20);
            this.btnRenameField.Text = "Rename";
            this.btnRenameField.Click += new System.EventHandler(this.btnRenameField_Click);
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteField.Image")));
            this.btnDeleteField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(60, 20);
            this.btnDeleteField.Text = "Delete";
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 20, 0);
            this.statusStrip.Size = new System.Drawing.Size(819, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoSize = true;
            this.btnDeleteAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.Location = new System.Drawing.Point(341, 28);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(125, 26);
            this.btnDeleteAccount.TabIndex = 9;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.tempToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(819, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCsvImporter,
            this.btnOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // btnCsvImporter
            // 
            this.btnCsvImporter.Image = ((System.Drawing.Image)(resources.GetObject("btnCsvImporter.Image")));
            this.btnCsvImporter.Name = "btnCsvImporter";
            this.btnCsvImporter.Size = new System.Drawing.Size(153, 22);
            this.btnCsvImporter.Text = "&CSV Importer...";
            this.btnCsvImporter.Click += new System.EventHandler(this.btnCsvImport_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(153, 22);
            this.btnOptions.Text = "&Options...";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp,
            this.toolStripSeparator5,
            this.btnAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(107, 22);
            this.btnHelp.Text = "&Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(104, 6);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(107, 22);
            this.btnAbout.Text = "&About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStripMetadata
            // 
            this.toolStripMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripMetadata.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMetadata.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMetadata.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMetadata.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCreated,
            this.toolStripSeparator,
            this.lblModified});
            this.toolStripMetadata.Location = new System.Drawing.Point(801, 445);
            this.toolStripMetadata.Name = "toolStripMetadata";
            this.toolStripMetadata.Size = new System.Drawing.Size(9, 25);
            this.toolStripMetadata.TabIndex = 11;
            this.toolStripMetadata.Text = "toolStrip1";
            // 
            // lblCreated
            // 
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // lblModified
            // 
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(0, 22);
            // 
            // tempToolStripMenuItem
            // 
            this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
            this.tempToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.tempToolStripMenuItem.Text = "Temp";
            this.tempToolStripMenuItem.Click += new System.EventHandler(this.tempToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.toolStripMetadata);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.grpCategories);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.dgvShed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(504, 424);
            this.Name = "frmMain";
            this.Text = "PassShed";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShed)).EndInit();
            this.grpCategories.ResumeLayout(false);
            this.grpCategories.PerformLayout();
            this.catToolStrip.ResumeLayout(false);
            this.catToolStrip.PerformLayout();
            this.grpFields.ResumeLayout(false);
            this.grpFields.PerformLayout();
            this.fieldToolStrip.ResumeLayout(false);
            this.fieldToolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripMetadata.ResumeLayout(false);
            this.toolStripMetadata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShed;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.GroupBox grpCategories;
        private System.Windows.Forms.ToolStrip catToolStrip;
        private System.Windows.Forms.ToolStripButton btnAddCategory;
        private System.Windows.Forms.ToolStripButton btnRenameCategory;
        private System.Windows.Forms.ToolStripButton btnDeleteCategory;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.GroupBox grpFields;
        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.ToolStrip fieldToolStrip;
        private System.Windows.Forms.ToolStripButton btnAddField;
        private System.Windows.Forms.ToolStripButton btnRenameField;
        private System.Windows.Forms.ToolStripButton btnDeleteField;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOptions;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStrip toolStripMetadata;
        private System.Windows.Forms.ToolStripLabel lblCreated;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripLabel lblModified;
        private System.Windows.Forms.ToolStripMenuItem btnCsvImporter;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem;
    }
}

