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
    public partial class AddCount : Form
    {
        public AddCount()
        {
            InitializeComponent();
            this.Load += new EventHandler(AddCount_Load);
        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            string str = anError.Context.ToString();
            MessageBox.Show("Помилка " + /*anError.Context.ToString()*/ str);

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                str = "Помилка виконання";
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("вводу даних");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("типу введених даних");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
             
       //     if (anError.Exception != null &&
       //anError.Context == DataGridViewDataErrorContexts.Commit)
       //     {
       //         MessageBox.Show("CustomerID value must be unique.");
       //     }
        }

        private void AddCount_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataError +=
        new DataGridViewDataErrorEventHandler(DataGridView1_DataError);
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet2.ClientCount' table. You can move, or remove it, as needed.
            this.clientCountTableAdapter1.Fill(this.botvynko_HotelDataSet2.ClientCount);
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet1.ClientCount' table. You can move, or remove it, as needed.
            //this.clientCountTableAdapter.Fill(this.botvynko_HotelDataSet1.ClientCount);
            // TODO: This line of code loads data into the 'botvynko_HotelDataSet.ClientCount' table. You can move, or remove it, as needed.
            //this.clientCountTableAdapter.Fill(this.botvynko_HotelDataSet.ClientCount);

        }

        private void save_Click(object sender, EventArgs e)
        {
            
                clientCountBindingSource2.EndEdit();
                clientCountTableAdapter1.Update(botvynko_HotelDataSet2.ClientCount);
            
                //MessageBox.Show("Не існує такого клієнта, або неправильно введені дані!");
                //DataGridView1_DataError(sender, e);

                //this.dataGridView1.DataError += new DataGridViewDataErrorEventHandler(DataGridView1_DataError);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
