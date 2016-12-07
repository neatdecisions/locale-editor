namespace LocaleEditor
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeLocale = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dataValues = new System.Windows.Forms.DataGridView();
			this.colLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAddValue = new System.Windows.Forms.ToolStripButton();
			this.tssbAddSection = new System.Windows.Forms.ToolStripSplitButton();
			this.tsmiAddSectionAsSibling = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbDelete = new System.Windows.Forms.ToolStripButton();
			this.tsbTranslate = new System.Windows.Forms.ToolStripButton();
			this.translatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataValues)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(917, 24);
			this.menuMain.TabIndex = 1;
			this.menuMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.translatorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = global::LocaleEditor.Properties.Resources.disk_black;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// projectToolStripMenuItem
			// 
			this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
			this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.projectToolStripMenuItem.Text = "Project";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exportToolStripMenuItem.Text = "Export...";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeLocale);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataValues);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer1.Size = new System.Drawing.Size(917, 429);
			this.splitContainer1.SplitterDistance = 305;
			this.splitContainer1.TabIndex = 2;
			// 
			// treeLocale
			// 
			this.treeLocale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeLocale.FullRowSelect = true;
			this.treeLocale.HideSelection = false;
			this.treeLocale.ImageIndex = 0;
			this.treeLocale.ImageList = this.imageList1;
			this.treeLocale.LabelEdit = true;
			this.treeLocale.Location = new System.Drawing.Point(0, 0);
			this.treeLocale.Name = "treeLocale";
			this.treeLocale.SelectedImageIndex = 0;
			this.treeLocale.Size = new System.Drawing.Size(305, 429);
			this.treeLocale.TabIndex = 1;
			this.treeLocale.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeLocale_AfterLabelEdit);
			this.treeLocale.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeLocale_AfterSelect);
			this.treeLocale.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeLocale_NodeMouseDoubleClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folder.png");
			this.imageList1.Images.SetKeyName(1, "receipt.png");
			// 
			// dataValues
			// 
			this.dataValues.AllowUserToAddRows = false;
			this.dataValues.AllowUserToDeleteRows = false;
			this.dataValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataValues.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLanguage,
            this.colValue});
			this.dataValues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataValues.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataValues.Location = new System.Drawing.Point(0, 28);
			this.dataValues.MultiSelect = false;
			this.dataValues.Name = "dataValues";
			this.dataValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataValues.RowHeadersVisible = false;
			this.dataValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataValues.Size = new System.Drawing.Size(605, 398);
			this.dataValues.TabIndex = 1;
			this.dataValues.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataValues_CellEndEdit);
			this.dataValues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataValues_KeyPress);
			this.dataValues.Resize += new System.EventHandler(this.dataValues_Resize);
			// 
			// colLanguage
			// 
			this.colLanguage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colLanguage.FillWeight = 30F;
			this.colLanguage.HeaderText = "Language";
			this.colLanguage.Name = "colLanguage";
			this.colLanguage.ReadOnly = true;
			this.colLanguage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colValue
			// 
			this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colValue.FillWeight = 70F;
			this.colValue.HeaderText = "Value";
			this.colValue.Name = "colValue";
			this.colValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddValue,
            this.tssbAddSection,
            this.tsbDelete,
            this.tsbTranslate});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(608, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAddValue
			// 
			this.tsbAddValue.Image = global::LocaleEditor.Properties.Resources.receipt__plus;
			this.tsbAddValue.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAddValue.Name = "tsbAddValue";
			this.tsbAddValue.Size = new System.Drawing.Size(80, 22);
			this.tsbAddValue.Text = "Add value";
			this.tsbAddValue.Click += new System.EventHandler(this.tsbAddValue_Click);
			// 
			// tssbAddSection
			// 
			this.tssbAddSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddSectionAsSibling});
			this.tssbAddSection.Image = global::LocaleEditor.Properties.Resources.folder__plus;
			this.tssbAddSection.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssbAddSection.Name = "tssbAddSection";
			this.tssbAddSection.Size = new System.Drawing.Size(102, 22);
			this.tssbAddSection.Text = "Add section";
			this.tssbAddSection.ButtonClick += new System.EventHandler(this.tssbAddSection_ButtonClick);
			// 
			// tsmiAddSectionAsSibling
			// 
			this.tsmiAddSectionAsSibling.Name = "tsmiAddSectionAsSibling";
			this.tsmiAddSectionAsSibling.Size = new System.Drawing.Size(125, 22);
			this.tsmiAddSectionAsSibling.Text = "As sibling";
			this.tsmiAddSectionAsSibling.Click += new System.EventHandler(this.tsmiAddSectionAsSibling_Click);
			// 
			// tsbDelete
			// 
			this.tsbDelete.Image = global::LocaleEditor.Properties.Resources.cross_script;
			this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDelete.Name = "tsbDelete";
			this.tsbDelete.Size = new System.Drawing.Size(60, 22);
			this.tsbDelete.Text = "Delete";
			this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
			// 
			// tsbTranslate
			// 
			this.tsbTranslate.Image = ((System.Drawing.Image)(resources.GetObject("tsbTranslate.Image")));
			this.tsbTranslate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTranslate.Name = "tsbTranslate";
			this.tsbTranslate.Size = new System.Drawing.Size(74, 22);
			this.tsbTranslate.Text = "Translate";
			this.tsbTranslate.Click += new System.EventHandler(this.tsbTranslate_Click);
			// 
			// translatorToolStripMenuItem
			// 
			this.translatorToolStripMenuItem.Name = "translatorToolStripMenuItem";
			this.translatorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.translatorToolStripMenuItem.Text = "Microsoft Translator...";
			this.translatorToolStripMenuItem.Click += new System.EventHandler(this.translatorToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(917, 453);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Locale Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataValues)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuMain;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView treeLocale;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbAddValue;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.DataGridView dataValues;
    private System.Windows.Forms.ToolStripButton tsbDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn colLanguage;
    private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.ToolStripSplitButton tssbAddSection;
    private System.Windows.Forms.ToolStripMenuItem tsmiAddSectionAsSibling;
    private System.Windows.Forms.ToolStripButton tsbTranslate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem translatorToolStripMenuItem;
	}
}

