
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
            this.NumUpDownGeneratePasswordCountForAdd = new System.Windows.Forms.NumericUpDown();
            this.BtnPasswordGenerateForAdd = new System.Windows.Forms.Button();
            this.BtnShowPasswordForAdd = new System.Windows.Forms.Button();
            this.TxtUserNameForAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClearForAdd = new System.Windows.Forms.Button();
            this.BtnPasswordAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClearForTxtSearch = new System.Windows.Forms.Button();
            this.BtnCopyUserName = new System.Windows.Forms.Button();
            this.BtnCopyPassword = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumUpDownGeneratePasswordCountForUpdate = new System.Windows.Forms.NumericUpDown();
            this.BtnPasswordGenerateForUpdate = new System.Windows.Forms.Button();
            this.DtpCreateDate = new System.Windows.Forms.DateTimePicker();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownGeneratePasswordCountForAdd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownGeneratePasswordCountForUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvValues)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            // 
            // TxtPasswordNameForAdd
            // 
            resources.ApplyResources(this.TxtPasswordNameForAdd, "TxtPasswordNameForAdd");
            this.TxtPasswordNameForAdd.BackColor = System.Drawing.Color.Silver;
            this.TxtPasswordNameForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPasswordNameForAdd.Name = "TxtPasswordNameForAdd";
            // 
            // TxtPasswordForAdd
            // 
            resources.ApplyResources(this.TxtPasswordForAdd, "TxtPasswordForAdd");
            this.TxtPasswordForAdd.BackColor = System.Drawing.Color.Silver;
            this.TxtPasswordForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPasswordForAdd.Name = "TxtPasswordForAdd";
            this.TxtPasswordForAdd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.NumUpDownGeneratePasswordCountForAdd);
            this.groupBox1.Controls.Add(this.BtnPasswordGenerateForAdd);
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // NumUpDownGeneratePasswordCountForAdd
            // 
            resources.ApplyResources(this.NumUpDownGeneratePasswordCountForAdd, "NumUpDownGeneratePasswordCountForAdd");
            this.NumUpDownGeneratePasswordCountForAdd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumUpDownGeneratePasswordCountForAdd.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumUpDownGeneratePasswordCountForAdd.Name = "NumUpDownGeneratePasswordCountForAdd";
            this.NumUpDownGeneratePasswordCountForAdd.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // BtnPasswordGenerateForAdd
            // 
            resources.ApplyResources(this.BtnPasswordGenerateForAdd, "BtnPasswordGenerateForAdd");
            this.BtnPasswordGenerateForAdd.BackColor = System.Drawing.Color.Silver;
            this.BtnPasswordGenerateForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnPasswordGenerateForAdd.Name = "BtnPasswordGenerateForAdd";
            this.BtnPasswordGenerateForAdd.UseVisualStyleBackColor = false;
            this.BtnPasswordGenerateForAdd.Click += new System.EventHandler(this.BtnPasswordGenerateForAdd_Click);
            // 
            // BtnShowPasswordForAdd
            // 
            resources.ApplyResources(this.BtnShowPasswordForAdd, "BtnShowPasswordForAdd");
            this.BtnShowPasswordForAdd.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPasswordForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnShowPasswordForAdd.Name = "BtnShowPasswordForAdd";
            this.BtnShowPasswordForAdd.UseVisualStyleBackColor = false;
            this.BtnShowPasswordForAdd.Click += new System.EventHandler(this.BtnShowPasswordForAdd_Click);
            // 
            // TxtUserNameForAdd
            // 
            resources.ApplyResources(this.TxtUserNameForAdd, "TxtUserNameForAdd");
            this.TxtUserNameForAdd.BackColor = System.Drawing.Color.Silver;
            this.TxtUserNameForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtUserNameForAdd.Name = "TxtUserNameForAdd";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Name = "label7";
            // 
            // BtnClearForAdd
            // 
            resources.ApplyResources(this.BtnClearForAdd, "BtnClearForAdd");
            this.BtnClearForAdd.BackColor = System.Drawing.Color.Silver;
            this.BtnClearForAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnClearForAdd.Name = "BtnClearForAdd";
            this.BtnClearForAdd.UseVisualStyleBackColor = false;
            this.BtnClearForAdd.Click += new System.EventHandler(this.BtnClearForAdd_Click);
            // 
            // BtnPasswordAdd
            // 
            resources.ApplyResources(this.BtnPasswordAdd, "BtnPasswordAdd");
            this.BtnPasswordAdd.BackColor = System.Drawing.Color.Silver;
            this.BtnPasswordAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnPasswordAdd.Name = "BtnPasswordAdd";
            this.BtnPasswordAdd.UseVisualStyleBackColor = false;
            this.BtnPasswordAdd.Click += new System.EventHandler(this.BtnPasswordAdd_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.BtnClearForTxtSearch);
            this.groupBox2.Controls.Add(this.BtnCopyUserName);
            this.groupBox2.Controls.Add(this.BtnCopyPassword);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DgvValues);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // BtnClearForTxtSearch
            // 
            resources.ApplyResources(this.BtnClearForTxtSearch, "BtnClearForTxtSearch");
            this.BtnClearForTxtSearch.BackColor = System.Drawing.Color.Silver;
            this.BtnClearForTxtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnClearForTxtSearch.Name = "BtnClearForTxtSearch";
            this.BtnClearForTxtSearch.UseVisualStyleBackColor = false;
            this.BtnClearForTxtSearch.Click += new System.EventHandler(this.BtnClearForTxtSearch_Click);
            // 
            // BtnCopyUserName
            // 
            resources.ApplyResources(this.BtnCopyUserName, "BtnCopyUserName");
            this.BtnCopyUserName.BackColor = System.Drawing.Color.Silver;
            this.BtnCopyUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnCopyUserName.Name = "BtnCopyUserName";
            this.BtnCopyUserName.UseVisualStyleBackColor = false;
            this.BtnCopyUserName.Click += new System.EventHandler(this.BtnCopyUserName_Click);
            // 
            // BtnCopyPassword
            // 
            resources.ApplyResources(this.BtnCopyPassword, "BtnCopyPassword");
            this.BtnCopyPassword.BackColor = System.Drawing.Color.Silver;
            this.BtnCopyPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnCopyPassword.Name = "BtnCopyPassword";
            this.BtnCopyPassword.UseVisualStyleBackColor = false;
            this.BtnCopyPassword.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.NumUpDownGeneratePasswordCountForUpdate);
            this.groupBox3.Controls.Add(this.BtnPasswordGenerateForUpdate);
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
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // NumUpDownGeneratePasswordCountForUpdate
            // 
            resources.ApplyResources(this.NumUpDownGeneratePasswordCountForUpdate, "NumUpDownGeneratePasswordCountForUpdate");
            this.NumUpDownGeneratePasswordCountForUpdate.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumUpDownGeneratePasswordCountForUpdate.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumUpDownGeneratePasswordCountForUpdate.Name = "NumUpDownGeneratePasswordCountForUpdate";
            this.NumUpDownGeneratePasswordCountForUpdate.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // BtnPasswordGenerateForUpdate
            // 
            resources.ApplyResources(this.BtnPasswordGenerateForUpdate, "BtnPasswordGenerateForUpdate");
            this.BtnPasswordGenerateForUpdate.BackColor = System.Drawing.Color.Silver;
            this.BtnPasswordGenerateForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnPasswordGenerateForUpdate.Name = "BtnPasswordGenerateForUpdate";
            this.BtnPasswordGenerateForUpdate.UseVisualStyleBackColor = false;
            this.BtnPasswordGenerateForUpdate.Click += new System.EventHandler(this.BtnPasswordGenerateForUpdate_Click);
            // 
            // DtpCreateDate
            // 
            resources.ApplyResources(this.DtpCreateDate, "DtpCreateDate");
            this.DtpCreateDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DtpCreateDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DtpCreateDate.Name = "DtpCreateDate";
            // 
            // BtnShowPasswordForUpdate
            // 
            resources.ApplyResources(this.BtnShowPasswordForUpdate, "BtnShowPasswordForUpdate");
            this.BtnShowPasswordForUpdate.BackColor = System.Drawing.Color.Silver;
            this.BtnShowPasswordForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnShowPasswordForUpdate.Name = "BtnShowPasswordForUpdate";
            this.BtnShowPasswordForUpdate.UseVisualStyleBackColor = false;
            this.BtnShowPasswordForUpdate.Click += new System.EventHandler(this.BtnShowPasswordForUpdate_Click);
            // 
            // txtUserNameForUpdate
            // 
            resources.ApplyResources(this.txtUserNameForUpdate, "txtUserNameForUpdate");
            this.txtUserNameForUpdate.BackColor = System.Drawing.Color.Silver;
            this.txtUserNameForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserNameForUpdate.Name = "txtUserNameForUpdate";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Name = "label8";
            // 
            // BtnClearForUpdate
            // 
            resources.ApplyResources(this.BtnClearForUpdate, "BtnClearForUpdate");
            this.BtnClearForUpdate.BackColor = System.Drawing.Color.Silver;
            this.BtnClearForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnClearForUpdate.Name = "BtnClearForUpdate";
            this.BtnClearForUpdate.UseVisualStyleBackColor = false;
            this.BtnClearForUpdate.Click += new System.EventHandler(this.BtnClearForUpdate_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Name = "label6";
            // 
            // BtnUpdate
            // 
            resources.ApplyResources(this.BtnUpdate, "BtnUpdate");
            this.BtnUpdate.BackColor = System.Drawing.Color.Silver;
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnSifreGuncelle_Click);
            // 
            // TxtNameForUpdate
            // 
            resources.ApplyResources(this.TxtNameForUpdate, "TxtNameForUpdate");
            this.TxtNameForUpdate.BackColor = System.Drawing.Color.Silver;
            this.TxtNameForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNameForUpdate.Name = "TxtNameForUpdate";
            // 
            // TxtPasswordForUpdate
            // 
            resources.ApplyResources(this.TxtPasswordForUpdate, "TxtPasswordForUpdate");
            this.TxtPasswordForUpdate.BackColor = System.Drawing.Color.Silver;
            this.TxtPasswordForUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPasswordForUpdate.Name = "TxtPasswordForUpdate";
            this.TxtPasswordForUpdate.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Name = "label5";
            // 
            // BtnDelete
            // 
            resources.ApplyResources(this.BtnDelete, "BtnDelete");
            this.BtnDelete.BackColor = System.Drawing.Color.Silver;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Name = "label3";
            // 
            // DgvValues
            // 
            resources.ApplyResources(this.DgvValues, "DgvValues");
            this.DgvValues.AllowUserToAddRows = false;
            this.DgvValues.AllowUserToDeleteRows = false;
            this.DgvValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvValues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvValues.MultiSelect = false;
            this.DgvValues.Name = "DgvValues";
            this.DgvValues.ReadOnly = true;
            this.DgvValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvValues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvValues_CellClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownGeneratePasswordCountForAdd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownGeneratePasswordCountForUpdate)).EndInit();
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
        private System.Windows.Forms.Button BtnPasswordGenerateForAdd;
        private System.Windows.Forms.DateTimePicker DtpCreateDate;
        private System.Windows.Forms.Button BtnPasswordGenerateForUpdate;
        private System.Windows.Forms.Button BtnClearForTxtSearch;
        private System.Windows.Forms.NumericUpDown NumUpDownGeneratePasswordCountForAdd;
        private System.Windows.Forms.NumericUpDown NumUpDownGeneratePasswordCountForUpdate;
    }
}

