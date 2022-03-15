namespace admin
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contlbl = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.userMgmtBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboardbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uc_Dashboard2 = new admin.wind.uc_Dashboard();
            this.user_management1 = new admin.wind.user_management();
            this.suplierManagement1 = new admin.wind.SuplierManagement();
            this.costManagement1 = new admin.wind.costManagement();
            this.adminProfile1 = new admin.adminProfile();
            this.viewSale1 = new admin.wind.viewSale();
            this.inventoryManagement1 = new admin.wind.InventoryManagement();
            this.medicineManagement1 = new admin.wind.medicineManagement();
            this.uc_Dashboard1 = new admin.wind.uc_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.usrLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.usrLbl);
            this.panel1.Controls.Add(this.Contlbl);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 52);
            this.panel1.TabIndex = 0;
            // 
            // Contlbl
            // 
            this.Contlbl.AutoSize = true;
            this.Contlbl.ForeColor = System.Drawing.Color.Orange;
            this.Contlbl.Location = new System.Drawing.Point(1281, 9);
            this.Contlbl.Name = "Contlbl";
            this.Contlbl.Size = new System.Drawing.Size(66, 13);
            this.Contlbl.TabIndex = 11;
            this.Contlbl.Text = "Conn::status";
            this.Contlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Contlbl.Click += new System.EventHandler(this.Contlbl_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(1222, 17);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(28, 13);
            this.userLabel.TabIndex = 10;
            this.userLabel.Text = "user";
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pharmacy Management System";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel1.Location = new System.Drawing.Point(1281, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(50, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "_Logout";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1144, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN -";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gunaButton1);
            this.panel2.Controls.Add(this.guna2Button7);
            this.panel2.Controls.Add(this.guna2Button6);
            this.panel2.Controls.Add(this.guna2Button5);
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.userMgmtBtn);
            this.panel2.Controls.Add(this.Dashboardbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 677);
            this.panel2.TabIndex = 1;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(75, 612);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(110, 42);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Text = "EXIT";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(75, 532);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(209, 45);
            this.guna2Button7.TabIndex = 6;
            this.guna2Button7.Text = "Suplier Management";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Location = new System.Drawing.Point(75, 451);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(209, 45);
            this.guna2Button6.TabIndex = 5;
            this.guna2Button6.Text = "Cost Management";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(75, 367);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(209, 45);
            this.guna2Button5.TabIndex = 4;
            this.guna2Button5.Text = " View Sales";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(75, 289);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(209, 45);
            this.guna2Button4.TabIndex = 3;
            this.guna2Button4.Text = "Inventory Management";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(75, 213);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(209, 45);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Medicine Management";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // userMgmtBtn
            // 
            this.userMgmtBtn.BackColor = System.Drawing.SystemColors.Control;
            this.userMgmtBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.userMgmtBtn.CheckedState.Parent = this.userMgmtBtn;
            this.userMgmtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userMgmtBtn.CustomImages.Parent = this.userMgmtBtn;
            this.userMgmtBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.userMgmtBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMgmtBtn.ForeColor = System.Drawing.Color.White;
            this.userMgmtBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.userMgmtBtn.HoverState.Parent = this.userMgmtBtn;
            this.userMgmtBtn.Location = new System.Drawing.Point(75, 144);
            this.userMgmtBtn.Name = "userMgmtBtn";
            this.userMgmtBtn.ShadowDecoration.Parent = this.userMgmtBtn;
            this.userMgmtBtn.Size = new System.Drawing.Size(209, 45);
            this.userMgmtBtn.TabIndex = 1;
            this.userMgmtBtn.Text = "User Management";
            this.userMgmtBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Dashboardbtn
            // 
            this.Dashboardbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Dashboardbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Dashboardbtn.CheckedState.Parent = this.Dashboardbtn;
            this.Dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboardbtn.CustomImages.Parent = this.Dashboardbtn;
            this.Dashboardbtn.FillColor = System.Drawing.Color.ForestGreen;
            this.Dashboardbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.Dashboardbtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.Dashboardbtn.HoverState.Parent = this.Dashboardbtn;
            this.Dashboardbtn.Location = new System.Drawing.Point(75, 71);
            this.Dashboardbtn.Name = "Dashboardbtn";
            this.Dashboardbtn.ShadowDecoration.Parent = this.Dashboardbtn;
            this.Dashboardbtn.Size = new System.Drawing.Size(209, 45);
            this.Dashboardbtn.TabIndex = 0;
            this.Dashboardbtn.Text = "Dashboard";
            this.Dashboardbtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uc_Dashboard2);
            this.panel3.Controls.Add(this.user_management1);
            this.panel3.Controls.Add(this.suplierManagement1);
            this.panel3.Controls.Add(this.costManagement1);
            this.panel3.Controls.Add(this.adminProfile1);
            this.panel3.Controls.Add(this.viewSale1);
            this.panel3.Controls.Add(this.inventoryManagement1);
            this.panel3.Controls.Add(this.medicineManagement1);
            this.panel3.Controls.Add(this.uc_Dashboard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(290, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 677);
            this.panel3.TabIndex = 2;
            // 
            // uc_Dashboard2
            // 
            this.uc_Dashboard2.Location = new System.Drawing.Point(0, 0);
            this.uc_Dashboard2.Name = "uc_Dashboard2";
            this.uc_Dashboard2.Size = new System.Drawing.Size(1060, 686);
            this.uc_Dashboard2.TabIndex = 10;
            // 
            // user_management1
            // 
            this.user_management1.Location = new System.Drawing.Point(-3, 0);
            this.user_management1.Name = "user_management1";
            this.user_management1.Size = new System.Drawing.Size(1060, 686);
            this.user_management1.TabIndex = 9;
            this.user_management1.Visible = false;
            this.user_management1.Load += new System.EventHandler(this.user_management1_Load_1);
            // 
            // suplierManagement1
            // 
            this.suplierManagement1.Location = new System.Drawing.Point(0, 0);
            this.suplierManagement1.Name = "suplierManagement1";
            this.suplierManagement1.Size = new System.Drawing.Size(1060, 686);
            this.suplierManagement1.TabIndex = 8;
            this.suplierManagement1.Visible = false;
            this.suplierManagement1.Load += new System.EventHandler(this.suplierManagement1_Load);
            // 
            // costManagement1
            // 
            this.costManagement1.Location = new System.Drawing.Point(0, 0);
            this.costManagement1.Name = "costManagement1";
            this.costManagement1.Size = new System.Drawing.Size(1060, 686);
            this.costManagement1.TabIndex = 7;
            this.costManagement1.Visible = false;
            this.costManagement1.Load += new System.EventHandler(this.costManagement1_Load_1);
            // 
            // adminProfile1
            // 
            this.adminProfile1.Location = new System.Drawing.Point(0, 0);
            this.adminProfile1.Name = "adminProfile1";
            this.adminProfile1.Size = new System.Drawing.Size(1060, 686);
            this.adminProfile1.TabIndex = 6;
            this.adminProfile1.Visible = false;
            this.adminProfile1.Load += new System.EventHandler(this.adminProfile1_Load);
            // 
            // viewSale1
            // 
            this.viewSale1.Location = new System.Drawing.Point(0, 0);
            this.viewSale1.Name = "viewSale1";
            this.viewSale1.Size = new System.Drawing.Size(1060, 686);
            this.viewSale1.TabIndex = 4;
            this.viewSale1.Load += new System.EventHandler(this.viewSale1_Load);
            // 
            // inventoryManagement1
            // 
            this.inventoryManagement1.Location = new System.Drawing.Point(0, 0);
            this.inventoryManagement1.Name = "inventoryManagement1";
            this.inventoryManagement1.Size = new System.Drawing.Size(1060, 686);
            this.inventoryManagement1.TabIndex = 3;
            this.inventoryManagement1.Load += new System.EventHandler(this.inventoryManagement1_Load);
            // 
            // medicineManagement1
            // 
            this.medicineManagement1.Location = new System.Drawing.Point(0, 0);
            this.medicineManagement1.Name = "medicineManagement1";
            this.medicineManagement1.Size = new System.Drawing.Size(1060, 686);
            this.medicineManagement1.TabIndex = 2;
            this.medicineManagement1.Load += new System.EventHandler(this.medicineManagement1_Load);
            // 
            // uc_Dashboard1
            // 
            this.uc_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uc_Dashboard1.Name = "uc_Dashboard1";
            this.uc_Dashboard1.Size = new System.Drawing.Size(1060, 686);
            this.uc_Dashboard1.TabIndex = 0;
            this.uc_Dashboard1.Load += new System.EventHandler(this.uc_Dashboard1_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel3;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.label1;
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Location = new System.Drawing.Point(13, 26);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(27, 13);
            this.usrLbl.TabIndex = 12;
            this.usrLbl.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pharmacy Management System V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button userMgmtBtn;
        private Guna.UI2.WinForms.Guna2Button Dashboardbtn;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private wind.uc_Dashboard uc_Dashboard1;
       // private wind.userManagement userManagement1;
        private wind.medicineManagement medicineManagement1;
        private wind.InventoryManagement inventoryManagement1;
        private wind.viewSale viewSale1;
        //private costManagement costManagement1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private adminProfile adminProfile1;
        private wind.costManagement costManagement1;
        private System.Windows.Forms.Label label2;
        private wind.SuplierManagement suplierManagement1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label Contlbl;
        private wind.user_management user_management1;
        private wind.uc_Dashboard uc_Dashboard2;
        private System.Windows.Forms.Label usrLbl;
        
    }
}

