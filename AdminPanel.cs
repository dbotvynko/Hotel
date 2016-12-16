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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void roomState_Click(object sender, EventArgs e)
        {
            CountStatet f1 = new CountStatet();
            f1.Show();
            
        }

        private void createCount_Click(object sender, EventArgs e)
        {
            Count count = new Count();
            count.Show();
        }

        private void addCount_Click(object sender, EventArgs e)
        {
            AddCount addCount = new AddCount();
            addCount.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClient newClient = new AddClient();
            newClient.Show();
        }

        private void zvitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Zvit_Click(object sender, EventArgs e)
        {
            if (zvitType.SelectedIndex == 0)
            {
                NumberClients numClients = new NumberClients();
                numClients.Show();
            }
            else if (zvitType.SelectedIndex == 1)
            {
                Rooms rState = new Rooms();
                rState.Show();
            }
        }
    }
}
