namespace Waterpedia_Winform
{
    partial class FormFrontPanel
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
            BtnBakteri = new Button();
            btnWTP = new Button();
            btnLogout = new Button();
            btnViewUser = new Button();
            lblWellcome = new Label();
            SuspendLayout();
            // 
            // BtnBakteri
            // 
            BtnBakteri.AutoSize = true;
            BtnBakteri.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBakteri.Location = new Point(44, 120);
            BtnBakteri.Name = "BtnBakteri";
            BtnBakteri.Size = new Size(180, 124);
            BtnBakteri.TabIndex = 0;
            BtnBakteri.Text = "Divisi Bakteri";
            BtnBakteri.UseVisualStyleBackColor = true;
            // 
            // btnWTP
            // 
            btnWTP.AutoSize = true;
            btnWTP.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnWTP.Location = new Point(262, 120);
            btnWTP.Name = "btnWTP";
            btnWTP.Size = new Size(180, 124);
            btnWTP.TabIndex = 2;
            btnWTP.Text = "Divisi WTP";
            btnWTP.UseVisualStyleBackColor = true;
            btnWTP.Click += btnWTP_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(44, 273);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(72, 31);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewUser
            // 
            btnViewUser.AutoSize = true;
            btnViewUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewUser.Location = new Point(262, 256);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(180, 48);
            btnViewUser.TabIndex = 4;
            btnViewUser.Text = "View User";
            btnViewUser.UseVisualStyleBackColor = true;
            // 
            // lblWellcome
            // 
            lblWellcome.AutoSize = true;
            lblWellcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWellcome.Location = new Point(44, 30);
            lblWellcome.Name = "lblWellcome";
            lblWellcome.Size = new Size(134, 37);
            lblWellcome.TabIndex = 5;
            lblWellcome.Text = "Wellcome";
            // 
            // FormFrontPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 345);
            Controls.Add(lblWellcome);
            Controls.Add(btnViewUser);
            Controls.Add(btnLogout);
            Controls.Add(btnWTP);
            Controls.Add(BtnBakteri);
            Name = "FormFrontPanel";
            Text = "Form Front Panel";
            Load += FormFrontPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBakteri;
        private Button btnWTP;
        private Button btnLogout;
        private Button btnViewUser;
        private Label lblWellcome;
    }
}