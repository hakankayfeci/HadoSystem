using Hado.DL;
using Hado.DL.ViewModel;
using Hado.PL.HadoUIServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hado.PL.Forms.Exam
{
    public partial class _CreateExam : Form
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
        public _CreateExam(User user)
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

        private void LblCreateExam_MouseDown(object sender, MouseEventArgs e)
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

        List<QuestionViewModel> questionViewModels = new List<QuestionViewModel>();
        int klasik, secmeli, dogruyanlis, bosluk;
        private void _CreateExam_Load(object sender, EventArgs e)
        {
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            var lesson = client.LessonList(teacher.TeacherId);
            cmbBoxLesson.DisplayMember = "Value";
            foreach (var item in lesson)
            {
                cmbBoxLesson.Items.Add(new KeyValuePair<int, string>(item.LessonId, item.LessonName));
            }
            var type = client.QuestionTypeList();

            string seciniz = "Seçiniz...";
            cmbBoxLesson.SelectedItem = seciniz.ToString();
            cmbBoxGroupNumber.SelectedItem = seciniz.ToString();

        }
        void Temizle()
        {
            txtBoxClassic.Text = null;
            txtBoxGapFilling.Text = null;
            txtBoxMultipleChoice.Text = null;
            txtBoxTrueFalse.Text = null;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (cmbBoxGroupNumber.SelectedItem.ToString() == "1")
            {
                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiA.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiACevap.docx");
                MessageBox.Show("File Created!");
                Temizle();


            }
            else if (cmbBoxGroupNumber.SelectedItem.ToString() == "2")
            {
                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiA.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiACevap.docx");

                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiB.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiBCevap.docx");

                MessageBox.Show("File Created!");
                Temizle();

            }
            else if (cmbBoxGroupNumber.SelectedItem.ToString() == "3")
            {
                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiA.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiACevap.docx");

                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiB.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiBCevap.docx");

                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiC.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiCCevap.docx");

                MessageBox.Show("File Created!");
                Temizle();

            }
            else if (cmbBoxGroupNumber.SelectedItem.ToString() == "4")
            {
                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiA.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiACevap.docx");

                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiB.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiBCevap.docx");

                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiC.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiCCevap.docx");

                CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiD.docx");
                CreateWordAnswers(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\Dogukan\Desktop\SinavkagidiDCevap.docx");

                MessageBox.Show("File Created!");
                Temizle();

            }
            else
            {
                MessageBox.Show("Lütfen Kaç Adet Grup Olacağını Seçiniz ...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Find and Replace Method
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object ToFindText, object replaceWithText)
        {



            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        object missing = Missing.Value;
        Microsoft.Office.Interop.Word.Document myWordDoc = null;

        //Create the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
                missing = Missing.Value;
                myWordDoc = null;
                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
                    myWordDoc.Activate();
                    Content();

                }
                else
                {
                    MessageBox.Show("File not Found!");
                }

                //Save as
                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);
                myWordDoc.Close();
                wordApp.Quit();
            }
            catch (Exception ex)
            {
                myWordDoc.Close();
                wordApp.Quit();
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateWordAnswers(object filename, object SaveAs)
        {
            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
                missing = Missing.Value;
                myWordDoc = null;
                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
                    myWordDoc.Activate();
                    AnswerKey();

                }
                else
                {
                    MessageBox.Show("File not Found!");
                }
                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);
                myWordDoc.Close();
                wordApp.Quit();
            }
            catch (Exception ex)
            {
                myWordDoc.Close();
                wordApp.Quit();
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Content()
        {
            questionViewModels = new List<QuestionViewModel>();
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            var school = client.GetSchool(teacher.TeacherId);
            //find and replace
            this.FindAndReplace(wordApp, "<school>", "Kocatepe");
            if (DateTime.Now.Month < 8)
            {
                this.FindAndReplace(wordApp, "<fyear>", DateTime.Now.Year);
                this.FindAndReplace(wordApp, "<syear>", DateTime.Now.Year - 1);
                this.FindAndReplace(wordApp, "<season>", "Bahar");
            }
            else
            {
                this.FindAndReplace(wordApp, "<fyear>", DateTime.Now.Year + 1);
                this.FindAndReplace(wordApp, "<syear>", DateTime.Now.Year);
                this.FindAndReplace(wordApp, "<season>", "Güz");
            }
            this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
            this.FindAndReplace(wordApp, "<lesson>", ((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Value);
            this.FindAndReplace(wordApp, "<examName>", ((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Value);
            if (klasik > 0 || bosluk > 0 || secmeli > 0 || dogruyanlis > 0)
            {
                txtBoxClassic.Text = klasik.ToString();
                txtBoxGapFilling.Text = bosluk.ToString();
                txtBoxMultipleChoice.Text = secmeli.ToString();
                txtBoxTrueFalse.Text = dogruyanlis.ToString();
            }

            int sorusayisi = (string.IsNullOrEmpty(txtBoxClassic.Text) ? 0 : Convert.ToInt32(txtBoxClassic.Text)) + (string.IsNullOrEmpty(txtBoxGapFilling.Text) ? 0 : Convert.ToInt32(txtBoxGapFilling.Text)) + (string.IsNullOrEmpty(txtBoxMultipleChoice.Text) ? 0 : Convert.ToInt32(txtBoxMultipleChoice.Text)) + (string.IsNullOrEmpty(txtBoxTrueFalse.Text) ? 0 : Convert.ToInt32(txtBoxTrueFalse.Text));

            string kalphabet = "abcdefghiklmnoprstuvyz";
            char[] arrayy = kalphabet.ToCharArray();
            string alphabet = "ABCDEF";
            char[] array = alphabet.ToCharArray();
            int sayac = 0;
            for (int x = 1; x <= sorusayisi; x++)
            {
                //QTypeid = 1 ise Çoktan Seçmeli, 2 ise Boşluk Doldurma, 3 ise Doğru-Yanlış, 4 ise Klasik
                if (Convert.ToInt32(txtBoxClassic.Text) > 0)
                {
                    klasik = Convert.ToInt32(txtBoxClassic.Text);
                    var questClassic = client.QuestionVMRandom(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), 4, Convert.ToInt32(txtBoxClassic.Text));
                    foreach (var item in questClassic)
                    {
                        questionViewModels.Add(new QuestionViewModel { LessonId = item.LessonId, LessonName = "Boş", QAId = item.QAId, Question1 = item.Question1, QuestionAnswers = item.QuestionAnswers, QuestionId = item.QuestionId, QuestionType = item.QuestionType, QuestionTypee = "Boş" });
                    }
                    //Girilen Soru İle Gelen Soru Sayısı Aynı mı
                    if (questClassic.Count() == Convert.ToInt32(txtBoxClassic.Text))
                    {
                        this.FindAndReplace(wordApp, "<content>", "Aşağıdaki KLASİK soruları cevaplayınız" + Environment.NewLine + "" + Environment.NewLine + "<content>");
                        int sayacc = 0;
                        foreach (var item in questClassic)
                        {
                            sayacc++;
                            sayac++;

                            if (sayacc == Convert.ToInt32(txtBoxClassic.Text))
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ")" + item.Question1 + " ?" + Environment.NewLine + "" + Environment.NewLine + Environment.NewLine + "" + Environment.NewLine + Environment.NewLine + "" + Environment.NewLine + "<content>");
                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ")" + item.Question1 + " ?" + Environment.NewLine + "" + Environment.NewLine + Environment.NewLine + "" + Environment.NewLine + "" + Environment.NewLine + "<content>");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerekmektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtBoxClassic.Text = "0";

                }
                if (Convert.ToInt32(txtBoxGapFilling.Text) > 0)
                {
                    bosluk = Convert.ToInt32(txtBoxGapFilling.Text);

                    var questGF = client.QuestionVMRandom(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), 2, Convert.ToInt32(txtBoxGapFilling.Text));
                    foreach (var item in questGF)
                    {
                        questionViewModels.Add(new QuestionViewModel { LessonId = item.LessonId, LessonName = "Boş", QAId = item.QAId, Question1 = item.Question1, QuestionAnswers = item.QuestionAnswers, QuestionId = item.QuestionId, QuestionType = item.QuestionType, QuestionTypee = "Boş" });
                    }
                    //Girilen Soru İle Gelen Soru Sayısı Aynı mı
                    if (questGF.Count() == Convert.ToInt32(txtBoxGapFilling.Text))
                    {
                        this.FindAndReplace(wordApp, "<content>", (sayac + 1) + ")  Aşağıda verilen boşlukları doldurunuz." + Environment.NewLine + Environment.NewLine + "<content>");
                        int sayacc = 0;

                        foreach (var item in questGF)
                        {
                            if (sayacc == Convert.ToInt32(txtBoxGapFilling.Text))
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[sayacc] + ") " + item.Question1 + " ?" + Environment.NewLine + Environment.NewLine + "<content>");
                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[sayacc] + ") " + item.Question1 + " ?" + Environment.NewLine + Environment.NewLine + "<content>");
                            }
                            sayacc++;

                        }
                        sayac++;

                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerekmektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtBoxGapFilling.Text = "0";
                }
                if (Convert.ToInt32(txtBoxMultipleChoice.Text) > 0)
                {
                    secmeli = Convert.ToInt32(txtBoxMultipleChoice.Text);

                    var questMC = client.QuestionVMRandom(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), 1, Convert.ToInt32(txtBoxMultipleChoice.Text));
                    foreach (var item in questMC)
                    {
                        questionViewModels.Add(new QuestionViewModel { LessonId = item.LessonId, LessonName = "Boş", QAId = item.QAId, Question1 = item.Question1, QuestionAnswers = item.QuestionAnswers, QuestionId = item.QuestionId, QuestionType = item.QuestionType, QuestionTypee = "Boş" });
                    }
                    //Girilen Soru İle Gelen Soru Sayısı Aynı mı
                    if (questMC.Count() == Convert.ToInt32(txtBoxMultipleChoice.Text))
                    {
                        this.FindAndReplace(wordApp, "<content>", "Aşağıdaki ÇOKTAN SEÇMELİ soruları cevaplayınız." + Environment.NewLine + Environment.NewLine + "<content>");
                        int sayacc = 0;

                        foreach (var item in questMC)
                        {
                            string[] dizi;
                            dizi = item.QuestionAnswers.Split(',');
                            for (int i = 0; i < dizi.Length; i++)
                            {
                                if (dizi[i].Contains('+'))
                                {
                                    dizi[i] = dizi[i].ToString().TrimEnd('+');
                                }
                            }
                            sayacc++;
                            sayac++;
                            if (sayacc == Convert.ToInt32(txtBoxMultipleChoice.Text))
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ") " + item.Question1 + " ?" + Environment.NewLine + Environment.NewLine + "<content>");
                                for (int i = 0; i < dizi.Length; i++)
                                {
                                    if ((dizi.Length - 1) == i)
                                    {
                                        this.FindAndReplace(wordApp, "<content>", kalphabet[i] + ") " + dizi[i] + Environment.NewLine + Environment.NewLine + "<content>");
                                    }
                                    else
                                    {
                                        this.FindAndReplace(wordApp, "<content>", kalphabet[i] + ") " + dizi[i] + Environment.NewLine + "<content>");

                                    }
                                }
                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ") " + item.Question1 + " ?" + Environment.NewLine + Environment.NewLine + "<content>");
                                for (int i = 0; i < dizi.Length; i++)
                                {
                                    if ((dizi.Length - 1) == i)
                                    {
                                        this.FindAndReplace(wordApp, "<content>", kalphabet[i] + ") " + dizi[i] + Environment.NewLine + Environment.NewLine + "<content>");
                                    }
                                    else
                                    {
                                        this.FindAndReplace(wordApp, "<content>", kalphabet[i] + ") " + dizi[i] + Environment.NewLine + "<content>");

                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerekmektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtBoxMultipleChoice.Text = "0";
                }
                if (Convert.ToInt32(txtBoxTrueFalse.Text) > 0)
                {
                    dogruyanlis = Convert.ToInt32(txtBoxTrueFalse.Text);
                    var questTF = client.QuestionVMRandom(Convert.ToInt32(((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Key), 3, Convert.ToInt32(txtBoxTrueFalse.Text));
                    foreach (var item in questTF)
                    {
                        questionViewModels.Add(new QuestionViewModel { LessonId = item.LessonId, LessonName = "Boş", QAId = item.QAId, Question1 = item.Question1, QuestionAnswers = item.QuestionAnswers, QuestionId = item.QuestionId, QuestionType = item.QuestionType, QuestionTypee = "Boş" });
                    }
                    //Girilen Soru İle Gelen Soru Sayısı Aynı mı
                    if (questTF.Count() == Convert.ToInt32(txtBoxTrueFalse.Text))
                    {
                        this.FindAndReplace(wordApp, "<content>", (sayac + 1) + ") Aşağıda verilen ifadelerden DOĞRU olanların yanına D, YANLIŞ olanların yanına Y harfi koyunuz." + Environment.NewLine + "" + Environment.NewLine + "<content>");
                        int sayacc = 0;
                        int harf = 0;

                        foreach (var item in questTF)
                        {
                            sayacc++;
                            if (sayacc == Convert.ToInt32(txtBoxTrueFalse.Text))
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[harf] + ") " + " ( )" + item.Question1 + Environment.NewLine + "" + Environment.NewLine + "<content>");
                                harf++;
                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[harf] + ")" + " ( )" + item.Question1 + Environment.NewLine + "<content>");
                                harf++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerekmektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtBoxTrueFalse.Text = "0";
                }
                this.FindAndReplace(wordApp, "<content>", "Başarılar…");


            }
        }
        void AnswerKey()
        {
            var teacher = client.TeacherList().Where(x => x.UserId == _user.UserId).FirstOrDefault();
            var school = client.GetSchool(teacher.TeacherId);
            //find and replace
            this.FindAndReplace(wordApp, "<school>", "Kocatepe");
            if (DateTime.Now.Month < 8)
            {
                this.FindAndReplace(wordApp, "<fyear>", DateTime.Now.Year);
                this.FindAndReplace(wordApp, "<syear>", DateTime.Now.Year - 1);
                this.FindAndReplace(wordApp, "<season>", "Bahar");
            }
            else
            {
                this.FindAndReplace(wordApp, "<fyear>", DateTime.Now.Year + 1);
                this.FindAndReplace(wordApp, "<syear>", DateTime.Now.Year);
                this.FindAndReplace(wordApp, "<season>", "Güz");
            }
            this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
            this.FindAndReplace(wordApp, "<lesson>", ((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Value);
            this.FindAndReplace(wordApp, "<examName>", ((KeyValuePair<int, string>)cmbBoxLesson.SelectedItem).Value);

            int sorusayisi = klasik + secmeli + dogruyanlis + bosluk;

            string kalphabet = "abcdefghiklmnoprstuvyz";
            char[] arrayy = kalphabet.ToCharArray();
            string alphabet = "ABCDEF";
            char[] array = alphabet.ToCharArray();
            int sayac = 0;
            for (int x = 1; x <= sorusayisi; x++)
            {
                //QTypeid = 1 ise Çoktan Seçmeli, 2 ise Boşluk Doldurma, 3 ise Doğru-Yanlış, 4 ise Klasik
                if (klasik > 0)
                {
                    if (questionViewModels.Where(y => y.QuestionType == 4).ToList().Count() == klasik)
                    {
                        this.FindAndReplace(wordApp, "<content>", "Aşağıdaki KLASİK soruları cevaplayınız" + Environment.NewLine + "" + Environment.NewLine + "<content>");
                        int sayacc = 0;
                        foreach (var item in questionViewModels.Where(z => z.QuestionType == 4).ToList())
                        {
                            sayacc++;
                            sayac++;

                            if (sayacc == klasik)
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ")" + item.Question1 + " ?" + Environment.NewLine + "" + Environment.NewLine + "Cevap : " + item.QuestionAnswers + Environment.NewLine + "" + Environment.NewLine + Environment.NewLine + "" + Environment.NewLine + "<content>");
                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ")" + item.Question1 + " ?" + Environment.NewLine + "" + Environment.NewLine + "Cevap : " + item.QuestionAnswers + Environment.NewLine + "" + Environment.NewLine + "" + Environment.NewLine + "<content>");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerkemektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (bosluk > 0)
                {
                    //Girilen Soru İle Gelen Soru Sayısı Aynı mı
                    if (questionViewModels.Where(y => y.QuestionType == 2).ToList().Count() == bosluk)
                    {

                        this.FindAndReplace(wordApp, "<content>", (sayac + 1) + ")  Aşağıda verilen boşlukları doldurunuz." + Environment.NewLine + Environment.NewLine + "<content>");
                        int sayacc = 0;

                        foreach (var item in questionViewModels.Where(z => z.QuestionType == 2).ToList())
                        {
                            string[] dizi = new string[] { };
                            if (item.QuestionAnswers.Contains(','))
                            {
                                dizi = item.QuestionAnswers.Split(',');
                            }
                            else
                            {
                                dizi[0] = item.QuestionAnswers;
                            }
                            if (sayacc == bosluk)
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[sayacc] + ") " + item.Question1 + " ?" + Environment.NewLine + "<content>");
                                this.FindAndReplace(wordApp, "<content>", "Cevap : " + " <content>");
                                for (int i = 0; i < dizi.Length; i++)
                                {
                                    this.FindAndReplace(wordApp, "<content>", i + ") " + dizi[i] + Environment.NewLine+"<content>");
                                }
                                this.FindAndReplace(wordApp, "<content>", Environment.NewLine + Environment.NewLine + "<content>");

                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[sayacc] + ") " + item.Question1 + " ?" + Environment.NewLine + "<content>");
                                this.FindAndReplace(wordApp, "<content>", "Cevap : " + "<content>");
                                for (int i = 0; i < dizi.Length; i++)
                                {
                                    this.FindAndReplace(wordApp, "<content>", arrayy[sayacc] + ") " + dizi[i] + "<content>");
                                }
                                this.FindAndReplace(wordApp, "<content>", Environment.NewLine + "<content>");
                            }
                            sayacc++;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerkemektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (secmeli > 0)
                {
                    //Girilen Soru İle Gelen Soru Sayısı Aynı mı
                    if (questionViewModels.Where(y => y.QuestionType == 1).ToList().Count() == secmeli)
                    {
                        this.FindAndReplace(wordApp, "<content>", "Aşağıdaki ÇOKTAN SEÇMELİ soruları cevaplayınız." + Environment.NewLine + Environment.NewLine + "<content>");
                        int sayacc = 0;

                        foreach (var item in questionViewModels.Where(y => y.QuestionType == 1).ToList())
                        {
                            string[] dizi;
                            string cevap = "";
                            int sayi = 0;
                            dizi = item.QuestionAnswers.Split(',');
                            for (int i = 0; i < dizi.Length; i++)
                            {
                                if (dizi[i].Contains('+'))
                                {
                                    dizi[i] = dizi[i].ToString().TrimEnd('+');
                                    cevap = dizi[i].ToString();
                                    sayi = i;
                                }
                            }
                            sayacc++;
                            sayac++;
                            if (sayacc == secmeli)
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ") " + item.Question1 + " ?" + Environment.NewLine + Environment.NewLine + "<content>");

                                this.FindAndReplace(wordApp, "<content>", kalphabet[sayi] + ") " + cevap + Environment.NewLine + Environment.NewLine + Environment.NewLine + "<content>");
                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", sayac + ") " + item.Question1 + " ?" + Environment.NewLine + Environment.NewLine + "<content>");

                                this.FindAndReplace(wordApp, "<content>", kalphabet[sayi] + ") " + cevap + Environment.NewLine + Environment.NewLine + "<content>");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerkemektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (dogruyanlis > 0)
                {
                    //Girilen Soru İle Gelen Soru Sayısı Aynı mı
                    if (questionViewModels.Where(z => z.QuestionType == 3).ToList().Count() == dogruyanlis)
                    {
                        this.FindAndReplace(wordApp, "<content>", (sayac + 1) + ") Aşağıda verilen ifadelerden DOĞRU olanların yanına D, YANLIŞ olanların yanına Y harfi koyunuz." + Environment.NewLine + "" + Environment.NewLine + "<content>");
                        int sayacc = 0;
                        int harf = 0;

                        foreach (var item in questionViewModels.Where(z => z.QuestionType == 3).ToList())
                        {
                            sayacc++;
                            if (sayacc == dogruyanlis)
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[harf] + ") " + item.Question1 + " (" + item.QuestionAnswers == "Doğru" ? "D" : "Y" + ")" + item.Question1 + Environment.NewLine + "" + Environment.NewLine + "<content>");
                                harf++;
                            }
                            else
                            {
                                this.FindAndReplace(wordApp, "<content>", arrayy[harf] + ")" + item.Question1 + " (" + item.QuestionAnswers == "Doğru" ? "D" : "Y" + ")" + item.Question1 + Environment.NewLine + "<content>");
                                harf++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yeterli Sayıda Klasik Soru bulunmamaktadır. Soru Eklemeniz Yada Girilen Soru Sayısını Değiştirmeniz Gerkemektedir.", "Hata..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sayac++;

                }
                this.FindAndReplace(wordApp, "<content>", "Başarılar…");
            }
        }


    }
}
