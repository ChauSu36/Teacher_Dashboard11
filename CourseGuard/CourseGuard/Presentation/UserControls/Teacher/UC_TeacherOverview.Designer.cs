namespace CourseGuard.Presentation.UserControls.Teacher
{
    partial class UC_TeacherOverview
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlDivider = new Panel();
            pnlCards = new Panel();
            tblCards = new TableLayoutPanel();
            pnlCardCourses = new Panel();
            tblCardCourses = new TableLayoutPanel();
            lblCardCoursesIcon = new Label();
            lblCardCourseValue = new Label();
            lblCardCourseLabel = new Label();
            pnlCardCoursesStrip = new Panel();
            pnlCardActive = new Panel();
            tblCardActive = new TableLayoutPanel();
            lblCardActiveIcon = new Label();
            lblCardActiveValue = new Label();
            lblCardActiveLabel = new Label();
            pnlCardActiveStrip = new Panel();
            pnlCardStudents = new Panel();
            tblCardStudents = new TableLayoutPanel();
            lblCardStudentsIcon = new Label();
            lblCardStudentValue = new Label();
            lblCardStudentLabel = new Label();
            pnlCardStudentsStrip = new Panel();
            pnlGridOuter = new Panel();
            pnlGridContainer = new Panel();
            dgvCourses = new DataGridView();
            lblGridTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlCards.SuspendLayout();
            tblCards.SuspendLayout();
            pnlCardCourses.SuspendLayout();
            tblCardCourses.SuspendLayout();
            pnlCardActive.SuspendLayout();
            tblCardActive.SuspendLayout();
            pnlCardStudents.SuspendLayout();
            tblCardStudents.SuspendLayout();
            pnlGridOuter.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlDivider);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(28, 0, 28, 0);
            pnlHeader.Size = new Size(1835, 96);
            pnlHeader.TabIndex = 2;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(30, 56);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(394, 21);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Xem nhanh tình trạng các khóa học và học viên của bạn";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(37, 99, 235);
            lblTitle.Location = new Point(28, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(369, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TỔNG QUAN GIẢNG VIÊN";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(229, 231, 235);
            pnlDivider.Dock = DockStyle.Bottom;
            pnlDivider.Location = new Point(28, 95);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(1779, 1);
            pnlDivider.TabIndex = 2;
            // 
            // pnlCards
            // 
            pnlCards.BackColor = Color.FromArgb(243, 244, 246);
            pnlCards.Controls.Add(tblCards);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 96);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(24, 12, 24, 12);
            pnlCards.Size = new Size(1835, 150);
            pnlCards.TabIndex = 1;
            // 
            // tblCards
            // 
            tblCards.BackColor = Color.Transparent;
            tblCards.ColumnCount = 3;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tblCards.Controls.Add(pnlCardCourses, 0, 0);
            tblCards.Controls.Add(pnlCardActive, 1, 0);
            tblCards.Controls.Add(pnlCardStudents, 2, 0);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(24, 12);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 1;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCards.Size = new Size(1787, 126);
            tblCards.TabIndex = 0;
            // 
            // pnlCardCourses
            // 
            pnlCardCourses.BackColor = Color.White;
            pnlCardCourses.Controls.Add(tblCardCourses);
            pnlCardCourses.Controls.Add(pnlCardCoursesStrip);
            pnlCardCourses.Dock = DockStyle.Fill;
            pnlCardCourses.Location = new Point(0, 0);
            pnlCardCourses.Margin = new Padding(0, 0, 8, 0);
            pnlCardCourses.Name = "pnlCardCourses";
            pnlCardCourses.Size = new Size(587, 126);
            pnlCardCourses.TabIndex = 0;
            // 
            // tblCardCourses
            // 
            tblCardCourses.BackColor = Color.Transparent;
            tblCardCourses.ColumnCount = 2;
            tblCardCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tblCardCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCardCourses.Controls.Add(lblCardCoursesIcon, 0, 0);
            tblCardCourses.Controls.Add(lblCardCourseValue, 1, 0);
            tblCardCourses.Controls.Add(lblCardCourseLabel, 1, 1);
            tblCardCourses.Dock = DockStyle.Fill;
            tblCardCourses.Location = new Point(5, 0);
            tblCardCourses.Name = "tblCardCourses";
            tblCardCourses.Padding = new Padding(10, 0, 10, 0);
            tblCardCourses.RowCount = 2;
            tblCardCourses.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tblCardCourses.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tblCardCourses.Size = new Size(582, 126);
            tblCardCourses.TabIndex = 0;
            // 
            // lblCardCoursesIcon
            // 
            lblCardCoursesIcon.BackColor = Color.FromArgb(219, 234, 254);
            lblCardCoursesIcon.Dock = DockStyle.Fill;
            lblCardCoursesIcon.Font = new Font("Segoe UI Emoji", 22F);
            lblCardCoursesIcon.ForeColor = Color.FromArgb(37, 99, 235);
            lblCardCoursesIcon.Location = new Point(10, 8);
            lblCardCoursesIcon.Margin = new Padding(0, 8, 8, 8);
            lblCardCoursesIcon.Name = "lblCardCoursesIcon";
            tblCardCourses.SetRowSpan(lblCardCoursesIcon, 2);
            lblCardCoursesIcon.Size = new Size(64, 110);
            lblCardCoursesIcon.TabIndex = 0;
            lblCardCoursesIcon.Text = "📚";
            lblCardCoursesIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardCourseValue
            // 
            lblCardCourseValue.Dock = DockStyle.Fill;
            lblCardCourseValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCardCourseValue.ForeColor = Color.FromArgb(37, 99, 235);
            lblCardCourseValue.Location = new Point(82, 6);
            lblCardCourseValue.Margin = new Padding(0, 6, 0, 2);
            lblCardCourseValue.Name = "lblCardCourseValue";
            lblCardCourseValue.Size = new Size(490, 61);
            lblCardCourseValue.TabIndex = 1;
            lblCardCourseValue.Text = "0";
            lblCardCourseValue.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblCardCourseLabel
            // 
            lblCardCourseLabel.Dock = DockStyle.Fill;
            lblCardCourseLabel.Font = new Font("Segoe UI", 9.5F);
            lblCardCourseLabel.ForeColor = Color.FromArgb(107, 114, 128);
            lblCardCourseLabel.Location = new Point(82, 71);
            lblCardCourseLabel.Margin = new Padding(0, 2, 0, 6);
            lblCardCourseLabel.Name = "lblCardCourseLabel";
            lblCardCourseLabel.Size = new Size(490, 49);
            lblCardCourseLabel.TabIndex = 2;
            lblCardCourseLabel.Text = "Tổng Khóa Học";
            // 
            // pnlCardCoursesStrip
            // 
            pnlCardCoursesStrip.BackColor = Color.FromArgb(37, 99, 235);
            pnlCardCoursesStrip.Dock = DockStyle.Left;
            pnlCardCoursesStrip.Location = new Point(0, 0);
            pnlCardCoursesStrip.Name = "pnlCardCoursesStrip";
            pnlCardCoursesStrip.Size = new Size(5, 126);
            pnlCardCoursesStrip.TabIndex = 1;
            // 
            // pnlCardActive
            // 
            pnlCardActive.BackColor = Color.White;
            pnlCardActive.Controls.Add(tblCardActive);
            pnlCardActive.Controls.Add(pnlCardActiveStrip);
            pnlCardActive.Dock = DockStyle.Fill;
            pnlCardActive.Location = new Point(599, 0);
            pnlCardActive.Margin = new Padding(4, 0, 4, 0);
            pnlCardActive.Name = "pnlCardActive";
            pnlCardActive.Size = new Size(587, 126);
            pnlCardActive.TabIndex = 1;
            // 
            // tblCardActive
            // 
            tblCardActive.BackColor = Color.Transparent;
            tblCardActive.ColumnCount = 2;
            tblCardActive.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tblCardActive.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCardActive.Controls.Add(lblCardActiveIcon, 0, 0);
            tblCardActive.Controls.Add(lblCardActiveValue, 1, 0);
            tblCardActive.Controls.Add(lblCardActiveLabel, 1, 1);
            tblCardActive.Dock = DockStyle.Fill;
            tblCardActive.Location = new Point(5, 0);
            tblCardActive.Name = "tblCardActive";
            tblCardActive.Padding = new Padding(10, 0, 10, 0);
            tblCardActive.RowCount = 2;
            tblCardActive.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tblCardActive.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tblCardActive.Size = new Size(582, 126);
            tblCardActive.TabIndex = 0;
            // 
            // lblCardActiveIcon
            // 
            lblCardActiveIcon.BackColor = Color.FromArgb(209, 250, 229);
            lblCardActiveIcon.Dock = DockStyle.Fill;
            lblCardActiveIcon.Font = new Font("Segoe UI Emoji", 22F);
            lblCardActiveIcon.ForeColor = Color.FromArgb(5, 150, 105);
            lblCardActiveIcon.Location = new Point(10, 8);
            lblCardActiveIcon.Margin = new Padding(0, 8, 8, 8);
            lblCardActiveIcon.Name = "lblCardActiveIcon";
            tblCardActive.SetRowSpan(lblCardActiveIcon, 2);
            lblCardActiveIcon.Size = new Size(64, 110);
            lblCardActiveIcon.TabIndex = 0;
            lblCardActiveIcon.Text = "✅";
            lblCardActiveIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardActiveValue
            // 
            lblCardActiveValue.Dock = DockStyle.Fill;
            lblCardActiveValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCardActiveValue.ForeColor = Color.FromArgb(5, 150, 105);
            lblCardActiveValue.Location = new Point(82, 6);
            lblCardActiveValue.Margin = new Padding(0, 6, 0, 2);
            lblCardActiveValue.Name = "lblCardActiveValue";
            lblCardActiveValue.Size = new Size(490, 61);
            lblCardActiveValue.TabIndex = 1;
            lblCardActiveValue.Text = "0";
            lblCardActiveValue.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblCardActiveLabel
            // 
            lblCardActiveLabel.Dock = DockStyle.Fill;
            lblCardActiveLabel.Font = new Font("Segoe UI", 9.5F);
            lblCardActiveLabel.ForeColor = Color.FromArgb(107, 114, 128);
            lblCardActiveLabel.Location = new Point(82, 71);
            lblCardActiveLabel.Margin = new Padding(0, 2, 0, 6);
            lblCardActiveLabel.Name = "lblCardActiveLabel";
            lblCardActiveLabel.Size = new Size(490, 49);
            lblCardActiveLabel.TabIndex = 2;
            lblCardActiveLabel.Text = "Đang Hoạt Động";
            // 
            // pnlCardActiveStrip
            // 
            pnlCardActiveStrip.BackColor = Color.FromArgb(5, 150, 105);
            pnlCardActiveStrip.Dock = DockStyle.Left;
            pnlCardActiveStrip.Location = new Point(0, 0);
            pnlCardActiveStrip.Name = "pnlCardActiveStrip";
            pnlCardActiveStrip.Size = new Size(5, 126);
            pnlCardActiveStrip.TabIndex = 1;
            // 
            // pnlCardStudents
            // 
            pnlCardStudents.BackColor = Color.White;
            pnlCardStudents.Controls.Add(tblCardStudents);
            pnlCardStudents.Controls.Add(pnlCardStudentsStrip);
            pnlCardStudents.Dock = DockStyle.Fill;
            pnlCardStudents.Location = new Point(1198, 0);
            pnlCardStudents.Margin = new Padding(8, 0, 0, 0);
            pnlCardStudents.Name = "pnlCardStudents";
            pnlCardStudents.Size = new Size(589, 126);
            pnlCardStudents.TabIndex = 2;
            // 
            // tblCardStudents
            // 
            tblCardStudents.BackColor = Color.Transparent;
            tblCardStudents.ColumnCount = 2;
            tblCardStudents.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tblCardStudents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCardStudents.Controls.Add(lblCardStudentsIcon, 0, 0);
            tblCardStudents.Controls.Add(lblCardStudentValue, 1, 0);
            tblCardStudents.Controls.Add(lblCardStudentLabel, 1, 1);
            tblCardStudents.Dock = DockStyle.Fill;
            tblCardStudents.Location = new Point(5, 0);
            tblCardStudents.Name = "tblCardStudents";
            tblCardStudents.Padding = new Padding(10, 0, 10, 0);
            tblCardStudents.RowCount = 2;
            tblCardStudents.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tblCardStudents.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tblCardStudents.Size = new Size(584, 126);
            tblCardStudents.TabIndex = 0;
            // 
            // lblCardStudentsIcon
            // 
            lblCardStudentsIcon.BackColor = Color.FromArgb(237, 233, 254);
            lblCardStudentsIcon.Dock = DockStyle.Fill;
            lblCardStudentsIcon.Font = new Font("Segoe UI Emoji", 22F);
            lblCardStudentsIcon.ForeColor = Color.FromArgb(124, 58, 237);
            lblCardStudentsIcon.Location = new Point(10, 8);
            lblCardStudentsIcon.Margin = new Padding(0, 8, 8, 8);
            lblCardStudentsIcon.Name = "lblCardStudentsIcon";
            tblCardStudents.SetRowSpan(lblCardStudentsIcon, 2);
            lblCardStudentsIcon.Size = new Size(64, 110);
            lblCardStudentsIcon.TabIndex = 0;
            lblCardStudentsIcon.Text = "👥";
            lblCardStudentsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardStudentValue
            // 
            lblCardStudentValue.Dock = DockStyle.Fill;
            lblCardStudentValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCardStudentValue.ForeColor = Color.FromArgb(124, 58, 237);
            lblCardStudentValue.Location = new Point(82, 6);
            lblCardStudentValue.Margin = new Padding(0, 6, 0, 2);
            lblCardStudentValue.Name = "lblCardStudentValue";
            lblCardStudentValue.Size = new Size(492, 61);
            lblCardStudentValue.TabIndex = 1;
            lblCardStudentValue.Text = "0";
            lblCardStudentValue.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblCardStudentLabel
            // 
            lblCardStudentLabel.Dock = DockStyle.Fill;
            lblCardStudentLabel.Font = new Font("Segoe UI", 9.5F);
            lblCardStudentLabel.ForeColor = Color.FromArgb(107, 114, 128);
            lblCardStudentLabel.Location = new Point(82, 71);
            lblCardStudentLabel.Margin = new Padding(0, 2, 0, 6);
            lblCardStudentLabel.Name = "lblCardStudentLabel";
            lblCardStudentLabel.Size = new Size(492, 49);
            lblCardStudentLabel.TabIndex = 2;
            lblCardStudentLabel.Text = "Tổng Học Viên";
            // 
            // pnlCardStudentsStrip
            // 
            pnlCardStudentsStrip.BackColor = Color.FromArgb(124, 58, 237);
            pnlCardStudentsStrip.Dock = DockStyle.Left;
            pnlCardStudentsStrip.Location = new Point(0, 0);
            pnlCardStudentsStrip.Name = "pnlCardStudentsStrip";
            pnlCardStudentsStrip.Size = new Size(5, 126);
            pnlCardStudentsStrip.TabIndex = 1;
            // 
            // pnlGridOuter
            // 
            pnlGridOuter.BackColor = Color.FromArgb(243, 244, 246);
            pnlGridOuter.Controls.Add(pnlGridContainer);
            pnlGridOuter.Dock = DockStyle.Fill;
            pnlGridOuter.Location = new Point(0, 246);
            pnlGridOuter.Name = "pnlGridOuter";
            pnlGridOuter.Padding = new Padding(24, 0, 24, 24);
            pnlGridOuter.Size = new Size(1835, 547);
            pnlGridOuter.TabIndex = 0;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvCourses);
            pnlGridContainer.Controls.Add(lblGridTitle);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(24, 0);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(24, 16, 24, 20);
            pnlGridContainer.Size = new Size(1787, 523);
            pnlGridContainer.TabIndex = 0;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.BorderStyle = BorderStyle.None;
            dgvCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCourses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCourses.ColumnHeadersHeight = 29;
            dgvCourses.Cursor = Cursors.Hand;
            dgvCourses.Dock = DockStyle.Fill;
            dgvCourses.GridColor = Color.FromArgb(229, 231, 235);
            dgvCourses.Location = new Point(24, 54);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(1739, 449);
            dgvCourses.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblGridTitle.Location = new Point(24, 16);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Padding = new Padding(0, 4, 0, 0);
            lblGridTitle.Size = new Size(1739, 38);
            lblGridTitle.TabIndex = 1;
            lblGridTitle.Text = "Danh Sách Khóa Học Đang Giảng Dạy";
            // 
            // UC_TeacherOverview
            // 
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(pnlGridOuter);
            Controls.Add(pnlCards);
            Controls.Add(pnlHeader);
            Name = "UC_TeacherOverview";
            Size = new Size(1835, 793);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCards.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            pnlCardCourses.ResumeLayout(false);
            tblCardCourses.ResumeLayout(false);
            pnlCardActive.ResumeLayout(false);
            tblCardActive.ResumeLayout(false);
            pnlCardStudents.ResumeLayout(false);
            tblCardStudents.ResumeLayout(false);
            pnlGridOuter.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ── Header ────────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlDivider;

        // ── Cards container ───────────────────────────────────────────────────
        private System.Windows.Forms.Panel            pnlCards;
        private System.Windows.Forms.TableLayoutPanel tblCards;

        // ── Card 1: Tổng Khóa Học ─────────────────────────────────────────────
        private System.Windows.Forms.Panel            pnlCardCourses;
        private System.Windows.Forms.Panel            pnlCardCoursesStrip;
        private System.Windows.Forms.TableLayoutPanel tblCardCourses;
        private System.Windows.Forms.Label            lblCardCoursesIcon;
        private System.Windows.Forms.Label            lblCardCourseValue;
        private System.Windows.Forms.Label            lblCardCourseLabel;

        // ── Card 2: Đang Hoạt Động ────────────────────────────────────────────
        private System.Windows.Forms.Panel            pnlCardActive;
        private System.Windows.Forms.Panel            pnlCardActiveStrip;
        private System.Windows.Forms.TableLayoutPanel tblCardActive;
        private System.Windows.Forms.Label            lblCardActiveIcon;
        private System.Windows.Forms.Label            lblCardActiveValue;
        private System.Windows.Forms.Label            lblCardActiveLabel;

        // ── Card 3: Tổng Học Viên ─────────────────────────────────────────────
        private System.Windows.Forms.Panel            pnlCardStudents;
        private System.Windows.Forms.Panel            pnlCardStudentsStrip;
        private System.Windows.Forms.TableLayoutPanel tblCardStudents;
        private System.Windows.Forms.Label            lblCardStudentsIcon;
        private System.Windows.Forms.Label            lblCardStudentValue;
        private System.Windows.Forms.Label            lblCardStudentLabel;

        // ── Grid section ──────────────────────────────────────────────────────
        private System.Windows.Forms.Panel         pnlGridOuter;
        private System.Windows.Forms.Panel         pnlGridContainer;
        private System.Windows.Forms.Label         lblGridTitle;
        private System.Windows.Forms.DataGridView  dgvCourses;
    }
}
