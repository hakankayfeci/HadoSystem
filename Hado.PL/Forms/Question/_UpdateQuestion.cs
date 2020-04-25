using Hado.DL.ViewModel;
using Hado.PL.HadoUIServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hado.PL.Forms.Question
{
    public partial class _UpdateQuestion : Form
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
        public _UpdateQuestion(DL.User user)
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
        private void LblUpdateQuestion_MouseDown(object sender, MouseEventArgs e)
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
        void Listele()
        {
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            var lesson = client.LessonList(teacher.TeacherId);
            cmbBoxQuestionType.DisplayMember = "Value";
            cmbBoxLesson.DisplayMember = "Value";
            foreach (var item in lesson)
            {
                cmbBoxLesson.Items.Add(new KeyValuePair<int, string>(item.LessonId, item.LessonName));
            }
            var type = client.QuestionTypeList();
            foreach (var item in type)
            {
                cmbBoxQuestionType.Items.Add(new KeyValuePair<int, string>(item.QuestionTypeId, item.Description));
            }

            List<QuestionViewModel> viewModel = new List<QuestionViewModel>();
            List<Hado.DL.Question> quest = new List<DL.Question>();

            foreach (var item in lesson)
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
                    QuestionTypee = client.QuestionTypeList().Where(x => x.QuestionTypeId == item.QuestionType).FirstOrDefault().Description,
                    QAId= client.QuestionAnswerListByQuestion(item.QuestionId).QAId
                });
            }
            dgvQuestions.DataSource = viewModel;
        }
        void CoktanSecmeli(int sayi)
        {
            lblId.Visible = true;
            txtBoxId.Visible = true;
            pnlId.Visible = true;
            lblLesson.Visible = true;
            cmbBoxLesson.Visible = true;
            pnlLesson.Visible = true;
            lblQuestionType.Visible = true;
            cmbBoxQuestionType.Visible = true;
            pnlQuestionType.Visible = true;

            lblControl2.Visible = false;
            lbl1.Visible = false;
            txtBox1.Visible = false;
            pnlOne.Visible = false;
            lbl2.Visible = false;
            txtBox2.Visible = false;
            pnlTwo.Visible = false;
            lbl3.Visible = false;
            txtBox3.Visible = false;
            pnlThree.Visible = false;
            lbl4.Visible = false;
            txtBox4.Visible = false;
            pnlFour.Visible = false;
            lbl5.Visible = false;
            txtBox5.Visible = false;
            pnlFive.Visible = false;
            btnAddAnswer.Visible = false;
            btnRemoveAnswer.Visible = false;

            lblControl3.Visible = false;
            checkBoxTrue.Visible = false;
            checkBoxFalse.Visible = false;

            lblControl4.Visible = false;
            lblAnswer.Visible = false;
            txtBoxAnswer.Visible = false;
            pnlAnswer.Visible = false;

            btnUpdate.Visible = true;
            if (sayi == 1)
            {
                lblA.Visible = true;
                txtBoxA.Visible = true;
                pnlA.Visible = true;
                checkA.Visible = true;

                btnRemoveOption.Visible = false;
                btnAddOption.Visible = true;
            }
            else if (sayi == 2)
            {
                lblA.Visible = true;
                txtBoxA.Visible = true;
                pnlA.Visible = true;
                checkA.Visible = true;

                lblB.Visible = true;
                txtBoxB.Visible = true;
                pnlB.Visible = true;
                checkB.Visible = true;

                btnRemoveOption.Visible = true;
                btnAddOption.Visible = true;
            }
            else if (sayi == 3)
            {
                lblA.Visible = true;
                txtBoxA.Visible = true;
                pnlA.Visible = true;
                checkA.Visible = true;

                lblB.Visible = true;
                txtBoxB.Visible = true;
                pnlB.Visible = true;
                checkB.Visible = true;

                lblC.Visible = true;
                txtBoxC.Visible = true;
                pnlC.Visible = true;
                checkC.Visible = true;

                btnRemoveOption.Visible = true;
                btnAddOption.Visible = true;
            }
            else if (sayi == 4)
            {
                lblA.Visible = true;
                txtBoxA.Visible = true;
                pnlA.Visible = true;
                checkA.Visible = true;

                lblB.Visible = true;
                txtBoxB.Visible = true;
                pnlB.Visible = true;
                checkB.Visible = true;

                lblC.Visible = true;
                txtBoxC.Visible = true;
                pnlC.Visible = true;
                checkC.Visible = true;

                lblD.Visible = true;
                txtBoxD.Visible = true;
                pnlD.Visible = true;
                checkD.Visible = true;

                btnRemoveOption.Visible = true;
                btnAddOption.Visible = true;

            }
            else if (sayi == 5)
            {
                lblA.Visible = true;
                txtBoxA.Visible = true;
                pnlA.Visible = true;
                checkA.Visible = true;

                lblB.Visible = true;
                txtBoxB.Visible = true;
                pnlB.Visible = true;
                checkB.Visible = true;

                lblC.Visible = true;
                txtBoxC.Visible = true;
                pnlC.Visible = true;
                checkC.Visible = true;

                lblD.Visible = true;
                txtBoxD.Visible = true;
                pnlD.Visible = true;
                checkD.Visible = true;

                lblE.Visible = true;
                txtBoxE.Visible = true;
                pnlE.Visible = true;
                checkE.Visible = true;

                btnRemoveOption.Visible = true;
                btnAddOption.Visible = false;
            }
            else
            {
                sayi = 5;
            }
        }
        void CoktanSecmeliCorrect(int sayi)
        {
            if (sayi == 0)
            {
                checkA.Checked = true;
            }
            else if (sayi == 1)
            {
                checkB.Checked = true;
            }
            else if (sayi == 2)
            {
                checkC.Checked = true;
            }
            else if (sayi == 3)
            {
                checkD.Checked = true;
            }
            else if (sayi == 4)
            {
                checkE.Checked = true;
            }
        }
        void BoslukDoldurma(int sayi)
        {

            lblContent.Visible = true;
            txtBoxContent.Visible = true;
            pnlContent.Visible = true;
            lblControl.Visible = false;
            lblA.Visible = false;
            txtBoxA.Visible = false;
            pnlA.Visible = false;
            checkA.Visible = false;
            lblB.Visible = false;
            txtBoxB.Visible = false;
            pnlB.Visible = false;
            checkB.Visible = false;
            lblC.Visible = false;
            txtBoxC.Visible = false;
            pnlC.Visible = false;
            checkC.Visible = false;
            lblD.Visible = false;
            txtBoxD.Visible = false;
            pnlD.Visible = false;
            checkD.Visible = false;
            lblE.Visible = false;
            txtBoxE.Visible = false;
            pnlE.Visible = false;
            checkE.Visible = false;
            btnAddOption.Visible = false;
            btnRemoveOption.Visible = false;

            lblControl3.Visible = false;
            checkBoxTrue.Visible = false;
            checkBoxFalse.Visible = false;

            lblControl4.Visible = false;
            lblAnswer.Visible = false;
            txtBoxAnswer.Visible = false;
            pnlAnswer.Visible = false;



            lblId.Visible = true;
            txtBoxId.Visible = true;
            pnlId.Visible = true;
            lblLesson.Visible = true;
            cmbBoxLesson.Visible = true;
            pnlLesson.Visible = true;
            lblQuestionType.Visible = true;
            cmbBoxQuestionType.Visible = true;
            pnlQuestionType.Visible = true;

            lblControl2.Location = new Point(421, 284);
            lbl1.Location = new Point(421, 328);
            txtBox1.Location = new Point(426, 352);
            pnlOne.Location = new Point(426, 380);
            lbl2.Location = new Point(421, 400);
            txtBox2.Location = new Point(426, 424);
            pnlTwo.Location = new Point(426, 452);
            lbl3.Location = new Point(421, 480);
            txtBox3.Location = new Point(426, 504);
            pnlThree.Location = new Point(426, 532);
            lbl4.Location = new Point(421, 556);
            txtBox4.Location = new Point(426, 580);
            pnlFour.Location = new Point(426, 608);
            lbl5.Location = new Point(421, 631);
            txtBox5.Location = new Point(426, 655);
            pnlFive.Location = new Point(426, 683);
            btnAddAnswer.Location = new Point(831, 331);
            btnRemoveAnswer.Location = new Point(831, 405);
            btnUpdate.Location = new Point(832, 491);
            if (sayi == 1)
            {
                lbl1.Visible = true;
                txtBox1.Visible = true;
                pnlOne.Visible = true;

                lbl2.Visible = false;
                txtBox2.Visible = false;
                pnlTwo.Visible = false;

                lbl3.Visible = false;
                txtBox3.Visible = false;
                pnlThree.Visible = false;

                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;

                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;

                btnRemoveAnswer.Visible = true;

            }
            else if (sayi == 2)
            {
                lbl1.Visible = true;
                txtBox1.Visible = true;
                pnlOne.Visible = true;

                lbl2.Visible = true;
                txtBox2.Visible = true;
                pnlTwo.Visible = true;

                lbl3.Visible = false;
                txtBox3.Visible = false;
                pnlThree.Visible = false;

                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;

                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;

                btnRemoveAnswer.Visible = true;

            }
            else if (sayi == 3)
            {
                lbl1.Visible = true;
                txtBox1.Visible = true;
                pnlOne.Visible = true;

                lbl2.Visible = true;
                txtBox2.Visible = true;
                pnlTwo.Visible = true;

                lbl3.Visible = true;
                txtBox3.Visible = true;
                pnlThree.Visible = true;

                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;

                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;

            }
            else if (sayi == 4)
            {
                lbl1.Visible = true;
                txtBox1.Visible = true;
                pnlOne.Visible = true;

                lbl2.Visible = true;
                txtBox2.Visible = true;
                pnlTwo.Visible = true;

                lbl3.Visible = true;
                txtBox3.Visible = true;
                pnlThree.Visible = true;

                lbl4.Visible = true;
                txtBox4.Visible = true;
                pnlFour.Visible = true;

                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;
            }
            else if (sayi == 5)
            {
                lbl1.Visible = true;
                txtBox1.Visible = true;
                pnlOne.Visible = true;

                lbl2.Visible = true;
                txtBox2.Visible = true;
                pnlTwo.Visible = true;

                lbl3.Visible = true;
                txtBox3.Visible = true;
                pnlThree.Visible = true;

                lbl4.Visible = true;
                txtBox4.Visible = true;
                pnlFour.Visible = true;

                lbl5.Visible = true;
                txtBox5.Visible = true;
                pnlFive.Visible = true;

                btnAddAnswer.Visible = false;

            }
            else
            {
                sayi = 5;
            }
        }
        int sayacx = 0;
        int sayacy = 0;
        string OldTextContent = "";

        private void _UpdateQuestion_Load(object sender, EventArgs e)
        {
            Listele();
            string seciniz = "Seçiniz...";
            cmbBoxQuestionType.SelectedItem = seciniz.ToString();
            cmbBoxLesson.SelectedItem = seciniz.ToString();
        }
        private void dgvQuestions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvQuestions.Rows[e.RowIndex];
            txtBoxId.Text = selectedRow.Cells["QuestionId"].Value.ToString();
            textBoxQAId.Text = selectedRow.Cells["QAId"].Value.ToString();
            txtBoxContent.Text = selectedRow.Cells["Question1"].Value.ToString();
            cmbBoxLesson.SelectedItem = new KeyValuePair<int, string>(Convert.ToInt32(selectedRow.Cells["LessonId"].Value), selectedRow.Cells["LessonName"].Value.ToString());
            cmbBoxQuestionType.SelectedItem = new KeyValuePair<int, string>(Convert.ToInt32(selectedRow.Cells["QuestionType"].Value), selectedRow.Cells["QuestionTypee"].Value.ToString());
            string Sorucevabi = selectedRow.Cells["QuestionAnswers"].Value.ToString();


            //Çoktan Seçmeli veya Boşluk doldurmaysa Dizi de tutuyoruz
            if (Sorucevabi.Contains(",") && cmbBoxQuestionType.Text == "Çoktan Seçmeli" || cmbBoxQuestionType.Text == "Boşluk Doldurma")
            {
                string[] dizi;
                dizi = Sorucevabi.Split(',');
                sayacx = dizi.Count();
                sayacy = dizi.Count();
                int deger = 0;
                for (int i = 0; i < dizi.Count(); i++)
                {
                    if (dizi[i].Contains("+"))
                    {
                        deger = i;
                        dizi[i] = dizi[i].ToString().TrimEnd('+');
                    }
                }
                if (cmbBoxQuestionType.Text == "Çoktan Seçmeli" && dizi.Count() > 0 && dizi.Count() < 6)
                {
                    CoktanSecmeli(dizi.Count());
                    CoktanSecmeliCorrect(deger);
                    if (dizi.Count() == 1)
                    {
                        txtBoxA.Text = dizi[0].ToString();
                    }
                    else if (dizi.Count() == 2)
                    {
                        txtBoxA.Text = dizi[0].ToString();
                        txtBoxB.Text = dizi[1].ToString();

                    }
                    else if (dizi.Count() == 3)
                    {
                        txtBoxA.Text = dizi[0].ToString();
                        txtBoxB.Text = dizi[1].ToString();
                        txtBoxC.Text = dizi[2].ToString();
                    }
                    else if (dizi.Count() == 4)
                    {
                        txtBoxA.Text = dizi[0].ToString();
                        txtBoxB.Text = dizi[1].ToString();
                        txtBoxC.Text = dizi[2].ToString();
                        txtBoxD.Text = dizi[3].ToString();
                    }
                    else if (dizi.Count() == 5)
                    {
                        txtBoxA.Text = dizi[0].ToString();
                        txtBoxB.Text = dizi[1].ToString();
                        txtBoxC.Text = dizi[2].ToString();
                        txtBoxD.Text = dizi[3].ToString();
                        txtBoxE.Text = dizi[4].ToString();
                    }
                }
                else
                {
                    BoslukDoldurma(dizi.Count());
                    if (dizi.Count() == 1)
                    {
                        txtBox1.Text = dizi[0].ToString();
                    }
                    else if (dizi.Count() == 2)
                    {
                        txtBox1.Text = dizi[0].ToString();
                        txtBox2.Text = dizi[1].ToString();

                    }
                    else if (dizi.Count() == 3)
                    {
                        txtBox1.Text = dizi[0].ToString();
                        txtBox2.Text = dizi[1].ToString();
                        txtBox3.Text = dizi[2].ToString();
                    }
                    else if (dizi.Count() == 4)
                    {
                        txtBox1.Text = dizi[0].ToString();
                        txtBox2.Text = dizi[1].ToString();
                        txtBox3.Text = dizi[2].ToString();
                        txtBox4.Text = dizi[3].ToString();
                    }
                    else if (dizi.Count() == 5)
                    {
                        txtBox1.Text = dizi[0].ToString();
                        txtBox2.Text = dizi[1].ToString();
                        txtBox3.Text = dizi[2].ToString();
                        txtBox4.Text = dizi[3].ToString();
                        txtBox5.Text = dizi[4].ToString();
                    }
                }
            }
            if (cmbBoxQuestionType.Text == "Doğru-Yanlış")
            {
                if (Sorucevabi== "Doğru")
                {
                    checkBoxTrue.Checked = true;
                    checkBoxFalse.Checked = false;

                }
                else
                {
                    checkBoxTrue.Checked = false;
                    checkBoxFalse.Checked = true;
                }
            }
            else if (cmbBoxQuestionType.Text == "Klasik")
            {
                txtBoxAnswer.Text = Sorucevabi;
            }
        }
        private void cmbBoxQuestionType_TextChanged(object sender, EventArgs e)
        {
            if (cmbBoxQuestionType.Text == "Çoktan Seçmeli")
            {
                sayacx = 2;

                lblA.Visible = true;
                txtBoxA.Visible = true;
                pnlA.Visible = true;
                checkA.Visible = true;

                lblB.Visible = true;
                txtBoxB.Visible = true;
                pnlB.Visible = true;
                checkB.Visible = true;

                btnRemoveOption.Visible = false;
                btnAddOption.Visible = true;

                lblControl2.Visible = false;
                lbl1.Visible = false;
                txtBox1.Visible = false;
                pnlOne.Visible = false;
                lbl2.Visible = false;
                txtBox2.Visible = false;
                pnlTwo.Visible = false;
                lbl3.Visible = false;
                txtBox3.Visible = false;
                pnlThree.Visible = false;
                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;
                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;
                btnAddAnswer.Visible = false;
                btnRemoveAnswer.Visible = false;

                lblControl3.Visible = false;
                checkBoxTrue.Visible = false;
                checkBoxFalse.Visible = false;

                lblControl4.Visible = false;
                lblAnswer.Visible = false;
                txtBoxAnswer.Visible = false;
                pnlAnswer.Visible = false;

                btnUpdate.Location = new Point(832, 491);
            }
            else if (cmbBoxQuestionType.Text == "Boşluk Doldurma")
            {
                sayacy = 2;
                BoslukTemizleme();
                lblContent.Visible = true;
                txtBoxContent.Visible = true;
                pnlContent.Visible = true;
                lblControl.Visible = false;
                lblA.Visible = false;
                txtBoxA.Visible = false;
                pnlA.Visible = false;
                checkA.Visible = false;
                lblB.Visible = false;
                txtBoxB.Visible = false;
                pnlB.Visible = false;
                checkB.Visible = false;
                lblC.Visible = false;
                txtBoxC.Visible = false;
                pnlC.Visible = false;
                checkC.Visible = false;
                lblD.Visible = false;
                txtBoxD.Visible = false;
                pnlD.Visible = false;
                checkD.Visible = false;
                lblE.Visible = false;
                txtBoxE.Visible = false;
                pnlE.Visible = false;
                checkE.Visible = false;
                btnAddOption.Visible = false;
                btnRemoveOption.Visible = false;

                lblControl3.Visible = false;
                checkBoxTrue.Visible = false;
                checkBoxFalse.Visible = false;

                lblControl4.Visible = false;
                lblAnswer.Visible = false;
                txtBoxAnswer.Visible = false;
                pnlAnswer.Visible = false;



                lblId.Visible = true;
                txtBoxId.Visible = true;
                pnlId.Visible = true;
                lblLesson.Visible = true;
                cmbBoxLesson.Visible = true;
                pnlLesson.Visible = true;
                lblQuestionType.Visible = true;
                cmbBoxQuestionType.Visible = true;
                pnlQuestionType.Visible = true;



                lblControl2.Visible = true;
                lbl1.Visible = true;
                txtBox1.Visible = true;
                pnlOne.Visible = true;

                btnAddAnswer.Visible = true;
                btnRemoveAnswer.Visible = true;
                btnUpdate.Visible = true;

                lblControl2.Location = new Point(421, 284);
                lbl1.Location = new Point(421, 328);
                txtBox1.Location = new Point(426, 352);
                pnlOne.Location = new Point(426, 380);
                lbl2.Location = new Point(421, 400);
                txtBox2.Location = new Point(426, 424);
                pnlTwo.Location = new Point(426, 452);
                lbl3.Location = new Point(421, 480);
                txtBox3.Location = new Point(426, 504);
                pnlThree.Location = new Point(426, 532);
                lbl4.Location = new Point(421, 556);
                txtBox4.Location = new Point(426, 580);
                pnlFour.Location = new Point(426, 608);
                lbl5.Location = new Point(421, 631);
                txtBox5.Location = new Point(426, 655);
                pnlFive.Location = new Point(426, 683);
                btnAddAnswer.Location = new Point(831, 331);
                btnRemoveAnswer.Location = new Point(831, 405);
                btnUpdate.Location = new Point(832, 491);
            }
            else if (cmbBoxQuestionType.Text == "Doğru-Yanlış")
            {
                lblControl2.Visible = false;
                lbl1.Visible = false;
                txtBox1.Visible = false;
                pnlOne.Visible = false;
                lbl2.Visible = false;
                txtBox2.Visible = false;
                pnlTwo.Visible = false;
                lbl3.Visible = false;
                txtBox3.Visible = false;
                pnlThree.Visible = false;
                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;
                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;
                btnAddAnswer.Visible = false;
                btnRemoveAnswer.Visible = false;

                lblContent.Visible = true;
                txtBoxContent.Visible = true;
                pnlContent.Visible = true;
                lblControl.Visible = false;
                lblA.Visible = false;
                txtBoxA.Visible = false;
                pnlA.Visible = false;
                checkA.Visible = false;
                lblB.Visible = false;
                txtBoxB.Visible = false;
                pnlB.Visible = false;
                checkB.Visible = false;
                lblC.Visible = false;
                txtBoxC.Visible = false;
                pnlC.Visible = false;
                checkC.Visible = false;
                lblD.Visible = false;
                txtBoxD.Visible = false;
                pnlD.Visible = false;
                checkD.Visible = false;
                lblE.Visible = false;
                txtBoxE.Visible = false;
                pnlE.Visible = false;
                checkE.Visible = false;
                btnAddOption.Visible = false;
                btnRemoveOption.Visible = false;

                lblControl4.Visible = false;
                lblAnswer.Visible = false;
                txtBoxAnswer.Visible = false;
                pnlAnswer.Visible = false;

                lblId.Visible = true;
                txtBoxId.Visible = true;
                pnlId.Visible = true;
                lblLesson.Visible = true;
                cmbBoxLesson.Visible = true;
                pnlLesson.Visible = true;
                lblQuestionType.Visible = true;
                cmbBoxQuestionType.Visible = true;
                pnlQuestionType.Visible = true;

                lblControl3.Visible = true;
                checkBoxTrue.Visible = true;
                checkBoxFalse.Visible = true;

                lblControl3.Location = new Point(421, 284);
                checkBoxTrue.Location = new Point(425, 318);
                checkBoxFalse.Location = new Point(519, 318);
                btnUpdate.Location = new Point(422, 358);


            }
            else if (cmbBoxQuestionType.Text == "Klasik")
            {
                lblControl2.Visible = false;
                lbl1.Visible = false;
                txtBox1.Visible = false;
                pnlOne.Visible = false;
                lbl2.Visible = false;
                txtBox2.Visible = false;
                pnlTwo.Visible = false;
                lbl3.Visible = false;
                txtBox3.Visible = false;
                pnlThree.Visible = false;
                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;
                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;
                btnAddAnswer.Visible = false;
                btnRemoveAnswer.Visible = false;

                lblContent.Visible = true;
                txtBoxContent.Visible = true;
                pnlContent.Visible = true;
                lblControl.Visible = false;
                lblA.Visible = false;
                txtBoxA.Visible = false;
                pnlA.Visible = false;
                checkA.Visible = false;
                lblB.Visible = false;
                txtBoxB.Visible = false;
                pnlB.Visible = false;
                checkB.Visible = false;
                lblC.Visible = false;
                txtBoxC.Visible = false;
                pnlC.Visible = false;
                checkC.Visible = false;
                lblD.Visible = false;
                txtBoxD.Visible = false;
                pnlD.Visible = false;
                checkD.Visible = false;
                lblE.Visible = false;
                txtBoxE.Visible = false;
                pnlE.Visible = false;
                checkE.Visible = false;
                btnAddOption.Visible = false;
                btnRemoveOption.Visible = false;

                lblId.Visible = true;
                txtBoxId.Visible = true;
                pnlId.Visible = true;
                lblLesson.Visible = true;
                cmbBoxLesson.Visible = true;
                pnlLesson.Visible = true;
                lblQuestionType.Visible = true;
                cmbBoxQuestionType.Visible = true;
                pnlQuestionType.Visible = true;

                lblControl3.Visible = false;
                checkBoxTrue.Visible = false;
                checkBoxFalse.Visible = false;

                lblControl4.Visible = true;
                lblAnswer.Visible = true;
                txtBoxAnswer.Visible = true;
                pnlAnswer.Visible = true;
                btnUpdate.Visible = true;

                lblControl4.Location = new Point(423, 284);
                lblAnswer.Location = new Point(423, 318);
                txtBoxAnswer.Location = new Point(428, 342);
                pnlAnswer.Location = new Point(427, 429);

                btnUpdate.Location = new Point(769, 455);

            }
        }


        void BoslukTemizleme()
        {
            txtBox1.Text = null;
            txtBox2.Text = null;
            txtBox3.Text = null;
            txtBox4.Text = null;
            txtBox5.Text = null;

        }
        int sayac = 0;
        private void BtnAddOption_Click(object sender, EventArgs e)
        {
            sayac = sayacx + 1;
            sayacx += 1;

            if (sayac == 3)
            {
                lblC.Visible = true;
                txtBoxC.Visible = true;
                pnlC.Visible = true;
                checkC.Visible = true;

                btnRemoveOption.Visible = true;
            }
            else if (sayac == 4)
            {
                lblD.Visible = true;
                txtBoxD.Visible = true;
                pnlD.Visible = true;
                checkD.Visible = true;
            }
            else if (sayac == 5)
            {
                lblE.Visible = true;
                txtBoxE.Visible = true;
                pnlE.Visible = true;
                checkE.Visible = true;
                btnAddOption.Visible = false;
            }
            else
            {
                sayac = 5;
            }
        }
        private void BtnRemoveOption_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                sayac = sayacx;
            }
            if (sayac == 3)
            {
                lblC.Visible = false;
                txtBoxC.Visible = false;
                pnlC.Visible = false;
                checkC.Visible = false;

                sayac = sayac - 1;
                sayacx -= 1;

            }
            else if (sayac == 4)
            {
                lblD.Visible = false;
                txtBoxD.Visible = false;
                pnlD.Visible = false;
                checkD.Visible = false;
                sayac = sayac - 1;
                sayacx -= 1;

            }
            else if (sayac == 5)
            {
                lblE.Visible = false;
                txtBoxE.Visible = false;
                pnlE.Visible = false;
                checkE.Visible = false;
                btnAddOption.Visible = true;
                sayac = sayac - 1;
                sayacx -= 1;

            }
            else
            {
                sayac = 2;
                btnRemoveOption.Visible = false;
            }
        }

        int sayac2 = 0;
        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            sayac2 = sayacy + 1;
            sayacy += 1;
            if (sayac2 == 2)
            {
                lbl2.Visible = true;
                txtBox2.Visible = true;
                pnlTwo.Visible = true;
                btnRemoveAnswer.Visible = true;

            }
            else if (sayac2 == 3)
            {
                lbl3.Visible = true;
                txtBox3.Visible = true;
                pnlThree.Visible = true;

            }
            else if (sayac2 == 4)
            {
                lbl4.Visible = true;
                txtBox4.Visible = true;
                pnlFour.Visible = true;


            }
            else if (sayac2 == 5)
            {
                lbl5.Visible = true;
                txtBox5.Visible = true;
                pnlFive.Visible = true;

                btnAddAnswer.Visible = false;

            }
            else
            {
                sayac2 = 5;
            }
        }
        private void BtnRemoveAnswer_Click(object sender, EventArgs e)
        {
            if (sayac2 == 0)
            {
                sayac2 = sayacy;
            }
            if (sayac2 == 2)
            {
                lbl2.Visible = false;
                txtBox2.Visible = false;
                pnlTwo.Visible = false;

                btnRemoveAnswer.Visible = false;
                sayac2 = sayac2 - 1;
                sayacy -= 1;
            }
            else if (sayac2 == 3)
            {
                lbl3.Visible = false;
                txtBox3.Visible = false;
                pnlThree.Visible = false;
                sayac2 = sayac2 - 1;
                sayacy -= 1;


            }
            else if (sayac2 == 4)
            {
                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;
                sayac2 = sayac2 - 1;
                sayacy -= 1;

            }
            else if (sayac2 == 5)
            {
                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;
                sayac2 = sayac2 - 1;
                sayacy -= 1;
                btnAddAnswer.Visible = true;
            }
            else
            {
                sayac2 = 1;
                btnRemoveAnswer.Visible = false;

            }
        }



        private void CheckA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkA.Checked == true)
            {
                checkB.Checked = false;
                checkC.Checked = false;
                checkD.Checked = false;
                checkE.Checked = false;

            }
        }

        private void CheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB.Checked == true)
            {
                checkA.Checked = false;
                checkC.Checked = false;
                checkD.Checked = false;
                checkE.Checked = false;
            }
        }

        private void CheckC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkC.Checked == true)
            {
                checkA.Checked = false;
                checkB.Checked = false;
                checkD.Checked = false;
                checkE.Checked = false;
            }
        }

        private void CheckD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkD.Checked == true)
            {
                checkA.Checked = false;
                checkB.Checked = false;
                checkC.Checked = false;
                checkE.Checked = false;
            }
        }

        private void CheckE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkE.Checked == true)
            {
                checkA.Checked = false;
                checkB.Checked = false;
                checkC.Checked = false;
                checkD.Checked = false;
            }
        }

        private void CheckBoxTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrue.Checked == true)
            {
                checkBoxFalse.Checked = false;
            }
        }

        private void CheckBoxFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFalse.Checked == true)
            {
                checkBoxTrue.Checked = false;
            }
        }

        bool Denetleme(int sayacc)
        {
            if (sayac == 1 && txtBoxA.Text != null)
                return true;
            else if (sayac == 2 && txtBoxA.Text != null && txtBoxB.Text != null)
                return true;
            else if (sayac == 3 && txtBoxA.Text != null && txtBoxB.Text != null && txtBoxC.Text != null)
                return true;
            else if (sayac == 4 && txtBoxA.Text != null && txtBoxB.Text != null && txtBoxC.Text != null && txtBoxD.Text != null)
                return true;
            else if (sayac == 5 && txtBoxA.Text != null && txtBoxB.Text != null && txtBoxC.Text != null && txtBoxD.Text != null && txtBoxE.Text != null)
                return true;
            else
                return false;
        }
        bool Denetleme2(int sayacc)
        {
            if (sayacc == 1 && txtBoxA.Text != null)
                return true;
            else if (sayacc == 2 && txtBox1.Text != null && txtBox2.Text != null)
                return true;
            else if (sayacc == 3 && txtBox1.Text != null && txtBox2.Text != null && txtBox3.Text != null)
                return true;
            else if (sayacc == 4 && txtBox1.Text != null && txtBox2.Text != null && txtBox3.Text != null && txtBox4.Text != null)
                return true;
            else if (sayacc == 5 && txtBox1.Text != null && txtBox2.Text != null && txtBox3.Text != null && txtBox4.Text != null && txtBox5.Text != null)
                return true;
            else
                return false;
        }
        void Success(bool deger)
        {
            if (deger)
            {
                MessageBox.Show("Başarıyla Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir Hata Meydana Geldi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBoxQuestionType.Text == "Çoktan Seçmeli")
            {
                if (sayac == 0)
                {
                    sayac = sayacx;
                }
                if (string.IsNullOrEmpty(txtBoxContent.Text) != true && Denetleme(sayac))
                {
                    if (checkA.Checked)
                    {
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionEdit(new DL.Question { QuestionId=quest.QuestionId,Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        Success(result);
                        if (sayac == 1)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer {QAId=Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "+", QuestionId = Convert.ToInt32(txtBoxId.Text) });
                        }
                        else if (sayac == 2)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text, QuestionId = Convert.ToInt32(txtBoxId.Text) });
                        }
                        else if (sayac == 3)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text + "," + txtBoxC.Text, QuestionId = Convert.ToInt32(txtBoxId.Text)});
                        }
                        else if (sayac == 4)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text, QuestionId = Convert.ToInt32(txtBoxId.Text) });
                        }
                        else if (sayac == 5)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "," + txtBoxE.Text, QuestionId = Convert.ToInt32(txtBoxId.Text) });
                        }
                    }
                    else if (checkB.Checked)
                    {
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        Success(result);
                        if (sayac == 2)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+", QuestionId = Convert.ToInt32(txtBoxId.Text) });
                        }
                        else if (sayac == 3)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+," + txtBoxC.Text, QuestionId = Convert.ToInt32(txtBoxId.Text) });

                        }
                        else if (sayac == 4)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+," + txtBoxC.Text + "," + txtBoxD.Text, QuestionId = Convert.ToInt32(txtBoxId.Text) });

                        }
                        else if (sayac == 5)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+," + txtBoxC.Text + "," + txtBoxD.Text + "," + txtBoxE.Text, QuestionId = Convert.ToInt32(txtBoxId.Text) });
                        }
                    }
                    else if (checkC.Checked)
                    {
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        Success(result);
                        if (sayac == 3)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "+", QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 4)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "+," + txtBoxD.Text, QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 5)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "+," + txtBoxD.Text + "," + txtBoxE.Text, QuestionId = quest.QuestionId });
                        }
                    }
                    else if (checkD.Checked)
                    {
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        Success(result);
                        if (sayac == 4)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "+", QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 5)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "+," + txtBoxE.Text, QuestionId = quest.QuestionId });
                        }
                    }
                    else if (checkE.Checked)
                    {
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        Success(result);
                        if (sayac == 5)
                        {
                            client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "," + txtBoxE.Text + "+", QuestionId = quest.QuestionId });

                        }
                    }
                    else
                    {
                        MessageBox.Show("Doğru Cevabı Seçmediniz! (Doğru Olan Şık Hangisi İse Üstündeki Kutucuğu İşaretleyiniz.)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Bütün İçerikleri Doldurduğunuza Emin Olun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else if (cmbBoxQuestionType.Text == "Boşluk Doldurma")
            {
                if (sayac2 == 0)
                {
                    sayac2 = sayacy;
                }
                if (txtBoxContent.Text != null && Denetleme2(sayac2))
                {
                    var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                    var result = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                    Success(result);

                    if (sayac2 == 1)
                    {
                        client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBox1.Text, QuestionId = quest.QuestionId });
                    }
                    else if (sayac2 == 2)
                    {
                        client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBox1.Text + "," + txtBox2.Text, QuestionId = quest.QuestionId });
                    }
                    else if (sayac2 == 3)
                    {
                        client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBox1.Text + "," + txtBox2.Text + "," + txtBox3.Text, QuestionId = quest.QuestionId });

                    }
                    else if (sayac2 == 4)
                    {
                        client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBox1.Text + "," + txtBox2.Text + "," + txtBox3.Text + "," + txtBox4.Text, QuestionId = quest.QuestionId });

                    }
                    else if (sayac2 == 5)
                    {
                        client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBox1.Text + "," + txtBox2.Text + "," + txtBox3.Text + "," + txtBox4.Text + "," + txtBox5.Text, QuestionId = quest.QuestionId });
                    }
                }
                else
                {
                    MessageBox.Show("Bütün İçerikleri Doldurduğunuza Emin Olun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (cmbBoxQuestionType.Text == "Doğru-Yanlış")
            {
                if (checkBoxTrue.Checked || checkBoxFalse.Checked && txtBoxContent.Text != null)
                {
                    if (checkBoxTrue.Checked)
                    {
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var resultt = client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = "Doğru", QuestionId = quest.QuestionId });
                        Success(resultt);
                    }
                    else
                    {
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var resultt = client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = "Yanlış", QuestionId = quest.QuestionId });
                        Success(resultt);
                    }
                }
            }
            else if (cmbBoxQuestionType.Text == "Klasik")
            {
                if (txtBoxContent.Text != null && txtBoxAnswer.Text != null)
                {
                    var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), OldTextContent, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                    var resultt = client.QuestionEdit(new DL.Question { QuestionId = quest.QuestionId, Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                    var result = client.QuestionAnswerEdit(new DL.QuestionAnswer { QAId = Convert.ToInt32(textBoxQAId.Text), QuestionAnswers = txtBoxAnswer.Text, QuestionId = quest.QuestionId });
                    Success(result);
                }
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBoxContent_MouseClick(object sender, MouseEventArgs e)
        {
            OldTextContent = txtBoxContent.Text;
        }
    }
}
