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
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace LibraryManagementSystem
{
    public partial class PersonalInfo : Form
    {
        public int CurrentUserId { get; set; }
        public PersonalInfo(int currentUserId)
        {
            CurrentUserId = currentUserId;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.ToList();
                dataGridView1.DataSource = books;
            }
            LoadBorrowedBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadBorrowedBooks()
        {
            using (var context = new LibraryContext())
            {

                var borrowedBookIds = context.userbooks.Where(ub => ub.UserId == CurrentUserId).Select(ub => ub.BookId).ToList();


                var borrowedBooks = context.Books.Where(b => borrowedBookIds.Contains(b.BookId)).ToList();


                dataGridView1.DataSource = borrowedBooks;
            }
        }



        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bookBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a book to return.", "Information");
                return;
            }
            var selectedRow = dataGridView1.SelectedRows[0];
            int bookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value);

            using (var context = new LibraryContext())
            {

                var userBookRecord = context.userbooks.FirstOrDefault(ub => ub.UserId == CurrentUserId && ub.BookId == bookId);
                if (userBookRecord != null)
                {
                    context.userbooks.Remove(userBookRecord);

                    var bookToUpdate = context.Books.FirstOrDefault(b => b.BookId == bookId);
                    if (bookToUpdate != null)
                    {
                        bookToUpdate.IsAvailable = true;
                        context.Entry(bookToUpdate).State = EntityState.Modified;
                    }

                    context.SaveChanges();

                    MessageBox.Show("Book returned successfully!", "Success");

                    LoadBorrowedBooks();
                }
                else
                {
                    MessageBox.Show("Error returning the book!", "Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var UserFormInstance = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
            if (UserFormInstance != null)
            {
                UserFormInstance.LoadBooksData();
                UserFormInstance.Show();
            }
            this.Hide();
        }
    }
}
