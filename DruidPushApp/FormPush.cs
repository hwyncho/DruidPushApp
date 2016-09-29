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
		private int time = 0;

		private const int SW_SHOWNORMAL = 1;
		private const int SW_SHOWMINIMIZED = 2;
		private const int SW_SHOWMAXIMIZED = 3;

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
			IntPtr hWnd = FindWindow(null, this.Text);

			if (!hWnd.Equals(IntPtr.Zero))
			{
				ShowWindowAsync(hWnd, SW_SHOWNORMAL);       // 윈도우가 최소화 되어 있다면 활성화 시킨다				
				SetForegroundWindow(hWnd);					// 윈도우에 포커스를 줘서 최상위로 만든다
			}

			timer.Enabled = true;
			timer.Start();
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

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
	}
}