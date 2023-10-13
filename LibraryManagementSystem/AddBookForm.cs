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
    public partial class AddBookForm : Form
    {
        public Book NewBook { get; private set; }

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            NewBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                ISBN = txtISBN.Text,
                IsAvailable = chkIsAvailable.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

