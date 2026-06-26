using MySql.Data.MySqlClient;
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

        private void LoadTechnicians()
        {
            MySqlConnection conn =
                new MySqlConnection(DBConnection.connString);

            string query = "SELECT * FROM Technicians";

            MySqlDataAdapter da =
                new MySqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvTechnician.DataSource = dt;

            lblTotalTechnicians.Text = dt.Rows.Count.ToString();

            int available = dt.Select("Status='Available'").Length;
            lblAvailableTech.Text = available.ToString();

            int busy = dt.Select("Status='Busy'").Length;
            lblBusyTech.Text = busy.ToString();
        }
        private void frmTechnician_Load(object sender, EventArgs e)
        {
            LoadTechnicians();

            cmbSpecialization.SelectedIndex = -1;
            cmbTechStatus.SelectedIndex = -1;
        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn =
                    new MySqlConnection(DBConnection.connString);

                conn.Open();

                string query = @"INSERT INTO Technicians
        (Full_Name, Contact_No, Specialization, Status)
        VALUES
        (@name,@contact,@spec,@status)";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@contact", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@spec", cmbSpecialization.Text);
                cmd.Parameters.AddWithValue("@status", cmbTechStatus.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Technician Added!");

                LoadTechnicians();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditTechnician_Click(object sender, EventArgs e)
        {
            if (txtTechnicianID.Text == "")
            {
                MessageBox.Show("Select a technician first.");
                return;
            }

            MySqlConnection conn =
                new MySqlConnection(DBConnection.connString);

            conn.Open();

            string query = @"UPDATE Technicians SET
               Full_Name=@name,
               Contact_No=@contact,
               Specialization=@spec,
               Status=@status
               WHERE Technician_ID=@id";

            MySqlCommand cmd =
                new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", txtFullName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContactNo.Text);
            cmd.Parameters.AddWithValue("@spec", cmbSpecialization.Text);
            cmd.Parameters.AddWithValue("@status", cmbTechStatus.Text);
            cmd.Parameters.AddWithValue("@id", txtTechnicianID.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Technician Updated!");

            LoadTechnicians();
        }

        private void btnDeleteTechnician_Click(object sender, EventArgs e)
        {
            if (txtTechnicianID.Text == "")
            {
                MessageBox.Show("Select a technician first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete this technician?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MySqlConnection conn =
                    new MySqlConnection(DBConnection.connString);

                conn.Open();

                string query =
                    "DELETE FROM Technicians WHERE Technician_ID=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtTechnicianID.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Technician Deleted!");

                LoadTechnicians();
            }
        }

        private void btnRefreshTechnician_Click(object sender, EventArgs e)
        {
            LoadTechnicians();
        }

        private void txtSearchTechnician_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn =
        new MySqlConnection(DBConnection.connString);

            string query =
                "SELECT * FROM Technicians WHERE Full_Name LIKE @search";

            MySqlDataAdapter da =
                new MySqlDataAdapter(query, conn);

            da.SelectCommand.Parameters.AddWithValue(
                "@search",
                "%" + txtSearchTechnician.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvTechnician.DataSource = dt;
        }

        private void dgvTechnician_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTechnician.Rows[e.RowIndex];

                txtTechnicianID.Text =
                    row.Cells["Technician_ID"].Value.ToString();

                txtFullName.Text =
                    row.Cells["Full_Name"].Value.ToString();

                txtContactNo.Text =
                    row.Cells["Contact_No"].Value.ToString();

                cmbSpecialization.Text =
                    row.Cells["Specialization"].Value.ToString();

                cmbTechStatus.Text =
                    row.Cells["Status"].Value.ToString();
            }
        }
    }
    }
