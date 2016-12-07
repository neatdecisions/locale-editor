using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace LocaleEditor
{
	public partial class MainForm : Form
	{
		private LocalizationProject project = new LocalizationProject();

		public MainForm()
		{
			InitializeComponent();
			project.FileName = null;
		}


		private void ProcessNodeForExport(System.IO.StreamWriter sw, SingleLocale loc, TreeNode node, string prefix)
		{
			foreach (TreeNode subNode in node.Nodes)
			{
				if (subNode.Tag is LocaleValue)
				{
					LocaleValue lv = subNode.Tag as LocaleValue;
					string s = prefix + lv.Name + "=" + lv[loc];
					sw.WriteLine(s);
				}
				else if (subNode.Tag is LocaleSection)
				{
					LocaleSection ls = subNode.Tag as LocaleSection;
					ProcessNodeForExport(sw, loc, subNode, prefix + ls.Name + ".");
				}
			}

		}


		private void ExportProject(string folderPath)
		{
			foreach (SingleLocale loc in project.Locales)
			{
				StringBuilder builder = new StringBuilder(loc.Name);
				foreach (char c in ":\\/*?|<>")
				{
					builder.Replace(c, '_');
				}

				builder.Append(".lng");
				builder.Insert(0, "\\");
				builder.Insert(0, folderPath);

				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(builder.ToString(), false, Encoding.Unicode))
				{
					foreach (TreeNode node in treeLocale.Nodes)
					{
						if (node.Tag is LocaleSection)
						{
							LocaleSection ls = node.Tag as LocaleSection;
							sw.WriteLine(String.Format("[{0}]", ls.Name));
							ProcessNodeForExport(sw, loc, node, "");
						}
					}
				}
			}
		}

		private void SaveNode(XmlWriter writer, TreeNode node)
		{
			if (node.Tag is LocaleSection)
			{
				LocaleSection ls = node.Tag as LocaleSection;
				writer.WriteStartElement("section");
				writer.WriteAttributeString("name", ls.Name);

				foreach (TreeNode subNode in node.Nodes)
				{
					SaveNode(writer, subNode);
				}

				writer.WriteEndElement();
			}
			else
			{
				if (node.Tag is LocaleValue)
				{
					LocaleValue lv = node.Tag as LocaleValue;
					writer.WriteStartElement("value");
					writer.WriteAttributeString("name", lv.Name);

					foreach (SingleLocale loc in project.Locales)
					{
						writer.WriteStartElement("lang");
						writer.WriteAttributeString("name", loc.Name);
						writer.WriteString(lv[loc]);
						writer.WriteEndElement();
					}

					writer.WriteEndElement();
				}
			}
		}

		private void SaveProject(string fileName)
		{
			if (System.IO.File.Exists(fileName))
				System.IO.File.Copy(fileName, fileName + ".~bak", true);
			FillDataValues(false);
			XmlWriter writer = XmlWriter.Create(fileName);
			writer.WriteStartDocument();
			writer.WriteStartElement("LocalizationProject");

			writer.WriteStartElement("Languages");

			foreach (SingleLocale loc in project.Locales)
			{
				writer.WriteStartElement("language");
				writer.WriteAttributeString("name", loc.Name);
				writer.WriteAttributeString("code", loc.Code);
				if (loc == project.DefaultLocale)
					writer.WriteAttributeString("default", "true");
				writer.WriteEndElement();
			}

			writer.WriteEndElement();

			foreach (TreeNode node in treeLocale.Nodes)
			{
				SaveNode(writer, node);
			}

			writer.WriteEndElement();
			writer.WriteEndDocument();
			writer.Flush();
			writer.Close();

			project.FileName = fileName;
			project.IsSaved = true;
		}


		private void ReadNode(XmlNode node, TreeNodeCollection treeNodes)
		{
			XmlNodeList sections = node.SelectNodes("section");
			foreach (XmlNode sectionNode in sections)
			{
				LocaleSection section = new LocaleSection(ReadAttribute(sectionNode, "name"));
				TreeNode nd = treeNodes.Add(section.Name);
				nd.Tag = section;
				nd.ImageIndex = 0;
				nd.SelectedImageIndex = 0;
				ReadNode(sectionNode, nd.Nodes);
			}


			XmlNodeList values = node.SelectNodes("value");
			foreach (XmlNode valueNode in values)
			{
				LocaleValue lv = new LocaleValue(ReadAttribute(valueNode, "name"));
				foreach (SingleLocale loc in project.Locales)
				{
					XmlNode langNode = valueNode.SelectSingleNode(String.Format("lang[@name='{0}']", loc.Name));
					if (langNode == null)
						continue;
					lv[loc] = langNode.InnerText;
				}
				TreeNode nd = treeNodes.Add(lv.Name);
				nd.Tag = lv;
				nd.ImageIndex = 1;
				nd.SelectedImageIndex = 1;
			}


		}

		private string ReadAttribute(XmlNode node, string attribName)
		{
			if (node.Attributes[attribName] == null)
				return "";
			return node.Attributes[attribName].Value;
		}

		private void LoadProject(string fileName)
		{
			project.Locales.Clear();
			XmlDocument doc = new XmlDocument();
			doc.Load(fileName);
			XmlNode node = doc.DocumentElement;
			XmlNodeList langNodes = node.SelectNodes("//Languages/language");
			foreach (XmlNode langNode in langNodes)
			{
				SingleLocale loc = new SingleLocale();
				loc.Name = ReadAttribute(langNode, "name");
				loc.Code = ReadAttribute(langNode, "code");
				project.Locales.Add(loc);
				if (ReadAttribute(langNode, "default") == "true")
					project.DefaultLocale = loc;
			}

			treeLocale.Nodes.Clear();

			ReadNode(node, treeLocale.Nodes);

			project.FileName = fileName;

		}

		private void tsbAddValue_Click(object sender, EventArgs e)
		{
			project.IsSaved = false;
			TreeNode node = treeLocale.SelectedNode;
			TreeNode newNode = null;
			if (node == null)
				newNode = treeLocale.Nodes.Add("{new value}");
			else
			{
				if (node.Tag is LocaleSection)
					newNode = node.Nodes.Add("{new value}");
				else
				{
					if (node.Parent == null)
					{
						newNode = treeLocale.Nodes.Add("{new value}");
					}
					else
					{
						newNode = node.Parent.Nodes.Add("{new value}");
					}
				}
			}

			if (newNode != null)
			{
				newNode.SelectedImageIndex = 1;
				newNode.ImageIndex = 1;
				newNode.Tag = new LocaleValue("{new value}");
				treeLocale.SelectedNode = newNode;
				newNode.BeginEdit();
			}
		}

		private void treeLocale_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				if (e.Node.Bounds.Contains(e.Location))
					e.Node.BeginEdit();
			}

			if (e.X >= e.Node.Bounds.Left)
			{
				return;
			}

		}


		private void FillDataValues(bool toForm = false)
		{
			if (toForm)
			{
				dataValues.Rows.Clear();
				LocaleValue lv = dataValues.Tag as LocaleValue;
				if (lv != null)
				{
					foreach (SingleLocale loc in project.Locales)
					{
						int i = dataValues.Rows.Add(loc.Name, lv[loc]);
						dataValues.Rows[i].Tag = loc;
					}
				}
			}
			else
			{
				LocaleValue lv = dataValues.Tag as LocaleValue;

				if (lv != null)
				{
					foreach (DataGridViewRow row in dataValues.Rows)
					{
						SingleLocale loc = row.Tag as SingleLocale;
						if (loc != null)
							lv[loc] = row.Cells[1].Value as string;
					}
				}
			}
		}


		private void RefreshDataGrid(TreeNode node)
		{
			FillDataValues(false);
			dataValues.Tag = null;
			dataValues.Rows.Clear();
			if (node != null)
			{
				if (node.Tag is LocaleValue)
				{
					dataValues.Tag = node.Tag;
					FillDataValues(true);
				}
			}
		}


		private void treeLocale_AfterSelect(object sender, TreeViewEventArgs e)
		{
			RefreshDataGrid(e.Node);
		}

		private void tsbDelete_Click(object sender, EventArgs e)
		{
			project.IsSaved = false;
			TreeNode node = treeLocale.SelectedNode;
			node.Remove();
		}

		private void dataValues_Resize(object sender, EventArgs e)
		{
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
		}

		private void PerformProjectSave()
		{
			if (project.FileName == null)
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.DefaultExt = "xml";
				sfd.Filter = "Localization projects|*.xml";
				sfd.OverwritePrompt = true;
				if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					SaveProject(sfd.FileName);
			}
			else
				SaveProject(project.FileName);
		}


		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PerformProjectSave();
		}

		private void treeLocale_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			if (e.Label == null)
				return;
			project.IsSaved = false;
			if (e.Node.Tag is LocaleSection)
			{
				(e.Node.Tag as LocaleSection).Name = e.Label;
			}
			else
				if (e.Node.Tag is LocaleValue)
			{
				(e.Node.Tag as LocaleValue).Name = e.Label;
			}
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProjectOptionsForm pof = new ProjectOptionsForm(project);
			if (pof.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				project.IsSaved = false;
				FillDataValues(false);
				FillDataValues(true);
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.ShowDialog();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ConfirmDiscarding())
			{
				OpenFileDialog ofd = new OpenFileDialog();
				if (project.FileName != null)
				{
					ofd.InitialDirectory = System.IO.Path.GetDirectoryName(project.FileName);
				}
				ofd.DefaultExt = "xml";
				ofd.Filter = "Localization projects|*.xml";
				ofd.CheckFileExists = true;
				ofd.Multiselect = false;

				if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					LoadProject(ofd.FileName);
			}
		}


		private bool ConfirmDiscarding()
		{
			if (project.IsSaved)
				return true;

			switch (MessageBox.Show("Save current project?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
			{
				case System.Windows.Forms.DialogResult.Yes:
					PerformProjectSave();
					return true;
				case System.Windows.Forms.DialogResult.No:
					return true;
				default:
					return false;
			}

		}


		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ConfirmDiscarding())
			{
				project.FileName = null;
				project.DefaultLocale = null;
				project.Locales.Clear();
				treeLocale.Nodes.Clear();
				RefreshDataGrid(null);
				project.IsSaved = true;
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !ConfirmDiscarding();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (project.FileName != null)
				fbd.SelectedPath = System.IO.Path.GetDirectoryName(project.FileName);
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ExportProject(fbd.SelectedPath);
			}
		}

		private void dataValues_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			FillDataValues(false);
		}


		private void AddSection(TreeNode node, bool asSibling = false)
		{
			project.IsSaved = false;
			TreeNode newNode = null;

			if (asSibling && node != null)
				node = node.Parent;

			if (node == null)
				newNode = newNode = treeLocale.Nodes.Add("{new section}");
			else
			{
				if (node.Tag is LocaleSection)
				{
					newNode = node.Nodes.Add("{new section}");
				}
				else
				{
					if (node.Parent == null)
						newNode = treeLocale.Nodes.Add("{new section}");
					else
						newNode = node.Parent.Nodes.Add("{new section}");
				}
			}

			if (newNode != null)
			{
				newNode.Tag = new LocaleSection("{new section}");
				newNode.SelectedImageIndex = 0;
				newNode.ImageIndex = 0;
				treeLocale.SelectedNode = newNode;
				newNode.BeginEdit();
			}
		}


		private void tssbAddSection_ButtonClick(object sender, EventArgs e)
		{
			AddSection(treeLocale.SelectedNode, false);
		}

		private void tsmiAddSectionAsSibling_Click(object sender, EventArgs e)
		{
			AddSection(treeLocale.SelectedNode, true);
		}

		private void dataValues_KeyPress(object sender, KeyPressEventArgs e)
		{
			return;
		}

		private void tsbTranslate_Click(object sender, EventArgs e)
		{
			TranslatorService.LanguageServiceClient client = null;
			try
			{
				client = new TranslatorService.LanguageServiceClient("BasicHttpBinding_LanguageService");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}


			if (dataValues.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataValues.SelectedRows[0];
				SingleLocale loc = row.Tag as SingleLocale;
				if (loc == null || loc == project.DefaultLocale || project.DefaultLocale == null)
					return;
				string defaultValue = "";
				foreach (DataGridViewRow r in dataValues.Rows)
				{
					if ((r.Tag as SingleLocale) == project.DefaultLocale)
					{
						defaultValue = r.Cells[1].Value.ToString();
						break;
					}
				}
				if (defaultValue == null)
					return;

				if (string.IsNullOrEmpty(Properties.Settings.Default.TranslatorToken))
				{
					if (!requestTranslatorToken())
					{
						return;
					}
				}
				try
				{
					row.Cells[1].Value = client.Translate(Properties.Settings.Default.TranslatorToken, defaultValue, project.DefaultLocale.Code, loc.Code);
					project.IsSaved = false;
					dataValues.RefreshEdit();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

			}
		}

		private bool requestTranslatorToken()
		{
			InputBox inputBox = new InputBox();
			inputBox.setInputText(Properties.Settings.Default.TranslatorToken);
			if (inputBox.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.TranslatorToken = inputBox.getInputText();
				Properties.Settings.Default.Save();
				return true;
			}
			return false;
		}

		private void translatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InputBox inputBox = new InputBox();
			inputBox.setInputText(Properties.Settings.Default.TranslatorToken);
			if (inputBox.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.TranslatorToken = inputBox.getInputText();
				Properties.Settings.Default.Save();
			}
		}
	}
}
