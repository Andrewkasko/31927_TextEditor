
namespace _31927_TextEditor
{
    partial class LoginScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.ExitApplicationBtn = new System.Windows.Forms.Button();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Editor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Andrew Kaskaniotis - 13538158";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please login or create account.";
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtbox.Location = new System.Drawing.Point(389, 283);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(188, 29);
            this.UsernameTxtbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(866, 280);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(141, 40);
            this.login.TabIndex = 7;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(436, 507);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(141, 40);
            this.createAccount.TabIndex = 8;
            this.createAccount.Text = "New User";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // ExitApplicationBtn
            // 
            this.ExitApplicationBtn.Location = new System.Drawing.Point(628, 507);
            this.ExitApplicationBtn.Name = "ExitApplicationBtn";
            this.ExitApplicationBtn.Size = new System.Drawing.Size(141, 40);
            this.ExitApplicationBtn.TabIndex = 9;
            this.ExitApplicationBtn.Text = "Exit";
            this.ExitApplicationBtn.UseVisualStyleBackColor = true;
            this.ExitApplicationBtn.Click += new System.EventHandler(this.ExitApplicationBtn_Click);
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PasswordTxtbox.Location = new System.Drawing.Point(628, 283);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.Size = new System.Drawing.Size(192, 29);
            this.PasswordTxtbox.TabIndex = 11;
            this.PasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.ExitApplicationBtn);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsernameTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.Button ExitApplicationBtn;
        private System.Windows.Forms.TextBox PasswordTxtbox;
    }
}

