namespace MaintenanceAssetSystem
{
    partial class frmAssets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssets));
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.lblAvailableAssetsText = new System.Windows.Forms.Label();
            this.pnlAvailableAssets = new System.Windows.Forms.Panel();
            this.lblMaintenanceAssetsText = new System.Windows.Forms.Label();
            this.pnlMaintenanceAssets = new System.Windows.Forms.Panel();
            this.pnlTotalAssets = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblTotalAssetsText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pnlAssetTable = new System.Windows.Forms.Panel();
            this.btnEditAsset = new System.Windows.Forms.Button();
            this.txtSearchAsset = new System.Windows.Forms.TextBox();
            this.lblSearchAsset = new System.Windows.Forms.Label();
            this.btnRefreshAsset = new System.Windows.Forms.Button();
            this.btnDeleteAsset = new System.Windows.Forms.Button();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTechnicians = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAssets = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAssetsSubtitle = new System.Windows.Forms.Label();
            this.lblAssetsTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalAssets = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.txtAssetCategory = new System.Windows.Forms.TextBox();
            this.txtAssetLocation = new System.Windows.Forms.TextBox();
            this.cmbAssetStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateAsset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.pnlAvailableAssets.SuspendLayout();
            this.pnlMaintenanceAssets.SuspendLayout();
            this.pnlTotalAssets.SuspendLayout();
            this.pnlAssetTable.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssets
            // 
            this.dgvAssets.AllowUserToAddRows = false;
            this.dgvAssets.AllowUserToResizeRows = false;
            this.dgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssets.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAssets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.EnableHeadersVisualStyles = false;
            this.dgvAssets.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAssets.Location = new System.Drawing.Point(560, 53);
            this.dgvAssets.MultiSelect = false;
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersVisible = false;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(989, 546);
            this.dgvAssets.TabIndex = 20;
            // 
            // lblAvailableAssetsText
            // 
            this.lblAvailableAssetsText.AutoSize = true;
            this.lblAvailableAssetsText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableAssetsText.Location = new System.Drawing.Point(125, 19);
            this.lblAvailableAssetsText.Name = "lblAvailableAssetsText";
            this.lblAvailableAssetsText.Size = new System.Drawing.Size(134, 40);
            this.lblAvailableAssetsText.TabIndex = 1;
            this.lblAvailableAssetsText.Text = "Avalable";
            // 
            // pnlAvailableAssets
            // 
            this.pnlAvailableAssets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAvailableAssets.Controls.Add(this.lblAvailable);
            this.pnlAvailableAssets.Controls.Add(this.lblAvailableAssetsText);
            this.pnlAvailableAssets.Location = new System.Drawing.Point(905, 124);
            this.pnlAvailableAssets.Name = "pnlAvailableAssets";
            this.pnlAvailableAssets.Size = new System.Drawing.Size(358, 233);
            this.pnlAvailableAssets.TabIndex = 32;
            // 
            // lblMaintenanceAssetsText
            // 
            this.lblMaintenanceAssetsText.AutoSize = true;
            this.lblMaintenanceAssetsText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceAssetsText.Location = new System.Drawing.Point(44, 19);
            this.lblMaintenanceAssetsText.Name = "lblMaintenanceAssetsText";
            this.lblMaintenanceAssetsText.Size = new System.Drawing.Size(289, 40);
            this.lblMaintenanceAssetsText.TabIndex = 2;
            this.lblMaintenanceAssetsText.Text = "Under Maintenance";
            // 
            // pnlMaintenanceAssets
            // 
            this.pnlMaintenanceAssets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMaintenanceAssets.Controls.Add(this.lblMaintenance);
            this.pnlMaintenanceAssets.Controls.Add(this.lblMaintenanceAssetsText);
            this.pnlMaintenanceAssets.Location = new System.Drawing.Point(1300, 124);
            this.pnlMaintenanceAssets.Name = "pnlMaintenanceAssets";
            this.pnlMaintenanceAssets.Size = new System.Drawing.Size(358, 233);
            this.pnlMaintenanceAssets.TabIndex = 31;
            // 
            // pnlTotalAssets
            // 
            this.pnlTotalAssets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssets);
            this.pnlTotalAssets.Controls.Add(this.lblDashboardTitle);
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsText);
            this.pnlTotalAssets.Location = new System.Drawing.Point(509, 124);
            this.pnlTotalAssets.Name = "pnlTotalAssets";
            this.pnlTotalAssets.Size = new System.Drawing.Size(358, 233);
            this.pnlTotalAssets.TabIndex = 29;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(-9, -54);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(229, 54);
            this.lblDashboardTitle.TabIndex = 27;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // lblTotalAssetsText
            // 
            this.lblTotalAssetsText.AutoSize = true;
            this.lblTotalAssetsText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetsText.Location = new System.Drawing.Point(102, 19);
            this.lblTotalAssetsText.Name = "lblTotalAssetsText";
            this.lblTotalAssetsText.Size = new System.Drawing.Size(178, 40);
            this.lblTotalAssetsText.TabIndex = 0;
            this.lblTotalAssetsText.Text = "Total Assets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(67, 912);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "admin";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(67, 892);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(108, 20);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Administrator";
            // 
            // pnlAssetTable
            // 
            this.pnlAssetTable.BackColor = System.Drawing.Color.Silver;
            this.pnlAssetTable.Controls.Add(this.groupBox1);
            this.pnlAssetTable.Controls.Add(this.txtSearchAsset);
            this.pnlAssetTable.Controls.Add(this.lblSearchAsset);
            this.pnlAssetTable.Controls.Add(this.dgvAssets);
            this.pnlAssetTable.Location = new System.Drawing.Point(288, 376);
            this.pnlAssetTable.Name = "pnlAssetTable";
            this.pnlAssetTable.Size = new System.Drawing.Size(1613, 638);
            this.pnlAssetTable.TabIndex = 33;
            // 
            // btnEditAsset
            // 
            this.btnEditAsset.Location = new System.Drawing.Point(354, 140);
            this.btnEditAsset.Name = "btnEditAsset";
            this.btnEditAsset.Size = new System.Drawing.Size(142, 44);
            this.btnEditAsset.TabIndex = 30;
            this.btnEditAsset.Text = "Edit";
            this.btnEditAsset.UseVisualStyleBackColor = true;
            this.btnEditAsset.Click += new System.EventHandler(this.btnEditAsset_Click);
            // 
            // txtSearchAsset
            // 
            this.txtSearchAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAsset.Location = new System.Drawing.Point(1342, 18);
            this.txtSearchAsset.Multiline = true;
            this.txtSearchAsset.Name = "txtSearchAsset";
            this.txtSearchAsset.Size = new System.Drawing.Size(207, 29);
            this.txtSearchAsset.TabIndex = 29;
            this.txtSearchAsset.TextChanged += new System.EventHandler(this.txtSearchAsset_TextChanged);
            // 
            // lblSearchAsset
            // 
            this.lblSearchAsset.AutoSize = true;
            this.lblSearchAsset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAsset.ForeColor = System.Drawing.Color.Black;
            this.lblSearchAsset.Location = new System.Drawing.Point(1265, 18);
            this.lblSearchAsset.Name = "lblSearchAsset";
            this.lblSearchAsset.Size = new System.Drawing.Size(71, 25);
            this.lblSearchAsset.TabIndex = 28;
            this.lblSearchAsset.Text = "Search";
            // 
            // btnRefreshAsset
            // 
            this.btnRefreshAsset.Location = new System.Drawing.Point(354, 250);
            this.btnRefreshAsset.Name = "btnRefreshAsset";
            this.btnRefreshAsset.Size = new System.Drawing.Size(142, 44);
            this.btnRefreshAsset.TabIndex = 27;
            this.btnRefreshAsset.Text = "Referesh";
            this.btnRefreshAsset.UseVisualStyleBackColor = true;
            this.btnRefreshAsset.Click += new System.EventHandler(this.btnRefreshAsset_Click);
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAsset.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAsset.Location = new System.Drawing.Point(354, 190);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(142, 54);
            this.btnDeleteAsset.TabIndex = 26;
            this.btnDeleteAsset.Text = "Delete";
            this.btnDeleteAsset.UseVisualStyleBackColor = false;
            this.btnDeleteAsset.Click += new System.EventHandler(this.btnDeleteAsset_Click);
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.BackColor = System.Drawing.Color.Navy;
            this.btnAddAsset.ForeColor = System.Drawing.Color.White;
            this.btnAddAsset.Location = new System.Drawing.Point(354, 24);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(142, 53);
            this.btnAddAsset.TabIndex = 24;
            this.btnAddAsset.Text = "Add Assets";
            this.btnAddAsset.UseVisualStyleBackColor = false;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(3, 964);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogout.Size = new System.Drawing.Size(266, 50);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 853);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 10);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnTechnicians
            // 
            this.btnTechnicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicians.ForeColor = System.Drawing.Color.White;
            this.btnTechnicians.Location = new System.Drawing.Point(3, 482);
            this.btnTechnicians.Name = "btnTechnicians";
            this.btnTechnicians.Padding = new System.Windows.Forms.Padding(10);
            this.btnTechnicians.Size = new System.Drawing.Size(266, 64);
            this.btnTechnicians.TabIndex = 12;
            this.btnTechnicians.Text = "Technicians";
            this.btnTechnicians.UseVisualStyleBackColor = true;
            this.btnTechnicians.Click += new System.EventHandler(this.btnTechnicians_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.White;
            this.btnRequests.Location = new System.Drawing.Point(3, 412);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Padding = new System.Windows.Forms.Padding(10);
            this.btnRequests.Size = new System.Drawing.Size(266, 64);
            this.btnRequests.TabIndex = 10;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Navy;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(3, 272);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(266, 64);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(36, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asset Tracking Sytem";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(77, 151);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(118, 47);
            this.lblSystemName.TabIndex = 3;
            this.lblSystemName.Text = "MATS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(17, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maintenance Request and\r\n";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Navy;
            this.pnlSidebar.Controls.Add(this.label4);
            this.pnlSidebar.Controls.Add(this.Label1);
            this.pnlSidebar.Controls.Add(this.pictureBox2);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.flowLayoutPanel1);
            this.pnlSidebar.Controls.Add(this.btnTechnicians);
            this.pnlSidebar.Controls.Add(this.btnRequests);
            this.pnlSidebar.Controls.Add(this.btnAssets);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.lblSystemName);
            this.pnlSidebar.Controls.Add(this.label3);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(272, 1026);
            this.pnlSidebar.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MaintenanceAssetSystem.Properties.Resources.download__14_;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 892);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnAssets
            // 
            this.btnAssets.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssets.ForeColor = System.Drawing.Color.White;
            this.btnAssets.Location = new System.Drawing.Point(3, 342);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Padding = new System.Windows.Forms.Padding(10);
            this.btnAssets.Size = new System.Drawing.Size(266, 64);
            this.btnAssets.TabIndex = 9;
            this.btnAssets.Text = "Assets";
            this.btnAssets.UseVisualStyleBackColor = false;
            this.btnAssets.Click += new System.EventHandler(this.btnAssets_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaintenanceAssetSystem.Properties.Resources.Screenshot_2026_06_20_023846;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblAssetsSubtitle
            // 
            this.lblAssetsSubtitle.AutoSize = true;
            this.lblAssetsSubtitle.BackColor = System.Drawing.Color.White;
            this.lblAssetsSubtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetsSubtitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAssetsSubtitle.Location = new System.Drawing.Point(308, 74);
            this.lblAssetsSubtitle.Name = "lblAssetsSubtitle";
            this.lblAssetsSubtitle.Size = new System.Drawing.Size(260, 25);
            this.lblAssetsSubtitle.TabIndex = 35;
            this.lblAssetsSubtitle.Text = "Manage all registered assets";
            // 
            // lblAssetsTitle
            // 
            this.lblAssetsTitle.AutoSize = true;
            this.lblAssetsTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetsTitle.Location = new System.Drawing.Point(304, 20);
            this.lblAssetsTitle.Name = "lblAssetsTitle";
            this.lblAssetsTitle.Size = new System.Drawing.Size(143, 54);
            this.lblAssetsTitle.TabIndex = 34;
            this.lblAssetsTitle.Text = "Assets";
            this.lblAssetsTitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(498, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 258);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(896, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 258);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(1291, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 258);
            this.panel3.TabIndex = 38;
            // 
            // lblTotalAssets
            // 
            this.lblTotalAssets.AutoSize = true;
            this.lblTotalAssets.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssets.Location = new System.Drawing.Point(165, 74);
            this.lblTotalAssets.Name = "lblTotalAssets";
            this.lblTotalAssets.Size = new System.Drawing.Size(38, 45);
            this.lblTotalAssets.TabIndex = 28;
            this.lblTotalAssets.Text = "0";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(162, 79);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(38, 45);
            this.lblAvailable.TabIndex = 29;
            this.lblAvailable.Text = "0";
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.Location = new System.Drawing.Point(163, 74);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(38, 45);
            this.lblMaintenance.TabIndex = 30;
            this.lblMaintenance.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnUpdateAsset);
            this.groupBox1.Controls.Add(this.btnAddAsset);
            this.groupBox1.Controls.Add(this.btnRefreshAsset);
            this.groupBox1.Controls.Add(this.cmbAssetStatus);
            this.groupBox1.Controls.Add(this.btnEditAsset);
            this.groupBox1.Controls.Add(this.txtAssetLocation);
            this.groupBox1.Controls.Add(this.btnDeleteAsset);
            this.groupBox1.Controls.Add(this.txtAssetCategory);
            this.groupBox1.Controls.Add(this.txtAssetName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 325);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Asset Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.GhostWhite;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GhostWhite;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GhostWhite;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Status";
            // 
            // txtAssetName
            // 
            this.txtAssetName.Location = new System.Drawing.Point(103, 29);
            this.txtAssetName.Multiline = true;
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(211, 29);
            this.txtAssetName.TabIndex = 35;
            // 
            // txtAssetCategory
            // 
            this.txtAssetCategory.Location = new System.Drawing.Point(103, 88);
            this.txtAssetCategory.Multiline = true;
            this.txtAssetCategory.Name = "txtAssetCategory";
            this.txtAssetCategory.Size = new System.Drawing.Size(211, 29);
            this.txtAssetCategory.TabIndex = 36;
            // 
            // txtAssetLocation
            // 
            this.txtAssetLocation.Location = new System.Drawing.Point(103, 141);
            this.txtAssetLocation.Multiline = true;
            this.txtAssetLocation.Name = "txtAssetLocation";
            this.txtAssetLocation.Size = new System.Drawing.Size(211, 29);
            this.txtAssetLocation.TabIndex = 37;
            // 
            // cmbAssetStatus
            // 
            this.cmbAssetStatus.FormattingEnabled = true;
            this.cmbAssetStatus.Items.AddRange(new object[] {
            "Available",
            "",
            "In Use",
            "",
            "Under Maintenance",
            "",
            "Disposed"});
            this.cmbAssetStatus.Location = new System.Drawing.Point(103, 206);
            this.cmbAssetStatus.Name = "cmbAssetStatus";
            this.cmbAssetStatus.Size = new System.Drawing.Size(211, 21);
            this.cmbAssetStatus.TabIndex = 38;
            // 
            // btnUpdateAsset
            // 
            this.btnUpdateAsset.Location = new System.Drawing.Point(354, 87);
            this.btnUpdateAsset.Name = "btnUpdateAsset";
            this.btnUpdateAsset.Size = new System.Drawing.Size(142, 44);
            this.btnUpdateAsset.TabIndex = 39;
            this.btnUpdateAsset.Text = "Update";
            this.btnUpdateAsset.UseVisualStyleBackColor = true;
            this.btnUpdateAsset.Click += new System.EventHandler(this.btnUpdateAsset_Click);
            // 
            // frmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1913, 1026);
            this.Controls.Add(this.lblAssetsSubtitle);
            this.Controls.Add(this.lblAssetsTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlAvailableAssets);
            this.Controls.Add(this.pnlMaintenanceAssets);
            this.Controls.Add(this.pnlTotalAssets);
            this.Controls.Add(this.pnlAssetTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmAssets";
            this.Text = "frmAssets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAssets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.pnlAvailableAssets.ResumeLayout(false);
            this.pnlAvailableAssets.PerformLayout();
            this.pnlMaintenanceAssets.ResumeLayout(false);
            this.pnlMaintenanceAssets.PerformLayout();
            this.pnlTotalAssets.ResumeLayout(false);
            this.pnlTotalAssets.PerformLayout();
            this.pnlAssetTable.ResumeLayout(false);
            this.pnlAssetTable.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.Label lblAvailableAssetsText;
        private System.Windows.Forms.Panel pnlAvailableAssets;
        private System.Windows.Forms.Label lblMaintenanceAssetsText;
        private System.Windows.Forms.Panel pnlMaintenanceAssets;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlTotalAssets;
        private System.Windows.Forms.Label lblTotalAssetsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel pnlAssetTable;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTechnicians;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Label lblAssetsSubtitle;
        private System.Windows.Forms.Label lblAssetsTitle;
        private System.Windows.Forms.Label lblSearchAsset;
        private System.Windows.Forms.Button btnRefreshAsset;
        private System.Windows.Forms.Button btnDeleteAsset;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.TextBox txtSearchAsset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditAsset;
        private System.Windows.Forms.Label lblTotalAssets;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAssetStatus;
        private System.Windows.Forms.TextBox txtAssetLocation;
        private System.Windows.Forms.TextBox txtAssetCategory;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateAsset;
    }
}