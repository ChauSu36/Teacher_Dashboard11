/*
 * UC_TeacherNotifications.cs
 *
 * Layer: Presentation (UserControls/Teacher)
 * Vai trò: Hiển thị danh sách thông báo dành cho Giảng viên.
 *
 * Lưu ý: Toàn bộ UI tĩnh (header, bodyPanel) được khai báo trong
 *         UC_TeacherNotifications.Designer.cs → InitializeComponent().
 *         File này chỉ chứa logic xử lý sự kiện UI.
 */
using System.Windows.Forms;

namespace CourseGuard.Presentation.UserControls.Teacher
{
    public partial class UC_TeacherNotifications : UserControl
    {
        // ── Constructor ──────────────────────────────────────────────────
        public UC_TeacherNotifications()
        {
            InitializeComponent();

            // Canh lại vị trí link "Đánh dấu tất cả đã đọc" khi resize header
            this.pnlHeader.Resize += (s, e) =>
            {
                lnkMarkAllRead.Left = pnlHeader.Width - lnkMarkAllRead.Width - 20;
            };
        }

        // ── Event Handlers ───────────────────────────────────────────────

        private void btnAll_Click(object sender, System.EventArgs e)
        {
            // TODO: Lọc hiển thị tất cả thông báo
        }

        private void btnUnread_Click(object sender, System.EventArgs e)
        {
            // TODO: Lọc hiển thị thông báo chưa đọc
        }

        private void lnkMarkAllRead_Click(object sender, System.EventArgs e)
        {
            // TODO: Đánh dấu tất cả thông báo là đã đọc
        }
    }
}
