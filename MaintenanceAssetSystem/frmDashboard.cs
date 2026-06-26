using MySql.Data.MySqlClient;
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

        private void LoadDashboard()
        {
            MySqlConnection conn =
                new MySqlConnection(DBConnection.connString);

            conn.Open();

            // TOTAL ASSETS
            MySqlCommand cmd1 =
                new MySqlCommand("SELECT COUNT(*) FROM Assets", conn);

            Label.Text =
                cmd1.ExecuteScalar().ToString();

            // PENDING REQUESTS
            MySqlCommand cmd2 =
                new MySqlCommand("SELECT COUNT(*) FROM Requests WHERE Status='Pending'", conn);

            lblPendingRequests.Text =
                cmd2.ExecuteScalar().ToString();

            // COMPLETED
            MySqlCommand cmd3 =
                new MySqlCommand("SELECT COUNT(*) FROM Requests WHERE Status='Completed'", conn);

            lblCompletedMaintenance.Text =
                cmd3.ExecuteScalar().ToString();

            // TECHNICIANS
            MySqlCommand cmd4 =
                new MySqlCommand("SELECT COUNT(*) FROM Technicians", conn);

            lblTotalTechnicians.Text =
                cmd4.ExecuteScalar().ToString();

            conn.Close();

            LoadRecentRequests();
        }

        private void LoadRecentRequests()
        {
            MySqlConnection conn =
                new MySqlConnection(DBConnection.connString);

            string query = @"
            SELECT
                r.Request_ID,
                a.Asset_Name AS Asset,
                r.Requested_By,
                t.Full_Name AS Technician,
                r.Status,
                r.Date_Requested
            FROM Requests r
            INNER JOIN Assets a
                ON r.Asset_ID = a.Asset_ID
            INNER JOIN Technicians t
                ON r.Technician_ID = t.Technician_ID
            ORDER BY r.Date_Requested DESC
            LIMIT 5";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvDashboard.DataSource = dt;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();

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

