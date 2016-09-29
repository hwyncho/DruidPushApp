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
			this.panel_Image = new System.Windows.Forms.Panel();
			this.pictureBox_Image = new System.Windows.Forms.PictureBox();
			this.panel_Detail = new System.Windows.Forms.Panel();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.label_Username = new System.Windows.Forms.Label();
			this.label_Title = new System.Windows.Forms.Label();
			this.panel_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
			this.panel_Detail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_Image
			// 
			this.panel_Image.Controls.Add(this.pictureBox_Image);
			this.panel_Image.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_Image.Location = new System.Drawing.Point(3, 3);
			this.panel_Image.Name = "panel_Image";
			this.panel_Image.Padding = new System.Windows.Forms.Padding(3);
			this.panel_Image.Size = new System.Drawing.Size(150, 194);
			this.panel_Image.TabIndex = 0;
			// 
			// pictureBox_Image
			// 
			this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Image.Image")));
			this.pictureBox_Image.Location = new System.Drawing.Point(3, 3);
			this.pictureBox_Image.Name = "pictureBox_Image";
			this.pictureBox_Image.Padding = new System.Windows.Forms.Padding(3);
			this.pictureBox_Image.Size = new System.Drawing.Size(144, 188);
			this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Image.TabIndex = 0;
			this.pictureBox_Image.TabStop = false;
			// 
			// panel_Detail
			// 
			this.panel_Detail.Controls.Add(this.splitContainer);
			this.panel_Detail.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_Detail.Location = new System.Drawing.Point(159, 3);
			this.panel_Detail.Name = "panel_Detail";
			this.panel_Detail.Padding = new System.Windows.Forms.Padding(3);
			this.panel_Detail.Size = new System.Drawing.Size(588, 194);
			this.panel_Detail.TabIndex = 1;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.splitContainer.Location = new System.Drawing.Point(3, 3);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.label_Username);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.label_Title);
			this.splitContainer.Size = new System.Drawing.Size(582, 188);
			this.splitContainer.SplitterDistance = 94;
			this.splitContainer.TabIndex = 0;
			// 
			// label_Username
			// 
			this.label_Username.AutoEllipsis = true;
			this.label_Username.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_Username.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Username.Location = new System.Drawing.Point(0, 0);
			this.label_Username.Margin = new System.Windows.Forms.Padding(3);
			this.label_Username.Name = "label_Username";
			this.label_Username.Padding = new System.Windows.Forms.Padding(3);
			this.label_Username.Size = new System.Drawing.Size(582, 94);
			this.label_Username.TabIndex = 0;
			this.label_Username.Text = "작성자";
			this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_Title
			// 
			this.label_Title.AutoEllipsis = true;
			this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_Title.Location = new System.Drawing.Point(0, 0);
			this.label_Title.Name = "label_Title";
			this.label_Title.Size = new System.Drawing.Size(582, 90);
			this.label_Title.TabIndex = 0;
			this.label_Title.Text = "제목";
			this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormPush
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(750, 200);
			this.Controls.Add(this.panel_Detail);
			this.Controls.Add(this.panel_Image);
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
			this.panel_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
			this.panel_Detail.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_Image;
		private System.Windows.Forms.PictureBox pictureBox_Image;
		private System.Windows.Forms.Panel panel_Detail;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label label_Username;
		private System.Windows.Forms.Label label_Title;
	}
}