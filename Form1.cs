using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sifre_Tutma_Programi.Models;

namespace Sifre_Tutma_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            txtGuncelleSifre.UseSystemPasswordChar = true;
            Listele();
        }

        private void cbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                cbSifreGoster.Text = "Gizle";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                cbSifreGoster.Text = "Göster";
            }
        }

        private void Listele()
        {
            using (SifreEntities sifre = new SifreEntities())
            {
                var liste = sifre.Sifrelers.ToList();
                dgvDegerler.DataSource = liste;
            }
        }

        private void Ara(string deger)
        {
            using (SifreEntities sifreEntites = new SifreEntities())
            {
                var sifre = sifreEntites.Sifrelers.AsNoTracking().Where(t => t.Ad.Contains(deger)).ToList();
                dgvDegerler.DataSource = sifre;
            }
        }
        private void Ekle(string ad, string sifre, string kullaniciAdi)
        {
            using (SifreEntities sifreEntites = new SifreEntities())
            {
                Sifreler sifreler = new Sifreler
                {
                    Ad = ad,
                    Sifre = sifre,
                    Kullanici_Adi_E_Posta = kullaniciAdi,
                    Olusturulma_Zamani = DateTime.Now,
                };
                sifreEntites.Sifrelers.Add(sifreler);
                sifreEntites.SaveChanges();
                Listele();
                MessageBox.Show("Şifre Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkleTextBoxlariTemizle();
            }
        }
        private void btnSifreEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSifre.Text != "" && txtKullaniciAdi.Text!="")
            {
                Ekle(txtAd.Text, txtSifre.Text , txtKullaniciAdi.Text);
            }
            else if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen Sitenin Adını Boş Bırakmayınız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Şifreyi Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKullaniciAdi.Text=="")
            {
                MessageBox.Show("Lütfen Kullanıcı adı veya E-postayı boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int dgItemBul()
        {
            int id = 0;
            foreach (DataGridViewRow item in dgvDegerler.SelectedRows)
            {
                id = Convert.ToInt32(item.Cells[0].Value);
            }
            return id;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Ara(txtAra.Text);
        }
        private void Sil()
        {
            int id = dgItemBul();
            if (id != 0)
            {
                using (SifreEntities sifreEntites = new SifreEntities())
                {
                    sifreEntites.Sifrelers.Remove(sifreEntites.Sifrelers.Find(id));
                    sifreEntites.SaveChanges();
                    Listele();
                    MessageBox.Show("Silme işlemi başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("İşlem Yapılamadı, Lütfen Kayıt Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçilen Şifrenin Kaydını Silmek istediğinize Emin misiniz", "Şifre Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Sil();
            }
            else
            {
                MessageBox.Show("İşlem Yapılmadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGoster.Checked)
            {
                txtGuncelleSifre.UseSystemPasswordChar = false;
                cbGoster.Text = "Gizle";
            }
            else
            {
                txtGuncelleSifre.UseSystemPasswordChar = true;
                cbGoster.Text = "Göster";
            }
        }
        private void Guncelle(string ad, string KullaniciAdi, string sifre)
        {
            using (SifreEntities db = new SifreEntities())
            {
                int ID = dgItemBul();
                if (ID > 0)
                {
                    var guncelle = db.Sifrelers.Where(w => w.SifreID == ID).FirstOrDefault();
                    guncelle.Ad = ad;
                    guncelle.Sifre = sifre;
                    guncelle.Kullanici_Adi_E_Posta = KullaniciAdi;
                    guncelle.Degistirme_Zamani = DateTime.Now;
                    db.SaveChanges();
                    Listele();
                    MessageBox.Show("İşlem Başarılı " + guncelle.Ad + " Adlı şifre güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuncelleTextBoxlariTemizle();
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGuncelleAdi.Text!="" && txtGuncelleKullaniciAdi.Text!="" && txtGuncelleSifre.Text!="")
            {
                Guncelle(txtGuncelleAdi.Text, txtGuncelleKullaniciAdi.Text, txtGuncelleSifre.Text);
            }
            else if(txtGuncelleAdi.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Adını Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGuncelleKullaniciAdi.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Kullanıcı Adını veya E-Postasını boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenen Kaydın Şifresini boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDegerler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelleAdi.Text = dgvDegerler.CurrentRow.Cells[1].Value.ToString();
            txtGuncelleKullaniciAdi.Text = dgvDegerler.CurrentRow.Cells[2].Value.ToString();
            txtGuncelleSifre.Text = dgvDegerler.CurrentRow.Cells[3].Value.ToString();            
            txtZaman.Text = dgvDegerler.CurrentRow.Cells[4].Value.ToString();
        }

        private void EkleTextBoxlariTemizle()
        {
            txtAd.Clear();
            txtSifre.Clear();
            txtKullaniciAdi.Clear();
        }
        private void GuncelleTextBoxlariTemizle()
        {
            txtGuncelleAdi.Clear();
            txtGuncelleSifre.Clear();
            txtGuncelleKullaniciAdi.Clear();
            txtZaman.Clear();
        }

        private void dgvDegerler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void btnEkleTemizle_Click(object sender, EventArgs e)
        {
            EkleTextBoxlariTemizle();
        }

        private void btnGuncelleTemizle_Click(object sender, EventArgs e)
        {
            GuncelleTextBoxlariTemizle();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (dgvDegerler.SelectedRows.Count > 0)
            {
                Clipboard.SetText(dgvDegerler.CurrentRow.Cells[3].Value.ToString());
                string cikti = string.Format("{0} Adlı Şifre Panoya Kopyalandı",dgvDegerler.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show(cikti, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Kopyalanacak Şifreyi Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPanoTemizle_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            MessageBox.Show("Kopyalama Panosu Temizlendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
