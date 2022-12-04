using Parola_Yoneticisi.Models;
using Sifre_Tutma_Programi;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            BtnShowPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            await CheckPasswordAsync(TxtPassword.Text);
        }

        private async Task CheckPasswordAsync(string password)
        {
            using (SifreEntities sifre = new SifreEntities())
            {
                string crytoPassword = PasswordCrypto.ComputeSha256Hash(password);
                var isTrueKey = await sifre.Keys.Where(x => x.Key == crytoPassword).AnyAsync();
                if (isTrueKey)
                {
                    Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                    Form1.Key = password;
                }
                else
                {
                    MessageBox.Show("Parolanız hatalı lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.Show();
            Hide();
        }
    }
}
