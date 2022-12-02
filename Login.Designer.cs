namespace Parola_Yoneticisi
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.CbShowGoster = new System.Windows.Forms.CheckBox();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.CbShowGoster);
            this.groupBox1.Controls.Add(this.TxtParola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(31, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(436, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Ekleme";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Silver;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnLogin.Location = new System.Drawing.Point(54, 177);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(304, 47);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // CbShowGoster
            // 
            this.CbShowGoster.AutoSize = true;
            this.CbShowGoster.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CbShowGoster.Location = new System.Drawing.Point(163, 135);
            this.CbShowGoster.Margin = new System.Windows.Forms.Padding(4);
            this.CbShowGoster.Name = "CbShowGoster";
            this.CbShowGoster.Size = new System.Drawing.Size(77, 24);
            this.CbShowGoster.TabIndex = 4;
            this.CbShowGoster.Text = "Göster";
            this.CbShowGoster.UseVisualStyleBackColor = true;
            this.CbShowGoster.CheckedChanged += new System.EventHandler(this.CbShow_CheckedChanged);
            // 
            // TxtParola
            // 
            this.TxtParola.BackColor = System.Drawing.Color.Silver;
            this.TxtParola.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtParola.Location = new System.Drawing.Point(54, 89);
            this.TxtParola.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Size = new System.Drawing.Size(304, 26);
            this.TxtParola.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(166, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parolanız";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(501, 295);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox CbShowGoster;
        private System.Windows.Forms.TextBox TxtParola;
        private System.Windows.Forms.Label label2;
    }
}