namespace Payroll_M_System
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lbl_uName = new System.Windows.Forms.Label();
            this.lbl_uId = new System.Windows.Forms.Label();
            this.lbl_pwrd = new System.Windows.Forms.Label();
            this.lbl_adminLogin = new System.Windows.Forms.Label();
            this.txt_uName = new System.Windows.Forms.TextBox();
            this.txt_uId = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_uName
            // 
            this.lbl_uName.AutoSize = true;
            this.lbl_uName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uName.Location = new System.Drawing.Point(140, 117);
            this.lbl_uName.Name = "lbl_uName";
            this.lbl_uName.Size = new System.Drawing.Size(139, 26);
            this.lbl_uName.TabIndex = 0;
            this.lbl_uName.Text = "User Name :";
            // 
            // lbl_uId
            // 
            this.lbl_uId.AutoSize = true;
            this.lbl_uId.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uId.Location = new System.Drawing.Point(140, 169);
            this.lbl_uId.Name = "lbl_uId";
            this.lbl_uId.Size = new System.Drawing.Size(106, 26);
            this.lbl_uId.TabIndex = 1;
            this.lbl_uId.Text = "User ID :";
            // 
            // lbl_pwrd
            // 
            this.lbl_pwrd.AutoSize = true;
            this.lbl_pwrd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwrd.Location = new System.Drawing.Point(140, 217);
            this.lbl_pwrd.Name = "lbl_pwrd";
            this.lbl_pwrd.Size = new System.Drawing.Size(124, 26);
            this.lbl_pwrd.TabIndex = 2;
            this.lbl_pwrd.Text = "Password :";
            // 
            // lbl_adminLogin
            // 
            this.lbl_adminLogin.AutoSize = true;
            this.lbl_adminLogin.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_adminLogin.Location = new System.Drawing.Point(314, 41);
            this.lbl_adminLogin.Name = "lbl_adminLogin";
            this.lbl_adminLogin.Size = new System.Drawing.Size(183, 35);
            this.lbl_adminLogin.TabIndex = 3;
            this.lbl_adminLogin.Text = "Admin Login";
            // 
            // txt_uName
            // 
            this.txt_uName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uName.Location = new System.Drawing.Point(285, 123);
            this.txt_uName.Name = "txt_uName";
            this.txt_uName.Size = new System.Drawing.Size(234, 22);
            this.txt_uName.TabIndex = 4;
            // 
            // txt_uId
            // 
            this.txt_uId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uId.Location = new System.Drawing.Point(285, 171);
            this.txt_uId.Name = "txt_uId";
            this.txt_uId.Size = new System.Drawing.Size(234, 22);
            this.txt_uId.TabIndex = 5;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(285, 221);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(234, 22);
            this.txt_pwd.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(434, 291);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 44);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(564, 291);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 44);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uId);
            this.Controls.Add(this.txt_uName);
            this.Controls.Add(this.lbl_adminLogin);
            this.Controls.Add(this.lbl_pwrd);
            this.Controls.Add(this.lbl_uId);
            this.Controls.Add(this.lbl_uName);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_uName;
        private System.Windows.Forms.Label lbl_uId;
        private System.Windows.Forms.Label lbl_pwrd;
        private System.Windows.Forms.Label lbl_adminLogin;
        private System.Windows.Forms.TextBox txt_uName;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox txt_uId;
    }
}