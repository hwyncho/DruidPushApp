namespace DruidPushApp
{
	partial class Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.groupBox_URL = new System.Windows.Forms.GroupBox();
			this.radioButton_Advanced = new System.Windows.Forms.RadioButton();
			this.radioButton_Discrete = new System.Windows.Forms.RadioButton();
			this.radioButton_Datastructure = new System.Windows.Forms.RadioButton();
			this.radioButton_Algorithm = new System.Windows.Forms.RadioButton();
			this.contextMenuStrip.SuspendLayout();
			this.groupBox_URL.SuspendLayout();
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
			this.contextMenuStrip.Size = new System.Drawing.Size(164, 42);
			// 
			// ToolStripMenuItem_Exit
			// 
			this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
			this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(163, 38);
			this.ToolStripMenuItem_Exit.Text = "종료";
			this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
			// 
			// button_OK
			// 
			this.button_OK.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button_OK.Location = new System.Drawing.Point(0, 217);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(774, 56);
			this.button_OK.TabIndex = 4;
			this.button_OK.Text = "확인";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button_Cancel.Location = new System.Drawing.Point(0, 273);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(774, 56);
			this.button_Cancel.TabIndex = 5;
			this.button_Cancel.Text = "종료";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// groupBox_URL
			// 
			this.groupBox_URL.Controls.Add(this.radioButton_Algorithm);
			this.groupBox_URL.Controls.Add(this.radioButton_Datastructure);
			this.groupBox_URL.Controls.Add(this.radioButton_Discrete);
			this.groupBox_URL.Controls.Add(this.radioButton_Advanced);
			this.groupBox_URL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_URL.Location = new System.Drawing.Point(0, 0);
			this.groupBox_URL.Name = "groupBox_URL";
			this.groupBox_URL.Padding = new System.Windows.Forms.Padding(12);
			this.groupBox_URL.Size = new System.Drawing.Size(774, 217);
			this.groupBox_URL.TabIndex = 6;
			this.groupBox_URL.TabStop = false;
			this.groupBox_URL.Text = "URL";
			// 
			// radioButton_Advanced
			// 
			this.radioButton_Advanced.AutoSize = true;
			this.radioButton_Advanced.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButton_Advanced.Location = new System.Drawing.Point(12, 44);
			this.radioButton_Advanced.Margin = new System.Windows.Forms.Padding(6);
			this.radioButton_Advanced.Name = "radioButton_Advanced";
			this.radioButton_Advanced.Size = new System.Drawing.Size(750, 36);
			this.radioButton_Advanced.TabIndex = 0;
			this.radioButton_Advanced.TabStop = true;
			this.radioButton_Advanced.Text = "고급프로그래밍";
			this.radioButton_Advanced.UseVisualStyleBackColor = true;
			this.radioButton_Advanced.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButton_Discrete
			// 
			this.radioButton_Discrete.AutoSize = true;
			this.radioButton_Discrete.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButton_Discrete.Location = new System.Drawing.Point(12, 80);
			this.radioButton_Discrete.Margin = new System.Windows.Forms.Padding(6);
			this.radioButton_Discrete.Name = "radioButton_Discrete";
			this.radioButton_Discrete.Size = new System.Drawing.Size(750, 36);
			this.radioButton_Discrete.TabIndex = 1;
			this.radioButton_Discrete.TabStop = true;
			this.radioButton_Discrete.Text = "이산구조";
			this.radioButton_Discrete.UseVisualStyleBackColor = true;
			this.radioButton_Discrete.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButton_Datastructure
			// 
			this.radioButton_Datastructure.AutoSize = true;
			this.radioButton_Datastructure.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButton_Datastructure.Location = new System.Drawing.Point(12, 116);
			this.radioButton_Datastructure.Margin = new System.Windows.Forms.Padding(6);
			this.radioButton_Datastructure.Name = "radioButton_Datastructure";
			this.radioButton_Datastructure.Size = new System.Drawing.Size(750, 36);
			this.radioButton_Datastructure.TabIndex = 2;
			this.radioButton_Datastructure.TabStop = true;
			this.radioButton_Datastructure.Text = "자료구조";
			this.radioButton_Datastructure.UseVisualStyleBackColor = true;
			this.radioButton_Datastructure.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButton_Algorithm
			// 
			this.radioButton_Algorithm.AutoSize = true;
			this.radioButton_Algorithm.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButton_Algorithm.Location = new System.Drawing.Point(12, 152);
			this.radioButton_Algorithm.Margin = new System.Windows.Forms.Padding(6);
			this.radioButton_Algorithm.Name = "radioButton_Algorithm";
			this.radioButton_Algorithm.Size = new System.Drawing.Size(750, 36);
			this.radioButton_Algorithm.TabIndex = 3;
			this.radioButton_Algorithm.TabStop = true;
			this.radioButton_Algorithm.Text = "알고리즘";
			this.radioButton_Algorithm.UseVisualStyleBackColor = true;
			this.radioButton_Algorithm.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(774, 329);
			this.Controls.Add(this.groupBox_URL);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.button_Cancel);
			this.Font = new System.Drawing.Font("맑은 고딕", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DruidPushApp";
			this.contextMenuStrip.ResumeLayout(false);
			this.groupBox_URL.ResumeLayout(false);
			this.groupBox_URL.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.GroupBox groupBox_URL;
		private System.Windows.Forms.RadioButton radioButton_Algorithm;
		private System.Windows.Forms.RadioButton radioButton_Datastructure;
		private System.Windows.Forms.RadioButton radioButton_Discrete;
		private System.Windows.Forms.RadioButton radioButton_Advanced;
	}
}

