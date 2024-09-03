using lab_03.BL.Services;
using System;
using System.Windows.Forms;

namespace FootballLeague.WindowFormViews
{
    public partial class ClubForm : Form
    {
        private ClubService clubService;
        private string role;
        public ClubForm(ClubService clubService, string role = "NotGuest")
        {
            InitializeComponent();
            this.clubService = clubService;
            this.role = role;
        }
        private void showAllClubs()
        {
            dgvClub.Rows.Clear();
            var clubs = clubService.getAll();
            foreach (var c in clubs)
            {
                dgvClub.Rows.Add(c.Id, c.Name);
            }
        }

        private void ClubForm_Load(object sender, EventArgs e)
        {
            showAllClubs();
            if (role == "Guest")
            {
                panel2.Enabled = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null)
            {
                string name = tbName.Text;
                clubService.insertClub(name);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null)
            {
                string newName = tbName.Text;
                int id = (int)dgvClub.CurrentRow.Cells[0].Value;
                clubService.modifyClub(id, newName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvClub.CurrentRow.Cells[0].Value;
            clubService.deleteClub(id);
        }

        private void dgvClub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClub.CurrentRow.Cells[0].Value != null)
            {
                int id = (int)dgvClub.CurrentRow.Cells[0].Value;
                tbName.Text = clubService.getNameClubById(id);
            }
        }
    }
}
