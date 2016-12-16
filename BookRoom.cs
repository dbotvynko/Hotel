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
    public partial class BookRoom : Form
    {
        public BookRoom()
        {
            InitializeComponent();
        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            if ((room.SelectedIndex == 0 || room.SelectedIndex == 1 || room.SelectedIndex == 2) && (numPersons.SelectedIndex == 0 || numPersons.SelectedIndex == 1 || numPersons.SelectedIndex == 2) && monthCalendar1.SelectionStart != DateTime.MinValue.Date) 
            {
                PersonalData personalData = new PersonalData();
                personalData.Show();
            }
        }
    }
}
