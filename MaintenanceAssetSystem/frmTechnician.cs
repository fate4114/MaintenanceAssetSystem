using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceAssetSystem
{
    public partial class frmTechnician : Form
    {
        public frmTechnician()
        {
            InitializeComponent();
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            frmAssets dash = new frmAssets();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            frmRequest dash = new frmRequest();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    }
