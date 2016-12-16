namespace WindowsFormsApplication1
{
    partial class NumberClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberClients));
            this.titleNumClients = new System.Windows.Forms.TextBox();
            this.numberClientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.botvynko_HotelDataSet2 = new WindowsFormsApplication1.Botvynko_HotelDataSet();
            this.numberClientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numberClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberClientsTableAdapter2 = new WindowsFormsApplication1.Botvynko_HotelDataSetTableAdapters.NumberClientsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberClientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botvynko_HotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // titleNumClients
            // 
            this.titleNumClients.Location = new System.Drawing.Point(12, 22);
            this.titleNumClients.Name = "titleNumClients";
            this.titleNumClients.Size = new System.Drawing.Size(189, 20);
            this.titleNumClients.TabIndex = 0;
            this.titleNumClients.Text = "Кількіть клієнтів за останні півроку";
            // 
            // numberClientsBindingSource2
            // 
            this.numberClientsBindingSource2.DataMember = "NumberClients";
            this.numberClientsBindingSource2.DataSource = this.botvynko_HotelDataSet2;
            // 
            // botvynko_HotelDataSet2
            // 
            this.botvynko_HotelDataSet2.DataSetName = "Botvynko_HotelDataSet";
            this.botvynko_HotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberClientsBindingSource1
            // 
            this.numberClientsBindingSource1.DataMember = "NumberClients";
            // 
            // numberClientsBindingSource
            // 
            this.numberClientsBindingSource.DataMember = "NumberClients";
            // 
            // numberClientsTableAdapter2
            // 
            this.numberClientsTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.numberClientsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numberClientsBindingSource3
            // 
            this.numberClientsBindingSource3.DataMember = "NumberClients";
            this.numberClientsBindingSource3.DataSource = this.botvynko_HotelDataSet2;
            // 
            // кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn
            // 
            this.кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn.DataPropertyName = "Кількість проживаючих у готелі за весь період";
            this.кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn.HeaderText = "Кількість проживаючих у готелі за весь період";
            this.кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn.Name = "кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn";
            this.кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn.Width = 300;
            // 
            // NumberClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 193);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleNumClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumberClients";
            this.Text = "NumberClients";
            this.Load += new System.EventHandler(this.NumberClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botvynko_HotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberClientsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleNumClients;
        private Botvynko_HotelDataSet botvynko_HotelDataSet;
        private System.Windows.Forms.BindingSource numberClientsBindingSource;
        private Botvynko_HotelDataSetTableAdapters.NumberClientsTableAdapter numberClientsTableAdapter;
        private Botvynko_HotelDataSet botvynko_HotelDataSet1;
        private System.Windows.Forms.BindingSource numberClientsBindingSource1;
        private Botvynko_HotelDataSetTableAdapters.NumberClientsTableAdapter numberClientsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПроживаючихУГотеліЗаОстанніПіврокуDataGridViewTextBoxColumn;
        private Botvynko_HotelDataSet botvynko_HotelDataSet2;
        private System.Windows.Forms.BindingSource numberClientsBindingSource2;
        private Botvynko_HotelDataSetTableAdapters.NumberClientsTableAdapter numberClientsTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПроживаючихУГотеліЗаВесьПеріодDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource numberClientsBindingSource3;
         
    }
}