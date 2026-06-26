using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceAssetSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            {
                MakeCircle(pictureBox1);
                MakeCircle(pictureBox2);
            }

            dgvRequests.Rows.Add(
                "MR-2025-0012",
                "Dell Laptop",
                "Francine Manabat",
                "Jaycel Suarez",
                "Pending",
                "May 13, 2025");

            dgvRequests.Rows.Add(
                "MR-2025-0011",
                "Projector",
                "Joshua Garcia",
                "Marty De Jesus",
                "Completed",
                "May 12, 2025");

        }

            private void MakeCircle(PictureBox pic)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pic.Width, pic.Height);
            pic.Region = new Region(gp);
        }

        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
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

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            frmAssets dash = new frmAssets();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            frmRequest dash = new frmRequest();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            frmTechnician dash = new frmTechnician();
            dash.Show();
            this.Hide(); // or this.Close();
        }
    }
    }

