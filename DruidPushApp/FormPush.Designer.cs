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
            this.tableLayoutPanel_Push = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.label_Writer = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Push.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel_Push
            // 
            this.tableLayoutPanel_Push.ColumnCount = 2;
            this.tableLayoutPanel_Push.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Push.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Push.Controls.Add(this.pictureBox_Icon, 0, 0);
            this.tableLayoutPanel_Push.Controls.Add(this.label_Writer, 1, 0);
            this.tableLayoutPanel_Push.Controls.Add(this.label_Title, 1, 1);
            this.tableLayoutPanel_Push.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Push.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel_Push.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel_Push.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_Push.Name = "tableLayoutPanel_Push";
            this.tableLayoutPanel_Push.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_Push.RowCount = 2;
            this.tableLayoutPanel_Push.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Push.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Push.Size = new System.Drawing.Size(252, 68);
            this.tableLayoutPanel_Push.TabIndex = 0;
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon.Image")));
            this.pictureBox_Icon.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_Icon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.tableLayoutPanel_Push.SetRowSpan(this.pictureBox_Icon, 2);
            this.pictureBox_Icon.Size = new System.Drawing.Size(45, 60);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Icon.TabIndex = 0;
            this.pictureBox_Icon.TabStop = false;
            // 
            // label_Writer
            // 
            this.label_Writer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Writer.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Writer.Location = new System.Drawing.Point(53, 4);
            this.label_Writer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label_Writer.Name = "label_Writer";
            this.label_Writer.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label_Writer.Size = new System.Drawing.Size(195, 28);
            this.label_Writer.TabIndex = 1;
            this.label_Writer.Text = "작성자";
            this.label_Writer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Title
            // 
            this.label_Title.AutoEllipsis = true;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Location = new System.Drawing.Point(53, 36);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label_Title.Name = "label_Title";
            this.label_Title.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label_Title.Size = new System.Drawing.Size(195, 28);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "제목";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(256, 72);
            this.Controls.Add(this.tableLayoutPanel_Push);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPush";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "새 글이 등록되었습니다.";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FormPush_Shown);
            this.Click += new System.EventHandler(this.FormPush_Click);
            this.tableLayoutPanel_Push.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Push;
		private System.Windows.Forms.PictureBox pictureBox_Icon;
		private System.Windows.Forms.Label label_Writer;
		private System.Windows.Forms.Label label_Title;
	}
}