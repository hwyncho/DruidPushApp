namespace DruidPushApp
{
	partial class FormPush
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPush));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel_View = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
			this.label_Username = new System.Windows.Forms.Label();
			this.label_Title = new System.Windows.Forms.Label();
			this.tableLayoutPanel_View.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// tableLayoutPanel_View
			// 
			this.tableLayoutPanel_View.ColumnCount = 2;
			this.tableLayoutPanel_View.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel_View.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel_View.Controls.Add(this.pictureBox_Icon, 0, 0);
			this.tableLayoutPanel_View.Controls.Add(this.label_Username, 1, 0);
			this.tableLayoutPanel_View.Controls.Add(this.label_Title, 1, 1);
			this.tableLayoutPanel_View.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_View.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tableLayoutPanel_View.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel_View.Name = "tableLayoutPanel_View";
			this.tableLayoutPanel_View.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel_View.RowCount = 2;
			this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_View.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel_View.Size = new System.Drawing.Size(744, 194);
			this.tableLayoutPanel_View.TabIndex = 0;
			// 
			// pictureBox_Icon
			// 
			this.pictureBox_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon.Image")));
			this.pictureBox_Icon.Location = new System.Drawing.Point(6, 6);
			this.pictureBox_Icon.Name = "pictureBox_Icon";
			this.tableLayoutPanel_View.SetRowSpan(this.pictureBox_Icon, 2);
			this.pictureBox_Icon.Size = new System.Drawing.Size(141, 182);
			this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Icon.TabIndex = 0;
			this.pictureBox_Icon.TabStop = false;
			// 
			// label_Username
			// 
			this.label_Username.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_Username.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Username.Location = new System.Drawing.Point(153, 6);
			this.label_Username.Margin = new System.Windows.Forms.Padding(3);
			this.label_Username.Name = "label_Username";
			this.label_Username.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.label_Username.Size = new System.Drawing.Size(585, 88);
			this.label_Username.TabIndex = 1;
			this.label_Username.Text = "작성자";
			this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_Title
			// 
			this.label_Title.AutoEllipsis = true;
			this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_Title.Location = new System.Drawing.Point(153, 100);
			this.label_Title.Margin = new System.Windows.Forms.Padding(3);
			this.label_Title.Name = "label_Title";
			this.label_Title.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.label_Title.Size = new System.Drawing.Size(585, 88);
			this.label_Title.TabIndex = 2;
			this.label_Title.Text = "제목";
			this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormPush
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(750, 200);
			this.Controls.Add(this.tableLayoutPanel_View);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPush";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "새 글이 등록되었습니다.";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.FormPush_Shown);
			this.Click += new System.EventHandler(this.FormPush_Click);
			this.tableLayoutPanel_View.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_View;
		private System.Windows.Forms.PictureBox pictureBox_Icon;
		private System.Windows.Forms.Label label_Username;
		private System.Windows.Forms.Label label_Title;
	}
}