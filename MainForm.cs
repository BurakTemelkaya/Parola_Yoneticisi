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

namespace Parola_Yoneticisi
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        public static string Key;

        private static int Id;

        List<Passwords> PasswordList = new List<Passwords>();
        private async void Form1_Load(object sender, EventArgs e)
        {
            SetButtonsImage();
            DgvValues.Columns.Add("Count", "#");
            await ListAsync();
        }

        private void SetButtonsImage()
        {
            BtnShowPasswordForAdd.Image = ImageFileNames.GetShowPasswordImage();
            BtnShowPasswordForUpdate.Image = ImageFileNames.GetShowPasswordImage();
            BtnPasswordGenerateForAdd.Image = ImageFileNames.GetRefreshImage();
            BtnPasswordGenerateForUpdate.Image = ImageFileNames.GetRefreshImage();
            BtnClearForTxtSearch.Image = ImageFileNames.GetCloseImage();
        }

        private async Task ListAsync()
        {
            using (SifreEntities passwordEntites = new SifreEntities())
            {
                PasswordList = await passwordEntites.Passwords.AsNoTracking().ToListAsync();
            }
            DgvValues.DataSource = PasswordList;

            DgvValues.Columns[1].Visible = false;
            DgvValues.Columns[4].Visible = false;

            DgvValues.Columns[0].Width = 60;
            DgvValues.Columns[2].Width = 250;
            DgvValues.Columns[3].Width = 250;
            DgvValues.Columns[5].Width = 175;
            DgvValues.Columns[6].Width = 175;

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(PasswordList.Select(x => x.Name).ToArray());
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;

            for (int i = 0; i < PasswordList.Count; i++)
            {
                DgvValues.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private async Task SearchAsync(string deger)
        {
            if (deger != string.Empty)
            {
                var password = PasswordList.Where(t => t.Name.ToLower().Contains(deger.ToLower())).ToList();
                DgvValues.DataSource = password;
                for (int i = 0; i < password.Count; i++)
                {
                    DgvValues.Rows[i].Cells[0].Value = i + 1;
                }
            }
            else
            {
                await ListAsync();
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
                MessageBox.Show("Parola Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxClearForAdd();
            }
        }
        private async void BtnPasswordAdd_Click(object sender, EventArgs e)
        {
            if (TxtPasswordNameForAdd.Text != string.Empty && TxtPasswordForAdd.Text != string.Empty && TxtUserNameForAdd.Text != string.Empty)
            {
                await AddAsync(TxtPasswordNameForAdd.Text, TxtPasswordForAdd.Text, TxtUserNameForAdd.Text);
                TextBoxClearForAdd();
            }
            else if (TxtPasswordNameForAdd.Text == string.Empty)
            {
                MessageBox.Show("Lütfen parolanın adını boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPasswordForAdd.Text == string.Empty)
            {
                MessageBox.Show("Lütfen parolayı boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtUserNameForAdd.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adını boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TxtSearch_TextChanged(object sender, EventArgs e) => await SearchAsync(txtSearch.Text);
        private async Task DeleteAsync()
        {
            if (Id != 0)
            {
                using (SifreEntities passwordEntites = new SifreEntities())
                {
                    passwordEntites.Passwords.Remove(await passwordEntites.Passwords.FindAsync(Id));
                    await passwordEntites.SaveChangesAsync();
                    await ListAsync();
                    MessageBox.Show("Silme işlemi başarılı", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılamadı, lütfen kayıt seçiniz !", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçilen parolanın kaydını silmek istediğinize emin misiniz ?", "Parola Kaydı Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                await DeleteAsync();
                TextBoxClearForUpdate();
                txtSearch.Clear();
            }
        }

        private async void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtNameForUpdate.Text != "" && txtUserNameForUpdate.Text != "" && TxtPasswordForUpdate.Text != "")
            {
                await UpdateAsync(TxtNameForUpdate.Text, txtUserNameForUpdate.Text, TxtPasswordForUpdate.Text, DtpCreateDate.Value);
                TextBoxClearForUpdate();
                txtSearch.Clear();
            }
            else if (TxtNameForUpdate.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek parolanın adını boş bırakmayınız", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserNameForUpdate.Text == "")
            {
                MessageBox.Show("Lütfen güncellenen parolanın kullanıcı adını boş bırakmayınız", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPasswordForAdd.Text == "")
            {
                MessageBox.Show("Lütfen güncellenen parolanın şifresini boş bırakmayınız", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateAsync(string name, string userName, string password, DateTime createDate)
        {
            using (SifreEntities passwordEntites = new SifreEntities())
            {
                if (Id > 0)
                {
                    var value = await passwordEntites.Passwords.Where(w => w.Id == Id).FirstOrDefaultAsync();
                    value.Name = name;
                    value.Password = await PasswordCrypto.EncryptAsync(Key, password);
                    value.UserName = userName;
                    value.CreateDate = createDate;
                    value.UpdateDate = DateTime.Now;
                    await passwordEntites.SaveChangesAsync();
                    await ListAsync();
                    TextBoxClearForUpdate();
                    MessageBox.Show("İşlem başarılı " + value.Name + " adlı parola güncellendi", "Parola Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen parola seçiniz", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            DtpCreateDate.Value = DateTime.Now;
        }

        private void BtnClearForAdd_Click(object sender, EventArgs e) => TextBoxClearForAdd();

        private void BtnClearForUpdate_Click(object sender, EventArgs e) => TextBoxClearForUpdate();

        private async void BtnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(await PasswordCrypto.DecryptAsync(Key, DgvValues.CurrentRow.Cells[4].Value.ToString()));
            }
            catch
            {
                MessageBox.Show("Lütfen kopyalanacak parolayı seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string output = string.Format("{0} Adlı parola panoya kopyalandı", DgvValues.CurrentRow.Cells[2].Value.ToString());
            MessageBox.Show(output, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCopyUserName_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(DgvValues.CurrentRow.Cells[3].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Lütfen kopyalanacak parolayı seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string output = string.Format("{0} adlı kullanıcı adı panoya kopyalandı", DgvValues.CurrentRow.Cells[2].Value.ToString());
            MessageBox.Show(output, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void DgvValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HidePasswordForUpdate();
            Id = Convert.ToInt32(DgvValues.CurrentRow.Cells[1].Value);
            TxtNameForUpdate.Text = DgvValues.CurrentRow.Cells[2].Value.ToString();
            txtUserNameForUpdate.Text = DgvValues.CurrentRow.Cells[3].Value.ToString();
            TxtPasswordForUpdate.Text = await PasswordCrypto.DecryptAsync(Key, DgvValues.CurrentRow.Cells[4].Value.ToString());
            DtpCreateDate.Text = DgvValues.CurrentRow.Cells[5].Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void BtnShowPasswordForAdd_Click(object sender, EventArgs e)
        {
            ShowHidePasswordForAdd();
        }

        private void ShowPasswordForAdd()
        {
            TxtPasswordForAdd.UseSystemPasswordChar = false;
            BtnShowPasswordForAdd.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
        }

        private void HidePasswordForAdd()
        {
            TxtPasswordForAdd.UseSystemPasswordChar = true;
            BtnShowPasswordForAdd.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
        }

        private void ShowHidePasswordForAdd()
        {
            if (TxtPasswordForAdd.UseSystemPasswordChar)
            {
                ShowPasswordForAdd();
            }
            else
            {
                HidePasswordForAdd();
            }
        }
        private void BtnShowPasswordForUpdate_Click(object sender, EventArgs e) => ShowHidePasswordForUpdate();

        private void BtnPasswordGenerateForAdd_Click(object sender, EventArgs e)
        {
            ShowPasswordForAdd();
            TxtPasswordForAdd.Text = PasswordGenerator.GenerateRandomPassword((int)NumUpDownGeneratePasswordCountForAdd.Value);
        }
        private void BtnPasswordGenerateForUpdate_Click(object sender, EventArgs e)
        {
            ShowPasswordForUpdate();
            TxtPasswordForUpdate.Text = PasswordGenerator.GenerateRandomPassword((int)NumUpDownGeneratePasswordCountForUpdate.Value);
        }

        private void ShowHidePasswordForUpdate()
        {
            if (TxtPasswordForUpdate.UseSystemPasswordChar)
            {
                ShowPasswordForUpdate();
            }
            else
            {
                HidePasswordForUpdate();
            }
        }
        private void ShowPasswordForUpdate()
        {
            TxtPasswordForUpdate.UseSystemPasswordChar = false;
            BtnShowPasswordForUpdate.Image = Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
        }

        private void HidePasswordForUpdate()
        {
            TxtPasswordForUpdate.UseSystemPasswordChar = true;
            BtnShowPasswordForUpdate.Image = Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
        }

        private void BtnClearForTxtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            TextBoxClearForUpdate();
        }
    }
}
