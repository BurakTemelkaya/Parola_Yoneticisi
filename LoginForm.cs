using Parola_Yoneticisi.Models;
using Parola_Yoneticisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = Parola_Yoneticisi.Models.Keys;

namespace Parola_Yoneticisi
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            BtnShowPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
        }

        private string Password;
        private async void LoginForm_Load(object sender, EventArgs e)
        {
            using (SifreEntities sifre = new SifreEntities())
            {
                var value = await sifre.Keys.FirstOrDefaultAsync();
                Password = value.Key;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Parola alanını boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string password = TxtPassword.Text;
            string crytoPassword = PasswordCrypto.ComputeSha256Hash(password);

            if (crytoPassword == Password)
            {
                Hide();
                MainForm form1 = new MainForm();
                form1.Show();
                MainForm.Key = password;
            }
            else
            {
                MessageBox.Show("Parolanız hatalı lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false;
                BtnShowPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                BtnShowPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            }
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetPassword = new ResetPasswordForm();
            resetPassword.Show();
            Hide();
        }
        
    }
}
