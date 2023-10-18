using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem
{
    public partial class UserForm : Form
    {
        public int CurrentUserId { get; set; }
        public UserForm()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadBooksData();
        }
        public void LoadBooksData()
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.ToList();
                dataGridView1.DataSource = books;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a book first.", "Information");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            var bookId = Convert.ToInt32(selectedRow.Cells["BookIdColumn"].Value);
            using (var context = new LibraryContext())
            {
                var book = context.Books.Find(bookId);

                if (book == null)
                {
                    MessageBox.Show("Book not found!", "Error");
                    return;
                }

                if (!book.IsAvailable)
                {
                    MessageBox.Show("This book is already borrowed. Please choose another one.", "Information");
                    return;
                }

                book.IsAvailable = false;

                var currentUserId = CurrentUserId;
                var userBookEntry = new userbooks
                {
                    BookId = bookId,
                    UserId = currentUserId
                };

                context.userbooks.Add(userBookEntry);

                context.SaveChanges();

                var books = context.Books.ToList();
                dataGridView1.DataSource = books;

                MessageBox.Show("Book borrowed successfully!", "Success");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalInfo personalInfoForm = new PersonalInfo(CurrentUserId);

            personalInfoForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            this.Hide();
        }
    }
}
