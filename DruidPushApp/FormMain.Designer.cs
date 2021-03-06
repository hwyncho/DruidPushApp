﻿namespace DruidPushApp
{
	partial class FormMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_Parse = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval_1S = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval_3M = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval_5M = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Subjects = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Subjects = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_Discrete = new System.Windows.Forms.RadioButton();
            this.radioButton_Datastructure1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Datastructure2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Algorithm = new System.Windows.Forms.RadioButton();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.timer_Notify = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.groupBox_Subjects.SuspendLayout();
            this.tableLayoutPanel_Subjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DruidPushApp";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(99, 26);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(98, 22);
            this.ToolStripMenuItem_Exit.Text = "종료";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // timer_Parse
            // 
            this.timer_Parse.Interval = 1000;
            this.timer_Parse.Tick += new System.EventHandler(this.timer_Parse_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Setting,
            this.ToolStripMenuItem_Help});
            this.menuStrip.Location = new System.Drawing.Point(2, 2);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(280, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // ToolStripMenuItem_Setting
            // 
            this.ToolStripMenuItem_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Interval,
            this.ToolStripMenuItem_Quit});
            this.ToolStripMenuItem_Setting.Name = "ToolStripMenuItem_Setting";
            this.ToolStripMenuItem_Setting.Size = new System.Drawing.Size(58, 20);
            this.ToolStripMenuItem_Setting.Text = "설정(&S)";
            // 
            // ToolStripMenuItem_Interval
            // 
            this.ToolStripMenuItem_Interval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Interval_1S,
            this.ToolStripMenuItem_Interval_3M,
            this.ToolStripMenuItem_Interval_5M});
            this.ToolStripMenuItem_Interval.Name = "ToolStripMenuItem_Interval";
            this.ToolStripMenuItem_Interval.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Interval.Text = "알림주기(&I)";
            // 
            // ToolStripMenuItem_Interval_1S
            // 
            this.ToolStripMenuItem_Interval_1S.Checked = true;
            this.ToolStripMenuItem_Interval_1S.CheckOnClick = true;
            this.ToolStripMenuItem_Interval_1S.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem_Interval_1S.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMenuItem_Interval_1S.Name = "ToolStripMenuItem_Interval_1S";
            this.ToolStripMenuItem_Interval_1S.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Interval_1S.Text = "실시간(&A)";
            this.ToolStripMenuItem_Interval_1S.Click += new System.EventHandler(this.ToolStripMenuItem_Interval_1_Click);
            // 
            // ToolStripMenuItem_Interval_3M
            // 
            this.ToolStripMenuItem_Interval_3M.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMenuItem_Interval_3M.Name = "ToolStripMenuItem_Interval_3M";
            this.ToolStripMenuItem_Interval_3M.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Interval_3M.Text = "3분(&B)";
            this.ToolStripMenuItem_Interval_3M.Click += new System.EventHandler(this.ToolStripMenuItem_Interval_3_Click);
            // 
            // ToolStripMenuItem_Interval_5M
            // 
            this.ToolStripMenuItem_Interval_5M.CheckOnClick = true;
            this.ToolStripMenuItem_Interval_5M.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMenuItem_Interval_5M.Name = "ToolStripMenuItem_Interval_5M";
            this.ToolStripMenuItem_Interval_5M.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Interval_5M.Text = "5분(&C)";
            this.ToolStripMenuItem_Interval_5M.Click += new System.EventHandler(this.ToolStripMenuItem_Interval_5_Click);
            // 
            // ToolStripMenuItem_Quit
            // 
            this.ToolStripMenuItem_Quit.Name = "ToolStripMenuItem_Quit";
            this.ToolStripMenuItem_Quit.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Quit.Text = "종료(&Q)";
            this.ToolStripMenuItem_Quit.Click += new System.EventHandler(this.ToolStripMenuItem_Quit_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Info});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(72, 20);
            this.ToolStripMenuItem_Help.Text = "도움말(&H)";
            // 
            // ToolStripMenuItem_Info
            // 
            this.ToolStripMenuItem_Info.Name = "ToolStripMenuItem_Info";
            this.ToolStripMenuItem_Info.Size = new System.Drawing.Size(165, 22);
            this.ToolStripMenuItem_Info.Text = "프로그램 정보(&P)";
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.groupBox_Subjects, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.button_Cancel, 0, 2);
            this.tableLayoutPanel_Main.Controls.Add(this.button_OK, 0, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(2, 26);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(280, 333);
            this.tableLayoutPanel_Main.TabIndex = 1;
            // 
            // groupBox_Subjects
            // 
            this.groupBox_Subjects.Controls.Add(this.tableLayoutPanel_Subjects);
            this.groupBox_Subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Subjects.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Subjects.Name = "groupBox_Subjects";
            this.groupBox_Subjects.Size = new System.Drawing.Size(274, 260);
            this.groupBox_Subjects.TabIndex = 0;
            this.groupBox_Subjects.TabStop = false;
            this.groupBox_Subjects.Text = "과목";
            // 
            // tableLayoutPanel_Subjects
            // 
            this.tableLayoutPanel_Subjects.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Subjects.ColumnCount = 1;
            this.tableLayoutPanel_Subjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Subjects.Controls.Add(this.radioButton_Discrete, 0, 0);
            this.tableLayoutPanel_Subjects.Controls.Add(this.radioButton_Datastructure1, 0, 1);
            this.tableLayoutPanel_Subjects.Controls.Add(this.radioButton_Datastructure2, 0, 2);
            this.tableLayoutPanel_Subjects.Controls.Add(this.radioButton_Algorithm, 0, 3);
            this.tableLayoutPanel_Subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Subjects.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel_Subjects.Name = "tableLayoutPanel_Subjects";
            this.tableLayoutPanel_Subjects.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Subjects.RowCount = 4;
            this.tableLayoutPanel_Subjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Subjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Subjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Subjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Subjects.Size = new System.Drawing.Size(268, 238);
            this.tableLayoutPanel_Subjects.TabIndex = 0;
            // 
            // radioButton_Discrete
            // 
            this.radioButton_Discrete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_Discrete.AutoSize = true;
            this.radioButton_Discrete.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Discrete.Location = new System.Drawing.Point(104, 15);
            this.radioButton_Discrete.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_Discrete.Name = "radioButton_Discrete";
            this.radioButton_Discrete.Size = new System.Drawing.Size(59, 32);
            this.radioButton_Discrete.TabIndex = 0;
            this.radioButton_Discrete.TabStop = true;
            this.radioButton_Discrete.Text = "이산구조";
            this.radioButton_Discrete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Discrete.UseVisualStyleBackColor = true;
            this.radioButton_Discrete.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_Datastructure1
            // 
            this.radioButton_Datastructure1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_Datastructure1.AutoSize = true;
            this.radioButton_Datastructure1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Datastructure1.Location = new System.Drawing.Point(77, 73);
            this.radioButton_Datastructure1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_Datastructure1.Name = "radioButton_Datastructure1";
            this.radioButton_Datastructure1.Size = new System.Drawing.Size(114, 32);
            this.radioButton_Datastructure1.TabIndex = 1;
            this.radioButton_Datastructure1.TabStop = true;
            this.radioButton_Datastructure1.Text = "자료구조 (화5/목6)";
            this.radioButton_Datastructure1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Datastructure1.UseVisualStyleBackColor = true;
            this.radioButton_Datastructure1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_Datastructure2
            // 
            this.radioButton_Datastructure2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_Datastructure2.AutoSize = true;
            this.radioButton_Datastructure2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Datastructure2.Location = new System.Drawing.Point(77, 131);
            this.radioButton_Datastructure2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_Datastructure2.Name = "radioButton_Datastructure2";
            this.radioButton_Datastructure2.Size = new System.Drawing.Size(114, 32);
            this.radioButton_Datastructure2.TabIndex = 2;
            this.radioButton_Datastructure2.TabStop = true;
            this.radioButton_Datastructure2.Text = "자료구조 (화6/목5)";
            this.radioButton_Datastructure2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Datastructure2.UseVisualStyleBackColor = true;
            this.radioButton_Datastructure2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_Algorithm
            // 
            this.radioButton_Algorithm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_Algorithm.AutoSize = true;
            this.radioButton_Algorithm.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Algorithm.Location = new System.Drawing.Point(104, 190);
            this.radioButton_Algorithm.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_Algorithm.Name = "radioButton_Algorithm";
            this.radioButton_Algorithm.Size = new System.Drawing.Size(59, 32);
            this.radioButton_Algorithm.TabIndex = 3;
            this.radioButton_Algorithm.TabStop = true;
            this.radioButton_Algorithm.Text = "알고리즘";
            this.radioButton_Algorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Algorithm.UseVisualStyleBackColor = true;
            this.radioButton_Algorithm.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Location = new System.Drawing.Point(0, 299);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(280, 34);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "종료";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Location = new System.Drawing.Point(0, 266);
            this.button_OK.Margin = new System.Windows.Forms.Padding(0);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(280, 33);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "확인";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // timer_Notify
            // 
            this.timer_Notify.Interval = 1000;
            this.timer_Notify.Tick += new System.EventHandler(this.timer_Notify_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DruidPushApp";
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.groupBox_Subjects.ResumeLayout(false);
            this.tableLayoutPanel_Subjects.ResumeLayout(false);
            this.tableLayoutPanel_Subjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
		private System.Windows.Forms.Timer timer_Parse;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Quit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.GroupBox groupBox_Subjects;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Subjects;
        private System.Windows.Forms.RadioButton radioButton_Discrete;
        private System.Windows.Forms.RadioButton radioButton_Datastructure1;
        private System.Windows.Forms.RadioButton radioButton_Datastructure2;
        private System.Windows.Forms.RadioButton radioButton_Algorithm;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval_1S;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval_3M;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval_5M;
        private System.Windows.Forms.Timer timer_Notify;
    }
}

