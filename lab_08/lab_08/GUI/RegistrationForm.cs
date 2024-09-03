using lab_03.BL.Services;
using System;
using System.Windows.Forms;

namespace WindowFormViews
{
    public partial class Registration : Form
    {
        private UserService userService;
        public Registration(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
            checkMatchPassword.Visible = false;
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(textboxPassword.Text, textboxRepassword.Text, true) == 0)
            {
                checkMatchPassword.Visible = true;
            }
            else
            {
                checkMatchPassword.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string login = textboxUsername.Text;
            string password = textboxPassword.Text;
            string repassword = textboxRepassword.Text;
            string role = comboboxRole.Text;
            string name = textboxFirstname.Text;
            if (string.Compare(password, repassword) == 0)
            {
                try
                {
                    userService.Register(login, password, role, name);
                    MessageBox.Show("Registration successfully");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password and Re-password have not match");
            }
        }
    }
}
