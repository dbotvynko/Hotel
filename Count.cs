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
    public partial class Count : Form
    {
        public Count()
        {
            InitializeComponent();
        }

        private void Count_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet.ClientRoomCount' table. You can move, or remove it, as needed.
            this.clientRoomCountTableAdapter.Fill(this.botvynko_HotelDataSet.ClientRoomCount);

        }

        private void save_Click(object sender, EventArgs e)
        {
            //clientRoomCountBindingSource.EndEdit();
            //clientRoomCountTableAdapter.Update(botvynko_HotelDataSet.ClientRoomCount);

        }
    }
}
