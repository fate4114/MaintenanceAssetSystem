using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class frmAssets : Form
    {
        public int AssetID = 0;
        public frmAssets()
        {
            InitializeComponent();
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {

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

        private void btnRequests_Click(object sender, EventArgs e)
        {
            frmRequest dash = new frmRequest();
            dash.Show();
            this.Hide(); // or this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
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
            MySqlConnection conn =
        new MySqlConnection(DBConnection.connString);

            string query = "SELECT * FROM Assets";

            MySqlDataAdapter da =
                new MySqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvAssets.DataSource = dt;

            // Total Assets
            lblTotalAssets.Text = dt.Rows.Count.ToString();

            // Available Assets
            int available = dt.Select("Status='Available'").Length;
            lblAvailable.Text = available.ToString();

            // Under Maintenance
            int maintenance = dt.Select("Status='Maintenance'").Length;
            lblMaintenance.Text = maintenance.ToString();
        }

        private void frmAssets_Load(object sender, EventArgs e)
        {
            LoadAssets();
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn =
                    new MySqlConnection(DBConnection.connString);

                conn.Open();

                string query;

                if (AssetID > 0)
                {
                    query = @"UPDATE Assets SET
                    Asset_Name=@name,
                    Category=@category,
                    Location=@location,
                    Status=@status
                    WHERE Asset_ID=@id";
                }
                else
                {
                    query = @"INSERT INTO Assets
                    (Asset_Name, Category, Location, Status)
                    VALUES
                    (@name,@category,@location,@status)";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtAssetName.Text);
                cmd.Parameters.AddWithValue("@category", txtAssetCategory.Text);
                cmd.Parameters.AddWithValue("@location", txtAssetLocation.Text);
                cmd.Parameters.AddWithValue("@status", cmbAssetStatus.Text);
                cmd.Parameters.AddWithValue("@id", AssetID);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Saved Successfully!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshAsset_Click(object sender, EventArgs e)
        {
            LoadAssets();
        }

        private void txtSearchAsset_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn =
                    new MySqlConnection(DBConnection.connString);

                string query =
                    "SELECT * FROM Assets WHERE Asset_Name LIKE @search";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearchAsset.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvAssets.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            if (dgvAssets.SelectedRows.Count > 0)
            {
                int assetID = Convert.ToInt32(
                    dgvAssets.SelectedRows[0].Cells["Asset_ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Delete this asset?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn =
                        new MySqlConnection(DBConnection.connString);

                    conn.Open();

                    string query =
                        "DELETE FROM Assets WHERE Asset_ID=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", assetID);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Asset Deleted!");

                    LoadAssets();
                }
            }
            else
            {
                MessageBox.Show("Select a row first.");
            }
        }

        private void btnEditAsset_Click(object sender, EventArgs e)
        {
            if (dgvAssets.SelectedRows.Count > 0)
            {
                frmAssets frm = new frmAssets();

                frm.AssetID = Convert.ToInt32(
                    dgvAssets.SelectedRows[0].Cells["Asset_ID"].Value);

                frm.txtAssetName.Text =
                    dgvAssets.SelectedRows[0].Cells["Asset_Name"].Value.ToString();

                frm.txtAssetCategory.Text =
                    dgvAssets.SelectedRows[0].Cells["Category"].Value.ToString();

                frm.txtAssetLocation.Text =
                    dgvAssets.SelectedRows[0].Cells["Location"].Value.ToString();

                frm.cmbAssetStatus.Text =
                    dgvAssets.SelectedRows[0].Cells["Status"].Value.ToString();

                frm.ShowDialog();

                LoadAssets();
            }
        }

        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            if (dgvAssets.SelectedRows.Count > 0)
            {
                frmAssets frm = new frmAssets();

                // PASS ID (important for UPDATE)
                frm.AssetID = Convert.ToInt32(
                    dgvAssets.SelectedRows[0].Cells["Asset_ID"].Value);

                // FILL FORM DATA
                frm.txtAssetName.Text =
                    dgvAssets.SelectedRows[0].Cells["Asset_Name"].Value.ToString();

                frm.txtAssetCategory.Text =
                    dgvAssets.SelectedRows[0].Cells["Category"].Value.ToString();

                frm.txtAssetLocation.Text =
                    dgvAssets.SelectedRows[0].Cells["Location"].Value.ToString();

                frm.cmbAssetStatus.Text =
                    dgvAssets.SelectedRows[0].Cells["Status"].Value.ToString();

                frm.ShowDialog();

                LoadAssets(); // refresh after update
            }
            else
            {
                MessageBox.Show("Pumili ka muna ng asset sa table.");
            }
        }
    }
}
