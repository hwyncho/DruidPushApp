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

		private String URL = "";         // 입력한 URL을 저장

		private int oldCount = 0;		// 이전 게시물 갯수 저장
		private int newCount = 0;       // 새 게시물 갯수 저장

		public FormMain()
		{
			InitializeComponent();

			this.MySetVariable();
		}

		private void radioButton_Click(object sender, EventArgs e)
		{
			this.MySelect();
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			timer.Interval = INTERVAL_1;
			this.oldCount = MyGetCount();

			MyTrayMode(true);
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			Close();
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
					ShowInTaskbar = false;
					WindowState = FormWindowState.Minimized;
					Visible = false;

					new Thread(() => MyPush("DruidPushApp", "백그라운드에서 실행 중 입니다.")).Start();

					// Timer 활성화
					timer.Enabled = true;
					timer.Start();
					break;

				case false:
					// Timer 비활성화
					timer.Stop();
					timer.Enabled = false;

					Visible = true;
					WindowState = FormWindowState.Normal;
					ShowInTaskbar = true;
					
					break;
			}
		}

		private int MyGetCount()
		{
			HtmlAgilityPack.HtmlWeb htmlWeb = new HtmlAgilityPack.HtmlWeb();
			HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
			HtmlAgilityPack.HtmlNode htmlNode;

			htmlDocument = htmlWeb.Load(URL);
			htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr//th").First();

			return Convert.ToInt32(htmlNode.InnerHtml);
		}

		private void MySelect()
		{
			if (radioButton_Advanced.Checked == true)
			{
				radioButton_Discrete.Checked = false;
				radioButton_Datastructure.Checked = false;
				radioButton_Algorithm.Checked = false;

				this.URL = URL_Advanced;
			}
			else if (radioButton_Discrete.Checked == true)
			{
				radioButton_Advanced.Checked = false;
				radioButton_Datastructure.Checked = false;
				radioButton_Algorithm.Checked = false;

				this.URL = URL_Discrete;
			}
			else if (radioButton_Datastructure.Checked == true)
			{
				radioButton_Advanced.Checked = false;
				radioButton_Discrete.Checked = false;
				radioButton_Algorithm.Checked = false;

				this.URL = URL_Datastructure;
			}
			else if (radioButton_Algorithm.Checked == true)
			{
				radioButton_Advanced.Checked = false;
				radioButton_Discrete.Checked = false;
				radioButton_Datastructure.Checked = false;

				this.URL = URL_Algorithm;
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

				if (newCount > oldCount)
				{
					new Thread(() => MyPush(htmlNode_Writer.InnerHtml, htmlNode_Title.InnerHtml)).Start();
					oldCount = newCount;
				}
			}
			catch (Exception e)
			{
				throw;
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