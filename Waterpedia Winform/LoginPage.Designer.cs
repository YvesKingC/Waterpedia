namespace Waterpedia_Winform
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblEmail = new Label();
            lblPassword = new Label();
            tBoxEmail = new TextBox();
            tBoxPassword = new TextBox();
            button1 = new Button();
            cBoxShowPass = new CheckBox();
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            cBoxRememberUser = new CheckBox();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(61, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(219, 37);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Username/Emaill";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(61, 214);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(128, 37);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // tBoxEmail
            // 
            tBoxEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxEmail.Location = new Point(258, 134);
            tBoxEmail.Name = "tBoxEmail";
            tBoxEmail.Size = new Size(317, 43);
            tBoxEmail.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(258, 211);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(317, 43);
            tBoxPassword.TabIndex = 3;
            // 
            // button1
            // 
<<<<<<< HEAD:Waterpedia Winform/LoginPage.Designer.cs
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(254, 229);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
=======
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(258, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
>>>>>>> 8344b60 (login sudah fix):Waterpedia Winform/FormLogin.Designer.cs
            // 
            // cBoxShowPass
            // 
            cBoxShowPass.AutoSize = true;
            cBoxShowPass.Location = new Point(258, 254);
            cBoxShowPass.Name = "cBoxShowPass";
            cBoxShowPass.Size = new Size(132, 24);
            cBoxShowPass.TabIndex = 5;
            cBoxShowPass.Text = "Show Password";
            cBoxShowPass.UseVisualStyleBackColor = true;
            cBoxShowPass.CheckedChanged += cBoxShowPass_CheckedChanged;
            // 
<<<<<<< HEAD:Waterpedia Winform/LoginPage.Designer.cs
            // LoginPage
=======
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 38);
            label1.Name = "label1";
            label1.Size = new Size(274, 59);
            label1.TabIndex = 6;
            label1.Text = "WATERPEDIA";
            // 
            // notifyIcon1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(644, 399);
            Controls.Add(cBoxRememberUser);
            Controls.Add(label1);
            Controls.Add(cBoxShowPass);
            Controls.Add(button1);
            Controls.Add(tBoxPassword);
            Controls.Add(tBoxEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LoginPage";
            Text = "Login Page";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox tBoxEmail;
        private TextBox tBoxPassword;
        private Button button1;
        private CheckBox cBoxShowPass;
        private Label label1;
        private NotifyIcon notifyIcon1;
        private CheckBox cBoxRememberUser;
    }
}