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
            lblEmail = new Label();
            lblPassword = new Label();
            tBoxEmail = new TextBox();
            tBoxPassword = new TextBox();
            button1 = new Button();
            cBoxShowPass = new CheckBox();
            SuspendLayout();
            // 
            // lblEmail
            // 
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
            tBoxEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxEmail.Location = new Point(254, 140);
            tBoxEmail.Name = "tBoxEmail";
            tBoxEmail.Size = new Size(317, 36);
            tBoxEmail.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(254, 63);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(317, 36);
            tBoxPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(254, 229);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // cBoxShowPass
            // 
            cBoxShowPass.AutoSize = true;
            cBoxShowPass.Location = new Point(254, 183);
            cBoxShowPass.Name = "cBoxShowPass";
            cBoxShowPass.Size = new Size(108, 19);
            cBoxShowPass.TabIndex = 5;
            cBoxShowPass.Text = "Show Password";
            cBoxShowPass.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 328);
            Controls.Add(cBoxShowPass);
            Controls.Add(button1);
            Controls.Add(tBoxPassword);
            Controls.Add(tBoxEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LoginPage";
            Text = "Login Page";
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
    }
}