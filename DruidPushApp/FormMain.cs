using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DruidPushApp
{
	public partial class FormMain : System.Windows.Forms.Form
	{
		private enum HwndInsertAfter
		{
			HWND_BOTTOM = 1,
			HWND_NOTOPMOST = -2,
			HWND_TOP = 0,
			HWND_TOPMOST = -1
		}

		private Thread thread_parse;
		
		private String URL;         // 입력한 URL을 저장

		private int oldCount;		// 이전 게시물 갯수 저장
		private int newCount;       // 새 게시물 갯수 저장

		public FormMain()
		{
			InitializeComponent();

			MySetVariable();
		}

		private void radioButton_Click(object sender, EventArgs e)
		{
			MySelect();
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			oldCount = MyGetCount();

			MyTrayMode(true);
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			MyTrayMode(false);
		}

		/* 변수 초기화 함수 */
		private void MySetVariable()
		{
			URL = "";

			oldCount = 0;
			newCount = 0;
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

					// HTML 소스 파싱 스레드 생성 및 실행
					thread_parse = new Thread(new ThreadStart(MyParse));
					thread_parse.Start();
					break;

				case false:
					thread_parse.Abort();       // HTML 소스 파싱 스레드 종료

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

				URL = "http://druid.kw.ac.kr/Board/Contents/Advanced";
			}
			else if (radioButton_Discrete.Checked == true)
			{
				radioButton_Advanced.Checked = false;
				radioButton_Datastructure.Checked = false;
				radioButton_Algorithm.Checked = false;

				URL = "http://druid.kw.ac.kr/Board/Contents/Discrete";
			}
			else if (radioButton_Datastructure.Checked == true)
			{
				radioButton_Advanced.Checked = false;
				radioButton_Discrete.Checked = false;
				radioButton_Algorithm.Checked = false;

				URL = "http://druid.kw.ac.kr/Board/Contents/Datastructure";
			}
			else if (radioButton_Algorithm.Checked == true)
			{
				radioButton_Advanced.Checked = false;
				radioButton_Discrete.Checked = false;
				radioButton_Datastructure.Checked = false;

				URL = "http://druid.kw.ac.kr/Board/Contents/Algorithm";
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

			while (true)
			{
				htmlDocument = htmlWeb.Load(URL);
				htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr").First();
				htmlNode_Number = htmlNode.SelectNodes(".//th").First();
				htmlNode_Title = htmlNode.SelectNodes(".//td//a[@class='detail-title']").First();
				htmlNode_Writer = htmlNode.SelectNodes(".//td[@class='text-center detail-username']").First();

				newCount = Convert.ToInt32(htmlNode_Number.InnerHtml);

				if (newCount > oldCount)
				{
					new Thread(() => MyPush(htmlNode_Writer.InnerHtml, htmlNode_Title.InnerHtml)).Start();
					oldCount = newCount;
				}
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