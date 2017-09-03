using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace DruidPushApp
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private const int INTERVAL_1S = 1100;       // 알림주기 1분
        private const int INTERVAL_3M = 1000 * 180;      // 알림주기 3분
        private const int INTERVAL_5M = 1000 * 300;      // 알림주기 5분

        private const String URL = "http://druid.kw.ac.kr/Board/";      // 게시판 URL
        private const String DISCRETE = "Discrete";                     // 이산구조
        private const String DATASTRUCTURE1 = "Datastructure";          // 자료구조 (화5/목6)
        private const String DATASTRUCTURE2 = "DS";                     // 자료구조 (화6/목5)
        private const String ALGORITHM = "Algorithm";                   // 알고리즘

        private int interval = 1000;       // 선택한 알림 주기를 저장 (초기값 : 1초)

        private String subject = "";        // 선택한 과목을 저장

        private int count = 0;
        private int oldNumber = 0;      // 이전 게시물 번호 저장
        private int newNumber = 0;      // 새 게시물 번호 저장

        public FormMain()
        {
            InitializeComponent();

            this.MySetVariable();
        }

        /* 설정 > 알림주기 > 1분 */
        private void ToolStripMenuItem_Interval_1_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_Interval_1S.CheckState = CheckState.Checked;
            this.ToolStripMenuItem_Interval_3M.CheckState = CheckState.Unchecked;
            this.ToolStripMenuItem_Interval_5M.CheckState = CheckState.Unchecked;

            this.interval = INTERVAL_1S;
        }

        /* 설정 > 알림주기 > 3분 */
        private void ToolStripMenuItem_Interval_3_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_Interval_1S.CheckState = CheckState.Unchecked;
            this.ToolStripMenuItem_Interval_3M.CheckState = CheckState.Checked;
            this.ToolStripMenuItem_Interval_5M.CheckState = CheckState.Unchecked;

            this.interval = INTERVAL_3M;
        }

        /* 설정 > 알림주기 > 5분 */
        private void ToolStripMenuItem_Interval_5_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_Interval_1S.CheckState = CheckState.Unchecked;
            this.ToolStripMenuItem_Interval_3M.CheckState = CheckState.Unchecked;
            this.ToolStripMenuItem_Interval_5M.CheckState = CheckState.Checked;

            this.interval = INTERVAL_5M;
        }

        /* 설정 > 종료 */
        private void ToolStripMenuItem_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* 과목 */
        private void radioButton_Click(object sender, EventArgs e)
        {
            this.MySelect_Subject();
        }

        /* 확인 */
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (this.subject == "")
            {
                MessageBox.Show("과목을 선택하세요!");
            }
            else
            {
                this.timer_Notify.Interval = this.interval;
                this.oldNumber = MyGetCount();

                MyTrayMode(true);
            }
        }

        /* 종료 */
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* notifyIcon > 종료 */
        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.MyTrayMode(false);
        }

        private void timer_Parse_Tick(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(MyParse)).Start();
        }

        private void timer_Notify_Tick(object sender, EventArgs e)
        {
            if (this.count > 0)
            {
                String a = String.Format("{0} 개의 새 질문이 있습니다.", this.count);
                new Thread(() => MyPush("DruidPushApp", a)).Start();
                this.count = 0;
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(URL + subject + "/" + this.newNumber);
        }

        /* 변수 초기화 함수 */
        private void MySetVariable()
        {
            this.interval = 1000;

            this.subject = "";

            this.oldNumber = 0;
            this.newNumber = 0;
        }

        private void MyTrayMode(Boolean mode)
        {
            switch (mode)
            {
                case true:
                    this.ShowInTaskbar = false;
                    this.WindowState = FormWindowState.Minimized;
                    this.Visible = false;
                    
                    this.notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                    this.notifyIcon.BalloonTipTitle = "백그라운드에서 실행 중 입니다.";
                    this.notifyIcon.BalloonTipText = "새 글이 등록되면 알려드립니다.";
                    this.notifyIcon.ShowBalloonTip(3000);

                    // Timer 활성화
                    this.timer_Parse.Enabled = true;
                    this.timer_Parse.Start();

                    this.timer_Notify.Interval = this.interval;
                    this.timer_Notify.Enabled = true;
                    this.timer_Notify.Start();

                    break;

                case false:
                    // Timer 비활성화
                    this.timer_Notify.Stop();
                    this.timer_Notify.Enabled = false;

                    this.timer_Parse.Stop();
                    this.timer_Parse.Enabled = false;

                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                    
                    break;
            }
        }

        /* 과목 선택 함수 */
        private void MySelect_Subject()
        {
            if (this.radioButton_Discrete.Checked == true)
            {
                this.radioButton_Datastructure1.Checked = false;
                this.radioButton_Datastructure2.Checked = false;
                this.radioButton_Algorithm.Checked = false;

                this.subject = DISCRETE;
            }
            else if (this.radioButton_Datastructure1.Checked == true)
            {
                this.radioButton_Discrete.Checked = false;
                this.radioButton_Datastructure2.Checked = false;
                this.radioButton_Algorithm.Checked = false;

                this.subject = DATASTRUCTURE1;
            }
            else if (this.radioButton_Datastructure2.Checked == true)
            {
                this.radioButton_Discrete.Checked = false;
                this.radioButton_Datastructure1.Checked = false;
                this.radioButton_Algorithm.Checked = false;

                this.subject = DATASTRUCTURE2;
            }
            else if (this.radioButton_Algorithm.Checked == true)
            {
                this.radioButton_Discrete.Checked = false;
                this.radioButton_Datastructure1.Checked = false;
                this.radioButton_Datastructure2.Checked = false;

                this.subject = ALGORITHM;
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
                htmlDocument = htmlWeb.Load(URL + "Contents/" + subject);
                htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr[2]//th").First();
                Console.WriteLine(htmlNode.InnerHtml);
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
            //HtmlAgilityPack.HtmlNode htmlNode_Number;
            //HtmlAgilityPack.HtmlNode htmlNode_Title;
            //HtmlAgilityPack.HtmlNode htmlNode_Writer;

            try
            {
                htmlDocument = htmlWeb.Load(URL + "Contents/" + subject);
                /*
                htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr[2]").First();
                htmlNode_Number = htmlNode.SelectSingleNode(".//th");
                htmlNode_Title = htmlNode.SelectSingleNode(".//td//a[@class='detail-title']");
                htmlNode_Writer = htmlNode.SelectSingleNode(".//td[@class='text-center detail-username']");

                this.newNumber = Convert.ToInt32(htmlNode_Number.InnerHtml);
                */

                htmlNode = htmlDocument.DocumentNode.SelectNodes("//tbody//tr[2]//th").First();
                Console.WriteLine(htmlNode.InnerHtml);
                this.newNumber = Convert.ToInt32(htmlNode.InnerHtml);

                if (this.oldNumber < this.newNumber)
                {
                    this.count += 1;
                    this.oldNumber = this.newNumber;
                }
            }
            catch (Exception e)
            {
                return;
            }
        }

        /* 알림 표시 함수 */
        private void MyPush(String writer, String title)
        {
            String url = URL + subject + "/" + this.newNumber;

            FormBackground formBackground = new FormBackground();

            FormPush formPush = new FormPush(writer, title, url);
            formPush.Owner = formBackground;
            formPush.ShowDialog();
        }

        /* 알림 표시 함수 - 시스템 알림 사용 */
        private void MyPush2(String writer, String title)
        {
            this.notifyIcon.BalloonTipIcon = ToolTipIcon.None;
            this.notifyIcon.BalloonTipTitle = "새 질문이 등록되었습니다.";
            this.notifyIcon.BalloonTipText = "작성자 : " + writer + "\n" + "제목 : " + title;
            this.notifyIcon.ShowBalloonTip(3000);
        }
    }
}
