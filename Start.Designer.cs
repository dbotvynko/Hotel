namespace WindowsFormsApplication1
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.administrator_button = new System.Windows.Forms.Button();
            this.startBook = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.startpage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startpage)).BeginInit();
            this.SuspendLayout();
            // 
            // administrator_button
            // 
            this.administrator_button.Location = new System.Drawing.Point(460, 29);
            this.administrator_button.Name = "administrator_button";
            this.administrator_button.Size = new System.Drawing.Size(149, 32);
            this.administrator_button.TabIndex = 1;
            this.administrator_button.Text = "Увійти як адміністратор";
            this.administrator_button.UseVisualStyleBackColor = true;
            this.administrator_button.Click += new System.EventHandler(this.administrator_button_Click);
            // 
            // startBook
            // 
            this.startBook.Location = new System.Drawing.Point(176, 368);
            this.startBook.Name = "startBook";
            this.startBook.Size = new System.Drawing.Size(161, 59);
            this.startBook.TabIndex = 2;
            this.startBook.Text = "Забронювати кімнату!";
            this.startBook.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(460, 87);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(149, 32);
            this.Info.TabIndex = 3;
            this.Info.Text = "Про програму";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // startpage
            // 
            this.startpage.Image = global::WindowsFormsApplication1.Properties.Resources.icon_book;
            this.startpage.Location = new System.Drawing.Point(86, 12);
            this.startpage.Name = "startpage";
            this.startpage.Size = new System.Drawing.Size(341, 350);
            this.startpage.TabIndex = 0;
            this.startpage.TabStop = false;
            this.startpage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 461);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.startBook);
            this.Controls.Add(this.administrator_button);
            this.Controls.Add(this.startpage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME!";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startpage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox startpage;
        private System.Windows.Forms.Button administrator_button;
        private System.Windows.Forms.Button startBook;
        private System.Windows.Forms.Button Info;
    }
}

