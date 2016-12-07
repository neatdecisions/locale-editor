using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LocaleEditor
{
  public partial class ProjectOptionsForm : Form
  {

    protected LocalizationProject project = null;
    protected BindingList<SingleLocale> bindingList = null;
    protected string NewLanguageName = "{{New language{0}}}";
    SingleLocale defaultLocale = null;

    public ProjectOptionsForm(LocalizationProject project)
    {
      if ( project == null )
        throw new Exception("Localization project is not set");
      this.project = project;
      InitializeComponent();
    }


    private void ProjectOptionsForm_Load( object sender, EventArgs e )
    {
      dataGridLanguages.Rows.Clear();
      /*foreach ( SingleLocale loc in project.Locales )
      {
        int i = dataGridLanguages.Rows.Add( loc.Name, "", "" );
        dataGridLanguages.Rows[ i ].Tag = loc;
      }*/

      bindingList = new BindingList<SingleLocale>();

      foreach ( SingleLocale loc in project.Locales )
      {
        bindingList.Add( loc );
      }
      //( project.Locales );

      foreach ( SingleLocale loc in bindingList )
      {
        int i = dataGridLanguages.Rows.Add( loc.Name, loc.Code, "" );
        dataGridLanguages.Rows[ i ].Tag = loc;
      }


      toolStripComboBox1.ComboBox.DataSource = bindingList;
      toolStripComboBox1.ComboBox.DisplayMember = "SingleLocale.Name";

      if ( project.DefaultLocale != null )
      {
        defaultLocale = project.DefaultLocale;
      }
      else
      {
        if ( bindingList.Count > 0 )
          defaultLocale = bindingList[ 0 ];
      }
      
      toolStripComboBox1.SelectedItem = defaultLocale;

      
      // Bind alliance combobox to alliance list
      

    }

    private void tsbAddLanguage_Click( object sender, EventArgs e )
    {
      SingleLocale loc = new SingleLocale();

      int n = 0;
      bool nameExists = false;
      
      loc.Name = String.Format(NewLanguageName, "");
      do
      {
        nameExists = false;
        foreach ( DataGridViewRow row in dataGridLanguages.Rows )
        {
          if ( (string)row.Cells[ 0 ].Value == loc.Name )
          {
            loc.Name = String.Format( NewLanguageName, " " + ( ++n ).ToString() );
            nameExists = true;
            break;
          }
        }
      } while ( nameExists );
      
      //project.Locales.Add( loc );
      bindingList.Add( loc );
      int i = dataGridLanguages.Rows.Add( loc.Name, "", "" );
      /*
      n = toolStripComboBox1.Items.Add( loc );
      if ( toolStripComboBox1.Items.Count == 1 )
        toolStripComboBox1.SelectedIndex = n;*/

      dataGridLanguages.Rows[ i ].Tag = loc;
      dataGridLanguages.Rows[ i ].Selected = true;
      dataGridLanguages.CurrentCell = dataGridLanguages.Rows[ i ].Cells[ 0 ];
      dataGridLanguages.BeginEdit( true );
    }

    private void tsbRemoveLanguage_Click( object sender, EventArgs e )
    {
      if ( dataGridLanguages.SelectedRows.Count > 0 )
      {
        DataGridViewRow row = dataGridLanguages.SelectedRows[ 0 ];
        SingleLocale loc = row.Tag as SingleLocale;
        if ( loc != null )
          bindingList.Remove( loc );
        dataGridLanguages.Rows.Remove( row );
        //toolStripComboBox1.Items.Remove( loc );
      }
    }

    private void dataGridLanguages_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
    {
      if ( e.ColumnIndex == 0 )
      {
        foreach ( DataGridViewRow row in dataGridLanguages.Rows )
        {
          if ( row.Index == e.RowIndex )
            continue;
          if ( row.Cells[ 0 ].Value.ToString() == e.FormattedValue.ToString() )
          {
            Rectangle cr = dataGridLanguages.Rows[ e.RowIndex ].Cells[ e.ColumnIndex ].ContentBounds;
            Rectangle r = dataGridLanguages.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex, true );
            r.Offset( cr.Width, r.Height );
            errorTooltip.Show( "Error", dataGridLanguages, r.Location, 3000 );
            e.Cancel = true;

            break;
          }
        }
      }
      
    }

    private void dataGridLanguages_EditingControlShowing( object sender, DataGridViewEditingControlShowingEventArgs e )
    {
      TextBox tb = e.Control as TextBox;
      if ( tb != null )
      {
        tb.KeyDown += new KeyEventHandler(tb_KeyDown);
        tb.MouseClick += new MouseEventHandler( tb_MouseClick );
      }

    }

    void tb_MouseClick( object sender, MouseEventArgs e )
    {
      errorTooltip.Hide( dataGridLanguages );
    }

    void tb_KeyDown( object sender, KeyEventArgs e )
    {
      errorTooltip.Hide( dataGridLanguages );
    }

    private void dataGridLanguages_CellEndEdit( object sender, DataGridViewCellEventArgs e )
    {
      errorTooltip.Hide( dataGridLanguages );
    }

    private void toolStripComboBox1_SelectedIndexChanged( object sender, EventArgs e )
    {
      if (toolStripComboBox1.SelectedItem != null)
        defaultLocale = toolStripComboBox1.SelectedItem as SingleLocale;
    }

    private void dataGridLanguages_CellValidated( object sender, DataGridViewCellEventArgs e )
    {
      SingleLocale loc = dataGridLanguages.Rows[ e.RowIndex ].Tag as SingleLocale;
      if ( loc == null )
        return;
      switch( e.ColumnIndex)
      {
        case 0:
          loc.Name = dataGridLanguages.Rows[ e.RowIndex ].Cells[ e.ColumnIndex ].Value.ToString();

          toolStripComboBox1.ComboBox.DataSource = null;
          toolStripComboBox1.ComboBox.DataSource = bindingList;
          toolStripComboBox1.ComboBox.DisplayMember = "SingleLocale.Name";
          toolStripComboBox1.SelectedItem = defaultLocale;
          break;
        case 1:
          loc.Code = dataGridLanguages.Rows[ e.RowIndex ].Cells[ e.ColumnIndex ].Value.ToString();
          break;
    }

      /*int i = toolStripComboBox1.Items.IndexOf( loc );
      if ( i >= 0 )
      {
        toolStripComboBox1.ComboBox.DataSource = project.Locales;
      }*/
    }

    private void btnOk_Click( object sender, EventArgs e )
    {
      project.Locales.Clear();
      foreach ( DataGridViewRow row in dataGridLanguages.Rows )
      {
        SingleLocale loc = row.Tag as SingleLocale;
        if (loc != null)
          project.Locales.Add( loc );
      }
      //project.Locales.AddRange( bindingList.ToList() );
      try
      {
        project.DefaultLocale = defaultLocale;
      }
      catch
      {
        project.DefaultLocale = null;
      }
      //DialogResult = System.Windows.Forms.DialogResult.OK;
    }
  }
}
