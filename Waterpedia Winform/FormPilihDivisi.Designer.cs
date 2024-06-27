namespace Waterpedia_Winform
{
    partial class FormPilihDivisi
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
            btnTraining = new Button();
            btnWTP = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnBakteri
            // 
            BtnBakteri.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBakteri.Location = new Point(48, 41);
            BtnBakteri.Name = "BtnBakteri";
            BtnBakteri.Size = new Size(139, 120);
            BtnBakteri.TabIndex = 0;
            BtnBakteri.Text = "Divisi Bakteri";
            BtnBakteri.UseVisualStyleBackColor = true;
            // 
            // btnTraining
            // 
            btnTraining.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraining.Location = new Point(223, 41);
            btnTraining.Name = "btnTraining";
            btnTraining.Size = new Size(139, 120);
            btnTraining.TabIndex = 1;
            btnTraining.Text = "Divisi Training";
            btnTraining.UseVisualStyleBackColor = true;
            // 
            // btnWTP
            // 
            btnWTP.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnWTP.Location = new Point(401, 41);
            btnWTP.Name = "btnWTP";
            btnWTP.Size = new Size(139, 120);
            btnWTP.TabIndex = 2;
            btnWTP.Text = "Divisi WTP";
            btnWTP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(48, 185);
            button1.Name = "button1";
            button1.Size = new Size(71, 30);
            button1.TabIndex = 3;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormPilihDivisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 249);
            Controls.Add(button1);
            Controls.Add(btnWTP);
            Controls.Add(btnTraining);
            Controls.Add(BtnBakteri);
            Name = "FormPilihDivisi";
            Text = "FormPilihDivisi";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBakteri;
        private Button btnTraining;
        private Button btnWTP;
        private Button button1;
    }
}