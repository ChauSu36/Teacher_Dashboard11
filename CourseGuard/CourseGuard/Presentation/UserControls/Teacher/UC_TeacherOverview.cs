/*
 * UC_TeacherOverview.cs
 *
 * Layer: Presentation (UserControls/Teacher)
 * Vai trò: Hiển thị tổng quan dành cho Giảng viên - thống kê khóa học, học viên và danh sách khóa học đang dạy.
 * Phụ thuộc: DatabaseAction (Infrastructure) để truy vấn trực tiếp dữ liệu.
 *
 * Lưu ý: Toàn bộ UI được khởi tạo trong UC_TeacherOverview.Designer.cs → InitializeComponent().
 *        File này chỉ chứa logic dữ liệu và xử lý sự kiện.
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
        // ── TeacherId được set từ ngoài (TeacherDashboard truyền vào) ──────────
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TeacherId { get; set; } = 0;

        // ── Constructor ──────────────────────────────────────────────────────
        public UC_TeacherOverview()
        {
            InitializeComponent();

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

        // ── Tải dữ liệu thống kê ────────────────────────────────────────────

        /// <summary>
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

                // Cập nhật Labels trên các thẻ (được khai báo trong Designer.cs)
                lblCardCourseValue.Text = totalCourses.ToString();
                lblCardActiveValue.Text = activeCourses.ToString();
                lblCardStudentValue.Text = totalStudents.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Tải danh sách khóa học ──────────────────────────────────────────

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

        // ── Định dạng DataGridView ───────────────────────────────────────────

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
    }
}
