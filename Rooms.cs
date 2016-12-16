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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet.NumberPrice' table. You can move, or remove it, as needed.
            this.numberPriceTableAdapter.Fill(this.botvynko_HotelDataSet.NumberPrice);

        }
    }
}
