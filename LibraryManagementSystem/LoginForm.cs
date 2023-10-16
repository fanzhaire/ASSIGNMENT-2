using System.Linq;
using System.Data.Entity;
using System.Diagnostics;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!radioAdmin.Checked && !radioUser.Checked && !radioReception.Checked)
            {
                MessageBox.Show("Please select your login role!", "Error");
                return;
            }

            using (var context = new LibraryContext())
            {
                var account = context.loginaccount.FirstOrDefault(a => a.Username == txtUsername.Text && a.Password == txtPassword.Text);

                if (account != null)
                {
                    string role = account.Role.ToLower();

                    if (role == "admin" && radioAdmin.Checked)
                    {
                        MessageBox.Show("Admin Logged in Successfully!", "Success");

                        var adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (role == "user" && radioUser.Checked)
                    {
                        MessageBox.Show("User Logged in Successfully!", "Success");

                        var userForm = new UserForm();
                        userForm.Show();
                        this.Hide();
                    }
                    else if (role == "reception" && radioReception.Checked)
                    {
                        MessageBox.Show("Reception Logged in Successfully!", "Success");

                        var receptionForm = new ReceptionForm();
                        receptionForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please select the correct role for your account.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct username or password.", "Error");
                }
            }
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}