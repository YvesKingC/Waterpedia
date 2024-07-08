namespace Waterpedia_Winform
{
    partial class FormAddBakteri
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
            labelSelectPackaging = new Label();
            comboBox1 = new ComboBox();
            labelBakteri = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelJumlah = new Label();
            labelHarga = new Label();
            label1 = new Label();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // labelSelectPackaging
            // 
            labelSelectPackaging.AutoSize = true;
            labelSelectPackaging.Location = new Point(12, 51);
            labelSelectPackaging.Name = "labelSelectPackaging";
            labelSelectPackaging.Size = new Size(87, 20);
            labelSelectPackaging.TabIndex = 0;
            labelSelectPackaging.Text = "Packaging : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 28);
            comboBox1.TabIndex = 1;
            // 
            // labelBakteri
            // 
            labelBakteri.AutoSize = true;
            labelBakteri.Location = new Point(12, 108);
            labelBakteri.Name = "labelBakteri";
            labelBakteri.Size = new Size(101, 20);
            labelBakteri.TabIndex = 2;
            labelBakteri.Text = "Jenis Bakteri : ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(12, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(12, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(12, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 5;
            // 
            // labelJumlah
            // 
            labelJumlah.AutoSize = true;
            labelJumlah.Location = new Point(12, 167);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(66, 20);
            labelJumlah.TabIndex = 6;
            labelJumlah.Text = "Jumlah : ";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(12, 226);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(61, 20);
            labelHarga.TabIndex = 7;
            labelHarga.Text = "Harga : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(343, 38);
            label1.TabIndex = 8;
            label1.Text = "TAMBAH BAKTERI BARU";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(313, 261);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add Bakteri";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormAddBakteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 302);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(labelHarga);
            Controls.Add(labelJumlah);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelBakteri);
            Controls.Add(comboBox1);
            Controls.Add(labelSelectPackaging);
            Name = "FormAddBakteri";
            Text = "Tambah Bakteri Baru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelectPackaging;
        private ComboBox comboBox1;
        private Label labelBakteri;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelJumlah;
        private Label labelHarga;
        private Label label1;
        private Button buttonAdd;
    }
}