namespace WindowsFormsApplication1
{
    partial class BookRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRoom));
            this.room = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPersons = new System.Windows.Forms.ComboBox();
            this.dayPrice = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberNights = new System.Windows.Forms.TextBox();
            this.NextStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // room
            // 
            this.room.FormattingEnabled = true;
            this.room.Items.AddRange(new object[] {
            "Стандарт",
            "Економ",
            "Люкс"});
            this.room.Location = new System.Drawing.Point(22, 56);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(142, 21);
            this.room.TabIndex = 0;
            this.room.Text = "Номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть тип номеру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість гостей";
            // 
            // numPersons
            // 
            this.numPersons.FormattingEnabled = true;
            this.numPersons.Items.AddRange(new object[] {
            "1-місний",
            "2-місний",
            "5-місний"});
            this.numPersons.Location = new System.Drawing.Point(22, 124);
            this.numPersons.Name = "numPersons";
            this.numPersons.Size = new System.Drawing.Size(142, 21);
            this.numPersons.TabIndex = 2;
            this.numPersons.Text = "Місткість";
            // 
            // dayPrice
            // 
            this.dayPrice.Location = new System.Drawing.Point(161, 233);
            this.dayPrice.Name = "dayPrice";
            this.dayPrice.Size = new System.Drawing.Size(100, 20);
            this.dayPrice.TabIndex = 4;
            this.dayPrice.Text = "Ціна за добу:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(247, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Оберіть дату заїзду";
            // 
            // NumberNights
            // 
            this.NumberNights.Location = new System.Drawing.Point(25, 179);
            this.NumberNights.Name = "NumberNights";
            this.NumberNights.Size = new System.Drawing.Size(100, 20);
            this.NumberNights.TabIndex = 7;
            this.NumberNights.Text = "Кількість ночей:";
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(336, 272);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(75, 23);
            this.NextStep.TabIndex = 8;
            this.NextStep.Text = "Далі";
            this.NextStep.UseVisualStyleBackColor = true;
            this.NextStep.Click += new System.EventHandler(this.NextStep_Click);
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 307);
            this.Controls.Add(this.NextStep);
            this.Controls.Add(this.NumberNights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dayPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPersons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookRoom";
            this.Text = "Забронювати кімнату";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numPersons;
        private System.Windows.Forms.TextBox dayPrice;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberNights;
        private System.Windows.Forms.Button NextStep;
    }
}