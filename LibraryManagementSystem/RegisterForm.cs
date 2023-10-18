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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userAccount = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(userAccount) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Useraccount or Password cannot be empty!");
                return;
            }

            using (var context = new LibraryContext())
            {
                // Check if the useraccount already exists
                var existingUser = context.loginaccount.FirstOrDefault(u => u.Username == userAccount);
                if (existingUser != null)
                {
                    MessageBox.Show("Useraccount already exists!");
                    return;
                }

                // Create a new user
                var newUser = new Account()
                {
                    Username = userAccount,
                    Password = password,  // Consider hashing the password!
                    Role = "user"
                };

                context.loginaccount.Add(newUser);
                context.SaveChanges();
            }

            MessageBox.Show("Registration successful!");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
                button1.Text = "Hide Password";
            }
            else
            {
                textBox2.PasswordChar = '*';
                button1.Text = "Show Password";
            }
        }
    }
}
