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
	public partial class FormPush : Form
	{
		private enum HwndInsertAfter
		{
			HWND_BOTTOM = 1,
			HWND_NOTOPMOST = -2,
			HWND_TOP = 0,
			HWND_TOPMOST = -1
		}

		private int time = 0;

		public FormPush()
		{
			InitializeComponent();

			Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);
		}

		public FormPush(String username, String title)
		{
			InitializeComponent();

			Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);

			MySetText(username, title);
		}

		private void FormPush_Shown(object sender, EventArgs e)
		{
			timer.Enabled = true;
			timer.Start();
		}

		private void FormPush_Click(object sender, EventArgs e)
		{
			//System.Diagnostics.Process.Start(URL);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			time++;

			if (time == 3)
				Close();
		}

		private void MySetText(String username, String title)
		{
			label_Username.Text = username;
			label_Title.Text = title;
		}
	}
}