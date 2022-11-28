
namespace Sifre_Tutma_Programi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkleTemizle = new System.Windows.Forms.Button();
            this.btnSifreEkle = new System.Windows.Forms.Button();
            this.cbSifreGoster = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKullaniciAdiniKopyala = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGuncelleKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuncelleTemizle = new System.Windows.Forms.Button();
            this.txtZaman = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.cbGoster = new System.Windows.Forms.CheckBox();
            this.txtGuncelleAdi = new System.Windows.Forms.TextBox();
            this.txtGuncelleSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDegerler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrenin Adı";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Silver;
            this.txtAd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAd.Location = new System.Drawing.Point(45, 61);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(203, 26);
            this.txtAd.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Silver;
            this.txtSifre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSifre.Location = new System.Drawing.Point(45, 221);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(203, 26);
            this.txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(115, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEkleTemizle);
            this.groupBox1.Controls.Add(this.btnSifreEkle);
            this.groupBox1.Controls.Add(this.cbSifreGoster);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(39, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Ekleme";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Silver;
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(45, 147);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(203, 26);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(69, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kullanıcı Adı / E-Posta";
            // 
            // btnEkleTemizle
            // 
            this.btnEkleTemizle.BackColor = System.Drawing.Color.Silver;
            this.btnEkleTemizle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEkleTemizle.Location = new System.Drawing.Point(205, 275);
            this.btnEkleTemizle.Name = "btnEkleTemizle";
            this.btnEkleTemizle.Size = new System.Drawing.Size(115, 31);
            this.btnEkleTemizle.TabIndex = 5;
            this.btnEkleTemizle.Text = "Temizle";
            this.btnEkleTemizle.UseVisualStyleBackColor = false;
            this.btnEkleTemizle.Click += new System.EventHandler(this.btnEkleTemizle_Click);
            // 
            // btnSifreEkle
            // 
            this.btnSifreEkle.BackColor = System.Drawing.Color.Silver;
            this.btnSifreEkle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSifreEkle.Location = new System.Drawing.Point(45, 275);
            this.btnSifreEkle.Name = "btnSifreEkle";
            this.btnSifreEkle.Size = new System.Drawing.Size(115, 31);
            this.btnSifreEkle.TabIndex = 4;
            this.btnSifreEkle.Text = "Parola Ekle";
            this.btnSifreEkle.UseVisualStyleBackColor = false;
            this.btnSifreEkle.Click += new System.EventHandler(this.btnSifreEkle_Click);
            // 
            // cbSifreGoster
            // 
            this.cbSifreGoster.AutoSize = true;
            this.cbSifreGoster.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbSifreGoster.Location = new System.Drawing.Point(273, 221);
            this.cbSifreGoster.Name = "cbSifreGoster";
            this.cbSifreGoster.Size = new System.Drawing.Size(77, 24);
            this.cbSifreGoster.TabIndex = 4;
            this.cbSifreGoster.Text = "Göster";
            this.cbSifreGoster.UseVisualStyleBackColor = true;
            this.cbSifreGoster.CheckedChanged += new System.EventHandler(this.cbSifreGoster_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.btnKullaniciAdiniKopyala);
            this.groupBox2.Controls.Add(this.btnKopyala);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvDegerler);
            this.groupBox2.Location = new System.Drawing.Point(77, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 685);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreleri Görüntüle";
            // 
            // btnKullaniciAdiniKopyala
            // 
            this.btnKullaniciAdiniKopyala.BackColor = System.Drawing.Color.Silver;
            this.btnKullaniciAdiniKopyala.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnKullaniciAdiniKopyala.Location = new System.Drawing.Point(505, 267);
            this.btnKullaniciAdiniKopyala.Name = "btnKullaniciAdiniKopyala";
            this.btnKullaniciAdiniKopyala.Size = new System.Drawing.Size(270, 44);
            this.btnKullaniciAdiniKopyala.TabIndex = 2;
            this.btnKullaniciAdiniKopyala.Text = "Kullanıcı Adı / E Postayı Kopyala";
            this.btnKullaniciAdiniKopyala.UseVisualStyleBackColor = false;
            this.btnKullaniciAdiniKopyala.Click += new System.EventHandler(this.btnKullaniciAdiniKopyala_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.BackColor = System.Drawing.Color.Silver;
            this.btnKopyala.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnKopyala.Location = new System.Drawing.Point(234, 267);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(247, 44);
            this.btnKopyala.TabIndex = 1;
            this.btnKopyala.Text = "Seçilen Parolayı Panoya Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = false;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.txtGuncelleKullaniciAdi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnGuncelleTemizle);
            this.groupBox3.Controls.Add(this.txtZaman);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSifreGuncelle);
            this.groupBox3.Controls.Add(this.cbGoster);
            this.groupBox3.Controls.Add(this.txtGuncelleAdi);
            this.groupBox3.Controls.Add(this.txtGuncelleSifre);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(431, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 330);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şifre Güncelleme";
            // 
            // txtGuncelleKullaniciAdi
            // 
            this.txtGuncelleKullaniciAdi.BackColor = System.Drawing.Color.Silver;
            this.txtGuncelleKullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGuncelleKullaniciAdi.Location = new System.Drawing.Point(328, 92);
            this.txtGuncelleKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuncelleKullaniciAdi.Name = "txtGuncelleKullaniciAdi";
            this.txtGuncelleKullaniciAdi.Size = new System.Drawing.Size(155, 26);
            this.txtGuncelleKullaniciAdi.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(324, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kullanıcı Adı / E-Posta";
            // 
            // btnGuncelleTemizle
            // 
            this.btnGuncelleTemizle.BackColor = System.Drawing.Color.Silver;
            this.btnGuncelleTemizle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuncelleTemizle.Location = new System.Drawing.Point(325, 275);
            this.btnGuncelleTemizle.Name = "btnGuncelleTemizle";
            this.btnGuncelleTemizle.Size = new System.Drawing.Size(158, 31);
            this.btnGuncelleTemizle.TabIndex = 6;
            this.btnGuncelleTemizle.Text = "Temizle";
            this.btnGuncelleTemizle.UseVisualStyleBackColor = false;
            this.btnGuncelleTemizle.Click += new System.EventHandler(this.btnGuncelleTemizle_Click);
            // 
            // txtZaman
            // 
            this.txtZaman.BackColor = System.Drawing.Color.Silver;
            this.txtZaman.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtZaman.Location = new System.Drawing.Point(325, 175);
            this.txtZaman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZaman.Name = "txtZaman";
            this.txtZaman.Size = new System.Drawing.Size(155, 26);
            this.txtZaman.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(335, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Oluşturulma Tarihi";
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnSifreGuncelle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSifreGuncelle.Location = new System.Drawing.Point(61, 275);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(155, 31);
            this.btnSifreGuncelle.TabIndex = 5;
            this.btnSifreGuncelle.Text = "Parolayı Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = false;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // cbGoster
            // 
            this.cbGoster.AutoSize = true;
            this.cbGoster.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbGoster.Location = new System.Drawing.Point(97, 221);
            this.cbGoster.Name = "cbGoster";
            this.cbGoster.Size = new System.Drawing.Size(77, 24);
            this.cbGoster.TabIndex = 4;
            this.cbGoster.Text = "Göster";
            this.cbGoster.UseVisualStyleBackColor = true;
            this.cbGoster.CheckedChanged += new System.EventHandler(this.cbGoster_CheckedChanged);
            // 
            // txtGuncelleAdi
            // 
            this.txtGuncelleAdi.BackColor = System.Drawing.Color.Silver;
            this.txtGuncelleAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGuncelleAdi.Location = new System.Drawing.Point(53, 92);
            this.txtGuncelleAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuncelleAdi.Name = "txtGuncelleAdi";
            this.txtGuncelleAdi.Size = new System.Drawing.Size(155, 26);
            this.txtGuncelleAdi.TabIndex = 1;
            // 
            // txtGuncelleSifre
            // 
            this.txtGuncelleSifre.BackColor = System.Drawing.Color.Silver;
            this.txtGuncelleSifre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGuncelleSifre.Location = new System.Drawing.Point(55, 174);
            this.txtGuncelleSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuncelleSifre.Name = "txtGuncelleSifre";
            this.txtGuncelleSifre.Size = new System.Drawing.Size(155, 26);
            this.txtGuncelleSifre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(84, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifrenin Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(109, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifre";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSil.Location = new System.Drawing.Point(795, 267);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(174, 44);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Seçilen Parolayı Sİl";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.Silver;
            this.txtAra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAra.Location = new System.Drawing.Point(50, 287);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(155, 26);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(55, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ada Göre Parola Ara";
            // 
            // dgvDegerler
            // 
            this.dgvDegerler.AllowUserToAddRows = false;
            this.dgvDegerler.AllowUserToDeleteRows = false;
            this.dgvDegerler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDegerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDegerler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDegerler.Location = new System.Drawing.Point(39, 25);
            this.dgvDegerler.MultiSelect = false;
            this.dgvDegerler.Name = "dgvDegerler";
            this.dgvDegerler.ReadOnly = true;
            this.dgvDegerler.Size = new System.Drawing.Size(930, 221);
            this.dgvDegerler.TabIndex = 0;
            this.dgvDegerler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDegerler_CellDoubleClick);
            this.dgvDegerler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDegerler_CellFormatting);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Yöneticisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSifreGoster;
        private System.Windows.Forms.Button btnSifreEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.CheckBox cbGoster;
        private System.Windows.Forms.TextBox txtGuncelleAdi;
        private System.Windows.Forms.TextBox txtGuncelleSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZaman;
        private System.Windows.Forms.Button btnEkleTemizle;
        private System.Windows.Forms.Button btnGuncelleTemizle;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGuncelleKullaniciAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKullaniciAdiniKopyala;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDegerler;
    }
}

