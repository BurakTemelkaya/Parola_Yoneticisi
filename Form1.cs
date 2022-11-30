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
        static string key = "123";
        private async void Form1_Load(object sender, EventArgs e)
        {
            TxtSifre.UseSystemPasswordChar = true;
            txtGuncelleSifre.UseSystemPasswordChar = true;
            await Listele();
        }

        private void CbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster.Checked)
            {
                TxtSifre.UseSystemPasswordChar = false;
                cbSifreGoster.Text = "Gizle";
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
                cbSifreGoster.Text = "Göster";
            }
        }

        private async Task Listele()
        {
            using (SifreEntities sifre = new SifreEntities())
            {
                var liste = await sifre.Sifrelers.ToListAsync();
                DgvDegerler.DataSource = liste;
            }
        }

        private async Task Ara(string deger)
        {
            using (SifreEntities sifreEntites = new SifreEntities())
            {
                var sifre = await sifreEntites.Sifrelers.AsNoTracking().Where(t => t.Ad.Contains(deger)).ToListAsync();
                DgvDegerler.DataSource = sifre;
            }
        }
        private async Task Ekle(string ad, string sifre, string kullaniciAdi)
        {
            using (SifreEntities sifreEntites = new SifreEntities())
            {
                Sifreler sifreler = new Sifreler
                {
                    Ad = ad,
                    Sifre = await PasswordCrypto.EncryptAsync(key, sifre),
                    Kullanici_Adi_E_Posta = kullaniciAdi,
                    Olusturulma_Zamani = DateTime.Now,
                };
                sifreEntites.Sifrelers.Add(sifreler);
                await sifreEntites.SaveChangesAsync();
                await Listele();
                MessageBox.Show("Şifre Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkleTextBoxlariTemizle();
            }
        }
        private async void BtnSifreEkle_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtSifre.Text != "" && TxtKullaniciAdi.Text != "")
            {
                await Ekle(TxtAd.Text, TxtSifre.Text, TxtKullaniciAdi.Text);
            }
            else if (TxtAd.Text == "")
            {
                MessageBox.Show("Lütfen Sitenin Adını Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Şifreyi Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtKullaniciAdi.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı adı veya E-postayı boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DgItemBul()
        {
            try
            {
                return Convert.ToInt32(DgvDegerler.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                return 0;
            }
        }

        private async void TxtAra_TextChanged(object sender, EventArgs e)
        {
            await Ara(txtAra.Text);
        }
        private async Task Sil()
        {
            int id = DgItemBul();
            if (id != 0)
            {
                using (SifreEntities sifreEntites = new SifreEntities())
                {
                    sifreEntites.Sifrelers.Remove(await sifreEntites.Sifrelers.FindAsync(id));
                    await sifreEntites.SaveChangesAsync();
                    await Listele();
                    MessageBox.Show("Silme işlemi başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("İşlem Yapılamadı, Lütfen Kayıt Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçilen Şifrenin Kaydını Silmek istediğinize Emin misiniz", "Şifre Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                await Sil();
            }

        }

        private void CbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (CbGoster.Checked)
            {
                txtGuncelleSifre.UseSystemPasswordChar = false;
                CbGoster.Text = "Gizle";
            }
            else
            {
                txtGuncelleSifre.UseSystemPasswordChar = true;
                CbGoster.Text = "Göster";
            }
        }
        private async Task Guncelle(string ad, string KullaniciAdi, string sifre)
        {
            using (SifreEntities db = new SifreEntities())
            {
                int ID = DgItemBul();
                if (ID > 0)
                {
                    var guncelle = db.Sifrelers.Where(w => w.SifreID == ID).FirstOrDefault();
                    guncelle.Ad = ad;
                    guncelle.Sifre = await PasswordCrypto.EncryptAsync(key, sifre);
                    guncelle.Kullanici_Adi_E_Posta = KullaniciAdi;
                    guncelle.Degistirme_Zamani = DateTime.Now;
                    await db.SaveChangesAsync();
                    await Listele();
                    MessageBox.Show("İşlem Başarılı " + guncelle.Ad + " Adlı şifre güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuncelleTextBoxlariTemizle();
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGuncelleAdi.Text != "" && txtGuncelleKullaniciAdi.Text != "" && txtGuncelleSifre.Text != "")
            {
                await Guncelle(txtGuncelleAdi.Text, txtGuncelleKullaniciAdi.Text, txtGuncelleSifre.Text);
            }
            else if (txtGuncelleAdi.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Adını Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGuncelleKullaniciAdi.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Kullanıcı Adını veya E-Postasını boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Şifresini boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EkleTextBoxlariTemizle()
        {
            TxtAd.Clear();
            TxtSifre.Clear();
            TxtKullaniciAdi.Clear();
        }
        private void GuncelleTextBoxlariTemizle()
        {
            txtGuncelleAdi.Clear();
            txtGuncelleSifre.Clear();
            txtGuncelleKullaniciAdi.Clear();
            txtZaman.Clear();
        }

        private void DgvDegerler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void BtnEkleTemizle_Click(object sender, EventArgs e) => EkleTextBoxlariTemizle();

        private void BtnGuncelleTemizle_Click(object sender, EventArgs e) => GuncelleTextBoxlariTemizle();

        private async void BtnKopyala_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(await PasswordCrypto.DecryptAsync(key, DgvDegerler.CurrentRow.Cells[3].Value.ToString()));
            }
            catch
            {
                MessageBox.Show("Lütfen Kopyalanacak Parolayı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cikti = string.Format("{0} Adlı Şifre Panoya Kopyalandı", DgvDegerler.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show(cikti, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnKullaniciAdiniKopyala_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(DgvDegerler.CurrentRow.Cells[2].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Lütfen Kopyalanacak Parolayı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cikti = string.Format("{0} Adlı Kullanıcı Adı Panoya Kopyalandı", DgvDegerler.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show(cikti, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void DgvDegerler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelleAdi.Text = DgvDegerler.CurrentRow.Cells[1].Value.ToString();
            txtGuncelleKullaniciAdi.Text = DgvDegerler.CurrentRow.Cells[2].Value.ToString();
            txtGuncelleSifre.Text = await PasswordCrypto.DecryptAsync(key, DgvDegerler.CurrentRow.Cells[3].Value.ToString());
            txtZaman.Text = DgvDegerler.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
