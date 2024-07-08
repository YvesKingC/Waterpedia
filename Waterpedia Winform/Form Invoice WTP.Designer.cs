namespace Waterpedia_Winform
{
    partial class formInvoiceWTP
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
            textBox1 = new TextBox();
            buttonSearchInvoiceWTP = new Button();
            dataGridView1 = new DataGridView();
            buttonNewinvoiceWTP = new Button();
            buttonPrintinvoiceWTP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(659, 27);
            textBox1.TabIndex = 0;
            // 
            // buttonSearchInvoiceWTP
            // 
            buttonSearchInvoiceWTP.Location = new Point(677, 10);
            buttonSearchInvoiceWTP.Name = "buttonSearchInvoiceWTP";
            buttonSearchInvoiceWTP.Size = new Size(111, 29);
            buttonSearchInvoiceWTP.TabIndex = 1;
            buttonSearchInvoiceWTP.Text = "Search";
            buttonSearchInvoiceWTP.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(656, 394);
            dataGridView1.TabIndex = 2;
            // 
            // buttonNewinvoiceWTP
            // 
            buttonNewinvoiceWTP.Location = new Point(677, 206);
            buttonNewinvoiceWTP.Name = "buttonNewinvoiceWTP";
            buttonNewinvoiceWTP.Size = new Size(111, 29);
            buttonNewinvoiceWTP.TabIndex = 3;
            buttonNewinvoiceWTP.Text = "Invoice Baru";
            buttonNewinvoiceWTP.UseVisualStyleBackColor = true;
            // 
            // buttonPrintinvoiceWTP
            // 
            buttonPrintinvoiceWTP.Location = new Point(677, 241);
            buttonPrintinvoiceWTP.Name = "buttonPrintinvoiceWTP";
            buttonPrintinvoiceWTP.Size = new Size(111, 29);
            buttonPrintinvoiceWTP.TabIndex = 4;
            buttonPrintinvoiceWTP.Text = "Print Invoice";
            buttonPrintinvoiceWTP.UseVisualStyleBackColor = true;
            // 
            // formInvoiceWTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPrintinvoiceWTP);
            Controls.Add(buttonNewinvoiceWTP);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchInvoiceWTP);
            Controls.Add(textBox1);
            Name = "formInvoiceWTP";
            Text = "Form Invoice WTP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonSearchInvoiceWTP;
        private DataGridView dataGridView1;
        private Button buttonNewinvoiceWTP;
        private Button buttonPrintinvoiceWTP;
    }
}