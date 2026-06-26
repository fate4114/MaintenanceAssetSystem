using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaintenanceAssetSystem
{
    public partial class frmRequest : Form
    {
        public int RequestID = 0;
        public frmRequest()
        {
            InitializeComponent();
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

        private void btnAssets_Click(object sender, EventArgs e)
        {
            frmAssets dash = new frmAssets();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void RoundPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRequests_Click(object sender, EventArgs e)
        {

        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            frmTechnician dash = new frmTechnician();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void LoadAssets()
        {
            MySqlConnection conn = new MySqlConnection(DBConnection.connString);

            conn.Open();

            string query = "SELECT Asset_ID, Asset_Name FROM Assets";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbAsset.DataSource = dt;
            cmbAsset.DisplayMember = "Asset_Name";
            cmbAsset.ValueMember = "Asset_ID";

            
            cmbAsset.SelectedIndex = -1;
            cmbAsset.Text = "";

            conn.Close();
        }

        private void LoadRequests()
        {
            MySqlConnection conn = new MySqlConnection(DBConnection.connString);

            string query = "SELECT * FROM Requests";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvRequest.DataSource = dt;

            lblTotalRequest.Text = dt.Rows.Count.ToString();

            lblPending.Text =
                dt.Select("Status='Pending'").Length.ToString();

            lblInProgress.Text =
                dt.Select("Status='In Progress'").Length.ToString();

            lblCompleted.Text =
                dt.Select("Status='Completed'").Length.ToString();
        }

        private void LoadTechnicians()
        {
            MySqlConnection conn =
                new MySqlConnection(DBConnection.connString);

            conn.Open();

            string query =
                "SELECT Technician_ID, Full_Name FROM Technicians";

            MySqlDataAdapter da =
                new MySqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbTechnician.DataSource = dt;

            // kung ID lang gusto mong makita
            cmbTechnician.DisplayMember = "Technician_ID";
            cmbTechnician.ValueMember = "Technician_ID";

            cmbTechnician.SelectedIndex = -1;
            cmbTechnician.Text = "";

            conn.Close();
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            LoadAssets();
            LoadTechnicians();

            // STATUS
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Completed");

            // PRIORITY
            cmbPriority.Items.Clear();
            cmbPriority.Items.Add("Low");
            cmbPriority.Items.Add("Medium");
            cmbPriority.Items.Add("High");

            // walang default na naka-select
            cmbStatus.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;

            LoadRequests();
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn =
                    new MySqlConnection(DBConnection.connString);

                conn.Open();

                string query = @"INSERT INTO Requests
        (Asset_ID, Requested_By, Technician_ID, Status, Priority, Date_Requested)
        VALUES
        (@asset,@requestedby,@tech,@status,@priority,@date)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@asset", cmbAsset.SelectedValue);
                cmd.Parameters.AddWithValue("@requestedby", txtRequestedBy.Text);
                cmd.Parameters.AddWithValue("@tech", cmbTechnician.SelectedValue);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@priority", cmbPriority.Text);
                cmd.Parameters.AddWithValue("@date", dtpRequestDate.Value);

                cmd.ExecuteNonQuery();

               

                MessageBox.Show("Request Added Successfully!");

                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateRequest_Click(object sender, EventArgs e)
        {
            if (txtRequestID.Text == "")
            {
                MessageBox.Show("Select a request first.");
                return;
            }

            MySqlConnection conn =
                new MySqlConnection(DBConnection.connString);

            conn.Open();

            string query = @"UPDATE Requests SET
        Asset_ID=@asset,
        Requested_By=@requestedby,
        Technician_ID=@tech,
        Status=@status,
        Priority=@priority,
        Date_Requested=@date
        WHERE Request_ID=@id";

            MySqlCommand cmd =
                new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@asset", cmbAsset.SelectedValue);
            cmd.Parameters.AddWithValue("@requestedby", txtRequestedBy.Text);
            cmd.Parameters.AddWithValue("@tech", cmbTechnician.SelectedValue);
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@priority", cmbPriority.Text);
            cmd.Parameters.AddWithValue("@date", dtpRequestDate.Value);
            cmd.Parameters.AddWithValue("@id", txtRequestID.Text);

            cmd.ExecuteNonQuery();


            MessageBox.Show("Request Updated!");

            LoadRequests();
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            if (txtRequestID.Text == "")
            {
                MessageBox.Show("Select a request first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete this request?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MySqlConnection conn =
                    new MySqlConnection(DBConnection.connString);

                conn.Open();

                string query =
                    "DELETE FROM Requests WHERE Request_ID=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtRequestID.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Request Deleted!");

                LoadRequests();
            }
        }

        private void btnRefreshRequest_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void txtSearchRequest_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn =
        new MySqlConnection(DBConnection.connString);

            string query =
            @"SELECT * FROM Requests
      WHERE Requested_By LIKE @search";

            MySqlDataAdapter da =
                new MySqlDataAdapter(query, conn);

            da.SelectCommand.Parameters.AddWithValue(
                "@search",
                "%" + txtSearchRequest.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvRequest.DataSource = dt;
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRequest.Rows[e.RowIndex];

                txtRequestID.Text = row.Cells["Request_ID"].Value.ToString();
                cmbAsset.SelectedValue = row.Cells["Asset_ID"].Value;
                txtRequestedBy.Text = row.Cells["Requested_By"].Value.ToString();
                cmbTechnician.SelectedValue = row.Cells["Technician_ID"].Value;
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
                cmbPriority.Text = row.Cells["Priority"].Value.ToString();
                dtpRequestDate.Value = Convert.ToDateTime(row.Cells["Date_Requested"].Value);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (txtRequestID.Text == "")
            {
                MessageBox.Show("Please select a request first.");
                return;
            }

            string details =
                "Request ID: " + txtRequestID.Text +
                "\nAsset: " + cmbAsset.Text +
                "\nRequested By: " + txtRequestedBy.Text +
                "\nTechnician: " + cmbTechnician.Text +
                "\nStatus: " + cmbStatus.Text +
                "\nPriority: " + cmbPriority.Text +
                "\nDate Requested: " + dtpRequestDate.Value.ToShortDateString();

            MessageBox.Show(
                details,
                "Request Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
