using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddReceptionForm : Form
    {
        public AddReceptionForm()
        {
            InitializeComponent();
        }
        public Account NewReception { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewReception = new Account
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = "Reception"
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
