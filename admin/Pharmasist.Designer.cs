namespace admin
{
    partial class Pharmasist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmasist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Contlbl = new System.Windows.Forms.Label();
            this.usrLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ph_mDMgmtBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ph_tolkecCr_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Ph_dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usrDemo = new System.Windows.Forms.Label();
            this.token1 = new admin.wind.token();
            this.uc_Dashboard1 = new admin.wind.uc_Dashboard();
            this.medicineManagement1 = new admin.wind.medicineManagement();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.usrDemo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Contlbl);
            this.panel1.Controls.Add(this.usrLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 52);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1278, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Logout";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Contlbl
            // 
            this.Contlbl.AutoSize = true;
            this.Contlbl.Cursor = System.Windows.Forms.Cursors.No;
            this.Contlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contlbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Contlbl.Location = new System.Drawing.Point(1278, 7);
            this.Contlbl.Name = "Contlbl";
            this.Contlbl.Size = new System.Drawing.Size(59, 15);
            this.Contlbl.TabIndex = 1;
            this.Contlbl.Text = "con::state";
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLbl.Location = new System.Drawing.Point(1211, 13);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(35, 20);
            this.usrLbl.TabIndex = 1;
            this.usrLbl.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1101, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pharamasist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Ph_mDMgmtBtn);
            this.panel2.Controls.Add(this.ph_tolkecCr_btn);
            this.panel2.Controls.Add(this.Ph_dashboardBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 677);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Ph_mDMgmtBtn
            // 
            this.Ph_mDMgmtBtn.BackColor = System.Drawing.Color.White;
            this.Ph_mDMgmtBtn.CheckedState.Parent = this.Ph_mDMgmtBtn;
            this.Ph_mDMgmtBtn.CustomImages.Parent = this.Ph_mDMgmtBtn;
            this.Ph_mDMgmtBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.Ph_mDMgmtBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ph_mDMgmtBtn.ForeColor = System.Drawing.Color.White;
            this.Ph_mDMgmtBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.Ph_mDMgmtBtn.HoverState.Parent = this.Ph_mDMgmtBtn;
            this.Ph_mDMgmtBtn.Location = new System.Drawing.Point(52, 272);
            this.Ph_mDMgmtBtn.Name = "Ph_mDMgmtBtn";
            this.Ph_mDMgmtBtn.ShadowDecoration.Parent = this.Ph_mDMgmtBtn;
            this.Ph_mDMgmtBtn.Size = new System.Drawing.Size(232, 45);
            this.Ph_mDMgmtBtn.TabIndex = 0;
            this.Ph_mDMgmtBtn.Text = "Medicine Management";
            this.Ph_mDMgmtBtn.Click += new System.EventHandler(this.Ph_mDMgmtBtn_Click);
            // 
            // ph_tolkecCr_btn
            // 
            this.ph_tolkecCr_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.ph_tolkecCr_btn.CheckedState.Parent = this.ph_tolkecCr_btn;
            this.ph_tolkecCr_btn.CustomImages.Parent = this.ph_tolkecCr_btn;
            this.ph_tolkecCr_btn.FillColor = System.Drawing.Color.ForestGreen;
            this.ph_tolkecCr_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph_tolkecCr_btn.ForeColor = System.Drawing.Color.White;
            this.ph_tolkecCr_btn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.ph_tolkecCr_btn.HoverState.Parent = this.ph_tolkecCr_btn;
            this.ph_tolkecCr_btn.Location = new System.Drawing.Point(52, 177);
            this.ph_tolkecCr_btn.Name = "ph_tolkecCr_btn";
            this.ph_tolkecCr_btn.ShadowDecoration.Parent = this.ph_tolkecCr_btn;
            this.ph_tolkecCr_btn.Size = new System.Drawing.Size(232, 45);
            this.ph_tolkecCr_btn.TabIndex = 0;
            this.ph_tolkecCr_btn.Text = "Token Create";
            this.ph_tolkecCr_btn.Click += new System.EventHandler(this.ph_tolkecCr_btn_Click);
            // 
            // Ph_dashboardBtn
            // 
            this.Ph_dashboardBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.Ph_dashboardBtn.CheckedState.Parent = this.Ph_dashboardBtn;
            this.Ph_dashboardBtn.CustomImages.Parent = this.Ph_dashboardBtn;
            this.Ph_dashboardBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.Ph_dashboardBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ph_dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.Ph_dashboardBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.Ph_dashboardBtn.HoverState.Parent = this.Ph_dashboardBtn;
            this.Ph_dashboardBtn.Location = new System.Drawing.Point(52, 84);
            this.Ph_dashboardBtn.Name = "Ph_dashboardBtn";
            this.Ph_dashboardBtn.ShadowDecoration.Parent = this.Ph_dashboardBtn;
            this.Ph_dashboardBtn.Size = new System.Drawing.Size(232, 45);
            this.Ph_dashboardBtn.TabIndex = 0;
            this.Ph_dashboardBtn.Text = "Dashboard";
            this.Ph_dashboardBtn.Click += new System.EventHandler(this.Ph_dashboardBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.token1);
            this.panel3.Controls.Add(this.uc_Dashboard1);
            this.panel3.Controls.Add(this.medicineManagement1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(290, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 677);
            this.panel3.TabIndex = 2;
            // 
            // usrDemo
            // 
            this.usrDemo.AutoSize = true;
            this.usrDemo.Location = new System.Drawing.Point(12, 25);
            this.usrDemo.Name = "usrDemo";
            this.usrDemo.Size = new System.Drawing.Size(27, 13);
            this.usrDemo.TabIndex = 2;
            this.usrDemo.Text = "N/A";
            // 
            // token1
            // 
            this.token1.Location = new System.Drawing.Point(0, 0);
            this.token1.Name = "token1";
            this.token1.Size = new System.Drawing.Size(1060, 686);
            this.token1.TabIndex = 2;
            this.token1.Load += new System.EventHandler(this.token1_Load);
            // 
            // uc_Dashboard1
            // 
            this.uc_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uc_Dashboard1.Name = "uc_Dashboard1";
            this.uc_Dashboard1.Size = new System.Drawing.Size(1060, 686);
            this.uc_Dashboard1.TabIndex = 1;
            this.uc_Dashboard1.Load += new System.EventHandler(this.uc_Dashboard1_Load);
            // 
            // medicineManagement1
            // 
            this.medicineManagement1.Location = new System.Drawing.Point(0, 0);
            this.medicineManagement1.Name = "medicineManagement1";
            this.medicineManagement1.Size = new System.Drawing.Size(1060, 686);
            this.medicineManagement1.TabIndex = 0;
            this.medicineManagement1.Load += new System.EventHandler(this.medicineManagement1_Load);
            // 
            // Pharmasist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pharmasist";
            this.Text = "Pharmacy Management System v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pharmasist_FormClosing);
            this.Load += new System.EventHandler(this.Pharmasist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button ph_tolkecCr_btn;
        private Guna.UI2.WinForms.Guna2Button Ph_dashboardBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Contlbl;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Ph_mDMgmtBtn;
        private System.Windows.Forms.Panel panel3;
        private wind.medicineManagement medicineManagement1;
        private wind.uc_Dashboard uc_Dashboard1;
        private wind.token token1;
        private System.Windows.Forms.Label usrDemo;
    }
}