namespace LocaleEditor
{
  partial class ProjectOptionsForm
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
			this.errorTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tabPageLanguages = new System.Windows.Forms.TabPage();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAddLanguage = new System.Windows.Forms.ToolStripButton();
			this.tsbRemoveLanguage = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbDefaultLanguage = new System.Windows.Forms.ToolStripLabel();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.dataGridLanguages = new System.Windows.Forms.DataGridView();
			this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControlOptions = new System.Windows.Forms.TabControl();
			this.tabPageLanguages.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLanguages)).BeginInit();
			this.tabControlOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// errorTooltip
			// 
			this.errorTooltip.IsBalloon = true;
			this.errorTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(422, 375);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(503, 375);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tabPageLanguages
			// 
			this.tabPageLanguages.Controls.Add(this.dataGridLanguages);
			this.tabPageLanguages.Controls.Add(this.toolStrip1);
			this.tabPageLanguages.Location = new System.Drawing.Point(4, 25);
			this.tabPageLanguages.Name = "tabPageLanguages";
			this.tabPageLanguages.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLanguages.Size = new System.Drawing.Size(574, 342);
			this.tabPageLanguages.TabIndex = 0;
			this.tabPageLanguages.Text = "Languages";
			this.tabPageLanguages.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddLanguage,
            this.tsbRemoveLanguage,
            this.toolStripSeparator1,
            this.tsbDefaultLanguage,
            this.toolStripComboBox1});
			this.toolStrip1.Location = new System.Drawing.Point(3, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(568, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAddLanguage
			// 
			this.tsbAddLanguage.Image = global::LocaleEditor.Properties.Resources.globe__plus;
			this.tsbAddLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAddLanguage.Name = "tsbAddLanguage";
			this.tsbAddLanguage.Size = new System.Drawing.Size(101, 22);
			this.tsbAddLanguage.Text = "Add language";
			this.tsbAddLanguage.Click += new System.EventHandler(this.tsbAddLanguage_Click);
			// 
			// tsbRemoveLanguage
			// 
			this.tsbRemoveLanguage.Image = global::LocaleEditor.Properties.Resources.globe__minus;
			this.tsbRemoveLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRemoveLanguage.Name = "tsbRemoveLanguage";
			this.tsbRemoveLanguage.Size = new System.Drawing.Size(122, 22);
			this.tsbRemoveLanguage.Text = "Remove language";
			this.tsbRemoveLanguage.Click += new System.EventHandler(this.tsbRemoveLanguage_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbDefaultLanguage
			// 
			this.tsbDefaultLanguage.Name = "tsbDefaultLanguage";
			this.tsbDefaultLanguage.Size = new System.Drawing.Size(100, 22);
			this.tsbDefaultLanguage.Text = "Default language:";
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
			// 
			// dataGridLanguages
			// 
			this.dataGridLanguages.AllowUserToAddRows = false;
			this.dataGridLanguages.AllowUserToDeleteRows = false;
			this.dataGridLanguages.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridLanguages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCode,
            this.colFileName});
			this.dataGridLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridLanguages.Location = new System.Drawing.Point(3, 28);
			this.dataGridLanguages.Name = "dataGridLanguages";
			this.dataGridLanguages.RowHeadersVisible = false;
			this.dataGridLanguages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridLanguages.ShowCellToolTips = false;
			this.dataGridLanguages.Size = new System.Drawing.Size(568, 311);
			this.dataGridLanguages.TabIndex = 1;
			this.dataGridLanguages.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLanguages_CellEndEdit);
			this.dataGridLanguages.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLanguages_CellValidated);
			this.dataGridLanguages.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridLanguages_CellValidating);
			this.dataGridLanguages.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridLanguages_EditingControlShowing);
			// 
			// colFileName
			// 
			this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFileName.FillWeight = 45F;
			this.colFileName.HeaderText = "File name";
			this.colFileName.Name = "colFileName";
			this.colFileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colCode
			// 
			this.colCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colCode.FillWeight = 10F;
			this.colCode.HeaderText = "Code";
			this.colCode.Name = "colCode";
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.FillWeight = 45F;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			// 
			// tabControlOptions
			// 
			this.tabControlOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControlOptions.Controls.Add(this.tabPageLanguages);
			this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
			this.tabControlOptions.Name = "tabControlOptions";
			this.tabControlOptions.SelectedIndex = 0;
			this.tabControlOptions.Size = new System.Drawing.Size(582, 371);
			this.tabControlOptions.TabIndex = 0;
			// 
			// ProjectOptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 406);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tabControlOptions);
			this.KeyPreview = true;
			this.Name = "ProjectOptionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project Options";
			this.Load += new System.EventHandler(this.ProjectOptionsForm_Load);
			this.tabPageLanguages.ResumeLayout(false);
			this.tabPageLanguages.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLanguages)).EndInit();
			this.tabControlOptions.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ToolTip errorTooltip;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabPage tabPageLanguages;
		private System.Windows.Forms.DataGridView dataGridLanguages;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbAddLanguage;
		private System.Windows.Forms.ToolStripButton tsbRemoveLanguage;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel tsbDefaultLanguage;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.TabControl tabControlOptions;
	}
}