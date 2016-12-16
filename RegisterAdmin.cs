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
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            if (log.Text == "Admin" && password.Text == "qwerty")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Close();
            }
        }
    }
}
