namespace MaintenanceAssetSystem
{
    partial class frmRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequest));
            this.label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.btnAssets = new System.Windows.Forms.Button();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRequestsSubtitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTechnicians = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblRequestsTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCompleted = new System.Windows.Forms.Panel();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.pnlTotalRequests = new System.Windows.Forms.Panel();
            this.lblTotalRequestsText = new System.Windows.Forms.Label();
            this.pnlInProgress = new System.Windows.Forms.Panel();
            this.lblInProgressCount = new System.Windows.Forms.Label();
            this.pnlPendingRequests = new System.Windows.Forms.Panel();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.pnlRequestTable = new System.Windows.Forms.Panel();
            this.btnEditRequest = new System.Windows.Forms.Button();
            this.txtSearchRequest = new System.Windows.Forms.TextBox();
            this.lblSearchAsset = new System.Windows.Forms.Label();
            this.btnRefreshAsset = new System.Windows.Forms.Button();
            this.btnCancelRequest = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.colRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlCompleted.SuspendLayout();
            this.pnlTotalRequests.SuspendLayout();
            this.pnlInProgress.SuspendLayout();
            this.pnlPendingRequests.SuspendLayout();
            this.pnlRequestTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // lblRequestsSubtitle
            // 
            this.lblRequestsSubtitle.AutoSize = true;
            this.lblRequestsSubtitle.BackColor = System.Drawing.Color.White;
            this.lblRequestsSubtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestsSubtitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRequestsSubtitle.Location = new System.Drawing.Point(314, 74);
            this.lblRequestsSubtitle.Name = "lblRequestsSubtitle";
            this.lblRequestsSubtitle.Size = new System.Drawing.Size(397, 25);
            this.lblRequestsSubtitle.TabIndex = 43;
            this.lblRequestsSubtitle.Text = "Manage and track all maintenance requests";
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
            this.btnRequests.BackColor = System.Drawing.Color.LightSteelBlue;
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
            // lblRequestsTitle
            // 
            this.lblRequestsTitle.AutoSize = true;
            this.lblRequestsTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestsTitle.Location = new System.Drawing.Point(310, 20);
            this.lblRequestsTitle.Name = "lblRequestsTitle";
            this.lblRequestsTitle.Size = new System.Drawing.Size(175, 54);
            this.lblRequestsTitle.TabIndex = 42;
            this.lblRequestsTitle.Text = "Request";
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
            this.pnlSidebar.TabIndex = 36;
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
            // pnlCompleted
            // 
            this.pnlCompleted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCompleted.Controls.Add(this.lblCompletedCount);
            this.pnlCompleted.Location = new System.Drawing.Point(1513, 124);
            this.pnlCompleted.Name = "pnlCompleted";
            this.pnlCompleted.Size = new System.Drawing.Size(358, 233);
            this.pnlCompleted.TabIndex = 38;
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedCount.Location = new System.Drawing.Point(120, 19);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(120, 30);
            this.lblCompletedCount.TabIndex = 3;
            this.lblCompletedCount.Text = "Completed";
            // 
            // pnlTotalRequests
            // 
            this.pnlTotalRequests.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalRequests.Controls.Add(this.lblDashboardTitle);
            this.pnlTotalRequests.Controls.Add(this.lblTotalRequestsText);
            this.pnlTotalRequests.Location = new System.Drawing.Point(331, 124);
            this.pnlTotalRequests.Name = "pnlTotalRequests";
            this.pnlTotalRequests.Size = new System.Drawing.Size(358, 233);
            this.pnlTotalRequests.TabIndex = 37;
            // 
            // lblTotalRequestsText
            // 
            this.lblTotalRequestsText.AutoSize = true;
            this.lblTotalRequestsText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRequestsText.Location = new System.Drawing.Point(115, 19);
            this.lblTotalRequestsText.Name = "lblTotalRequestsText";
            this.lblTotalRequestsText.Size = new System.Drawing.Size(145, 30);
            this.lblTotalRequestsText.TabIndex = 0;
            this.lblTotalRequestsText.Text = "Total Request";
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInProgress.Controls.Add(this.lblInProgressCount);
            this.pnlInProgress.Location = new System.Drawing.Point(1127, 124);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(358, 233);
            this.pnlInProgress.TabIndex = 39;
            // 
            // lblInProgressCount
            // 
            this.lblInProgressCount.AutoSize = true;
            this.lblInProgressCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgressCount.Location = new System.Drawing.Point(122, 19);
            this.lblInProgressCount.Name = "lblInProgressCount";
            this.lblInProgressCount.Size = new System.Drawing.Size(123, 30);
            this.lblInProgressCount.TabIndex = 2;
            this.lblInProgressCount.Text = "In Progress";
            // 
            // pnlPendingRequests
            // 
            this.pnlPendingRequests.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPendingRequests.Controls.Add(this.lblPendingCount);
            this.pnlPendingRequests.Location = new System.Drawing.Point(727, 124);
            this.pnlPendingRequests.Name = "pnlPendingRequests";
            this.pnlPendingRequests.Size = new System.Drawing.Size(358, 233);
            this.pnlPendingRequests.TabIndex = 40;
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingCount.Location = new System.Drawing.Point(135, 19);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(94, 30);
            this.lblPendingCount.TabIndex = 1;
            this.lblPendingCount.Text = "Pending";
            // 
            // pnlRequestTable
            // 
            this.pnlRequestTable.BackColor = System.Drawing.Color.Silver;
            this.pnlRequestTable.Controls.Add(this.btnEditRequest);
            this.pnlRequestTable.Controls.Add(this.txtSearchRequest);
            this.pnlRequestTable.Controls.Add(this.lblSearchAsset);
            this.pnlRequestTable.Controls.Add(this.btnRefreshAsset);
            this.pnlRequestTable.Controls.Add(this.btnCancelRequest);
            this.pnlRequestTable.Controls.Add(this.btnViewDetails);
            this.pnlRequestTable.Controls.Add(this.btnNewRequest);
            this.pnlRequestTable.Controls.Add(this.dgvRequest);
            this.pnlRequestTable.Location = new System.Drawing.Point(288, 376);
            this.pnlRequestTable.Name = "pnlRequestTable";
            this.pnlRequestTable.Size = new System.Drawing.Size(1613, 638);
            this.pnlRequestTable.TabIndex = 44;
            // 
            // btnEditRequest
            // 
            this.btnEditRequest.Location = new System.Drawing.Point(271, 7);
            this.btnEditRequest.Name = "btnEditRequest";
            this.btnEditRequest.Size = new System.Drawing.Size(117, 40);
            this.btnEditRequest.TabIndex = 30;
            this.btnEditRequest.Text = "Edit";
            this.btnEditRequest.UseVisualStyleBackColor = true;
            // 
            // txtSearchRequest
            // 
            this.txtSearchRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRequest.Location = new System.Drawing.Point(1342, 18);
            this.txtSearchRequest.Multiline = true;
            this.txtSearchRequest.Name = "txtSearchRequest";
            this.txtSearchRequest.Size = new System.Drawing.Size(207, 29);
            this.txtSearchRequest.TabIndex = 29;
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
            this.btnRefreshAsset.Location = new System.Drawing.Point(517, 7);
            this.btnRefreshAsset.Name = "btnRefreshAsset";
            this.btnRefreshAsset.Size = new System.Drawing.Size(117, 40);
            this.btnRefreshAsset.TabIndex = 27;
            this.btnRefreshAsset.Text = "Referesh";
            this.btnRefreshAsset.UseVisualStyleBackColor = true;
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.BackColor = System.Drawing.Color.Red;
            this.btnCancelRequest.ForeColor = System.Drawing.Color.White;
            this.btnCancelRequest.Location = new System.Drawing.Point(394, 7);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(117, 40);
            this.btnCancelRequest.TabIndex = 26;
            this.btnCancelRequest.Text = "Cancel";
            this.btnCancelRequest.UseVisualStyleBackColor = false;
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.BackColor = System.Drawing.Color.Navy;
            this.btnNewRequest.ForeColor = System.Drawing.Color.White;
            this.btnNewRequest.Location = new System.Drawing.Point(25, 7);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(117, 40);
            this.btnNewRequest.TabIndex = 24;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = false;
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
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(148, 7);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(117, 40);
            this.btnViewDetails.TabIndex = 25;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(319, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 258);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(719, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 258);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(1117, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 258);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(1503, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 258);
            this.panel4.TabIndex = 47;
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
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1026);
            this.Controls.Add(this.pnlRequestTable);
            this.Controls.Add(this.lblRequestsSubtitle);
            this.Controls.Add(this.lblRequestsTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlCompleted);
            this.Controls.Add(this.pnlTotalRequests);
            this.Controls.Add(this.pnlInProgress);
            this.Controls.Add(this.pnlPendingRequests);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "frmRequest";
            this.Text = "frmRequest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlCompleted.ResumeLayout(false);
            this.pnlCompleted.PerformLayout();
            this.pnlTotalRequests.ResumeLayout(false);
            this.pnlTotalRequests.PerformLayout();
            this.pnlInProgress.ResumeLayout(false);
            this.pnlInProgress.PerformLayout();
            this.pnlPendingRequests.ResumeLayout(false);
            this.pnlPendingRequests.PerformLayout();
            this.pnlRequestTable.ResumeLayout(false);
            this.pnlRequestTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRequestsSubtitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTechnicians;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblRequestsTitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCompleted;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Panel pnlTotalRequests;
        private System.Windows.Forms.Label lblTotalRequestsText;
        private System.Windows.Forms.Panel pnlInProgress;
        private System.Windows.Forms.Label lblInProgressCount;
        private System.Windows.Forms.Panel pnlPendingRequests;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Panel pnlRequestTable;
        private System.Windows.Forms.Button btnEditRequest;
        private System.Windows.Forms.TextBox txtSearchRequest;
        private System.Windows.Forms.Label lblSearchAsset;
        private System.Windows.Forms.Button btnRefreshAsset;
        private System.Windows.Forms.Button btnCancelRequest;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateRequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}