using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CountStatet : Form
    {
        public CountStatet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.botvynko_HotelDataSet.Room);
            this.signin.Hide();
            this.label1.Hide();
            this.passw.Hide();
            this.log.Hide();
            this.Password.Hide();
            this.pictureBox1.Hide();
            this.save.Hide();
            this.bindingNavigator1.Hide();
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            this.signin.Show();
            this.label1.Show();
            this.passw.Show();
            this.log.Show();
            this.Password.Show();
            this.pictureBox1.Show();
           
            
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if (Password.Text == "qwerty")
            {
                MessageBox.Show("Реєстрація пройшла успішно!");
                this.Size = new Size(553, 467);
                this.save.Show();
                this.addrm.ReadOnly = false;
                this.bindingNavigator1.Show();

            }
            else {
                MessageBox.Show("Неправильний пароль!");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
           
                roomBindingSource.EndEdit();
               // oleDbDataAdapter1.Update(botvynko_HotelDataSet, botvynko_HotelDataSet.Room);
                //MessageBox.Show("Ok!");
                //oleDbDataAdapter1.Fill(botvynko_HotelDataSet.Room);
                //addrm.DataSource = roomBindingSource;
                roomTableAdapter.Update(botvynko_HotelDataSet.Room);
                //addrm.Refresh();
                //oleDbDataAdapter1.Fill(botvynko_HotelDataSet.Room);
                MessageBox.Show("Базу даних збережено");
            
        }

       
    }
}
