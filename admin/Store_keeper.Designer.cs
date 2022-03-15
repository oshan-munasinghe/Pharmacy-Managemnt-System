namespace admin
{
    partial class Store_keeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store_keeper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userdemo = new System.Windows.Forms.Label();
            this.conStateLBL = new System.Windows.Forms.Label();
            this.logoutlbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuplierMgmtBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MedMgmtBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uc_Dashboard1 = new admin.wind.uc_Dashboard();
            this.medicineManagement1 = new admin.wind.medicineManagement();
            this.suplierManagement1 = new admin.wind.SuplierManagement();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.userdemo);
            this.panel1.Controls.Add(this.conStateLBL);
            this.panel1.Controls.Add(this.logoutlbl);
            this.panel1.Controls.Add(this.userLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 52);
            this.panel1.TabIndex = 0;
            // 
            // userdemo
            // 
            this.userdemo.AutoSize = true;
            this.userdemo.Location = new System.Drawing.Point(12, 9);
            this.userdemo.Name = "userdemo";
            this.userdemo.Size = new System.Drawing.Size(33, 13);
            this.userdemo.TabIndex = 5;
            this.userdemo.Text = "demo";
            this.userdemo.Visible = false;
            // 
            // conStateLBL
            // 
            this.conStateLBL.AutoSize = true;
            this.conStateLBL.ForeColor = System.Drawing.Color.DarkOrange;
            this.conStateLBL.Location = new System.Drawing.Point(1278, 13);
            this.conStateLBL.Name = "conStateLBL";
            this.conStateLBL.Size = new System.Drawing.Size(54, 13);
            this.conStateLBL.TabIndex = 4;
            this.conStateLBL.Text = "con::state";
            // 
            // logoutlbl
            // 
            this.logoutlbl.AutoSize = true;
            this.logoutlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlbl.ForeColor = System.Drawing.Color.Red;
            this.logoutlbl.Location = new System.Drawing.Point(1278, 31);
            this.logoutlbl.Name = "logoutlbl";
            this.logoutlbl.Size = new System.Drawing.Size(45, 15);
            this.logoutlbl.TabIndex = 3;
            this.logoutlbl.Text = "Logout";
            this.logoutlbl.Click += new System.EventHandler(this.logoutlbl_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(1218, 16);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(36, 17);
            this.userLbl.TabIndex = 2;
            this.userLbl.Text = "-user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1115, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Store Keeper";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmay Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.SuplierMgmtBtn);
            this.panel2.Controls.Add(this.MedMgmtBtn);
            this.panel2.Controls.Add(this.DashboardBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 677);
            this.panel2.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExitBtn.BorderRadius = 15;
            this.ExitBtn.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(68, 570);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(93, 45);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "EXIT";
            // 
            // SuplierMgmtBtn
            // 
            this.SuplierMgmtBtn.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.SuplierMgmtBtn.CheckedState.Parent = this.SuplierMgmtBtn;
            this.SuplierMgmtBtn.CustomImages.Parent = this.SuplierMgmtBtn;
            this.SuplierMgmtBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.SuplierMgmtBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuplierMgmtBtn.ForeColor = System.Drawing.Color.White;
            this.SuplierMgmtBtn.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.SuplierMgmtBtn.HoverState.Parent = this.SuplierMgmtBtn;
            this.SuplierMgmtBtn.Location = new System.Drawing.Point(68, 227);
            this.SuplierMgmtBtn.Name = "SuplierMgmtBtn";
            this.SuplierMgmtBtn.ShadowDecoration.Parent = this.SuplierMgmtBtn;
            this.SuplierMgmtBtn.Size = new System.Drawing.Size(207, 45);
            this.SuplierMgmtBtn.TabIndex = 1;
            this.SuplierMgmtBtn.Text = "Supplier Management";
            this.SuplierMgmtBtn.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // MedMgmtBtn
            // 
            this.MedMgmtBtn.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.MedMgmtBtn.CheckedState.Parent = this.MedMgmtBtn;
            this.MedMgmtBtn.CustomImages.Parent = this.MedMgmtBtn;
            this.MedMgmtBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.MedMgmtBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedMgmtBtn.ForeColor = System.Drawing.Color.White;
            this.MedMgmtBtn.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.MedMgmtBtn.HoverState.Parent = this.MedMgmtBtn;
            this.MedMgmtBtn.Location = new System.Drawing.Point(68, 143);
            this.MedMgmtBtn.Name = "MedMgmtBtn";
            this.MedMgmtBtn.ShadowDecoration.Parent = this.MedMgmtBtn;
            this.MedMgmtBtn.Size = new System.Drawing.Size(207, 45);
            this.MedMgmtBtn.TabIndex = 0;
            this.MedMgmtBtn.Text = "Medicine Management";
            this.MedMgmtBtn.Click += new System.EventHandler(this.MedMgmtBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.DashboardBtn.CheckedState.Parent = this.DashboardBtn;
            this.DashboardBtn.CustomImages.Parent = this.DashboardBtn;
            this.DashboardBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.White;
            this.DashboardBtn.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.DashboardBtn.HoverState.Parent = this.DashboardBtn;
            this.DashboardBtn.Location = new System.Drawing.Point(68, 63);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.ShadowDecoration.Parent = this.DashboardBtn;
            this.DashboardBtn.Size = new System.Drawing.Size(207, 45);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uc_Dashboard1);
            this.panel3.Controls.Add(this.medicineManagement1);
            this.panel3.Controls.Add(this.suplierManagement1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(290, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 677);
            this.panel3.TabIndex = 2;
            // 
            // uc_Dashboard1
            // 
            this.uc_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uc_Dashboard1.Name = "uc_Dashboard1";
            this.uc_Dashboard1.Size = new System.Drawing.Size(1060, 686);
            this.uc_Dashboard1.TabIndex = 2;
            this.uc_Dashboard1.Load += new System.EventHandler(this.uc_Dashboard1_Load);
            // 
            // medicineManagement1
            // 
            this.medicineManagement1.Location = new System.Drawing.Point(0, 0);
            this.medicineManagement1.Name = "medicineManagement1";
            this.medicineManagement1.Size = new System.Drawing.Size(1060, 686);
            this.medicineManagement1.TabIndex = 1;
            this.medicineManagement1.Load += new System.EventHandler(this.medicineManagement1_Load);
            // 
            // suplierManagement1
            // 
            this.suplierManagement1.Location = new System.Drawing.Point(0, 0);
            this.suplierManagement1.Name = "suplierManagement1";
            this.suplierManagement1.Size = new System.Drawing.Size(1060, 686);
            this.suplierManagement1.TabIndex = 0;
            this.suplierManagement1.Load += new System.EventHandler(this.suplierManagement1_Load);
            // 
            // Store_keeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Store_keeper";
            this.Text = "Store_keeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Store_keeper_FormClosing);
            this.Load += new System.EventHandler(this.Store_keeper_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button DashboardBtn;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Button SuplierMgmtBtn;
        private Guna.UI2.WinForms.Guna2Button MedMgmtBtn;
        private wind.SuplierManagement suplierManagement1;
        private wind.medicineManagement medicineManagement1;
        private wind.uc_Dashboard uc_Dashboard1;
        private System.Windows.Forms.Label conStateLBL;
        private System.Windows.Forms.Label logoutlbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userdemo;
    }
}