using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace DruidPushApp
{
	public partial class FormMain : System.Windows.Forms.Form
	{
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

			Visible = false;
			ShowInTaskbar = false;
			WindowState = FormWindowState.Minimized;

			// 알림 표시
			/*
			notifyIcon.BalloonTipTitle = "DruidPushApp";
			notifyIcon.BalloonTipText = "백그라운드에서 실행 중 입니다.";
			notifyIcon.ShowBalloonTip(1000);
			*/
			new Thread(() => MyPush2("DruidPushApp", "백그라운드에서 실행 중 입니다.")).Start();

			// HTML 소스 파싱 스레드 생성 및 실행
			thread_parse = new Thread(new ThreadStart(MyParse));
			thread_parse.Start();
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			thread_parse.Abort();

			Visible = true;
			ShowInTaskbar = true;
			WindowState = FormWindowState.Normal;
		}

		/* 변수 초기화 함수 */
		private void MySetVariable()
		{
			URL = "";

			oldCount = 0;
			newCount = 0;
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
					//new Thread(() => MyPush(htmlNode_Writer.InnerHtml, htmlNode_Title.InnerHtml)).Start();
					new Thread(() => MyPush2(htmlNode_Writer.InnerHtml, htmlNode_Title.InnerHtml)).Start();
					oldCount = newCount;
				}
			}
		}

		/* 알림 표시 함수 */
		private void MyPush(String username, String title)
		{
			notifyIcon.BalloonTipTitle = "새 질문이 등록되었습니다.";
			notifyIcon.BalloonTipText = "작성자 : " + username + "\n" + "제목 : " + title;
			notifyIcon.ShowBalloonTip(3000);
		}

		private void MyPush2(String username, String title)
		{
			FormPush formPush = new FormPush(username, title);
			formPush.ShowDialog();
		}
	}
}