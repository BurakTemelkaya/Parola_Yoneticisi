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
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            await CheckPasswordAsync(TxtParola.Text);
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
                    MessageBox.Show("Parolanız hatalı lütfen tekrar deneyiniz.");
                }
            }
        }

        private void CbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (CbShowGoster.Checked)
            {
                TxtParola.UseSystemPasswordChar = false;
                CbShowGoster.Text = "Gizle";
            }
            else
            {
                TxtParola.UseSystemPasswordChar = true;
                CbShowGoster.Text = "Göster";
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
