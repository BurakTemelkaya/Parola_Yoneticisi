namespace Parola_Yoneticisi
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.BtnShowPasswordForOldPassword = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.TxtOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.TxtNewPasswordApprove = new System.Windows.Forms.TextBox();
            this.BtnShowPasswordForNewPassword = new System.Windows.Forms.Button();
            this.BtnShowPasswordForNewPasswordApprove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowPasswordForOldPassword
            // 
            this.BtnShowPasswordForOldPassword.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPasswordForOldPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.BtnShowPasswordForOldPassword, "BtnShowPasswordForOldPassword");
            this.BtnShowPasswordForOldPassword.Name = "BtnShowPasswordForOldPassword";
            this.BtnShowPasswordForOldPassword.UseVisualStyleBackColor = false;
            this.BtnShowPasswordForOldPassword.Click += new System.EventHandler(this.BtnShowPasswordForOldPassword_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Silver;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.BtnRefresh, "BtnRefresh");
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.BackColor = System.Drawing.Color.Silver;
            this.TxtOldPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.TxtOldPassword, "TxtOldPassword");
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BackColor = System.Drawing.Color.Silver;
            this.TxtNewPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.TxtNewPassword, "TxtNewPassword");
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.UseSystemPasswordChar = true;
            // 
            // TxtNewPasswordApprove
            // 
            this.TxtNewPasswordApprove.BackColor = System.Drawing.Color.Silver;
            this.TxtNewPasswordApprove.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.TxtNewPasswordApprove, "TxtNewPasswordApprove");
            this.TxtNewPasswordApprove.Name = "TxtNewPasswordApprove";
            this.TxtNewPasswordApprove.UseSystemPasswordChar = true;
            // 
            // BtnShowPasswordForNewPassword
            // 
            this.BtnShowPasswordForNewPassword.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPasswordForNewPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.BtnShowPasswordForNewPassword, "BtnShowPasswordForNewPassword");
            this.BtnShowPasswordForNewPassword.Name = "BtnShowPasswordForNewPassword";
            this.BtnShowPasswordForNewPassword.UseVisualStyleBackColor = false;
            this.BtnShowPasswordForNewPassword.Click += new System.EventHandler(this.BtnShowPasswordForNewPassword_Click);
            // 
            // BtnShowPasswordForNewPasswordApprove
            // 
            this.BtnShowPasswordForNewPasswordApprove.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPasswordForNewPasswordApprove.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.BtnShowPasswordForNewPasswordApprove, "BtnShowPasswordForNewPasswordApprove");
            this.BtnShowPasswordForNewPasswordApprove.Name = "BtnShowPasswordForNewPasswordApprove";
            this.BtnShowPasswordForNewPasswordApprove.UseVisualStyleBackColor = false;
            this.BtnShowPasswordForNewPasswordApprove.Click += new System.EventHandler(this.BtnShowPasswordForNewPasswordApprove_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Name = "label3";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Silver;
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ResetPasswordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnShowPasswordForNewPasswordApprove);
            this.Controls.Add(this.BtnShowPasswordForNewPassword);
            this.Controls.Add(this.TxtNewPasswordApprove);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.BtnShowPasswordForOldPassword);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.TxtOldPassword);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ResetPasswordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPasswordForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowPasswordForOldPassword;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox TxtOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.TextBox TxtNewPasswordApprove;
        private System.Windows.Forms.Button BtnShowPasswordForNewPassword;
        private System.Windows.Forms.Button BtnShowPasswordForNewPasswordApprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
    }
}