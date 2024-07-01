namespace Waterpedia_Winform
{
    partial class invoiceBakteri
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
            dataGridViewInvoiceBakteri = new DataGridView();
            buttonsearchInvoiceBakteri = new Button();
            textBox1 = new TextBox();
            buttonPrintInvoiceBakteri = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoiceBakteri).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInvoiceBakteri
            // 
            dataGridViewInvoiceBakteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoiceBakteri.Location = new Point(12, 36);
            dataGridViewInvoiceBakteri.Name = "dataGridViewInvoiceBakteri";
            dataGridViewInvoiceBakteri.RowHeadersWidth = 51;
            dataGridViewInvoiceBakteri.RowTemplate.Height = 29;
            dataGridViewInvoiceBakteri.Size = new Size(633, 402);
            dataGridViewInvoiceBakteri.TabIndex = 0;
            // 
            // buttonsearchInvoiceBakteri
            // 
            buttonsearchInvoiceBakteri.Location = new Point(651, 1);
            buttonsearchInvoiceBakteri.Name = "buttonsearchInvoiceBakteri";
            buttonsearchInvoiceBakteri.Size = new Size(137, 29);
            buttonsearchInvoiceBakteri.TabIndex = 1;
            buttonsearchInvoiceBakteri.Text = "Search";
            buttonsearchInvoiceBakteri.UseVisualStyleBackColor = true;
            buttonsearchInvoiceBakteri.Click += buttonsearchInvoiceBakteri_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(633, 27);
            textBox1.TabIndex = 2;
            // 
            // buttonPrintInvoiceBakteri
            // 
            buttonPrintInvoiceBakteri.Location = new Point(663, 206);
            buttonPrintInvoiceBakteri.Name = "buttonPrintInvoiceBakteri";
            buttonPrintInvoiceBakteri.Size = new Size(125, 29);
            buttonPrintInvoiceBakteri.TabIndex = 3;
            buttonPrintInvoiceBakteri.Text = "Print Invoice";
            buttonPrintInvoiceBakteri.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(663, 241);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 4;
            button2.Text = "Invoice Baru";
            button2.UseVisualStyleBackColor = true;
            // 
            // invoiceBakteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonPrintInvoiceBakteri);
            Controls.Add(textBox1);
            Controls.Add(buttonsearchInvoiceBakteri);
            Controls.Add(dataGridViewInvoiceBakteri);
            Name = "invoiceBakteri";
            Text = "Invoice Bakteri";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoiceBakteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInvoiceBakteri;
        private Button buttonsearchInvoiceBakteri;
        private TextBox textBox1;
        private Button buttonPrintInvoiceBakteri;
        private Button button2;
    }
}