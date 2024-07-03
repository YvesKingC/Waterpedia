namespace Waterpedia_Winform
{
    partial class FormNewInv
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
            labelnamaCust = new Label();
            textBoxNamaCust = new TextBox();
            labelNOHP = new Label();
            textboxNoHP = new TextBox();
            labelPerusahaan = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelnamaCust
            // 
            labelnamaCust.AutoSize = true;
            labelnamaCust.Location = new Point(12, 9);
            labelnamaCust.Name = "labelnamaCust";
            labelnamaCust.Size = new Size(139, 20);
            labelnamaCust.TabIndex = 0;
            labelnamaCust.Text = "NAMA CUSTOMER :";
            labelnamaCust.Click += label1_Click;
            // 
            // textBoxNamaCust
            // 
            textBoxNamaCust.Location = new Point(12, 32);
            textBoxNamaCust.Name = "textBoxNamaCust";
            textBoxNamaCust.Size = new Size(179, 27);
            textBoxNamaCust.TabIndex = 1;
            // 
            // labelNOHP
            // 
            labelNOHP.AutoSize = true;
            labelNOHP.Location = new Point(12, 66);
            labelNOHP.Name = "labelNOHP";
            labelNOHP.Size = new Size(98, 20);
            labelNOHP.TabIndex = 2;
            labelNOHP.Text = "NOMOR HP : ";
            // 
            // textboxNoHP
            // 
            textboxNoHP.Location = new Point(12, 89);
            textboxNoHP.Name = "textboxNoHP";
            textboxNoHP.Size = new Size(179, 27);
            textboxNoHP.TabIndex = 3;
            // 
            // labelPerusahaan
            // 
            labelPerusahaan.AutoSize = true;
            labelPerusahaan.Location = new Point(12, 119);
            labelPerusahaan.Name = "labelPerusahaan";
            labelPerusahaan.Size = new Size(138, 20);
            labelPerusahaan.TabIndex = 4;
            labelPerusahaan.Text = "Nama Perusahaan : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(725, 443);
            dataGridView1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 257);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(73, 29);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormNewInv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 556);
            Controls.Add(buttonAdd);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(labelPerusahaan);
            Controls.Add(textboxNoHP);
            Controls.Add(labelNOHP);
            Controls.Add(textBoxNamaCust);
            Controls.Add(labelnamaCust);
            Name = "FormNewInv";
            Text = "FormNewInv";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnamaCust;
        private TextBox textBoxNamaCust;
        private Label labelNOHP;
        private TextBox textboxNoHP;
        private Label labelPerusahaan;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button buttonAdd;
    }
}