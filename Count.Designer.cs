namespace WindowsFormsApplication1
{
    partial class Count
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Count));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botvynko_HotelDataSet = new WindowsFormsApplication1.Botvynko_HotelDataSet();
            this.clientRoomCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientRoomCountTableAdapter = new WindowsFormsApplication1.Botvynko_HotelDataSetTableAdapters.ClientRoomCountTableAdapter();
            this.типНомеруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяКлієнтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерРахункуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countText = new System.Windows.Forms.TextBox();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botvynko_HotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRoomCountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типНомеруDataGridViewTextBoxColumn,
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn,
            this.імяКлієнтаDataGridViewTextBoxColumn,
            this.номерРахункуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientRoomCountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // botvynko_HotelDataSet
            // 
            this.botvynko_HotelDataSet.DataSetName = "Botvynko_HotelDataSet";
            this.botvynko_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientRoomCountBindingSource
            // 
            this.clientRoomCountBindingSource.DataMember = "ClientRoomCount";
            this.clientRoomCountBindingSource.DataSource = this.botvynko_HotelDataSet;
            // 
            // clientRoomCountTableAdapter
            // 
            this.clientRoomCountTableAdapter.ClearBeforeFill = true;
            // 
            // типНомеруDataGridViewTextBoxColumn
            // 
            this.типНомеруDataGridViewTextBoxColumn.DataPropertyName = "Тип номеру";
            this.типНомеруDataGridViewTextBoxColumn.HeaderText = "Тип номеру";
            this.типНомеруDataGridViewTextBoxColumn.Name = "типНомеруDataGridViewTextBoxColumn";
            // 
            // цінаЗаДобуГрнDataGridViewTextBoxColumn
            // 
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn.DataPropertyName = "Ціна за добу, грн";
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn.HeaderText = "Ціна за добу, грн";
            this.цінаЗаДобуГрнDataGridViewTextBoxColumn.Name = "цінаЗаДобуГрнDataGridViewTextBoxColumn";
            // 
            // імяКлієнтаDataGridViewTextBoxColumn
            // 
            this.імяКлієнтаDataGridViewTextBoxColumn.DataPropertyName = "Ім\"я клієнта";
            this.імяКлієнтаDataGridViewTextBoxColumn.HeaderText = "Ім\"я клієнта";
            this.імяКлієнтаDataGridViewTextBoxColumn.Name = "імяКлієнтаDataGridViewTextBoxColumn";
            // 
            // номерРахункуDataGridViewTextBoxColumn
            // 
            this.номерРахункуDataGridViewTextBoxColumn.DataPropertyName = "Номер рахунку";
            this.номерРахункуDataGridViewTextBoxColumn.HeaderText = "Номер рахунку";
            this.номерРахункуDataGridViewTextBoxColumn.Name = "номерРахункуDataGridViewTextBoxColumn";
            // 
            // countText
            // 
            this.countText.Location = new System.Drawing.Point(68, 12);
            this.countText.Multiline = true;
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(221, 23);
            this.countText.TabIndex = 2;
            this.countText.Text = "Переглянути рахунки";
            this.countText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT * FROM ClientRoomCount";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ClientRoomCount", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Тип номеру", "Тип номеру"),
                        new System.Data.Common.DataColumnMapping("Ціна за добу, грн", "Ціна за добу, грн"),
                        new System.Data.Common.DataColumnMapping("Ім\"я клієнта", "Ім\"я клієнта"),
                        new System.Data.Common.DataColumnMapping("Номер рахунку", "Номер рахунку")})});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DORY\\SQLEXPRESS;Integrated Security=SSPI;Initial C" +
    "atalog=Botvynko_Hotel";
            // 
            // Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 408);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Count";
            this.Text = "Count";
            this.Load += new System.EventHandler(this.Count_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botvynko_HotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRoomCountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Botvynko_HotelDataSet botvynko_HotelDataSet;
        private System.Windows.Forms.BindingSource clientRoomCountBindingSource;
        private Botvynko_HotelDataSetTableAdapters.ClientRoomCountTableAdapter clientRoomCountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНомеруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаЗаДобуГрнDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяКлієнтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРахункуDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox countText;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}