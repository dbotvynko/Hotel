namespace WindowsFormsApplication1
{
    partial class PersonalData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalData));
            this.PassportNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassportNumber
            // 
            this.PassportNumber.Location = new System.Drawing.Point(26, 120);
            this.PassportNumber.Name = "PassportNumber";
            this.PassportNumber.Size = new System.Drawing.Size(217, 20);
            this.PassportNumber.TabIndex = 0;
            this.PassportNumber.Text = "Паспорт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер паспорту";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(26, 57);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(217, 20);
            this.FullName.TabIndex = 2;
            this.FullName.Text = "Ваше ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Повне ім\'я";
            // 
            // PersonalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassportNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalData";
            this.Text = "Забронювати кімнату";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassportNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label2;
    }
}