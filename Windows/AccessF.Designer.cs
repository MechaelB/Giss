using Giss.Resources;
namespace Giss
{
    partial class AccessF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_login = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // txtb_login
            // 
            this.txtb_login.Location = new System.Drawing.Point(82, 6);
            this.txtb_login.Name = "txtb_login";
            this.txtb_login.Size = new System.Drawing.Size(190, 20);
            this.txtb_login.TabIndex = 0;
            // 
            // txtb_password
            // 
            this.txtb_password.Location = new System.Drawing.Point(82, 30);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(190, 20);
            this.txtb_password.TabIndex = 1;
            this.txtb_password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(197, 69);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = global::Giss.Resources.Ru.text_btn_login;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(116, 70);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = global::Giss.Resources.Ru.text_btn_cancel;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(15, 69);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(81, 23);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Регистрация";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // AccessF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccessF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessF";
            this.Load += new System.EventHandler(this.AccessF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_login;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_register;
    }
}