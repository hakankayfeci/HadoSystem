using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Hado.DL;
using Hado.PL.HadoUIServiceReference;

namespace Hado.PL.Forms.Exam
{
    public partial class _RegisteredExam : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        User _user;
        public _RegisteredExam(User user)
        {
            InitializeComponent();
            _user = user;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LblRegisteredExam_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Pnl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnReduction_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        HadoUIServiceClient client = new HadoUIServiceClient();

        private void _RegisteredExam_Load(object sender, EventArgs e)
        {
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            var lesson = client.LessonList(teacher.UserId);
            foreach (var item in lesson)
            {
                cmbBoxLesson.Items.Add(item.LessonName);
            }

            string seciniz = "Seçiniz...";
            cmbBoxLesson.SelectedItem = seciniz.ToString();
        }
    }
}
