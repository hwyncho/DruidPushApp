using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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