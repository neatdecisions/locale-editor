using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocaleEditor
{
	public partial class InputBox : Form
	{
		public InputBox()
		{
			InitializeComponent();
		}

		public void setInputText(string text)
		{
			textBoxInput.Text = text;
		}

		public string getInputText()
		{
			return textBoxInput.Text;
		}
		
	}
}
