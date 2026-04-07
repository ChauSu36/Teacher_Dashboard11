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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();

            this.pnlCards = new System.Windows.Forms.Panel();
            this.tblCards = new System.Windows.Forms.TableLayoutPanel();

            this.pnlCardCourses = new System.Windows.Forms.Panel();
            this.pnlCardActive = new System.Windows.Forms.Panel();
            this.pnlCardStudents = new System.Windows.Forms.Panel();

            this.pnlGridOuter = new System.Windows.Forms.Panel();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.tblCards.SuspendLayout();
            this.pnlGridOuter.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            this.SuspendLayout();

            // ── Header ───────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 96;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(28, 0, 28, 0);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlDivider);

            // lblTitle
            this.lblTitle.Text = "TỔNG QUAN GIẢNG VIÊN";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.Accent;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(28, 16);

            // lblSubtitle
            this.lblSubtitle.Text = "Xem nhanh tình trạng các khóa học và học viên của bạn";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.TextSecondary;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(30, 56);

            // pnlDivider
            this.pnlDivider.Height = 1;
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDivider.BackColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.Border;

            // ── Cards ─────────────────────────────────────────
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Height = 150;
            this.pnlCards.BackColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.Base;
            this.pnlCards.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlCards.Controls.Add(this.tblCards);

            // tblCards
            this.tblCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCards.ColumnCount = 3;
            this.tblCards.RowCount = 1;
            this.tblCards.BackColor = System.Drawing.Color.Transparent;
            this.tblCards.Padding = new System.Windows.Forms.Padding(0);
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCards.Controls.Add(this.pnlCardCourses, 0, 0);
            this.tblCards.Controls.Add(this.pnlCardActive, 1, 0);
            this.tblCards.Controls.Add(this.pnlCardStudents, 2, 0);

            // pnlCardCourses
            this.pnlCardCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardCourses.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlCardCourses.BackColor = System.Drawing.Color.White;
            this.pnlCardCourses.Name = "pnlCardCourses";

            // pnlCardActive
            this.pnlCardActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlCardActive.BackColor = System.Drawing.Color.White;
            this.pnlCardActive.Name = "pnlCardActive";

            // pnlCardStudents
            this.pnlCardStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardStudents.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlCardStudents.BackColor = System.Drawing.Color.White;
            this.pnlCardStudents.Name = "pnlCardStudents";

            // ── Grid Section ──────────────────────────────────
            this.pnlGridOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridOuter.Padding = new System.Windows.Forms.Padding(24, 0, 24, 24);
            this.pnlGridOuter.BackColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.Base;
            this.pnlGridOuter.Controls.Add(this.pnlGridContainer);

            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.BackColor = System.Drawing.Color.White;
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
            this.pnlGridContainer.Controls.Add(this.dgvCourses);
            this.pnlGridContainer.Controls.Add(this.lblGridTitle);

            this.lblGridTitle.Text = "Danh Sách Khóa Học Đang Giảng Dạy";
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.TextPrimary;
            this.lblGridTitle.AutoSize = false;
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Height = 38;
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);

            // dgvCourses
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.GridColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.Border;
            this.dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvCourses.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── UC_TeacherOverview ───────────────────────────
            this.BackColor = CourseGuard.Presentation.Theme.ColorPalette.LightMode.Base;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.pnlGridOuter);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlHeader);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.tblCards.ResumeLayout(false);
            this.pnlGridOuter.ResumeLayout(false);
            this.pnlGridContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlDivider;

        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.TableLayoutPanel tblCards;
        private System.Windows.Forms.Panel pnlCardCourses;
        private System.Windows.Forms.Panel pnlCardActive;
        private System.Windows.Forms.Panel pnlCardStudents;

        private System.Windows.Forms.Panel pnlGridOuter;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvCourses;
    }
}
