using Hado.PL.Forms.Exam;
using Hado.PL.Forms.Lesson;
using Hado.PL.Forms.Question;
using Hado.PL.Forms.Teacher;
using Hado.PL.HadoUIServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hado.PL.Forms
{
    public partial class MainForm : Form
    {
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        DL.User _user ;
        public MainForm(DL.User user)
        {
            _user = user;
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        HadoUIServiceClient client = new HadoUIServiceClient();

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.GhostWhite;
                }
            }
            this.WindowState = FormWindowState.Maximized;
            if (_user.RoleId==2)
            {
                toolTeacher.Visible = false;
            }
            else
            {
                toolLesson.Visible = false;
                toolQuestion.Visible = false;
                toolExam.Visible = false;
            }

        }

        private void dersIslemleriMenu_Click(object sender, EventArgs e)
        {
            _AddLesson addLesson = new _AddLesson(_user);
            addLesson.MdiParent = this;
            addLesson.Show();
        }

        private void soruSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateQuestion updateQuestion = new _UpdateQuestion(_user);
            updateQuestion.MdiParent = this;
            updateQuestion.Show();

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlKontrol_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OgretmenIslemleriMenu_Click(object sender, EventArgs e)
        {
            _AddTeacher addTeacher = new _AddTeacher();
            addTeacher.MdiParent = this;
            addTeacher.Show();
        }

        private void ÖğretmenGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateTeacher updateTeacher = new _UpdateTeacher();
            updateTeacher.MdiParent = this;
            updateTeacher.Show();
        }

        private void ÖğretmenSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteTeacher deleteTeacher = new _DeleteTeacher();
            deleteTeacher.MdiParent = this;
            deleteTeacher.Show();
        }

        private void DersGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _UpdateLesson updateLesson = new _UpdateLesson(_user);
            updateLesson.MdiParent = this;
            updateLesson.Show();
        }

        private void DersSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _DeleteLesson deleteLesson = new _DeleteLesson(_user);
            deleteLesson.MdiParent = this;
            deleteLesson.Show();
        }

        private void SoruEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddQuestion addQuestion = new _AddQuestion(_user);
            addQuestion.MdiParent = this;
            addQuestion.Show();
        }

        private void SoruSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _DeleteQuestion deleteQuestion = new _DeleteQuestion(_user);
            deleteQuestion.MdiParent = this;
            deleteQuestion.Show();
        }

        private void SınavOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CreateExam createExam = new _CreateExam(_user);
            createExam.MdiParent = this;
            createExam.Show();
        }

        private void KayıtlıSınavlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _RegisteredExam registeredExam = new _RegisteredExam(_user);
            registeredExam.MdiParent = this;
            registeredExam.Show();
        }

        private void BtnClosed_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                
            }

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolLogout_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Login loginForm = new Login();
                this.Hide();
                loginForm.Show();
            }

            
        }
    }
}
