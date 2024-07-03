namespace Waterpedia_Winform
{
    partial class FormLogin
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
            lblEmail = new Label();
            lblPassword = new Label();
            tBoxEmail = new TextBox();
            tBoxPassword = new TextBox();
            btnLogin = new Button();
            cBoxShowPass = new CheckBox();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(57, 66);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(176, 30);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Username/Emaill";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(57, 143);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 30);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // tBoxEmail
            // 
            tBoxEmail.Anchor = AnchorStyles.Top;
            tBoxEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxEmail.Location = new Point(254, 63);
            tBoxEmail.Name = "tBoxEmail";
            tBoxEmail.Size = new Size(317, 36);
            tBoxEmail.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Anchor = AnchorStyles.Top;
            tBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(254, 140);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(317, 36);
            tBoxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(254, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cBoxShowPass
            // 
            cBoxShowPass.Anchor = AnchorStyles.Top;
            cBoxShowPass.AutoSize = true;
            cBoxShowPass.Location = new Point(254, 183);
            cBoxShowPass.Name = "cBoxShowPass";
            cBoxShowPass.Size = new Size(108, 19);
            cBoxShowPass.TabIndex = 5;
            cBoxShowPass.Text = "Show Password";
            cBoxShowPass.UseVisualStyleBackColor = true;
            cBoxShowPass.CheckedChanged += cBoxShowPass_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 328);
            Controls.Add(cBoxShowPass);
            Controls.Add(btnLogin);
            Controls.Add(tBoxPassword);
            Controls.Add(tBoxEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormLogin";
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
        private Button btnLogin;
        private CheckBox cBoxShowPass;
    }
}