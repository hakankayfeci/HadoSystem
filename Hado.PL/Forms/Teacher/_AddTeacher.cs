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

namespace Hado.PL.Forms.Teacher
{
    public partial class _AddTeacher : Form
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
        public _AddTeacher()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Pnl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblAddTeacher_MouseDown(object sender, MouseEventArgs e)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           bool result = client.TeacherAdd(new DL.Teacher
           {
                Birthday = dtpBirthday.Value,
                Firstname = txtBoxName.Text,
                Lastname = txtBoxSurname.Text,
                IdentityNumber = txtBoxTC.Text,
                Phone = txtBoxPhone.Text,
                Email = txtBoxEmail.Text,
                SchoolId=1,
            },txtBoxUserName.Text,2,txtBoxPassword.Text );

            MessageBox.Show( result ? "Kayıt Başarılı" : "Kayıt Başarısız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            dgvTeachers.DataSource = client.TeacherList();

        }

        private void _AddTeacher_Load(object sender, EventArgs e)
        {
            dgvTeachers.DataSource = client.TeacherList();
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
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTeachers.DataSource = client.TeacherList().Where(x => x.Firstname.StartsWith(txtBoxSearch.Text) || x.Firstname.StartsWith(FUpper(txtBoxSearch.Text)) || x.Lastname.StartsWith(txtBoxSearch.Text) || x.Lastname.StartsWith(FUpper(txtBoxSearch.Text))).ToList();

        }

        private void DgvTeachers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
