using Parola_Yoneticisi.Models;
using Parola_Yoneticisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parola_Yoneticisi
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
            BtnShowPasswordForOldPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            BtnShowPasswordForNewPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            BtnShowPasswordForNewPasswordApprove.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            string oldPassword = TxtOldPassword.Text;
            string newPassword = TxtNewPassword.Text;
            string newPasswordApprove = TxtNewPasswordApprove.Text;
            if (oldPassword == null || newPassword == null || newPasswordApprove == null)
            {
                MessageBox.Show("Lütfen boş değer bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != newPasswordApprove)
            {
                MessageBox.Show("Yeni parolanızı onaylanmadı lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SifreEntities sifreEntities = new SifreEntities())
            {
                var oldPasswordHash = await sifreEntities.Keys.FirstOrDefaultAsync();
                if (oldPasswordHash.Key == PasswordCrypto.ComputeSha256Hash(oldPassword))
                {
                    oldPasswordHash.Key = PasswordCrypto.ComputeSha256Hash(newPassword);
                    var passwordList = await sifreEntities.Passwords.ToListAsync();
                    foreach (var item in passwordList)
                    {
                        var decryptPassword = await PasswordCrypto.DecryptAsync(oldPassword, item.Password);
                        item.Password = await PasswordCrypto.EncryptAsync(newPassword, decryptPassword);
                    }
                    sifreEntities.Keys.AddOrUpdate(oldPasswordHash);
                    foreach (var item in passwordList)
                    {
                        sifreEntities.Passwords.AddOrUpdate(item);
                    }
                    await sifreEntities.SaveChangesAsync();
                    MessageBox.Show("Parolanız güncellenmiştir.", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm.Key = newPassword;
                    MainForm form1 = new MainForm();
                    form1.ShowDialog();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Parolanız hatalı lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnShowPasswordForOldPassword_Click(object sender, EventArgs e)
        {
            if (TxtOldPassword.UseSystemPasswordChar)
            {
                TxtOldPassword.UseSystemPasswordChar = false;
                BtnShowPasswordForOldPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
            }
            else
            {
                TxtOldPassword.UseSystemPasswordChar = true;
                BtnShowPasswordForOldPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            }
        }

        private void BtnShowPasswordForNewPassword_Click(object sender, EventArgs e)
        {
            if (TxtNewPassword.UseSystemPasswordChar)
            {
                TxtNewPassword.UseSystemPasswordChar = false;
                BtnShowPasswordForNewPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
            }
            else
            {
                TxtNewPassword.UseSystemPasswordChar = true;
                BtnShowPasswordForNewPassword.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            }
        }

        private void BtnShowPasswordForNewPasswordApprove_Click(object sender, EventArgs e)
        {
            if (TxtNewPasswordApprove.UseSystemPasswordChar)
            {
                TxtNewPasswordApprove.UseSystemPasswordChar = false;
                BtnShowPasswordForNewPasswordApprove.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
            }
            else
            {
                TxtNewPasswordApprove.UseSystemPasswordChar = true;
                BtnShowPasswordForNewPasswordApprove.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            }
        }
    }
}
