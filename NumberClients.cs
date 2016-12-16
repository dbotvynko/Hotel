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
    public partial class NumberClients : Form
    {
        public NumberClients()
        {
            InitializeComponent();
        }

        private void NumberClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet2.NumberClients' table. You can move, or remove it, as needed.
            this.numberClientsTableAdapter2.Fill(this.botvynko_HotelDataSet2.NumberClients);
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet1.NumberClients' table. You can move, or remove it, as needed.
            //this.numberClientsTableAdapter1.Fill(this.botvynko_HotelDataSet1.NumberClients);
            //dataGridView1.AutoGenerateColumns = true;
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet.NumberClients' table. You can move, or remove it, as needed.
            //this.numberClientsTableAdapter.Fill(this.botvynko_HotelDataSet1.NumberClients);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
