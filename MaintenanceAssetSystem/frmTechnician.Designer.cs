namespace MaintenanceAssetSystem
{
    partial class frmTechnician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechnician));
            this.pnlRequestTable = new System.Windows.Forms.Panel();
            this.btnEditTechnician = new System.Windows.Forms.Button();
            this.btnRefreshTechnician = new System.Windows.Forms.Button();
            this.btnDeleteTechnician = new System.Windows.Forms.Button();
            this.btnAddTechnician = new System.Windows.Forms.Button();
            this.txtSearchTechnician = new System.Windows.Forms.TextBox();
            this.lblSearchTechnician = new System.Windows.Forms.Label();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.colRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRequestsSubtitblTechniciansSubtitlele = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTechnicians = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.lblTechniciansTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnAssets = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAvailableTechnicians = new System.Windows.Forms.Panel();
            this.lblAvailableTechniciansText = new System.Windows.Forms.Label();
            this.pnlBusyTechnicians = new System.Windows.Forms.Panel();
            this.lblBusyTechniciansText = new System.Windows.Forms.Label();
            this.pnlTotalTechnicians = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblTotalTechniciansText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlRequestTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAvailableTechnicians.SuspendLayout();
            this.pnlBusyTechnicians.SuspendLayout();
            this.pnlTotalTechnicians.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRequestTable
            // 
            this.pnlRequestTable.BackColor = System.Drawing.Color.Silver;
            this.pnlRequestTable.Controls.Add(this.btnEditTechnician);
            this.pnlRequestTable.Controls.Add(this.btnRefreshTechnician);
            this.pnlRequestTable.Controls.Add(this.btnDeleteTechnician);
            this.pnlRequestTable.Controls.Add(this.btnAddTechnician);
            this.pnlRequestTable.Controls.Add(this.txtSearchTechnician);
            this.pnlRequestTable.Controls.Add(this.lblSearchTechnician);
            this.pnlRequestTable.Controls.Add(this.dgvRequest);
            this.pnlRequestTable.Location = new System.Drawing.Point(294, 376);
            this.pnlRequestTable.Name = "pnlRequestTable";
            this.pnlRequestTable.Size = new System.Drawing.Size(1613, 638);
            this.pnlRequestTable.TabIndex = 55;
            // 
            // btnEditTechnician
            // 
            this.btnEditTechnician.Location = new System.Drawing.Point(148, 9);
            this.btnEditTechnician.Name = "btnEditTechnician";
            this.btnEditTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnEditTechnician.TabIndex = 34;
            this.btnEditTechnician.Text = "Edit";
            this.btnEditTechnician.UseVisualStyleBackColor = true;
            // 
            // btnRefreshTechnician
            // 
            this.btnRefreshTechnician.Location = new System.Drawing.Point(394, 9);
            this.btnRefreshTechnician.Name = "btnRefreshTechnician";
            this.btnRefreshTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnRefreshTechnician.TabIndex = 33;
            this.btnRefreshTechnician.Text = "Referesh";
            this.btnRefreshTechnician.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTechnician
            // 
            this.btnDeleteTechnician.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTechnician.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTechnician.Location = new System.Drawing.Point(271, 9);
            this.btnDeleteTechnician.Name = "btnDeleteTechnician";
            this.btnDeleteTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnDeleteTechnician.TabIndex = 32;
            this.btnDeleteTechnician.Text = "Delete";
            this.btnDeleteTechnician.UseVisualStyleBackColor = false;
            // 
            // btnAddTechnician
            // 
            this.btnAddTechnician.BackColor = System.Drawing.Color.Navy;
            this.btnAddTechnician.ForeColor = System.Drawing.Color.White;
            this.btnAddTechnician.Location = new System.Drawing.Point(25, 9);
            this.btnAddTechnician.Name = "btnAddTechnician";
            this.btnAddTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnAddTechnician.TabIndex = 31;
            this.btnAddTechnician.Text = "Add Technician";
            this.btnAddTechnician.UseVisualStyleBackColor = false;
            // 
            // txtSearchTechnician
            // 
            this.txtSearchTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTechnician.Location = new System.Drawing.Point(1342, 18);
            this.txtSearchTechnician.Multiline = true;
            this.txtSearchTechnician.Name = "txtSearchTechnician";
            this.txtSearchTechnician.Size = new System.Drawing.Size(207, 29);
            this.txtSearchTechnician.TabIndex = 29;
            // 
            // lblSearchTechnician
            // 
            this.lblSearchTechnician.AutoSize = true;
            this.lblSearchTechnician.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTechnician.ForeColor = System.Drawing.Color.Black;
            this.lblSearchTechnician.Location = new System.Drawing.Point(1265, 18);
            this.lblSearchTechnician.Name = "lblSearchTechnician";
            this.lblSearchTechnician.Size = new System.Drawing.Size(71, 25);
            this.lblSearchTechnician.TabIndex = 28;
            this.lblSearchTechnician.Text = "Search";
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToResizeRows = false;
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequest.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequestID,
            this.colAsset,
            this.colRequestedBy,
            this.colTechnician,
            this.colStatus,
            this.colDateRequested,
            this.colPriority});
            this.dgvRequest.EnableHeadersVisualStyles = false;
            this.dgvRequest.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvRequest.Location = new System.Drawing.Point(25, 53);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersVisible = false;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(1524, 546);
            this.dgvRequest.TabIndex = 20;
            // 
            // colRequestID
            // 
            this.colRequestID.HeaderText = "Request ID";
            this.colRequestID.Name = "colRequestID";
            this.colRequestID.ReadOnly = true;
            // 
            // colAsset
            // 
            this.colAsset.HeaderText = "Asset";
            this.colAsset.Name = "colAsset";
            this.colAsset.ReadOnly = true;
            // 
            // colRequestedBy
            // 
            this.colRequestedBy.HeaderText = "Requested By";
            this.colRequestedBy.Name = "colRequestedBy";
            this.colRequestedBy.ReadOnly = true;
            // 
            // colTechnician
            // 
            this.colTechnician.HeaderText = "Technician";
            this.colTechnician.Name = "colTechnician";
            this.colTechnician.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colDateRequested
            // 
            this.colDateRequested.HeaderText = "Date Requested";
            this.colDateRequested.Name = "colDateRequested";
            this.colDateRequested.ReadOnly = true;
            // 
            // colPriority
            // 
            this.colPriority.HeaderText = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.ReadOnly = true;
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
            // lblRequestsSubtitblTechniciansSubtitlele
            // 
            this.lblRequestsSubtitblTechniciansSubtitlele.AutoSize = true;
            this.lblRequestsSubtitblTechniciansSubtitlele.BackColor = System.Drawing.Color.White;
            this.lblRequestsSubtitblTechniciansSubtitlele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestsSubtitblTechniciansSubtitlele.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRequestsSubtitblTechniciansSubtitlele.Location = new System.Drawing.Point(320, 74);
            this.lblRequestsSubtitblTechniciansSubtitlele.Name = "lblRequestsSubtitblTechniciansSubtitlele";
            this.lblRequestsSubtitblTechniciansSubtitlele.Size = new System.Drawing.Size(306, 25);
            this.lblRequestsSubtitblTechniciansSubtitlele.TabIndex = 54;
            this.lblRequestsSubtitblTechniciansSubtitlele.Text = "Manage maintenance technicians";
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
            this.btnTechnicians.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTechnicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicians.ForeColor = System.Drawing.Color.White;
            this.btnTechnicians.Location = new System.Drawing.Point(3, 482);
            this.btnTechnicians.Name = "btnTechnicians";
            this.btnTechnicians.Padding = new System.Windows.Forms.Padding(10);
            this.btnTechnicians.Size = new System.Drawing.Size(266, 64);
            this.btnTechnicians.TabIndex = 12;
            this.btnTechnicians.Text = "Technicians";
            this.btnTechnicians.UseVisualStyleBackColor = false;
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.Color.Navy;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.White;
            this.btnRequests.Location = new System.Drawing.Point(3, 412);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Padding = new System.Windows.Forms.Padding(10);
            this.btnRequests.Size = new System.Drawing.Size(266, 64);
            this.btnRequests.TabIndex = 10;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = false;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // lblTechniciansTitle
            // 
            this.lblTechniciansTitle.AutoSize = true;
            this.lblTechniciansTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechniciansTitle.Location = new System.Drawing.Point(316, 20);
            this.lblTechniciansTitle.Name = "lblTechniciansTitle";
            this.lblTechniciansTitle.Size = new System.Drawing.Size(236, 54);
            this.lblTechniciansTitle.TabIndex = 53;
            this.lblTechniciansTitle.Text = "Technicians";
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
            this.pnlSidebar.TabIndex = 48;
            // 
            // btnAssets
            // 
            this.btnAssets.BackColor = System.Drawing.Color.Navy;
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
            // pnlAvailableTechnicians
            // 
            this.pnlAvailableTechnicians.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAvailableTechnicians.Controls.Add(this.lblAvailableTechniciansText);
            this.pnlAvailableTechnicians.Location = new System.Drawing.Point(881, 124);
            this.pnlAvailableTechnicians.Name = "pnlAvailableTechnicians";
            this.pnlAvailableTechnicians.Size = new System.Drawing.Size(358, 233);
            this.pnlAvailableTechnicians.TabIndex = 58;
            // 
            // lblAvailableTechniciansText
            // 
            this.lblAvailableTechniciansText.AutoSize = true;
            this.lblAvailableTechniciansText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableTechniciansText.Location = new System.Drawing.Point(125, 19);
            this.lblAvailableTechniciansText.Name = "lblAvailableTechniciansText";
            this.lblAvailableTechniciansText.Size = new System.Drawing.Size(103, 30);
            this.lblAvailableTechniciansText.TabIndex = 1;
            this.lblAvailableTechniciansText.Text = "Available";
            // 
            // pnlBusyTechnicians
            // 
            this.pnlBusyTechnicians.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBusyTechnicians.Controls.Add(this.lblBusyTechniciansText);
            this.pnlBusyTechnicians.Location = new System.Drawing.Point(1276, 124);
            this.pnlBusyTechnicians.Name = "pnlBusyTechnicians";
            this.pnlBusyTechnicians.Size = new System.Drawing.Size(358, 233);
            this.pnlBusyTechnicians.TabIndex = 57;
            // 
            // lblBusyTechniciansText
            // 
            this.lblBusyTechniciansText.AutoSize = true;
            this.lblBusyTechniciansText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusyTechniciansText.Location = new System.Drawing.Point(154, 19);
            this.lblBusyTechniciansText.Name = "lblBusyTechniciansText";
            this.lblBusyTechniciansText.Size = new System.Drawing.Size(59, 30);
            this.lblBusyTechniciansText.TabIndex = 2;
            this.lblBusyTechniciansText.Text = "Busy";
            // 
            // pnlTotalTechnicians
            // 
            this.pnlTotalTechnicians.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalTechnicians.Controls.Add(this.lblDashboardTitle);
            this.pnlTotalTechnicians.Controls.Add(this.lblTotalTechniciansText);
            this.pnlTotalTechnicians.Location = new System.Drawing.Point(485, 124);
            this.pnlTotalTechnicians.Name = "pnlTotalTechnicians";
            this.pnlTotalTechnicians.Size = new System.Drawing.Size(358, 233);
            this.pnlTotalTechnicians.TabIndex = 56;
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
            // lblTotalTechniciansText
            // 
            this.lblTotalTechniciansText.AutoSize = true;
            this.lblTotalTechniciansText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTechniciansText.Location = new System.Drawing.Point(92, 19);
            this.lblTotalTechniciansText.Name = "lblTotalTechniciansText";
            this.lblTotalTechniciansText.Size = new System.Drawing.Size(179, 30);
            this.lblTotalTechniciansText.TabIndex = 0;
            this.lblTotalTechniciansText.Text = "Total Technicians";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(474, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 258);
            this.panel1.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(872, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 258);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(1267, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 258);
            this.panel3.TabIndex = 61;
            // 
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1026);
            this.Controls.Add(this.pnlAvailableTechnicians);
            this.Controls.Add(this.pnlBusyTechnicians);
            this.Controls.Add(this.pnlTotalTechnicians);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlRequestTable);
            this.Controls.Add(this.lblRequestsSubtitblTechniciansSubtitlele);
            this.Controls.Add(this.lblTechniciansTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmTechnician";
            this.Text = "frmTechnician";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRequestTable.ResumeLayout(false);
            this.pnlRequestTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAvailableTechnicians.ResumeLayout(false);
            this.pnlAvailableTechnicians.PerformLayout();
            this.pnlBusyTechnicians.ResumeLayout(false);
            this.pnlBusyTechnicians.PerformLayout();
            this.pnlTotalTechnicians.ResumeLayout(false);
            this.pnlTotalTechnicians.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlRequestTable;
        private System.Windows.Forms.TextBox txtSearchTechnician;
        private System.Windows.Forms.Label lblSearchTechnician;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateRequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRequestsSubtitblTechniciansSubtitlele;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTechnicians;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Label lblTechniciansTitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAvailableTechnicians;
        private System.Windows.Forms.Label lblAvailableTechniciansText;
        private System.Windows.Forms.Panel pnlBusyTechnicians;
        private System.Windows.Forms.Label lblBusyTechniciansText;
        private System.Windows.Forms.Panel pnlTotalTechnicians;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblTotalTechniciansText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditTechnician;
        private System.Windows.Forms.Button btnRefreshTechnician;
        private System.Windows.Forms.Button btnDeleteTechnician;
        private System.Windows.Forms.Button btnAddTechnician;
    }
}