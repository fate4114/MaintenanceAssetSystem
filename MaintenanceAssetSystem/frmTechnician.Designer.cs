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
            this.dgvTechnician = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTechStatus = new System.Windows.Forms.ComboBox();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblTotalTechnicians = new System.Windows.Forms.Label();
            this.lblAvailableTech = new System.Windows.Forms.Label();
            this.lblBusyTech = new System.Windows.Forms.Label();
            this.txtTechnicianID = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRequestTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnician)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlAvailableTechnicians.SuspendLayout();
            this.pnlBusyTechnicians.SuspendLayout();
            this.pnlTotalTechnicians.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRequestTable
            // 
            this.pnlRequestTable.BackColor = System.Drawing.Color.Silver;
            this.pnlRequestTable.Controls.Add(this.groupBox2);
            this.pnlRequestTable.Controls.Add(this.txtSearchTechnician);
            this.pnlRequestTable.Controls.Add(this.lblSearchTechnician);
            this.pnlRequestTable.Controls.Add(this.dgvTechnician);
            this.pnlRequestTable.Controls.Add(this.txtRequestID);
            this.pnlRequestTable.Controls.Add(this.label12);
            this.pnlRequestTable.Location = new System.Drawing.Point(294, 376);
            this.pnlRequestTable.Name = "pnlRequestTable";
            this.pnlRequestTable.Size = new System.Drawing.Size(1613, 638);
            this.pnlRequestTable.TabIndex = 55;
            // 
            // btnEditTechnician
            // 
            this.btnEditTechnician.Location = new System.Drawing.Point(396, 109);
            this.btnEditTechnician.Name = "btnEditTechnician";
            this.btnEditTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnEditTechnician.TabIndex = 34;
            this.btnEditTechnician.Text = "Update";
            this.btnEditTechnician.UseVisualStyleBackColor = true;
            this.btnEditTechnician.Click += new System.EventHandler(this.btnEditTechnician_Click);
            // 
            // btnRefreshTechnician
            // 
            this.btnRefreshTechnician.Location = new System.Drawing.Point(396, 260);
            this.btnRefreshTechnician.Name = "btnRefreshTechnician";
            this.btnRefreshTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnRefreshTechnician.TabIndex = 33;
            this.btnRefreshTechnician.Text = "Referesh";
            this.btnRefreshTechnician.UseVisualStyleBackColor = true;
            this.btnRefreshTechnician.Click += new System.EventHandler(this.btnRefreshTechnician_Click);
            // 
            // btnDeleteTechnician
            // 
            this.btnDeleteTechnician.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTechnician.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTechnician.Location = new System.Drawing.Point(396, 185);
            this.btnDeleteTechnician.Name = "btnDeleteTechnician";
            this.btnDeleteTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnDeleteTechnician.TabIndex = 32;
            this.btnDeleteTechnician.Text = "Delete";
            this.btnDeleteTechnician.UseVisualStyleBackColor = false;
            this.btnDeleteTechnician.Click += new System.EventHandler(this.btnDeleteTechnician_Click);
            // 
            // btnAddTechnician
            // 
            this.btnAddTechnician.BackColor = System.Drawing.Color.Navy;
            this.btnAddTechnician.ForeColor = System.Drawing.Color.White;
            this.btnAddTechnician.Location = new System.Drawing.Point(396, 37);
            this.btnAddTechnician.Name = "btnAddTechnician";
            this.btnAddTechnician.Size = new System.Drawing.Size(117, 40);
            this.btnAddTechnician.TabIndex = 31;
            this.btnAddTechnician.Text = "Add Technician";
            this.btnAddTechnician.UseVisualStyleBackColor = false;
            this.btnAddTechnician.Click += new System.EventHandler(this.btnAddTechnician_Click);
            // 
            // txtSearchTechnician
            // 
            this.txtSearchTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTechnician.Location = new System.Drawing.Point(1342, 18);
            this.txtSearchTechnician.Multiline = true;
            this.txtSearchTechnician.Name = "txtSearchTechnician";
            this.txtSearchTechnician.Size = new System.Drawing.Size(207, 29);
            this.txtSearchTechnician.TabIndex = 29;
            this.txtSearchTechnician.TextChanged += new System.EventHandler(this.txtSearchTechnician_TextChanged);
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
            // dgvTechnician
            // 
            this.dgvTechnician.AllowUserToAddRows = false;
            this.dgvTechnician.AllowUserToResizeRows = false;
            this.dgvTechnician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechnician.BackgroundColor = System.Drawing.Color.White;
            this.dgvTechnician.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTechnician.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTechnician.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnician.EnableHeadersVisualStyles = false;
            this.dgvTechnician.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTechnician.Location = new System.Drawing.Point(560, 53);
            this.dgvTechnician.MultiSelect = false;
            this.dgvTechnician.Name = "dgvTechnician";
            this.dgvTechnician.ReadOnly = true;
            this.dgvTechnician.RowHeadersVisible = false;
            this.dgvTechnician.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTechnician.Size = new System.Drawing.Size(989, 546);
            this.dgvTechnician.TabIndex = 20;
            this.dgvTechnician.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTechnician_CellContentClick);
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
            // pnlAvailableTechnicians
            // 
            this.pnlAvailableTechnicians.BackColor = System.Drawing.Color.White;
            this.pnlAvailableTechnicians.Controls.Add(this.pictureBox4);
            this.pnlAvailableTechnicians.Controls.Add(this.lblAvailableTech);
            this.pnlAvailableTechnicians.Controls.Add(this.lblAvailableTechniciansText);
            this.pnlAvailableTechnicians.Location = new System.Drawing.Point(881, 124);
            this.pnlAvailableTechnicians.Name = "pnlAvailableTechnicians";
            this.pnlAvailableTechnicians.Size = new System.Drawing.Size(358, 233);
            this.pnlAvailableTechnicians.TabIndex = 58;
            // 
            // lblAvailableTechniciansText
            // 
            this.lblAvailableTechniciansText.AutoSize = true;
            this.lblAvailableTechniciansText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblAvailableTechniciansText.Location = new System.Drawing.Point(108, 19);
            this.lblAvailableTechniciansText.Name = "lblAvailableTechniciansText";
            this.lblAvailableTechniciansText.Size = new System.Drawing.Size(157, 45);
            this.lblAvailableTechniciansText.TabIndex = 1;
            this.lblAvailableTechniciansText.Text = "Available";
            // 
            // pnlBusyTechnicians
            // 
            this.pnlBusyTechnicians.BackColor = System.Drawing.Color.White;
            this.pnlBusyTechnicians.Controls.Add(this.pictureBox3);
            this.pnlBusyTechnicians.Controls.Add(this.lblBusyTech);
            this.pnlBusyTechnicians.Controls.Add(this.lblBusyTechniciansText);
            this.pnlBusyTechnicians.Location = new System.Drawing.Point(1276, 124);
            this.pnlBusyTechnicians.Name = "pnlBusyTechnicians";
            this.pnlBusyTechnicians.Size = new System.Drawing.Size(358, 233);
            this.pnlBusyTechnicians.TabIndex = 57;
            // 
            // lblBusyTechniciansText
            // 
            this.lblBusyTechniciansText.AutoSize = true;
            this.lblBusyTechniciansText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusyTechniciansText.Location = new System.Drawing.Point(136, 19);
            this.lblBusyTechniciansText.Name = "lblBusyTechniciansText";
            this.lblBusyTechniciansText.Size = new System.Drawing.Size(91, 45);
            this.lblBusyTechniciansText.TabIndex = 2;
            this.lblBusyTechniciansText.Text = "Busy";
            // 
            // pnlTotalTechnicians
            // 
            this.pnlTotalTechnicians.BackColor = System.Drawing.Color.White;
            this.pnlTotalTechnicians.Controls.Add(this.pictureBox6);
            this.pnlTotalTechnicians.Controls.Add(this.lblTotalTechnicians);
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
            this.lblTotalTechniciansText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTechniciansText.Location = new System.Drawing.Point(50, 19);
            this.lblTotalTechniciansText.Name = "lblTotalTechniciansText";
            this.lblTotalTechniciansText.Size = new System.Drawing.Size(272, 45);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.btnRefreshTechnician);
            this.groupBox2.Controls.Add(this.btnEditTechnician);
            this.groupBox2.Controls.Add(this.btnDeleteTechnician);
            this.groupBox2.Controls.Add(this.cmbTechStatus);
            this.groupBox2.Controls.Add(this.cmbSpecialization);
            this.groupBox2.Controls.Add(this.btnAddTechnician);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtContactNo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(16, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 544);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // cmbTechStatus
            // 
            this.cmbTechStatus.FormattingEnabled = true;
            this.cmbTechStatus.Items.AddRange(new object[] {
            "Available",
            "",
            "Busy"});
            this.cmbTechStatus.Location = new System.Drawing.Point(146, 250);
            this.cmbTechStatus.Name = "cmbTechStatus";
            this.cmbTechStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbTechStatus.TabIndex = 43;
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Items.AddRange(new object[] {
            "Hardware",
            "",
            "Software",
            "",
            "Networking",
            "",
            "Electrical",
            "",
            "System Suppor",
            "t",
            "Database",
            "",
            "Security"});
            this.cmbSpecialization.Location = new System.Drawing.Point(146, 185);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(200, 21);
            this.cmbSpecialization.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Status:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(146, 109);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 29);
            this.txtContactNo.TabIndex = 37;
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(191, 621);
            this.txtRequestID.Multiline = true;
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.ReadOnly = true;
            this.txtRequestID.Size = new System.Drawing.Size(200, 29);
            this.txtRequestID.TabIndex = 35;
            this.txtRequestID.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.GhostWhite;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Specialization";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.GhostWhite;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Contact No";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(691, 1001);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(141, 44);
            this.btnViewDetails.TabIndex = 25;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.GhostWhite;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Full Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.GhostWhite;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 625);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Request ID:";
            this.label12.Visible = false;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(146, 37);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 29);
            this.txtFullName.TabIndex = 46;
            // 
            // lblTotalTechnicians
            // 
            this.lblTotalTechnicians.AutoSize = true;
            this.lblTotalTechnicians.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTechnicians.Location = new System.Drawing.Point(160, 64);
            this.lblTotalTechnicians.Name = "lblTotalTechnicians";
            this.lblTotalTechnicians.Size = new System.Drawing.Size(109, 128);
            this.lblTotalTechnicians.TabIndex = 30;
            this.lblTotalTechnicians.Text = "0";
            // 
            // lblAvailableTech
            // 
            this.lblAvailableTech.AutoSize = true;
            this.lblAvailableTech.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.lblAvailableTech.Location = new System.Drawing.Point(165, 74);
            this.lblAvailableTech.Name = "lblAvailableTech";
            this.lblAvailableTech.Size = new System.Drawing.Size(109, 128);
            this.lblAvailableTech.TabIndex = 31;
            this.lblAvailableTech.Text = "0";
            // 
            // lblBusyTech
            // 
            this.lblBusyTech.AutoSize = true;
            this.lblBusyTech.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.lblBusyTech.Location = new System.Drawing.Point(180, 74);
            this.lblBusyTech.Name = "lblBusyTech";
            this.lblBusyTech.Size = new System.Drawing.Size(109, 128);
            this.lblBusyTech.TabIndex = 32;
            this.lblBusyTech.Text = "0";
            // 
            // txtTechnicianID
            // 
            this.txtTechnicianID.Location = new System.Drawing.Point(531, 997);
            this.txtTechnicianID.Multiline = true;
            this.txtTechnicianID.Name = "txtTechnicianID";
            this.txtTechnicianID.Size = new System.Drawing.Size(200, 29);
            this.txtTechnicianID.TabIndex = 47;
            this.txtTechnicianID.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MaintenanceAssetSystem.Properties.Resources.Screenshot_2026_06_26_220801;
            this.pictureBox4.Location = new System.Drawing.Point(56, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaintenanceAssetSystem.Properties.Resources.Gemini_Generated_Image_ofs98bofs98bofs9;
            this.pictureBox3.Location = new System.Drawing.Point(80, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MaintenanceAssetSystem.Properties.Resources.Gemini_Generated_Image_vjfktwvjfktwvjfk;
            this.pictureBox6.Location = new System.Drawing.Point(60, 84);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(111, 93);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
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
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1026);
            this.Controls.Add(this.txtTechnicianID);
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
            this.Controls.Add(this.btnViewDetails);
            this.Name = "frmTechnician";
            this.Text = "frmTechnician";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTechnician_Load);
            this.pnlRequestTable.ResumeLayout(false);
            this.pnlRequestTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnician)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlAvailableTechnicians.ResumeLayout(false);
            this.pnlAvailableTechnicians.PerformLayout();
            this.pnlBusyTechnicians.ResumeLayout(false);
            this.pnlBusyTechnicians.PerformLayout();
            this.pnlTotalTechnicians.ResumeLayout(false);
            this.pnlTotalTechnicians.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlRequestTable;
        private System.Windows.Forms.TextBox txtSearchTechnician;
        private System.Windows.Forms.Label lblSearchTechnician;
        private System.Windows.Forms.DataGridView dgvTechnician;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTechStatus;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAvailableTech;
        private System.Windows.Forms.Label lblBusyTech;
        private System.Windows.Forms.Label lblTotalTechnicians;
        private System.Windows.Forms.TextBox txtTechnicianID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}