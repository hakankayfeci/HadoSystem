using Hado.DL.ViewModel;
using Hado.PL.HadoUIServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hado.PL.Forms.Question
{
    public partial class _DeleteQuestion : Form
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
        public _DeleteQuestion(DL.User user)
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

        private void LblDeleteQuestion_MouseDown(object sender, MouseEventArgs e)
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

        private void _DeleteQuestion_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {


            List<QuestionViewModel> viewModel = new List<QuestionViewModel>();
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            var lessons = client.LessonList(teacher.TeacherId);
            List<Hado.DL.Question> quest = new List<DL.Question>();

            foreach (var item in lessons)
            {
                var deneme = client.QuestionList();
                var result = client.QuestionList().Where(x => x.LessonId == item.LessonId);
                foreach (var itemx in result)
                {
                    quest.Add(itemx);
                }
            }
            foreach (var item in quest)
            {
                viewModel.Add(new QuestionViewModel
                {
                    Question1 = item.Question1,
                    QuestionAnswers = client.QuestionAnswerListByQuestion(item.QuestionId).QuestionAnswers,
                    LessonId = item.LessonId,
                    QuestionType = item.QuestionType,
                    QuestionId = item.QuestionId,
                    LessonName = client.LessonGet(item.LessonId).LessonName,
                    QuestionTypee = client.QuestionTypeList().Where(x => x.QuestionTypeId == item.QuestionType).FirstOrDefault().Description
                });
            }

            dgvQuestions.DataSource = viewModel;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxId.Text != null && txtBoxContent.Text != null)
            {
                var qremove = client.QuestionRemove(Convert.ToInt32(txtBoxId.Text));
                var aremove = client.QuestionAnswerRemove(Convert.ToInt32(txtBoxId.Text));
                if (qremove && aremove)
                {
                    MessageBox.Show("Soru Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bir Hata Meydana Geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Listele();

                }
            }
        }

        private void dgvQuestions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvQuestions.Rows[e.RowIndex];
            txtBoxId.Text = selectedRow.Cells["QuestionId"].Value.ToString();
            txtBoxContent.Text = selectedRow.Cells["Question1"].Value.ToString();
        }
    }
}
