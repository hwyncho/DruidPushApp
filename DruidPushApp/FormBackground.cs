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

			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			BackColor = Color.Transparent;
		}
	}
}