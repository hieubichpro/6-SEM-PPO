using lab_03.BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07.GUI
{
    public partial class UserForm : Form
    {
        private UserService userService;
        public UserForm(UserService userService)
        {
            this.userService = userService;
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            fillUser();
        }
        public void fillUser()
        {
            dgvUser.Rows.Clear();
            var users = userService.getAll();
            foreach (var u in users)
            {
                dgvUser.Rows.Add(u.Id, u.Login, u.Password, u.Role, u.Name);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string pass = tbPass.Text;
            string role = cbbRole.Text;
            string name = tbName.Text;
            userService.Register(login, pass, role, name);
            fillUser();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvUser.CurrentRow.Cells[0].Value;
            var u = userService.getbyId(id);
            tbLogin.Text = u.Login;
            tbPass.Text = u.Password;
            cbbRole.Text = u.Role;
            tbName.Text = u.Name;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUser.CurrentRow.Cells[0].Value;
            string login = tbLogin.Text;
            string pass = tbPass.Text;
            string role = cbbRole.Text;
            string name = tbName.Text;
            userService.ChangeInfo(id, login, pass, role, name);
            fillUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUser.CurrentRow.Cells[0].Value;
            userService.deleteUser(id);
            fillUser();
        }
    }
}
