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
    public partial class _UpdateTeacher : Form
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
        public _UpdateTeacher()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        

        private void LblUpdateTeacher_MouseDown(object sender, MouseEventArgs e)
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

        private void _UpdateTeacher_Load(object sender, EventArgs e)
        {
            var result = client.TeacherList();
            dgvTeachers.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = client.TeacherEdit(new DL.Teacher
            {
                TeacherId=Convert.ToInt32(txtBoxId.Text),
                Birthday = dtpBirthday.Value,
                Firstname = txtBoxName.Text,
                Lastname = txtBoxSurname.Text,
                IdentityNumber = txtBoxTC.Text,
                Phone = txtBoxPhone.Text,
                Email = txtBoxEmail.Text,
                SchoolId = 1,
                UserId= Convert.ToInt32(txtBoxUserId.Text),
            }, txtBoxUserName.Text, txtBoxPassword.Text);
            MessageBox.Show(result ? "Güncelleme Başarılı" : "Güncelleme Başarısız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            dgvTeachers.DataSource = client.TeacherList();

        }

        private void DgvTeachers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvTeachers.Rows[e.RowIndex];

            txtBoxId.Text = selectedRow.Cells["TeacherId"].Value.ToString();
            txtBoxName.Text = selectedRow.Cells["Firstname"].Value.ToString();
            txtBoxSurname.Text = selectedRow.Cells["Lastname"].Value.ToString();
            txtBoxTC.Text = selectedRow.Cells["IdentityNumber"].Value.ToString();
            txtBoxEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            dtpBirthday.Value = Convert.ToDateTime(selectedRow.Cells["Birthday"].Value.ToString());
            txtBoxPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
            txtBoxUserId.Text = selectedRow.Cells["UserId"].Value.ToString();
            var result = client.UserGet(Convert.ToInt32(txtBoxUserId.Text));
            txtBoxUserName.Text = result.Username;
            txtBoxPassword.Text = result.Password;
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
            dgvTeachers.DataSource = client.TeacherList().Where(x => x.Firstname.StartsWith(txtBoxSearch.Text) || x.Firstname.StartsWith(FUpper(txtBoxSearch.Text)) || x.Lastname.StartsWith(txtBoxSearch.Text) || x.Lastname.StartsWith(FUpper(txtBoxSearch.Text))).ToList();
        }
    }
}
