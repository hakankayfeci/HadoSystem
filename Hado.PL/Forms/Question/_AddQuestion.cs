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
    public partial class _AddQuestion : Form
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
        public _AddQuestion(DL.User user)
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

        private void LblAddQuestion_MouseDown(object sender, MouseEventArgs e)
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

        private void _AddQuestion_Load(object sender, EventArgs e)
        {
            Listele();

            string seciniz = "Seçiniz...";
            cmbBoxQuestionType.SelectedItem = seciniz.ToString();

            cmbBoxLesson.SelectedItem = seciniz.ToString();



            


        }
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
        }

        private void cmbBoxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbBoxQuestionType_TextChanged(object sender, EventArgs e)
        {
            if (cmbBoxQuestionType.Text == "Çoktan Seçmeli")
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

                lblControl3.Visible = false;
                checkBoxTrue.Visible = false;
                checkBoxFalse.Visible = false;

                lblControl4.Visible = false;
                lblAnswer.Visible = false;
                txtBoxAnswer.Visible = false;
                pnlAnswer.Visible = false;

                sayac = 2;

                lblContent.Visible = true;
                txtBoxContent.Visible = true;
                pnlContent.Visible = true;
                lblControl.Visible = true;
                lblA.Visible = true;
                txtBoxA.Visible = true;
                pnlA.Visible = true;
                checkA.Visible = true;
                lblB.Visible = true;
                txtBoxB.Visible = true;
                pnlB.Visible = true;
                checkB.Visible = true;
                btnAddOption.Visible = true;
                btnRemoveOption.Visible = true;

                btnAdd.Location = new Point(512, 492);
                btnAdd.Visible = true;

            }
            else if (cmbBoxQuestionType.Text == "Boşluk Doldurma")
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


                sayac2 = 1;




                lblControl2.Visible = true;
                lbl1.Visible = true;
                txtBox1.Visible = true;
                pnlOne.Visible = true;
                btnAddAnswer.Visible = true;
                btnAdd.Visible = true;

                lblControl2.Location = new Point(15, 293);
                lbl1.Location = new Point(15, 337);
                txtBox1.Location = new Point(20, 361);
                pnlOne.Location = new Point(20, 389);
                lbl2.Location = new Point(15, 409);
                txtBox2.Location = new Point(20, 433);
                pnlTwo.Location = new Point(20, 461);
                lbl3.Location = new Point(15, 484);
                txtBox3.Location = new Point(20, 508);
                pnlThree.Location = new Point(20, 536);
                lbl4.Location = new Point(15, 556);
                txtBox4.Location = new Point(20, 580);
                pnlFour.Location = new Point(20, 608);
                lbl5.Location = new Point(15, 629);
                txtBox5.Location = new Point(20, 653);
                pnlFive.Location = new Point(20, 681);

                btnAdd.Location = new Point(426, 489);




                btnAddAnswer.Location = new Point(421, 337);
                btnRemoveAnswer.Location = new Point(421, 409);
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



                lblControl3.Visible = true;
                checkBoxTrue.Visible = true;
                checkBoxFalse.Visible = true;
                btnAdd.Visible = true;
                lblControl3.Location = new Point(15, 293);
                checkBoxTrue.Location = new Point(20, 336);
                checkBoxFalse.Location = new Point(116, 336);

                btnAdd.Location = new Point(12, 373);



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

                lblControl3.Visible = false;
                checkBoxTrue.Visible = false;
                checkBoxFalse.Visible = false;


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


                lblControl4.Visible = true;
                lblAnswer.Visible = true;
                txtBoxAnswer.Visible = true;
                pnlAnswer.Visible = true;
                btnAdd.Visible = true;
                lblControl4.Location = new Point(15, 293);
                lblAnswer.Location = new Point(15, 329);
                txtBoxAnswer.Location = new Point(15, 356);
                pnlAnswer.Location = new Point(15, 431);

                btnAdd.Location = new Point(15, 446);

            }
            else
            {
                btnAdd.Visible = false;
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

                lblContent.Visible = false;
                txtBoxContent.Visible = false;
                pnlContent.Visible = false;
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
            }
        }
        int sayac = 2;
        private void BtnAddOption_Click(object sender, EventArgs e)
        {
            sayac = sayac + 1;
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
                sayac = 2;
            }

        }

        private void BtnRemoveOption_Click(object sender, EventArgs e)
        {

            if (sayac == 3)
            {
                lblC.Visible = false;
                txtBoxC.Visible = false;
                pnlC.Visible = false;
                checkC.Visible = false;
                btnRemoveOption.Visible = false;

                sayac = sayac - 1;
                sayac = 2;

            }
            else if (sayac == 4)
            {
                lblD.Visible = false;
                txtBoxD.Visible = false;
                pnlD.Visible = false;
                checkD.Visible = false;
                sayac = sayac - 1;

            }
            else if (sayac == 5)
            {
                lblE.Visible = false;
                txtBoxE.Visible = false;
                pnlE.Visible = false;
                checkE.Visible = false;
                btnAddOption.Visible = true;
                sayac = sayac - 1;

            }
            else
            {
                sayac = 5;
            }
        }
        int sayac2 = 1;
        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            sayac2 = sayac2 + 1;
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
                sayac2 = 1;
            }
        }

        private void BtnRemoveAnswer_Click(object sender, EventArgs e)
        {

            if (sayac2 == 2)
            {
                lbl2.Visible = false;
                txtBox2.Visible = false;
                pnlTwo.Visible = false;

                btnRemoveAnswer.Visible = false;
                sayac2 = sayac2 - 1;
                sayac2 = 1;
            }
            else if (sayac2 == 3)
            {
                lbl3.Visible = false;
                txtBox3.Visible = false;
                pnlThree.Visible = false;
                sayac2 = sayac2 - 1;


            }
            else if (sayac2 == 4)
            {
                lbl4.Visible = false;
                txtBox4.Visible = false;
                pnlFour.Visible = false;
                sayac2 = sayac2 - 1;


            }
            else if (sayac2 == 5)
            {
                lbl5.Visible = false;
                txtBox5.Visible = false;
                pnlFive.Visible = false;
                sayac2 = sayac2 - 1;
                btnAddAnswer.Visible = true;
            }
            else
            {
                sayac2 = 5;
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
            if (sayac == 1 && txtBoxA.Text != null)
                return true;
            else if (sayac == 2 && txtBox1.Text != null && txtBox2.Text != null)
                return true;
            else if (sayac == 3 && txtBox1.Text != null && txtBox2.Text != null && txtBox3.Text != null)
                return true;
            else if (sayac == 4 && txtBox1.Text != null && txtBox2.Text != null && txtBox3.Text != null && txtBox4.Text != null)
                return true;
            else if (sayac == 5 && txtBox1.Text != null && txtBox2.Text != null && txtBox3.Text != null && txtBox4.Text != null && txtBox5.Text != null)
                return true;
            else
                return false;
        }
        void Success(bool deger)
        {
            if (deger)
            {
                MessageBox.Show("Başarıyla Eklendi..", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Clear()
        {
            txtBoxContent.Text = "";
            txtBoxA.Text = "";
            txtBoxB.Text = "";
            txtBoxC.Text = "";
            txtBoxD.Text = "";
            txtBoxE.Text = "";
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
            txtBox4.Text = "";
            txtBox5.Text = "";
            checkBoxTrue.Checked = false;
            checkBoxFalse.Checked = false;
            txtBoxAnswer.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Sayac Çoktan Seçmelinin | Sayac2 ise Boşluk Doldurmanın
            if (cmbBoxQuestionType.Text == "Çoktan Seçmeli")
            {
                if (txtBoxContent.Text != null && Denetleme(sayac))
                {
                    if (checkA.Checked)
                    {
                        var result = client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        Success(result);
                        if (sayac == 1)
                        {
                            client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "+", QuestionId = quest.QuestionId });
                        }
                        else if (sayac == 2)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text, QuestionId = quest.QuestionId });
                        }
                        else if (sayac == 3)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text + "," + txtBoxC.Text, QuestionId = quest.QuestionId });
                        }
                        else if (sayac == 4)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text, QuestionId = quest.QuestionId });
                        }
                        else if (sayac == 5)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "+," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "," + txtBoxE.Text, QuestionId = quest.QuestionId });
                        }
                    }
                    else if (checkB.Checked)
                    {
                       var result = client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        Success(result);
                        if (sayac == 2)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+", QuestionId = quest.QuestionId });
                        }
                        else if (sayac == 3)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+," + txtBoxC.Text, QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 4)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+," + txtBoxC.Text + "," + txtBoxD.Text, QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 5)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "+," + txtBoxC.Text + "," + txtBoxD.Text + "," + txtBoxE.Text, QuestionId = quest.QuestionId });
                        }
                    }
                    else if (checkC.Checked)
                    {
                        var result = client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        Success(result);
                        if (sayac == 3)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "+", QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 4)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "+," + txtBoxD.Text, QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 5)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "+," + txtBoxD.Text + "," + txtBoxE.Text, QuestionId = quest.QuestionId });
                        }
                    }
                    else if (checkD.Checked)
                    {
                        var result = client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        Success(result);
                        if (sayac == 4)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "+", QuestionId = quest.QuestionId });

                        }
                        else if (sayac == 5)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "+," + txtBoxE.Text, QuestionId = quest.QuestionId });
                        }
                    }
                    else if (checkE.Checked)
                    {
                        var result = client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        Success(result);
                        if (sayac == 5)
                        {
                                client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxA.Text + "," + txtBoxB.Text + "," + txtBoxC.Text + "," + txtBoxD.Text + "," + txtBoxE.Text + "+", QuestionId = quest.QuestionId });

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
                if (txtBoxContent.Text != null && Denetleme2(sayac2))
                {
                    var result = client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                    var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                    Success(result);

                    if (sayac2 == 1)
                    {
                            client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBox1.Text, QuestionId = quest.QuestionId });
                    }
                    else if (sayac2 == 2)
                    {
                            client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBox1.Text + "," + txtBox2.Text, QuestionId = quest.QuestionId });
                    }
                    else if (sayac2 == 3)
                    {
                            client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBox1.Text + "," + txtBox2.Text + "," + txtBox3.Text, QuestionId = quest.QuestionId });

                    }
                    else if (sayac2 == 4)
                    {
                            client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBox1.Text + "," + txtBox2.Text + "," + txtBox3.Text + "," + txtBox4.Text, QuestionId = quest.QuestionId });

                    }
                    else if (sayac2 == 5)
                    {
                            client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBox1.Text + "," + txtBox2.Text + "," + txtBox3.Text + "," + txtBox4.Text + "," + txtBox5.Text, QuestionId = quest.QuestionId });
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
                        client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = "Doğru", QuestionId = quest.QuestionId });
                        Success(result);
                    }
                    else
                    {
                        client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                        var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                        var result = client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = "Yanlış", QuestionId = quest.QuestionId });
                        Success(result);
                    }
                }
            }
            else if (cmbBoxQuestionType.Text == "Klasik")
            {
                if (txtBoxContent.Text != null && txtBoxAnswer.Text != null)
                {
                    client.QuestionAdd(new DL.Question { Question1 = txtBoxContent.Text, LessonId = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), QuestionType = Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key) });
                    var quest = client.QuestionGet(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), txtBoxContent.Text, Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxQuestionType.SelectedItem).Key));
                   var result = client.QuestionAnswerAdd(new DL.QuestionAnswer { QuestionAnswers = txtBoxAnswer.Text, QuestionId = quest.QuestionId });
                    Success(result);
                }
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
