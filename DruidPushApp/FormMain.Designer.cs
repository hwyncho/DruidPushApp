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
			this.tableLayoutPanel_View = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox_Subject = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel_Subject = new System.Windows.Forms.TableLayoutPanel();
			this.radioButton_Advanced = new System.Windows.Forms.RadioButton();
			this.radioButton_Discrete = new System.Windows.Forms.RadioButton();
			this.radioButton_Datastructure = new System.Windows.Forms.RadioButton();
			this.radioButton_Algorithm = new System.Windows.Forms.RadioButton();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.contextMenuStrip.SuspendLayout();
			this.tableLayoutPanel_View.SuspendLayout();
			this.groupBox_Subject.SuspendLayout();
			this.tableLayoutPanel_Subject.SuspendLayout();
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
			this.contextMenuStrip.Size = new System.Drawing.Size(164, 42);
			// 
			// ToolStripMenuItem_Exit
			// 
			this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
			this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(163, 38);
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
			this.tableLayoutPanel_View.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_View.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel_View.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel_View.Name = "tableLayoutPanel_View";
			this.tableLayoutPanel_View.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel_View.RowCount = 3;
			this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel_View.Size = new System.Drawing.Size(768, 423);
			this.tableLayoutPanel_View.TabIndex = 0;
			// 
			// groupBox_Subject
			// 
			this.groupBox_Subject.Controls.Add(this.tableLayoutPanel_Subject);
			this.groupBox_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_Subject.Location = new System.Drawing.Point(6, 6);
			this.groupBox_Subject.Name = "groupBox_Subject";
			this.groupBox_Subject.Size = new System.Drawing.Size(756, 285);
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
			this.tableLayoutPanel_Subject.Location = new System.Drawing.Point(3, 35);
			this.tableLayoutPanel_Subject.Name = "tableLayoutPanel_Subject";
			this.tableLayoutPanel_Subject.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel_Subject.RowCount = 2;
			this.tableLayoutPanel_Subject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_Subject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_Subject.Size = new System.Drawing.Size(750, 247);
			this.tableLayoutPanel_Subject.TabIndex = 0;
			// 
			// radioButton_Advanced
			// 
			this.radioButton_Advanced.AutoSize = true;
			this.radioButton_Advanced.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
			this.radioButton_Advanced.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton_Advanced.Location = new System.Drawing.Point(7, 7);
			this.radioButton_Advanced.Name = "radioButton_Advanced";
			this.radioButton_Advanced.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.radioButton_Advanced.Size = new System.Drawing.Size(364, 113);
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
			this.radioButton_Discrete.Location = new System.Drawing.Point(378, 7);
			this.radioButton_Discrete.Name = "radioButton_Discrete";
			this.radioButton_Discrete.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.radioButton_Discrete.Size = new System.Drawing.Size(365, 113);
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
			this.radioButton_Datastructure.Location = new System.Drawing.Point(7, 127);
			this.radioButton_Datastructure.Name = "radioButton_Datastructure";
			this.radioButton_Datastructure.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.radioButton_Datastructure.Size = new System.Drawing.Size(364, 113);
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
			this.radioButton_Algorithm.Location = new System.Drawing.Point(378, 127);
			this.radioButton_Algorithm.Name = "radioButton_Algorithm";
			this.radioButton_Algorithm.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.radioButton_Algorithm.Size = new System.Drawing.Size(365, 113);
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
			this.button_OK.Location = new System.Drawing.Point(6, 297);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(756, 56);
			this.button_OK.TabIndex = 1;
			this.button_OK.Text = "확인";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_Cancel.Location = new System.Drawing.Point(6, 359);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(756, 58);
			this.button_Cancel.TabIndex = 2;
			this.button_Cancel.Text = "종료";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(774, 429);
			this.Controls.Add(this.tableLayoutPanel_View);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("맑은 고딕", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DruidPushApp";
			this.TopMost = true;
			this.contextMenuStrip.ResumeLayout(false);
			this.tableLayoutPanel_View.ResumeLayout(false);
			this.groupBox_Subject.ResumeLayout(false);
			this.tableLayoutPanel_Subject.ResumeLayout(false);
			this.tableLayoutPanel_Subject.PerformLayout();
			this.ResumeLayout(false);

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
	}
}

