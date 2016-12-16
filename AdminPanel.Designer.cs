namespace WindowsFormsApplication1
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.createCount = new System.Windows.Forms.Button();
            this.Zvit = new System.Windows.Forms.Button();
            this.zvitType = new System.Windows.Forms.CheckedListBox();
            this.roomState = new System.Windows.Forms.Button();
            this.addCount = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countPict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPict)).BeginInit();
            this.SuspendLayout();
            // 
            // createCount
            // 
            this.createCount.Location = new System.Drawing.Point(150, 21);
            this.createCount.Name = "createCount";
            this.createCount.Size = new System.Drawing.Size(155, 48);
            this.createCount.TabIndex = 0;
            this.createCount.Text = "Переглянути рахунки";
            this.createCount.UseVisualStyleBackColor = true;
            this.createCount.Click += new System.EventHandler(this.createCount_Click);
            // 
            // Zvit
            // 
            this.Zvit.Location = new System.Drawing.Point(150, 157);
            this.Zvit.Name = "Zvit";
            this.Zvit.Size = new System.Drawing.Size(155, 48);
            this.Zvit.TabIndex = 2;
            this.Zvit.Text = "Переглянути звіт";
            this.Zvit.UseVisualStyleBackColor = true;
            this.Zvit.Click += new System.EventHandler(this.Zvit_Click);
            // 
            // zvitType
            // 
            this.zvitType.BackColor = System.Drawing.Color.YellowGreen;
            this.zvitType.FormattingEnabled = true;
            this.zvitType.Items.AddRange(new object[] {
            "Звіт по проживаючим за період",
            "Звіт по кімнатах та їх цінах"});
            this.zvitType.Location = new System.Drawing.Point(162, 211);
            this.zvitType.Name = "zvitType";
            this.zvitType.Size = new System.Drawing.Size(202, 34);
            this.zvitType.TabIndex = 3;
            this.zvitType.SelectedIndexChanged += new System.EventHandler(this.zvitType_SelectedIndexChanged);
            // 
            // roomState
            // 
            this.roomState.Location = new System.Drawing.Point(150, 287);
            this.roomState.Name = "roomState";
            this.roomState.Size = new System.Drawing.Size(155, 48);
            this.roomState.TabIndex = 4;
            this.roomState.Text = "Перевіти наявність вільних кімнат";
            this.roomState.UseVisualStyleBackColor = true;
            this.roomState.Click += new System.EventHandler(this.roomState_Click);
            // 
            // addCount
            // 
            this.addCount.Location = new System.Drawing.Point(265, 84);
            this.addCount.Name = "addCount";
            this.addCount.Size = new System.Drawing.Size(120, 32);
            this.addCount.TabIndex = 7;
            this.addCount.Text = "Додати рахунок";
            this.addCount.UseVisualStyleBackColor = true;
            this.addCount.Click += new System.EventHandler(this.addCount_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(139, 84);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(120, 32);
            this.addClient.TabIndex = 8;
            this.addClient.Text = "Додати клієнта";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Living_512;
            this.pictureBox2.Location = new System.Drawing.Point(32, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 86);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.GapIcon;
            this.pictureBox1.Location = new System.Drawing.Point(32, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 88);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // countPict
            // 
            this.countPict.Image = global::WindowsFormsApplication1.Properties.Resources.imageedit_1_2567213580;
            this.countPict.Location = new System.Drawing.Point(32, 21);
            this.countPict.Name = "countPict";
            this.countPict.Size = new System.Drawing.Size(102, 95);
            this.countPict.TabIndex = 1;
            this.countPict.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 396);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.addCount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roomState);
            this.Controls.Add(this.zvitType);
            this.Controls.Add(this.Zvit);
            this.Controls.Add(this.countPict);
            this.Controls.Add(this.createCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сторінка адміністратора";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createCount;
        private System.Windows.Forms.PictureBox countPict;
        private System.Windows.Forms.Button Zvit;
        private System.Windows.Forms.CheckedListBox zvitType;
        private System.Windows.Forms.Button roomState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addCount;
        private System.Windows.Forms.Button addClient;
    }
}