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
using Hado.PL.HadoUIServiceReference;

namespace Hado.PL.Forms.Lesson
{
    public partial class _UpdateLesson : Form
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
        DL.User _user;
        public _UpdateLesson(DL.User user)
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

        private void LblUpdateLesson_MouseDown(object sender, MouseEventArgs e)
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

        private void _UpdateLesson_Load(object sender, EventArgs e)
        {
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            dgvLessons.DataSource = client.LessonList(teacher.TeacherId);
        }

        private void dgvLessons_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvLessons.Rows[e.RowIndex];

            txtBoxId.Text = selectedRow.Cells["LessonId"].Value.ToString();
            txtBoxLessonName.Text = selectedRow.Cells["LessonName"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            client.LessonEdit(new DL.Lesson {LessonId=Convert.ToInt32(txtBoxId.Text), LessonName = txtBoxLessonName.Text, TeacherId = teacher.TeacherId });
            MessageBox.Show("Ders Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvLessons.DataSource = client.LessonList(teacher.TeacherId);

        }
        public string FUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
            {
                if (str.Contains(' '))
                {
                    string[] ad; //ad adında dizi değişken oluşturduk.
                    ad = str.Split(' '); // "# " ile parçalayıp dizi değişkeni kelime kelime atadık.
                    string result = "";

                    for (int i = 0; i < ad.Length; i++)
                    {
                        if (ad[i].Length > 1)
                        {
                            result += char.ToUpper(ad[i][0]) + ad[i].Substring(1) + " ";
                        }

                    }
                    result = result.TrimEnd();
                    return result;
                }
                else
                    return char.ToUpper(str[0]) + str.Substring(1);

            }

            return str.ToUpper();
        }
        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();

            dgvLessons.DataSource = client.LessonList(teacher.TeacherId).Where(x => x.LessonName.StartsWith(txtBoxSearch.Text) || x.LessonName.StartsWith(FUpper(txtBoxSearch.Text))).ToList();
        }
    }
}
