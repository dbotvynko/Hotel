namespace WindowsFormsApplication1
{
    partial class Rooms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botvynko_HotelDataSet = new WindowsFormsApplication1.Botvynko_HotelDataSet();
            this.numberPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberPriceTableAdapter = new WindowsFormsApplication1.Botvynko_HotelDataSetTableAdapters.NumberPriceTableAdapter();
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botvynko_HotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Кількість номерів за цінами";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn,
            this.кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.numberPriceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // botvynko_HotelDataSet
            // 
            this.botvynko_HotelDataSet.DataSetName = "Botvynko_HotelDataSet";
            this.botvynko_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberPriceBindingSource
            // 
            this.numberPriceBindingSource.DataMember = "NumberPrice";
            this.numberPriceBindingSource.DataSource = this.botvynko_HotelDataSet;
            // 
            // numberPriceTableAdapter
            // 
            this.numberPriceTableAdapter.ClearBeforeFill = true;
            // 
            // цінаЗаДобуГрнDataGridViewTextBoxColumn
            // 
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn.DataPropertyName = "Ціна за добу, грн";
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn.HeaderText = "Ціна за добу, грн";
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn.Name = "цінаЗаДобуГрнDataGridViewTextBoxColumn";
            // 
            // кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn
            // 
            this.кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn.DataPropertyName = "Кількість номерів за даною ціною";
            this.кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn.HeaderText = "Кількість номерів за даною ціною";
            this.кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn.Name = "кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn";
            this.кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn.Width = 250;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 279);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botvynko_HotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPriceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Botvynko_HotelDataSet botvynko_HotelDataSet;
        private System.Windows.Forms.BindingSource numberPriceBindingSource;
        private Botvynko_HotelDataSetTableAdapters.NumberPriceTableAdapter numberPriceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаЗаДобуГрнDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьНомерівЗаДаноюЦіноюDataGridViewTextBoxColumn;
    }
}