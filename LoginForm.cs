using Parola_Yoneticisi.Models;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace Parola_Yoneticisi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string Password;
        private async void LoginForm_Load(object sender, EventArgs e)
        {
            HideShowPassword();
            using (SifreEntities sifre = new SifreEntities())
            {
                var value = await sifre.Keys.FirstOrDefaultAsync();
                Password = value.Key;
            }
            BtnLogin.Enabled = true;
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
                MainForm form1 = new MainForm();
                form1.Show();
                MainForm.Key = password;
                Hide();
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
            HideShowPassword();
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetPassword = new ResetPasswordForm();
            resetPassword.Show();
            Hide();
        }

        private void HideShowPassword()
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
    }
}
