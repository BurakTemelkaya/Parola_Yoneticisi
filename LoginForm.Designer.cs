namespace Parola_Yoneticisi
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnResetPassword = new System.Windows.Forms.Button();
            this.BtnShowPassword = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.BtnResetPassword);
            this.groupBox1.Controls.Add(this.BtnShowPassword);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BtnResetPassword
            // 
            resources.ApplyResources(this.BtnResetPassword, "BtnResetPassword");
            this.BtnResetPassword.BackColor = System.Drawing.Color.Silver;
            this.BtnResetPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnResetPassword.Name = "BtnResetPassword";
            this.BtnResetPassword.UseVisualStyleBackColor = false;
            this.BtnResetPassword.Click += new System.EventHandler(this.BtnResetPassword_Click);
            // 
            // BtnShowPassword
            // 
            resources.ApplyResources(this.BtnShowPassword, "BtnShowPassword");
            this.BtnShowPassword.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.UseVisualStyleBackColor = false;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // BtnLogin
            // 
            resources.ApplyResources(this.BtnLogin, "BtnLogin");
            this.BtnLogin.BackColor = System.Drawing.Color.Silver;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            resources.ApplyResources(this.TxtPassword, "TxtPassword");
            this.TxtPassword.BackColor = System.Drawing.Color.Silver;
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPassword.Name = "TxtPassword";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnShowPassword;
        private System.Windows.Forms.Button BtnResetPassword;
    }
}