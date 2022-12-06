
namespace Parola_Yoneticisi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPasswordNameForAdd = new System.Windows.Forms.TextBox();
            this.TxtPasswordForAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRandomPasswordGenerator = new System.Windows.Forms.Button();
            this.BtnShowPasswordForAdd = new System.Windows.Forms.Button();
            this.TxtUserNameForAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClearForAdd = new System.Windows.Forms.Button();
            this.BtnPasswordAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCopyUserName = new System.Windows.Forms.Button();
            this.BtnCopyPassword = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnShowPasswordForUpdate = new System.Windows.Forms.Button();
            this.txtUserNameForUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnClearForUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtNameForUpdate = new System.Windows.Forms.TextBox();
            this.TxtPasswordForUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvValues = new System.Windows.Forms.DataGridView();
            this.DtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvValues)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parolanın Adı";
            // 
            // TxtPasswordNameForAdd
            // 
            this.TxtPasswordNameForAdd.BackColor = System.Drawing.Color.Silver;
            this.TxtPasswordNameForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPasswordNameForAdd.Location = new System.Drawing.Point(45, 61);
            this.TxtPasswordNameForAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPasswordNameForAdd.Name = "TxtPasswordNameForAdd";
            this.TxtPasswordNameForAdd.Size = new System.Drawing.Size(203, 26);
            this.TxtPasswordNameForAdd.TabIndex = 1;
            // 
            // TxtPasswordForAdd
            // 
            this.TxtPasswordForAdd.BackColor = System.Drawing.Color.Silver;
            this.TxtPasswordForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPasswordForAdd.Location = new System.Drawing.Point(45, 221);
            this.TxtPasswordForAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPasswordForAdd.Name = "TxtPasswordForAdd";
            this.TxtPasswordForAdd.Size = new System.Drawing.Size(203, 26);
            this.TxtPasswordForAdd.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.BtnRandomPasswordGenerator);
            this.groupBox1.Controls.Add(this.BtnShowPasswordForAdd);
            this.groupBox1.Controls.Add(this.TxtUserNameForAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BtnClearForAdd);
            this.groupBox1.Controls.Add(this.BtnPasswordAdd);
            this.groupBox1.Controls.Add(this.TxtPasswordNameForAdd);
            this.groupBox1.Controls.Add(this.TxtPasswordForAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(39, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parola Ekleme";
            // 
            // BtnRandomPasswordGenerator
            // 
            this.BtnRandomPasswordGenerator.BackColor = System.Drawing.Color.Silver;
            this.BtnRandomPasswordGenerator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnRandomPasswordGenerator.Location = new System.Drawing.Point(309, 217);
            this.BtnRandomPasswordGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRandomPasswordGenerator.Name = "BtnRandomPasswordGenerator";
            this.BtnRandomPasswordGenerator.Size = new System.Drawing.Size(45, 35);
            this.BtnRandomPasswordGenerator.TabIndex = 9;
            this.BtnRandomPasswordGenerator.UseVisualStyleBackColor = false;
            this.BtnRandomPasswordGenerator.Click += new System.EventHandler(this.BtnRandomPasswordGenerator_Click);
            // 
            // BtnShowPasswordForAdd
            // 
            this.BtnShowPasswordForAdd.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPasswordForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnShowPasswordForAdd.Location = new System.Drawing.Point(256, 217);
            this.BtnShowPasswordForAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowPasswordForAdd.Name = "BtnShowPasswordForAdd";
            this.BtnShowPasswordForAdd.Size = new System.Drawing.Size(45, 35);
            this.BtnShowPasswordForAdd.TabIndex = 8;
            this.BtnShowPasswordForAdd.UseVisualStyleBackColor = false;
            this.BtnShowPasswordForAdd.Click += new System.EventHandler(this.BtnShowPasswordForAdd_Click);
            // 
            // TxtUserNameForAdd
            // 
            this.TxtUserNameForAdd.BackColor = System.Drawing.Color.Silver;
            this.TxtUserNameForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtUserNameForAdd.Location = new System.Drawing.Point(45, 147);
            this.TxtUserNameForAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUserNameForAdd.Name = "TxtUserNameForAdd";
            this.TxtUserNameForAdd.Size = new System.Drawing.Size(203, 26);
            this.TxtUserNameForAdd.TabIndex = 2;
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
            // BtnClearForAdd
            // 
            this.BtnClearForAdd.BackColor = System.Drawing.Color.Silver;
            this.BtnClearForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnClearForAdd.Location = new System.Drawing.Point(205, 275);
            this.BtnClearForAdd.Name = "BtnClearForAdd";
            this.BtnClearForAdd.Size = new System.Drawing.Size(115, 31);
            this.BtnClearForAdd.TabIndex = 5;
            this.BtnClearForAdd.Text = "Temizle";
            this.BtnClearForAdd.UseVisualStyleBackColor = false;
            this.BtnClearForAdd.Click += new System.EventHandler(this.BtnClearForAdd_Click);
            // 
            // BtnPasswordAdd
            // 
            this.BtnPasswordAdd.BackColor = System.Drawing.Color.Silver;
            this.BtnPasswordAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnPasswordAdd.Location = new System.Drawing.Point(45, 275);
            this.BtnPasswordAdd.Name = "BtnPasswordAdd";
            this.BtnPasswordAdd.Size = new System.Drawing.Size(115, 31);
            this.BtnPasswordAdd.TabIndex = 4;
            this.BtnPasswordAdd.Text = "Parola Ekle";
            this.BtnPasswordAdd.UseVisualStyleBackColor = false;
            this.BtnPasswordAdd.Click += new System.EventHandler(this.BtnPasswordAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.BtnCopyUserName);
            this.groupBox2.Controls.Add(this.BtnCopyPassword);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DgvValues);
            this.groupBox2.Location = new System.Drawing.Point(77, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 685);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreleri Görüntüle";
            // 
            // BtnCopyUserName
            // 
            this.BtnCopyUserName.BackColor = System.Drawing.Color.Silver;
            this.BtnCopyUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnCopyUserName.Location = new System.Drawing.Point(574, 267);
            this.BtnCopyUserName.Name = "BtnCopyUserName";
            this.BtnCopyUserName.Size = new System.Drawing.Size(212, 44);
            this.BtnCopyUserName.TabIndex = 2;
            this.BtnCopyUserName.Text = "Kullanıcı Adını Kopyala";
            this.BtnCopyUserName.UseVisualStyleBackColor = false;
            this.BtnCopyUserName.Click += new System.EventHandler(this.BtnCopyUserName_Click);
            // 
            // BtnCopyPassword
            // 
            this.BtnCopyPassword.BackColor = System.Drawing.Color.Silver;
            this.BtnCopyPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnCopyPassword.Location = new System.Drawing.Point(306, 267);
            this.BtnCopyPassword.Name = "BtnCopyPassword";
            this.BtnCopyPassword.Size = new System.Drawing.Size(247, 44);
            this.BtnCopyPassword.TabIndex = 1;
            this.BtnCopyPassword.Text = "Seçilen Parolayı Panoya Kopyala";
            this.BtnCopyPassword.UseVisualStyleBackColor = false;
            this.BtnCopyPassword.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.DtpCreateDate);
            this.groupBox3.Controls.Add(this.BtnShowPasswordForUpdate);
            this.groupBox3.Controls.Add(this.txtUserNameForUpdate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BtnClearForUpdate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.BtnUpdate);
            this.groupBox3.Controls.Add(this.TxtNameForUpdate);
            this.groupBox3.Controls.Add(this.TxtPasswordForUpdate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(431, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 330);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şifre Güncelleme";
            // 
            // BtnShowPasswordForUpdate
            // 
            this.BtnShowPasswordForUpdate.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPasswordForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnShowPasswordForUpdate.Location = new System.Drawing.Point(133, 217);
            this.BtnShowPasswordForUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowPasswordForUpdate.Name = "BtnShowPasswordForUpdate";
            this.BtnShowPasswordForUpdate.Size = new System.Drawing.Size(45, 35);
            this.BtnShowPasswordForUpdate.TabIndex = 9;
            this.BtnShowPasswordForUpdate.UseVisualStyleBackColor = false;
            this.BtnShowPasswordForUpdate.Click += new System.EventHandler(this.BtnShowPasswordForUpdate_Click);
            // 
            // txtUserNameForUpdate
            // 
            this.txtUserNameForUpdate.BackColor = System.Drawing.Color.Silver;
            this.txtUserNameForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserNameForUpdate.Location = new System.Drawing.Point(39, 92);
            this.txtUserNameForUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserNameForUpdate.Name = "txtUserNameForUpdate";
            this.txtUserNameForUpdate.Size = new System.Drawing.Size(230, 26);
            this.txtUserNameForUpdate.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(338, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kullanıcı Adı / E-Posta";
            // 
            // BtnClearForUpdate
            // 
            this.BtnClearForUpdate.BackColor = System.Drawing.Color.Silver;
            this.BtnClearForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnClearForUpdate.Location = new System.Drawing.Point(56, 269);
            this.BtnClearForUpdate.Name = "BtnClearForUpdate";
            this.BtnClearForUpdate.Size = new System.Drawing.Size(199, 31);
            this.BtnClearForUpdate.TabIndex = 6;
            this.BtnClearForUpdate.Text = "Temizle";
            this.BtnClearForUpdate.UseVisualStyleBackColor = false;
            this.BtnClearForUpdate.Click += new System.EventHandler(this.BtnClearForUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(347, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Oluşturulma Tarihi";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Silver;
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnUpdate.Location = new System.Drawing.Point(317, 237);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(199, 63);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Parolayı Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnSifreGuncelle_Click);
            // 
            // TxtNameForUpdate
            // 
            this.TxtNameForUpdate.BackColor = System.Drawing.Color.Silver;
            this.TxtNameForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNameForUpdate.Location = new System.Drawing.Point(301, 92);
            this.TxtNameForUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNameForUpdate.Name = "TxtNameForUpdate";
            this.TxtNameForUpdate.Size = new System.Drawing.Size(230, 26);
            this.TxtNameForUpdate.TabIndex = 1;
            // 
            // TxtPasswordForUpdate
            // 
            this.TxtPasswordForUpdate.BackColor = System.Drawing.Color.Silver;
            this.TxtPasswordForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPasswordForUpdate.Location = new System.Drawing.Point(39, 174);
            this.TxtPasswordForUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPasswordForUpdate.Name = "TxtPasswordForUpdate";
            this.TxtPasswordForUpdate.Size = new System.Drawing.Size(230, 26);
            this.TxtPasswordForUpdate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(109, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parolanın Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(129, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parola";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Silver;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnDelete.Location = new System.Drawing.Point(806, 267);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(174, 44);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Seçilen Parolayı Sİl";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Location = new System.Drawing.Point(50, 287);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(78, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ada Göre Parola Ara";
            // 
            // DgvValues
            // 
            this.DgvValues.AllowUserToAddRows = false;
            this.DgvValues.AllowUserToDeleteRows = false;
            this.DgvValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvValues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvValues.Location = new System.Drawing.Point(39, 25);
            this.DgvValues.MultiSelect = false;
            this.DgvValues.Name = "DgvValues";
            this.DgvValues.ReadOnly = true;
            this.DgvValues.Size = new System.Drawing.Size(957, 221);
            this.DgvValues.TabIndex = 0;
            this.DgvValues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvValues_CellClick);
            // 
            // DtpCreateDate
            // 
            this.DtpCreateDate.Location = new System.Drawing.Point(301, 174);
            this.DtpCreateDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DtpCreateDate.Name = "DtpCreateDate";
            this.DtpCreateDate.Size = new System.Drawing.Size(230, 26);
            this.DtpCreateDate.TabIndex = 10;
            // 
            // MainForm
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Yöneticisi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPasswordNameForAdd;
        private System.Windows.Forms.TextBox TxtPasswordForAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPasswordAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtNameForUpdate;
        private System.Windows.Forms.TextBox TxtPasswordForUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClearForAdd;
        private System.Windows.Forms.Button BtnClearForUpdate;
        private System.Windows.Forms.TextBox TxtUserNameForAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserNameForUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCopyUserName;
        private System.Windows.Forms.Button BtnCopyPassword;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvValues;
        private System.Windows.Forms.Button BtnShowPasswordForAdd;
        private System.Windows.Forms.Button BtnShowPasswordForUpdate;
        private System.Windows.Forms.Button BtnRandomPasswordGenerator;
        private System.Windows.Forms.DateTimePicker DtpCreateDate;
    }
}

