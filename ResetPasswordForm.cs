﻿using Parola_Yoneticisi.Models;
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
using System.Text.RegularExpressions;

namespace Parola_Yoneticisi
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
            BtnShowPasswordForOldPassword.Image = ImageFileNames.GetShowPasswordImage();
            BtnShowPasswordForNewPassword.Image = ImageFileNames.GetShowPasswordImage();
            BtnShowPasswordForNewPasswordApprove.Image = ImageFileNames.GetShowPasswordImage();
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            string oldPassword = TxtOldPassword.Text;
            string newPassword = TxtNewPassword.Text;
            string newPasswordApprove = TxtNewPasswordApprove.Text;

            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,}$");
            if (!validateGuidRegex.IsMatch(newPassword))
            {
                MessageBox.Show("Lütfen parolanızı en az 8 karekter, bir büyük, bir küçük ve bir rakam içerecek şekilde giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != newPasswordApprove)
            {
                MessageBox.Show("Yeni parolanız onaylanmadı lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Dispose();
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
                BtnShowPasswordForOldPassword.Image = ImageFileNames.GetDontShowPasswordImage();
            }
            else
            {
                TxtOldPassword.UseSystemPasswordChar = true;
                BtnShowPasswordForOldPassword.Image = ImageFileNames.GetShowPasswordImage();
            }
        }

        private void BtnShowPasswordForNewPassword_Click(object sender, EventArgs e)
        {
            if (TxtNewPassword.UseSystemPasswordChar)
            {
                TxtNewPassword.UseSystemPasswordChar = false;
                BtnShowPasswordForNewPassword.Image = ImageFileNames.GetDontShowPasswordImage();
            }
            else
            {
                TxtNewPassword.UseSystemPasswordChar = true;
                BtnShowPasswordForNewPassword.Image = ImageFileNames.GetShowPasswordImage();
            }
        }

        private void BtnShowPasswordForNewPasswordApprove_Click(object sender, EventArgs e)
        {
            if (TxtNewPasswordApprove.UseSystemPasswordChar)
            {
                TxtNewPasswordApprove.UseSystemPasswordChar = false;
                BtnShowPasswordForNewPasswordApprove.Image = ImageFileNames.GetDontShowPasswordImage();
            }
            else
            {
                TxtNewPasswordApprove.UseSystemPasswordChar = true;
                BtnShowPasswordForNewPasswordApprove.Image = ImageFileNames.GetShowPasswordImage();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ResetPasswordForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
