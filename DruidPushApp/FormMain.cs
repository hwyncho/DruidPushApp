using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DruidPushApp
{
	public partial class FormMain : System.Windows.Forms.Form
	{
		private const int INTERVAL_1 = 1000;
		private const int INTERVAL_3 = 3000;
		private const int INTERVAL_5 = 5000;

		private const String URL_Advanced = "http://druid.kw.ac.kr/Board/Contents/Advanced";
		private const String URL_Discrete = "http://druid.kw.ac.kr/Board/Contents/Discrete";
		private const String URL_Datastructure = "http://druid.kw.ac.kr/Board/Contents/Datastructure";
		private const String URL_Algorithm = "http://druid.kw.ac.kr/Board/Contents/Algorithm";

		private int interval = 1000;		// 알림 주기를 저장

		private String URL = "";			// 입력한 URL을 저장

		private int oldCount = 0;			// 이전 게시물 갯수 저장
		private int newCount = 0;			// 새 게시물 갯수 저장

		public FormMain()
		{
			InitializeComponent();

			this.MySetVariable();
		}

		private void ToolStripMenuItem_Interval_1_Click(object sender, EventArgs e)
		{
			this.ToolStripMenuItem_Interval_1.CheckState = CheckState.Checked;
			this.ToolStripMenuItem_Interval_3.CheckState = CheckState.Unchecked;
			this.ToolStripMenuItem_Interval_5.CheckState = CheckState.Unchecked;

			this.interval = INTERVAL_1;
		}

		private void ToolStripMenuItem_Interval_3_Click(object sender, EventArgs e)
		{
			this.ToolStripMenuItem_Interval_1.CheckState = CheckState.Unchecked;
			this.ToolStripMenuItem_Interval_3.CheckState = CheckState.Checked;
			this.ToolStripMenuItem_Interval_5.CheckState = CheckState.Unchecked;

			this.interval = INTERVAL_3;
		}

		private void ToolStripMenuItem_Interval_5_Click(object sender, EventArgs e)
		{
			this.ToolStripMenuItem_Interval_1.CheckState = CheckState.Unchecked;
			this.ToolStripMenuItem_Interval_3.CheckState = CheckState.Unchecked;
			this.ToolStripMenuItem_Interval_5.CheckState = CheckState.Checked;

			this.interval = INTERVAL_5;
		}

		private void ToolStripMenuItem_Quit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void radioButton_Click(object sender, EventArgs e)
		{
			this.MySelect_Subject();
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			if (this.URL == "")
			{
				MessageBox.Show("과목을 선택하세요!");
			}
			else
			{
				timer.Interval = this.interval;
				this.oldCount = MyGetCount();

				MyTrayMode(true);
			}
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			this.MyTrayMode(false);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(MyParse)).Start();
		}

		/* 변수 초기화 함수 */
		private void MySetVariable()
		{
			this.URL = "";

			this.oldCount = 0;
			this.newCount = 0;
		}

		private void MyTrayMode(Boolean mode)
		{
			switch (mode)
			{
				case true:
					this.ShowInTaskbar = false;
					this.WindowState = FormWindowState.Minimized;
					this.Visible = false;

					new Thread(() => MyPush("DruidPushApp", "백그라운드에서 실행 중 입니다.")).Start();

					// Timer 활성화
					this.timer.Enabled = true;
					this.timer.Start();
					break;

				case false:
					// Timer 비활성화
					this.timer.Stop();
					this.timer.Enabled = false;

					this.Visible = true;
					this.WindowState = FormWindowState.Normal;
					this.ShowInTaskbar = true;
					
					break;
			}
		}

		/* 알림주기 선택 함수 */
		private void MySelect_Interval()
		{
			if (this.ToolStripMenuItem_Interval_1.CheckState == CheckState.Checked)
			{
				this.ToolStripMenuItem_Interval_3.CheckState = CheckState.Unchecked;
				this.ToolStripMenuItem_Interval_5.CheckState = CheckState.Unchecked;

				this.interval = INTERVAL_1;
			}
			else if (ToolStripMenuItem_Interval_3.CheckState == CheckState.Checked)
			{
				this.ToolStripMenuItem_Interval_1.CheckState = CheckState.Unchecked;
				this.ToolStripMenuItem_Interval_5.CheckState = CheckState.Unchecked;

				this.interval = INTERVAL_3;
			}
			else if (ToolStripMenuItem_Interval_5.CheckState == CheckState.Checked)
			{
				this.ToolStripMenuItem_Interval_1.CheckState = CheckState.Unchecked;
				this.ToolStripMenuItem_Interval_3.CheckState = CheckState.Unchecked;

				this.interval = INTERVAL_5;
			}
		}

		/* 과목 선택 함수 */
		private void MySelect_Subject()
		{
			if (this.radioButton_Advanced.Checked == true)
			{
				this.radioButton_Discrete.Checked = false;
				this.radioButton_Datastructure.Checked = false;
				this.radioButton_Algorithm.Checked = false;

				this.URL = URL_Advanced;
			}
			else if (this.radioButton_Discrete.Checked == true)
			{
				this.radioButton_Advanced.Checked = false;
				this.radioButton_Datastructure.Checked = false;
				this.radioButton_Algorithm.Checked = false;

				this.URL = URL_Discrete;
			}
			else if (this.radioButton_Datastructure.Checked == true)
			{
				this.radioButton_Advanced.Checked = false;
				this.radioButton_Discrete.Checked = false;
				this.radioButton_Algorithm.Checked = false;

				this.URL = URL_Datastructure;
			}
			else if (this.radioButton_Algorithm.Checked == true)
			{
				this.radioButton_Advanced.Checked = false;
				this.radioButton_Discrete.Checked = false;
				this.radioButton_Datastructure.Checked = false;

				this.URL = URL_Algorithm;
			}
		}

		/* 최신 글번호 반환 함수 */
		private int MyGetCount()
		{
			HtmlAgilityPack.HtmlWeb htmlWeb = new HtmlAgilityPack.HtmlWeb();
			HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
			HtmlAgilityPack.HtmlNode htmlNode;

			try
			{
				htmlDocument = htmlWeb.Load(URL);
				htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr//th").First();

				return Convert.ToInt32(htmlNode.InnerHtml);
			}
			catch (Exception e)
			{
				return 0;
			}
		}

		/* HTML 소스 파싱 함수 */
		private void MyParse()
		{
			HtmlAgilityPack.HtmlWeb htmlWeb = new HtmlAgilityPack.HtmlWeb();
			HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
			HtmlAgilityPack.HtmlNode htmlNode;
			HtmlAgilityPack.HtmlNode htmlNode_Number;
			HtmlAgilityPack.HtmlNode htmlNode_Title;
			HtmlAgilityPack.HtmlNode htmlNode_Writer;

			try
			{
				htmlDocument = htmlWeb.Load(URL);
				htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr").First();
				htmlNode_Number = htmlNode.SelectNodes(".//th").First();
				htmlNode_Title = htmlNode.SelectNodes(".//td//a[@class='detail-title']").First();
				htmlNode_Writer = htmlNode.SelectNodes(".//td[@class='text-center detail-username']").First();

				this.newCount = Convert.ToInt32(htmlNode_Number.InnerHtml);

				if (this.newCount > this.oldCount)
				{
					new Thread(() => MyPush(htmlNode_Writer.InnerHtml, htmlNode_Title.InnerHtml)).Start();
					this.oldCount = this.newCount;
				}
			}
			catch (Exception e)
			{
				return;
			}		
		}

		/* 알림 표시 함수 */
		private void MyPush(String username, String title)
		{
			FormBackground formBackground = new FormBackground();

			FormPush formPush = new FormPush(username, title);
			formPush.Owner = formBackground;
			formPush.ShowDialog();
		}
	}
}