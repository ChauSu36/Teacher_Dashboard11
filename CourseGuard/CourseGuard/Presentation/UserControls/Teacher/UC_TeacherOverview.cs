/*
 * UC_TeacherOverview.cs
 *
 * Layer: Presentation (UserControls/Teacher)
 * Vai trò: Hiển thị tổng quan dành cho Giảng viên - thống kê khóa học, học viên và danh sách khóa học đang dạy.
 * Phụ thuộc: DatabaseAction (Infrastructure) để truy vấn trực tiếp dữ liệu.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CourseGuard.Infrastructure.Data;
using CourseGuard.Presentation.Theme;

namespace CourseGuard.Presentation.UserControls.Teacher
{
    public partial class UC_TeacherOverview : UserControl
    {
        // ── TeacherId được set từ ngoài (TeacherDashboard truyền vào) ──
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TeacherId { get; set; } = 0;

        // ── Card controls (built dynamically in InitializeCards) ──
        private Label lblCardCourseValue;
        private Label lblCardCourseLabel;
        private Label lblCardActiveValue;
        private Label lblCardActiveLabel;
        private Label lblCardStudentValue;
        private Label lblCardStudentLabel;

        // ── Constructor ───────────────────────────────────────────────
        public UC_TeacherOverview()
        {
            InitializeComponent();
            InitializeCards();

            this.Load += (s, e) =>
            {
                LoadStats();
                LoadCourseGrid();
            };
        }

        public UC_TeacherOverview(int teacherId) : this()
        {
            this.TeacherId = teacherId;
        }

        // ── Dữ liệu ──────────────────────────────────────────────────

        /// <summary>
        /// Xây dựng các stat card (thẻ thống kê) theo dynamic layout.
        /// Gọi trong constructor sau InitializeComponent().
        /// </summary>
        private void InitializeCards()
        {
            // ── Card 1: Tổng Khóa Học ───────────────────────
            pnlCardCourses.Controls.Add(
                BuildStatCard("📚", "0", "Tổng Khóa Học",
                    Color.FromArgb(37, 99, 235), Color.FromArgb(219, 234, 254),
                    out lblCardCourseValue, out lblCardCourseLabel));

            // ── Card 2: Đang Hoạt Động ──────────────────────
            pnlCardActive.Controls.Add(
                BuildStatCard("✅", "0", "Đang Hoạt Động",
                    Color.FromArgb(5, 150, 105), Color.FromArgb(209, 250, 229),
                    out lblCardActiveValue, out lblCardActiveLabel));

            // ── Card 3: Tổng Học Viên ───────────────────────
            pnlCardStudents.Controls.Add(
                BuildStatCard("👥", "0", "Tổng Học Viên",
                    Color.FromArgb(124, 58, 237), Color.FromArgb(237, 233, 254),
                    out lblCardStudentValue, out lblCardStudentLabel));
        }
        /// Lấy các con số thống kê từ DB: tổng khóa học, khóa hoạt động, tổng học viên.
        /// Query trực tiếp qua DatabaseAction.ExecuteScalar.
        /// </summary>
        private void LoadStats()
        {
            try
            {
                var p = new Dictionary<string, (SqlDbType, object)>
                {
                    { "@tid", (SqlDbType.Int, TeacherId) }
                };

                // Tổng số khóa học
                int totalCourses = Convert.ToInt32(
                    DatabaseAction.ExecuteScalar("SELECT COUNT(*) FROM COURSES WHERE TEACHER_ID = @tid", p));

                // Số khóa học ACTIVE
                var pActive = new Dictionary<string, (SqlDbType, object)>
                {
                    { "@tid", (SqlDbType.Int, TeacherId) }
                };
                int activeCourses = Convert.ToInt32(
                    DatabaseAction.ExecuteScalar(
                        "SELECT COUNT(*) FROM COURSES WHERE TEACHER_ID = @tid AND STATUS = 'ACTIVE'", pActive));

                // Tổng học viên đã APPROVED trong các khóa của giảng viên
                var pStudents = new Dictionary<string, (SqlDbType, object)>
                {
                    { "@tid", (SqlDbType.Int, TeacherId) }
                };
                int totalStudents = Convert.ToInt32(
                    DatabaseAction.ExecuteScalar(@"
                        SELECT COUNT(DISTINCT e.STUDENT_ID)
                        FROM ENROLLMENTS e
                        INNER JOIN COURSES c ON e.COURSE_ID = c.ID
                        WHERE c.TEACHER_ID = @tid AND e.STATUS = 'APPROVED'", pStudents));

                // Cập nhật thẻ
                lblCardCourseValue.Text = totalCourses.ToString();
                lblCardActiveValue.Text = activeCourses.ToString();
                lblCardStudentValue.Text = totalStudents.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lấy danh sách khóa học của giảng viên kèm số học viên từ DB.
        /// JOIN COURSES với ENROLLMENTS.
        /// </summary>
        private void LoadCourseGrid()
        {
            try
            {
                string query = @"
                    SELECT
                        c.ID                AS [Mã KH],
                        c.NAME              AS [Tên Khóa Học],
                        c.STATUS            AS [Trạng Thái],
                        CONVERT(varchar, c.START_DATE, 103) AS [Ngày Bắt Đầu],
                        CONVERT(varchar, c.END_DATE,   103) AS [Ngày Kết Thúc],
                        (SELECT COUNT(*) 
                         FROM ENROLLMENTS e 
                         WHERE e.COURSE_ID = c.ID AND e.STATUS = 'APPROVED') AS [Học Viên]
                    FROM COURSES c
                    WHERE c.TEACHER_ID = @tid
                    ORDER BY c.CREATED_AT DESC";

                var parameters = new Dictionary<string, (SqlDbType, object)>
                {
                    { "@tid", (SqlDbType.Int, TeacherId) }
                };

                DataTable dt = DatabaseAction.ExecuteQuery(query, parameters);
                dgvCourses.DataSource = dt;

                StyleDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khóa học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleDataGrid()
        {
            dgvCourses.EnableHeadersVisualStyles = false;
            dgvCourses.ColumnHeadersDefaultCellStyle.BackColor = ColorPalette.LightMode.Accent;
            dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvCourses.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvCourses.ColumnHeadersHeight = 38;

            dgvCourses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
            dgvCourses.DefaultCellStyle.BackColor = Color.White;
            dgvCourses.DefaultCellStyle.ForeColor = ColorPalette.LightMode.TextPrimary;
            dgvCourses.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvCourses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvCourses.DefaultCellStyle.SelectionForeColor = ColorPalette.LightMode.TextPrimary;
            dgvCourses.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgvCourses.RowTemplate.Height = 36;
        }

        // ── Xây dựng UI (statcard helper) ──────────────────────────

        /// <summary>
        /// Factory tạo stat card dùng TableLayoutPanel lồng nhau.
        /// Layout: strip (5px) | [icon span 2 rows] | [số lớn row0] / [mô tả row1]
        /// </summary>
        private Panel BuildStatCard(
            string icon, string value, string desc,
            Color accent, Color bgIcon,
            out Label valueLabel, out Label descLabel)
        {
            // ── Vỏ ngoài card ────────────────────────────────
            var card = new Panel { BackColor = Color.White };

            // Viền màu trái (5 px)
            var strip = new Panel
            {
                Dock = DockStyle.Left,
                Width = 5,
                BackColor = accent
            };
            card.Controls.Add(strip);

            // ── TableLayoutPanel bên trong (2 cột × 2 hàng) ──
            // Cột 0: icon (cố định 72px)  |  Cột 1: số + mô tả (fill)
            // Hàng 0: số lớn (55%)        |  Hàng 1: mô tả (45%)
            var tbl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                BackColor = Color.Transparent,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Padding = new Padding(10, 0, 10, 0)
            };
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));  // icon
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));  // text
            tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));          // số
            tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));          // mô tả

            // ── Icon — chiếm toàn bộ 2 hàng ─────────────────
            var iconLbl = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI Emoji", 22F),
                ForeColor = accent,
                BackColor = bgIcon,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 8, 8, 8)
            };
            tbl.Controls.Add(iconLbl, 0, 0);
            tbl.SetRowSpan(iconLbl, 2);

            // ── Số lớn (hàng 0, cột 1) ───────────────────────
            valueLabel = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = accent,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.BottomLeft,
                Margin = new Padding(0, 6, 0, 2)
            };
            tbl.Controls.Add(valueLabel, 1, 0);

            // ── Mô tả (hàng 1, cột 1) ────────────────────────
            descLabel = new Label
            {
                Text = desc,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = ColorPalette.LightMode.TextSecondary,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopLeft,
                Margin = new Padding(0, 2, 0, 6)
            };
            tbl.Controls.Add(descLabel, 1, 1);

            card.Controls.Add(tbl);
            return card;
        }
    }
}
