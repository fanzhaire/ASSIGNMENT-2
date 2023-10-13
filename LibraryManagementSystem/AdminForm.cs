using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.ToList();
                dataGridView1.DataSource = books;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addBookForm = new AddBookForm())
            {
                if (addBookForm.ShowDialog(this) == DialogResult.OK)
                {
                    var newBook = addBookForm.NewBook;

                    using (var context = new LibraryContext())
                    {
                        // Add new books to database
                        context.Books.Add(newBook);
                        context.SaveChanges();

                        // Refresh the contents of DataGridView
                        var books = context.Books.ToList();
                        dataGridView1.DataSource = books;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new LibraryContext())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    var bookId = Convert.ToInt32(row.Cells["BookIdColumn"].Value);
                    var book = context.Books.Find(bookId);

                    if (book != null)
                    {
                        book.Title = row.Cells["TitleColumn"].Value.ToString();
                        book.Author = row.Cells["AuthorColumn"].Value.ToString();
                        book.ISBN = row.Cells["ISBNColumn"].Value.ToString();
                        book.IsAvailable = Convert.ToBoolean(row.Cells["IsAvailableColumn"].Value);

                        context.Entry(book).State = EntityState.Modified;
                    }
                }

                context.SaveChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int bookId = Convert.ToInt32(selectedRow.Cells["BookIdColumn"].Value);

                using (var context = new LibraryContext())
                {
                    var book = context.Books.Find(bookId);

                    if (book != null)
                    {
                        context.Books.Remove(book);
                        context.SaveChanges();

                        // Refresh the contents of DataGridView
                        var books = context.Books.ToList();
                        dataGridView1.DataSource = books;
                    }
                    else
                    {
                        MessageBox.Show("Book not found!", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Information");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var addReceptionForm = new AddReceptionForm())
            {
                if (addReceptionForm.ShowDialog() == DialogResult.OK)
                {
                    using (var context = new LibraryContext())
                    {
                        context.loginaccount.Add(addReceptionForm.NewReception);
                        context.SaveChanges();

                        MessageBox.Show("Reception added successfully!", "Success");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
