using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoyTuQuiroApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void visitsButton_Click(object sender, EventArgs e)
        {

        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }
    }
}
