namespace Waterpedia_Winform
{
    partial class inventoryWTP
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
            textBoxWTP = new TextBox();
            buttonSearchWTP = new Button();
            dataGridView1 = new DataGridView();
            buttonApplyWTP = new Button();
            buttonEditWTP = new Button();
            buttonInvoice = new Button();
            comboBox1 = new ComboBox();
            buttonNewBakteri = new Button();
            buttonNewpackaging = new Button();
            buttonNewfilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxWTP
            // 
            textBoxWTP.Location = new Point(12, 12);
            textBoxWTP.Name = "textBoxWTP";
            textBoxWTP.Size = new Size(668, 27);
            textBoxWTP.TabIndex = 0;
            // 
            // buttonSearchWTP
            // 
            buttonSearchWTP.Location = new Point(686, 10);
            buttonSearchWTP.Name = "buttonSearchWTP";
            buttonSearchWTP.Size = new Size(151, 29);
            buttonSearchWTP.TabIndex = 1;
            buttonSearchWTP.Text = "Search";
            buttonSearchWTP.UseVisualStyleBackColor = true;
            buttonSearchWTP.Click += buttonSearchWTP_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(668, 393);
            dataGridView1.TabIndex = 2;
            // 
            // buttonApplyWTP
            // 
            buttonApplyWTP.Location = new Point(715, 165);
            buttonApplyWTP.Name = "buttonApplyWTP";
            buttonApplyWTP.Size = new Size(94, 29);
            buttonApplyWTP.TabIndex = 3;
            buttonApplyWTP.Text = "Apply";
            buttonApplyWTP.UseVisualStyleBackColor = true;
            // 
            // buttonEditWTP
            // 
            buttonEditWTP.Location = new Point(686, 200);
            buttonEditWTP.Name = "buttonEditWTP";
            buttonEditWTP.Size = new Size(151, 32);
            buttonEditWTP.TabIndex = 4;
            buttonEditWTP.Text = "Edit Item";
            buttonEditWTP.UseVisualStyleBackColor = true;
            buttonEditWTP.Click += buttonEditWTP_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.ForeColor = SystemColors.ControlText;
            buttonInvoice.Location = new Point(686, 343);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(151, 32);
            buttonInvoice.TabIndex = 5;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(686, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // buttonNewBakteri
            // 
            buttonNewBakteri.Location = new Point(686, 238);
            buttonNewBakteri.Name = "buttonNewBakteri";
            buttonNewBakteri.Size = new Size(151, 29);
            buttonNewBakteri.TabIndex = 7;
            buttonNewBakteri.Text = "Bakteri Baru";
            buttonNewBakteri.UseVisualStyleBackColor = true;
            // 
            // buttonNewpackaging
            // 
            buttonNewpackaging.Location = new Point(686, 273);
            buttonNewpackaging.Name = "buttonNewpackaging";
            buttonNewpackaging.Size = new Size(151, 29);
            buttonNewpackaging.TabIndex = 8;
            buttonNewpackaging.Text = "Packaging Baru";
            buttonNewpackaging.UseVisualStyleBackColor = true;
            // 
            // buttonNewfilter
            // 
            buttonNewfilter.Location = new Point(686, 308);
            buttonNewfilter.Name = "buttonNewfilter";
            buttonNewfilter.Size = new Size(151, 29);
            buttonNewfilter.TabIndex = 9;
            buttonNewfilter.Text = "Filter Baru";
            buttonNewfilter.UseVisualStyleBackColor = true;
            // 
            // inventoryWTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(buttonNewfilter);
            Controls.Add(buttonNewpackaging);
            Controls.Add(buttonNewBakteri);
            Controls.Add(comboBox1);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditWTP);
            Controls.Add(buttonApplyWTP);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchWTP);
            Controls.Add(textBoxWTP);
            Name = "inventoryWTP";
            Text = "Inventory WTP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWTP;
        private Button buttonSearchWTP;
        private DataGridView dataGridView1;
        private Button buttonApplyWTP;
        private Button buttonEditWTP;
        private Button buttonInvoice;
        private ComboBox comboBox1;
        private Button buttonNewBakteri;
        private Button buttonNewpackaging;
        private Button buttonNewfilter;
    }
}