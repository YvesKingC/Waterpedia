namespace Waterpedia_Winform
{
    partial class inventoryBakteri
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            labelFilter = new Label();
            buttonSearch = new Button();
            buttonEditItem = new Button();
            buttonApplyFilter = new Button();
            buttonInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(650, 27);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(646, 388);
            dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(679, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(679, 136);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(53, 20);
            labelFilter.TabIndex = 3;
            labelFilter.Text = "Filter : ";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.White;
            buttonSearch.ForeColor = SystemColors.ControlText;
            buttonSearch.Location = new Point(687, 10);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(143, 29);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += this.buttonSearch_Click;
            // 
            // buttonEditItem
            // 
            buttonEditItem.Location = new Point(687, 253);
            buttonEditItem.Name = "buttonEditItem";
            buttonEditItem.Size = new Size(143, 29);
            buttonEditItem.TabIndex = 5;
            buttonEditItem.Text = "Edit Item";
            buttonEditItem.UseVisualStyleBackColor = true;
            // 
            // buttonApplyFilter
            // 
            buttonApplyFilter.Location = new Point(707, 193);
            buttonApplyFilter.Name = "buttonApplyFilter";
            buttonApplyFilter.Size = new Size(94, 29);
            buttonApplyFilter.TabIndex = 6;
            buttonApplyFilter.Text = "Apply";
            buttonApplyFilter.UseVisualStyleBackColor = true;
            buttonApplyFilter.Click += this.buttonApplyFilter_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.Location = new Point(687, 288);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(143, 29);
            buttonInvoice.TabIndex = 7;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            // 
            // inventoryBakteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 459);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonApplyFilter);
            Controls.Add(buttonEditItem);
            Controls.Add(buttonSearch);
            Controls.Add(labelFilter);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "inventoryBakteri";
            Text = "Divisi Bakteri";
            Load += this.inventoryBakteri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label labelFilter;
        private Button buttonSearch;
        private Button buttonEditItem;
        private Button buttonApplyFilter;
        private Button buttonInvoice;
    }
}