namespace WindowsFormsApplication1
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Password = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 108);
            this.Password.MaxLength = 8;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(193, 20);
            this.Password.TabIndex = 0;
            // 
            // passw
            // 
            this.passw.AutoSize = true;
            this.passw.Location = new System.Drawing.Point(9, 83);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(107, 13);
            this.passw.TabIndex = 1;
            this.passw.Text = "Введіть ваш пароль";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 49);
            this.log.MaxLength = 8;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(193, 20);
            this.log.TabIndex = 2;
            this.log.Text = "ADMIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ваш логін:";
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(172, 158);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(96, 48);
            this.signin.TabIndex = 4;
            this.signin.Text = "Увійти";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Admin_icon;
            this.pictureBox1.Location = new System.Drawing.Point(284, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.Password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "Увійти як адміністратор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label passw;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}