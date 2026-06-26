namespace MaintenanceAssetSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTechnicians = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnAssets = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlAssets = new System.Windows.Forms.Panel();
            this.lblTotalAssets = new System.Windows.Forms.Label();
            this.pnlTechnicians = new System.Windows.Forms.Panel();
            this.lblTechniciansValue = new System.Windows.Forms.Label();
            this.pnlCompleted = new System.Windows.Forms.Panel();
            this.lblCompletedValue = new System.Windows.Forms.Label();
            this.pnlPending = new System.Windows.Forms.Panel();
            this.lblPendingValue = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.colRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundPane = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lblRecentRequests = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlAssets.SuspendLayout();
            this.pnlTechnicians.SuspendLayout();
            this.pnlCompleted.SuspendLayout();
            this.pnlPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.RoundPane.SuspendLayout();
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
            // btnAssets
            // 
            this.btnAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssets.ForeColor = System.Drawing.Color.White;
            this.btnAssets.Location = new System.Drawing.Point(3, 342);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Padding = new System.Windows.Forms.Padding(10);
            this.btnAssets.Size = new System.Drawing.Size(266, 64);
            this.btnAssets.TabIndex = 9;
            this.btnAssets.Text = "Assets";
            this.btnAssets.UseVisualStyleBackColor = true;
            this.btnAssets.Click += new System.EventHandler(this.btnAssets_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(300, 20);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(229, 54);
            this.lblDashboardTitle.TabIndex = 2;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWelcome.Location = new System.Drawing.Point(304, 74);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(281, 25);
            this.lblWelcome.TabIndex = 20;
            this.lblWelcome.Text = "Welcome back, Administrator!";
            // 
            // pnlAssets
            // 
            this.pnlAssets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAssets.Controls.Add(this.lblTotalAssets);
            this.pnlAssets.Location = new System.Drawing.Point(315, 132);
            this.pnlAssets.Name = "pnlAssets";
            this.pnlAssets.Size = new System.Drawing.Size(358, 233);
            this.pnlAssets.TabIndex = 21;
            // 
            // lblTotalAssets
            // 
            this.lblTotalAssets.AutoSize = true;
            this.lblTotalAssets.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssets.Location = new System.Drawing.Point(115, 19);
            this.lblTotalAssets.Name = "lblTotalAssets";
            this.lblTotalAssets.Size = new System.Drawing.Size(128, 30);
            this.lblTotalAssets.TabIndex = 0;
            this.lblTotalAssets.Text = "Total Assets";
            // 
            // pnlTechnicians
            // 
            this.pnlTechnicians.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTechnicians.Controls.Add(this.lblTechniciansValue);
            this.pnlTechnicians.Location = new System.Drawing.Point(1509, 132);
            this.pnlTechnicians.Name = "pnlTechnicians";
            this.pnlTechnicians.Size = new System.Drawing.Size(358, 233);
            this.pnlTechnicians.TabIndex = 22;
            // 
            // lblTechniciansValue
            // 
            this.lblTechniciansValue.AutoSize = true;
            this.lblTechniciansValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechniciansValue.Location = new System.Drawing.Point(120, 19);
            this.lblTechniciansValue.Name = "lblTechniciansValue";
            this.lblTechniciansValue.Size = new System.Drawing.Size(125, 30);
            this.lblTechniciansValue.TabIndex = 3;
            this.lblTechniciansValue.Text = "Technicians";
            // 
            // pnlCompleted
            // 
            this.pnlCompleted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCompleted.Controls.Add(this.lblCompletedValue);
            this.pnlCompleted.Location = new System.Drawing.Point(1111, 132);
            this.pnlCompleted.Name = "pnlCompleted";
            this.pnlCompleted.Size = new System.Drawing.Size(358, 233);
            this.pnlCompleted.TabIndex = 23;
            // 
            // lblCompletedValue
            // 
            this.lblCompletedValue.AutoSize = true;
            this.lblCompletedValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedValue.Location = new System.Drawing.Point(64, 19);
            this.lblCompletedValue.Name = "lblCompletedValue";
            this.lblCompletedValue.Size = new System.Drawing.Size(253, 30);
            this.lblCompletedValue.TabIndex = 2;
            this.lblCompletedValue.Text = "Completed Maintenance";
            // 
            // pnlPending
            // 
            this.pnlPending.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPending.Controls.Add(this.lblPendingValue);
            this.pnlPending.Location = new System.Drawing.Point(711, 132);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(358, 233);
            this.pnlPending.TabIndex = 24;
            // 
            // lblPendingValue
            // 
            this.lblPendingValue.AutoSize = true;
            this.lblPendingValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingValue.Location = new System.Drawing.Point(96, 19);
            this.lblPendingValue.Name = "lblPendingValue";
            this.lblPendingValue.Size = new System.Drawing.Size(178, 30);
            this.lblPendingValue.TabIndex = 1;
            this.lblPendingValue.Text = "Pending Request";
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToResizeRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequestID,
            this.colAsset,
            this.colRequestedBy,
            this.colTechnician,
            this.colDateRequested});
            this.dgvRequests.EnableHeadersVisualStyles = false;
            this.dgvRequests.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvRequests.Location = new System.Drawing.Point(25, 53);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(1524, 546);
            this.dgvRequests.TabIndex = 20;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.colTechnician.HeaderText = "Status";
            this.colTechnician.Name = "colTechnician";
            this.colTechnician.ReadOnly = true;
            // 
            // colDateRequested
            // 
            this.colDateRequested.HeaderText = "Date Requested";
            this.colDateRequested.Name = "colDateRequested";
            this.colDateRequested.ReadOnly = true;
            // 
            // RoundPane
            // 
            this.RoundPane.BackColor = System.Drawing.Color.Silver;
            this.RoundPane.Controls.Add(this.btnViewAll);
            this.RoundPane.Controls.Add(this.lblRecentRequests);
            this.RoundPane.Controls.Add(this.dgvRequests);
            this.RoundPane.Location = new System.Drawing.Point(290, 376);
            this.RoundPane.Name = "RoundPane";
            this.RoundPane.Size = new System.Drawing.Size(1602, 638);
            this.RoundPane.TabIndex = 25;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(1474, 16);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 23;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // lblRecentRequests
            // 
            this.lblRecentRequests.AutoSize = true;
            this.lblRecentRequests.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentRequests.Location = new System.Drawing.Point(27, 16);
            this.lblRecentRequests.Name = "lblRecentRequests";
            this.lblRecentRequests.Size = new System.Drawing.Size(268, 25);
            this.lblRecentRequests.TabIndex = 22;
            this.lblRecentRequests.Text = "Recent Maintenance Request";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(701, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 247);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(309, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 247);
            this.panel1.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(1102, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 247);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(1502, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 247);
            this.panel4.TabIndex = 41;
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
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1913, 1026);
            this.Controls.Add(this.pnlPending);
            this.Controls.Add(this.pnlCompleted);
            this.Controls.Add(this.pnlTechnicians);
            this.Controls.Add(this.pnlAssets);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblDashboardTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.RoundPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlAssets.ResumeLayout(false);
            this.pnlAssets.PerformLayout();
            this.pnlTechnicians.ResumeLayout(false);
            this.pnlTechnicians.PerformLayout();
            this.pnlCompleted.ResumeLayout(false);
            this.pnlCompleted.PerformLayout();
            this.pnlPending.ResumeLayout(false);
            this.pnlPending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.RoundPane.ResumeLayout(false);
            this.RoundPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTechnicians;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlAssets;
        private System.Windows.Forms.Panel pnlTechnicians;
        private System.Windows.Forms.Panel pnlCompleted;
        private System.Windows.Forms.Panel pnlPending;
        private System.Windows.Forms.Label lblTotalAssets;
        private System.Windows.Forms.Label lblTechniciansValue;
        private System.Windows.Forms.Label lblCompletedValue;
        private System.Windows.Forms.Label lblPendingValue;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateRequested;
        private System.Windows.Forms.Panel RoundPane;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label lblRecentRequests;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}