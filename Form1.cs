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
using Parola_Yoneticisi;
using Parola_Yoneticisi.Models;

namespace Sifre_Tutma_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Key;
        private async void Form1_Load(object sender, EventArgs e)
        {
            TxtPasswordForAdd.UseSystemPasswordChar = true;
            TxtPasswordForUpdate.UseSystemPasswordChar = true;
            BtnShowPasswordForAdd.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            BtnShowPasswordForUpdate.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            BtnRandomPasswordGenerator.Image = Image.FromFile(Application.StartupPath + @"\Icons\refresh.png");
            await ListAsync();
        }

        private async Task ListAsync()
        {
            using (SifreEntities passwordEntites = new SifreEntities())
            {
                var values = await passwordEntites.Passwords.ToListAsync();
                DgvValues.DataSource = values;
            }
            DgvValues.Columns[3].Visible = false;
            DgvValues.Columns[1].HeaderText = "İsmi";
            DgvValues.Columns[2].HeaderText = "Kullanıcı Adı";
            DgvValues.Columns[4].HeaderText = "Oluşturulma Tarihi";
            DgvValues.Columns[5].HeaderText = "Güncelleme Tarihi";
        }

        private async Task SearchAsync(string deger)
        {
            using (SifreEntities passwordEntites = new SifreEntities())
            {
                if (deger != string.Empty)
                {
                    var password = await passwordEntites.Passwords.AsNoTracking().Where(t => t.Name.ToLower().Contains(deger.ToLower())).ToListAsync();
                    DgvValues.DataSource = password;
                }
                else
                {
                    await ListAsync();
                }

            }
        }
        private async Task AddAsync(string name, string password, string userName)
        {
            using (SifreEntities passwordEntites = new SifreEntities())
            {
                Passwords value = new Passwords
                {
                    Name = name,
                    Password = await PasswordCrypto.EncryptAsync(Key, password),
                    UserName = userName,
                    CreateDate = DateTime.Now,
                };
                passwordEntites.Passwords.Add(value);
                await passwordEntites.SaveChangesAsync();
                await ListAsync();
                MessageBox.Show("Şifre Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxClearForAdd();
            }
        }
        private async void BtnPasswordAdd_Click(object sender, EventArgs e)
        {
            if (TxtPasswordNameForAdd.Text != "" && TxtPasswordForAdd.Text != "" && TxtUserNameForAdd.Text != "")
            {
                await AddAsync(TxtPasswordNameForAdd.Text, TxtPasswordForAdd.Text, TxtUserNameForAdd.Text);
            }
            else if (TxtPasswordNameForAdd.Text == "")
            {
                MessageBox.Show("Lütfen Sitenin Adını Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPasswordForAdd.Text == "")
            {
                MessageBox.Show("Lütfen Şifreyi Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtUserNameForAdd.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı adı veya E-postayı boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DgFindItem()
        {
            try
            {
                return Convert.ToInt32(DgvValues.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                return 0;
            }
        }

        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await SearchAsync(txtSearch.Text);
        }
        private async Task DeleteAsync()
        {
            int id = DgFindItem();
            if (id != 0)
            {
                using (SifreEntities passwordEntites = new SifreEntities())
                {
                    passwordEntites.Passwords.Remove(await passwordEntites.Passwords.FindAsync(id));
                    await passwordEntites.SaveChangesAsync();
                    await ListAsync();
                    MessageBox.Show("Silme işlemi başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("İşlem Yapılamadı, Lütfen Kayıt Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçilen Şifrenin Kaydını Silmek istediğinize Emin misiniz", "Şifre Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                await DeleteAsync();
                TextBoxClearForUpdate();
            }

        }
        private async Task UpdateAsync(string name, string userName, string password)
        {
            using (SifreEntities passwordEntites = new SifreEntities())
            {
                int ID = DgFindItem();
                if (ID > 0)
                {
                    var value = await passwordEntites.Passwords.Where(w => w.Id == ID).FirstOrDefaultAsync();
                    value.Name = name;
                    value.Password = await PasswordCrypto.EncryptAsync(Key, password);
                    value.UserName = userName;
                    value.UpdateDate = DateTime.Now;
                    await passwordEntites.SaveChangesAsync();
                    await ListAsync();
                    MessageBox.Show("İşlem Başarılı " + value.Name + " Adlı şifre güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxClearForUpdate();
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtNameForUpdate.Text != "" && txtUserNameForUpdate.Text != "" && TxtPasswordForUpdate.Text != "")
            {
                await UpdateAsync(TxtNameForUpdate.Text, txtUserNameForUpdate.Text, TxtPasswordForUpdate.Text);
            }
            else if (TxtNameForUpdate.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Adını Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserNameForUpdate.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Kullanıcı Adını veya E-Postasını boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPasswordForAdd.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Şifresini boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxClearForAdd()
        {
            TxtPasswordNameForAdd.Clear();
            TxtPasswordForAdd.Clear();
            TxtUserNameForAdd.Clear();
        }
        private void TextBoxClearForUpdate()
        {
            TxtNameForUpdate.Clear();
            TxtPasswordForUpdate.Clear();
            txtUserNameForUpdate.Clear();
            TxtCreateDateForUpdate.Clear();
        }

        private void DgvDegerler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void BtnClearForAdd_Click(object sender, EventArgs e) => TextBoxClearForAdd();

        private void BtnClearForUpdate_Click(object sender, EventArgs e) => TextBoxClearForUpdate();

        private async void BtnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(await PasswordCrypto.DecryptAsync(Key, DgvValues.CurrentRow.Cells[3].Value.ToString()));
            }
            catch
            {
                MessageBox.Show("Lütfen Kopyalanacak Parolayı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string output = string.Format("{0} Adlı Şifre Panoya Kopyalandı", DgvValues.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show(output, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCopyUserName_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(DgvValues.CurrentRow.Cells[2].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Lütfen Kopyalanacak Parolayı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string output = string.Format("{0} Adlı Kullanıcı Adı Panoya Kopyalandı", DgvValues.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show(output, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void DgvValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNameForUpdate.Text = DgvValues.CurrentRow.Cells[1].Value.ToString();
            txtUserNameForUpdate.Text = DgvValues.CurrentRow.Cells[2].Value.ToString();
            TxtPasswordForUpdate.Text = await PasswordCrypto.DecryptAsync(Key, DgvValues.CurrentRow.Cells[3].Value.ToString());
            TxtCreateDateForUpdate.Text = DgvValues.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BtnShowPasswordForAdd_Click(object sender, EventArgs e)
        {
            if (TxtPasswordForAdd.UseSystemPasswordChar)
            {
                TxtPasswordForAdd.UseSystemPasswordChar = false;
                BtnShowPasswordForAdd.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
            }
            else
            {
                TxtPasswordForAdd.UseSystemPasswordChar = true;
                BtnShowPasswordForAdd.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            }
        }
        private void BtnShowPasswordForUpdate_Click(object sender, EventArgs e)
        {
            if (TxtPasswordForUpdate.UseSystemPasswordChar)
            {
                TxtPasswordForUpdate.UseSystemPasswordChar = false;
                BtnShowPasswordForUpdate.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
            }
            else
            {
                TxtPasswordForUpdate.UseSystemPasswordChar = true;
                BtnShowPasswordForUpdate.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
            }
        }

        private void BtnRandomPasswordGenerator_Click(object sender, EventArgs e)
        {
            TxtPasswordForAdd.UseSystemPasswordChar = false;
            TxtPasswordForAdd.Text = PasswordGenerator.GetRandomPassword();
            BtnShowPasswordForAdd.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
        }
    }
}
