using System;
using System.Drawing;
using System.Windows.Forms;

namespace DruidPushApp
{
	public partial class FormBackground : Form
	{
		public FormBackground()
		{
			InitializeComponent();
		}

		private void FormBackground_Load(object sender, EventArgs e)
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			BackColor = Color.Transparent;
		}
	}
}