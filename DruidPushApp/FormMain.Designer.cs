namespace DruidPushApp
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
            this.tableLayoutPanel_View = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Subject = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Subject = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_Advanced = new System.Windows.Forms.RadioButton();
            this.radioButton_Discrete = new System.Windows.Forms.RadioButton();
            this.radioButton_Datastructure = new System.Windows.Forms.RadioButton();
            this.radioButton_Algorithm = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Interval_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.tableLayoutPanel_View.SuspendLayout();
            this.groupBox_Subject.SuspendLayout();
            this.tableLayoutPanel_Subject.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DruidPushApp";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 40);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(138, 36);
            this.ToolStripMenuItem_Exit.Text = "종료";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // tableLayoutPanel_View
            // 
            this.tableLayoutPanel_View.ColumnCount = 1;
            this.tableLayoutPanel_View.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_View.Controls.Add(this.groupBox_Subject, 0, 0);
            this.tableLayoutPanel_View.Controls.Add(this.button_OK, 0, 1);
            this.tableLayoutPanel_View.Controls.Add(this.button_Cancel, 0, 2);
            this.tableLayoutPanel_View.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_View.Location = new System.Drawing.Point(4, 52);
            this.tableLayoutPanel_View.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_View.Name = "tableLayoutPanel_View";
            this.tableLayoutPanel_View.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_View.RowCount = 3;
            this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_View.Size = new System.Drawing.Size(766, 372);
            this.tableLayoutPanel_View.TabIndex = 0;
            // 
            // groupBox_Subject
            // 
            this.groupBox_Subject.Controls.Add(this.tableLayoutPanel_Subject);
            this.groupBox_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Subject.Location = new System.Drawing.Point(8, 8);
            this.groupBox_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Subject.Name = "groupBox_Subject";
            this.groupBox_Subject.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Subject.Size = new System.Drawing.Size(750, 246);
            this.groupBox_Subject.TabIndex = 0;
            this.groupBox_Subject.TabStop = false;
            this.groupBox_Subject.Text = "과목";
            // 
            // tableLayoutPanel_Subject
            // 
            this.tableLayoutPanel_Subject.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Subject.ColumnCount = 2;
            this.tableLayoutPanel_Subject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Subject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Subject.Controls.Add(this.radioButton_Advanced, 0, 0);
            this.tableLayoutPanel_Subject.Controls.Add(this.radioButton_Discrete, 1, 0);
            this.tableLayoutPanel_Subject.Controls.Add(this.radioButton_Datastructure, 0, 1);
            this.tableLayoutPanel_Subject.Controls.Add(this.radioButton_Algorithm, 1, 1);
            this.tableLayoutPanel_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Subject.Location = new System.Drawing.Point(4, 36);
            this.tableLayoutPanel_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_Subject.Name = "tableLayoutPanel_Subject";
            this.tableLayoutPanel_Subject.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_Subject.RowCount = 2;
            this.tableLayoutPanel_Subject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Subject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Subject.Size = new System.Drawing.Size(742, 206);
            this.tableLayoutPanel_Subject.TabIndex = 0;
            // 
            // radioButton_Advanced
            // 
            this.radioButton_Advanced.AutoSize = true;
            this.radioButton_Advanced.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Advanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_Advanced.Location = new System.Drawing.Point(9, 9);
            this.radioButton_Advanced.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Advanced.Name = "radioButton_Advanced";
            this.radioButton_Advanced.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.radioButton_Advanced.Size = new System.Drawing.Size(357, 89);
            this.radioButton_Advanced.TabIndex = 0;
            this.radioButton_Advanced.TabStop = true;
            this.radioButton_Advanced.Text = "고급프로그래밍";
            this.radioButton_Advanced.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Advanced.UseVisualStyleBackColor = true;
            this.radioButton_Advanced.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_Discrete
            // 
            this.radioButton_Discrete.AutoSize = true;
            this.radioButton_Discrete.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Discrete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_Discrete.Location = new System.Drawing.Point(375, 9);
            this.radioButton_Discrete.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Discrete.Name = "radioButton_Discrete";
            this.radioButton_Discrete.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.radioButton_Discrete.Size = new System.Drawing.Size(358, 89);
            this.radioButton_Discrete.TabIndex = 1;
            this.radioButton_Discrete.TabStop = true;
            this.radioButton_Discrete.Text = "이산구조";
            this.radioButton_Discrete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Discrete.UseVisualStyleBackColor = true;
            this.radioButton_Discrete.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_Datastructure
            // 
            this.radioButton_Datastructure.AutoSize = true;
            this.radioButton_Datastructure.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Datastructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_Datastructure.Location = new System.Drawing.Point(9, 107);
            this.radioButton_Datastructure.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Datastructure.Name = "radioButton_Datastructure";
            this.radioButton_Datastructure.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.radioButton_Datastructure.Size = new System.Drawing.Size(357, 90);
            this.radioButton_Datastructure.TabIndex = 2;
            this.radioButton_Datastructure.TabStop = true;
            this.radioButton_Datastructure.Text = "자료구조";
            this.radioButton_Datastructure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Datastructure.UseVisualStyleBackColor = true;
            this.radioButton_Datastructure.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_Algorithm
            // 
            this.radioButton_Algorithm.AutoSize = true;
            this.radioButton_Algorithm.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_Algorithm.Location = new System.Drawing.Point(375, 107);
            this.radioButton_Algorithm.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Algorithm.Name = "radioButton_Algorithm";
            this.radioButton_Algorithm.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.radioButton_Algorithm.Size = new System.Drawing.Size(358, 90);
            this.radioButton_Algorithm.TabIndex = 3;
            this.radioButton_Algorithm.TabStop = true;
            this.radioButton_Algorithm.Text = "알고리즘";
            this.radioButton_Algorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Algorithm.UseVisualStyleBackColor = true;
            this.radioButton_Algorithm.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // button_OK
            // 
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Location = new System.Drawing.Point(8, 262);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(750, 46);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "확인";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Location = new System.Drawing.Point(8, 316);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(750, 48);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "종료";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Setting,
            this.ToolStripMenuItem_Help});
            this.menuStrip.Location = new System.Drawing.Point(4, 4);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(766, 46);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // ToolStripMenuItem_Setting
            // 
            this.ToolStripMenuItem_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Interval,
            this.ToolStripMenuItem_Quit});
            this.ToolStripMenuItem_Setting.Name = "ToolStripMenuItem_Setting";
            this.ToolStripMenuItem_Setting.Size = new System.Drawing.Size(102, 36);
            this.ToolStripMenuItem_Setting.Text = "설정(&S)";
            // 
            // ToolStripMenuItem_Interval
            // 
            this.ToolStripMenuItem_Interval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Interval_1,
            this.ToolStripMenuItem_Interval_3,
            this.ToolStripMenuItem_Interval_5});
            this.ToolStripMenuItem_Interval.Name = "ToolStripMenuItem_Interval";
            this.ToolStripMenuItem_Interval.Size = new System.Drawing.Size(268, 38);
            this.ToolStripMenuItem_Interval.Text = "알림주기(&I)";
            // 
            // ToolStripMenuItem_Interval_1
            // 
            this.ToolStripMenuItem_Interval_1.Checked = true;
            this.ToolStripMenuItem_Interval_1.CheckOnClick = true;
            this.ToolStripMenuItem_Interval_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem_Interval_1.Name = "ToolStripMenuItem_Interval_1";
            this.ToolStripMenuItem_Interval_1.Size = new System.Drawing.Size(268, 38);
            this.ToolStripMenuItem_Interval_1.Text = "1초(&A)";
            this.ToolStripMenuItem_Interval_1.Click += new System.EventHandler(this.ToolStripMenuItem_Interval_1_Click);
            // 
            // ToolStripMenuItem_Interval_3
            // 
            this.ToolStripMenuItem_Interval_3.Name = "ToolStripMenuItem_Interval_3";
            this.ToolStripMenuItem_Interval_3.Size = new System.Drawing.Size(268, 38);
            this.ToolStripMenuItem_Interval_3.Text = "3초(&B)";
            this.ToolStripMenuItem_Interval_3.Click += new System.EventHandler(this.ToolStripMenuItem_Interval_3_Click);
            // 
            // ToolStripMenuItem_Interval_5
            // 
            this.ToolStripMenuItem_Interval_5.CheckOnClick = true;
            this.ToolStripMenuItem_Interval_5.Name = "ToolStripMenuItem_Interval_5";
            this.ToolStripMenuItem_Interval_5.Size = new System.Drawing.Size(268, 38);
            this.ToolStripMenuItem_Interval_5.Text = "5초(&C)";
            this.ToolStripMenuItem_Interval_5.Click += new System.EventHandler(this.ToolStripMenuItem_Interval_5_Click);
            // 
            // ToolStripMenuItem_Quit
            // 
            this.ToolStripMenuItem_Quit.Name = "ToolStripMenuItem_Quit";
            this.ToolStripMenuItem_Quit.Size = new System.Drawing.Size(268, 38);
            this.ToolStripMenuItem_Quit.Text = "종료(&Q)";
            this.ToolStripMenuItem_Quit.Click += new System.EventHandler(this.ToolStripMenuItem_Quit_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Info});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(130, 36);
            this.ToolStripMenuItem_Help.Text = "도움말(&H)";
            // 
            // ToolStripMenuItem_Info
            // 
            this.ToolStripMenuItem_Info.Name = "ToolStripMenuItem_Info";
            this.ToolStripMenuItem_Info.Size = new System.Drawing.Size(294, 38);
            this.ToolStripMenuItem_Info.Text = "프로그램 정보(&P)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(774, 428);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tableLayoutPanel_View);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DruidPushApp";
            this.contextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel_View.ResumeLayout(false);
            this.groupBox_Subject.ResumeLayout(false);
            this.tableLayoutPanel_Subject.ResumeLayout(false);
            this.tableLayoutPanel_Subject.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_View;
		private System.Windows.Forms.GroupBox groupBox_Subject;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Subject;
		private System.Windows.Forms.RadioButton radioButton_Advanced;
		private System.Windows.Forms.RadioButton radioButton_Discrete;
		private System.Windows.Forms.RadioButton radioButton_Datastructure;
		private System.Windows.Forms.RadioButton radioButton_Algorithm;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval_1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval_3;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Interval_5;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Quit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Info;
	}
}

