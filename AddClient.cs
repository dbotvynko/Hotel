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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.botvynko_HotelDataSet.Client);

        }

        private void save_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            clientTableAdapter.Update(botvynko_HotelDataSet.Client);
        }
    }
}
