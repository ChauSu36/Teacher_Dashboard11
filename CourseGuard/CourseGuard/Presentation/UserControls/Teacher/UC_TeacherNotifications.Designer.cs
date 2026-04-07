namespace CourseGuard.Presentation.UserControls.Teacher
{
    partial class UC_TeacherNotifications
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnAll = new Button();
            btnUnread = new Button();
            lnkMarkAllRead = new LinkLabel();
            bodyPanel = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnAll);
            pnlHeader.Controls.Add(btnUnread);
            pnlHeader.Controls.Add(lnkMarkAllRead);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1835, 67);
            pnlHeader.TabIndex = 2;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(229, 231, 235);
            btnAll.Cursor = Cursors.Hand;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Font = new Font("Segoe UI", 9F);
            btnAll.ForeColor = Color.FromArgb(55, 65, 81);
            btnAll.Location = new Point(23, 13);
            btnAll.Margin = new Padding(3, 4, 3, 4);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(91, 40);
            btnAll.TabIndex = 0;
            btnAll.Text = "Tất cả";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnUnread
            // 
            btnUnread.BackColor = Color.White;
            btnUnread.Cursor = Cursors.Hand;
            btnUnread.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnUnread.FlatStyle = FlatStyle.Flat;
            btnUnread.Font = new Font("Segoe UI", 9F);
            btnUnread.ForeColor = Color.FromArgb(55, 65, 81);
            btnUnread.Location = new Point(126, 13);
            btnUnread.Margin = new Padding(3, 4, 3, 4);
            btnUnread.Name = "btnUnread";
            btnUnread.Size = new Size(114, 40);
            btnUnread.TabIndex = 1;
            btnUnread.Text = "Chưa đọc";
            btnUnread.UseVisualStyleBackColor = false;
            btnUnread.Click += btnUnread_Click;
            // 
            // lnkMarkAllRead
            // 
            lnkMarkAllRead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lnkMarkAllRead.AutoSize = true;
            lnkMarkAllRead.Cursor = Cursors.Hand;
            lnkMarkAllRead.Font = new Font("Segoe UI", 9F);
            lnkMarkAllRead.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkMarkAllRead.LinkColor = Color.FromArgb(59, 130, 246);
            lnkMarkAllRead.Location = new Point(2292, 24);
            lnkMarkAllRead.Name = "lnkMarkAllRead";
            lnkMarkAllRead.Size = new Size(164, 20);
            lnkMarkAllRead.TabIndex = 2;
            lnkMarkAllRead.TabStop = true;
            lnkMarkAllRead.Text = "Đánh dấu tất cả đã đọc";
            lnkMarkAllRead.Click += lnkMarkAllRead_Click;
            // 
            // bodyPanel
            // 
            bodyPanel.AutoScroll = true;
            bodyPanel.BackColor = Color.FromArgb(243, 244, 246);
            bodyPanel.Dock = DockStyle.Fill;
            bodyPanel.FlowDirection = FlowDirection.TopDown;
            bodyPanel.Location = new Point(0, 67);
            bodyPanel.Margin = new Padding(3, 4, 3, 4);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Padding = new Padding(23, 27, 23, 27);
            bodyPanel.Size = new Size(1835, 726);
            bodyPanel.TabIndex = 1;
            bodyPanel.WrapContents = false;
            // 
            // UC_TeacherNotifications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(bodyPanel);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_TeacherNotifications";
            Size = new Size(1835, 793);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ── Fields (Designer-managed) ─────────────────────────────────────
        private System.Windows.Forms.Panel         pnlHeader;
        private System.Windows.Forms.Button        btnAll;
        private System.Windows.Forms.Button        btnUnread;
        private System.Windows.Forms.LinkLabel     lnkMarkAllRead;
        private System.Windows.Forms.FlowLayoutPanel bodyPanel;
    }
}
