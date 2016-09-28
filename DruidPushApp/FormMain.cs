using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using HtmlAgilityPack;

namespace DruidPushApp
{
	public partial class Form : System.Windows.Forms.Form
	{
		Thread thread;

		String URL;			// 입력한 URL을 저장

		int oldCount;		// 이전 게시물 갯수 저장
		int newCount;		// 새 게시물 갯수 저장

		public Form()
		{
			InitializeComponent();

			MySetVariable();
		}
		
		private void button_OK_Click(object sender, EventArgs e)
		{
			HtmlAgilityPack.HtmlWeb htmlWeb = new HtmlAgilityPack.HtmlWeb();
			HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
			HtmlAgilityPack.HtmlNode htmlNode;

			URL = this.textBox_URL.Text;

			htmlDocument = htmlWeb.Load(URL);
			htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr//th").First();

			oldCount = Convert.ToInt32(htmlNode.InnerHtml);

			this.Visible = false;
			this.ShowInTaskbar = false;
			this.WindowState = FormWindowState.Minimized;

			// 알림 표시
			notifyIcon.BalloonTipText = "백그라운드에서 실행 중 입니다.";
			notifyIcon.ShowBalloonTip(3000);

			// 스레드 실행
			thread.Start();
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(URL);
		}

		private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			thread.Abort();

			this.Visible = true;
			this.ShowInTaskbar = true;
			this.WindowState = FormWindowState.Normal;
		}

		/* 변수 초기화 함수 */
		public void MySetVariable()
		{
			thread = new Thread(new ThreadStart(MyParser));

			URL = "";
			oldCount = 0;
			newCount = 0;
		}

		/* HTML 소스 파싱 함수 */
		public void MyParser()
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
					MyPushNotify(htmlNode_Writer.InnerHtml, htmlNode_Title.InnerHtml);
					oldCount = newCount;
				}
			}
		}

		/* 알림 표시 함수 */
		public void MyPushNotify(String writer, String title)
		{
			notifyIcon.BalloonTipText = "새 질문이 등록되었습니다.\n" + "작성자 : " + writer + "\n" + "제목 : " + title;
			notifyIcon.ShowBalloonTip(5000);
		}
	}
}
