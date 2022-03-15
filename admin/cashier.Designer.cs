namespace app03
{
    partial class cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userdemo = new System.Windows.Forms.Label();
            this.conStateLBL = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cas_ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CreateSaleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ViewSaleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sale1 = new admin.wind.Sale();
            this.viewSale1 = new admin.wind.viewSale();
            this.uc_Dashboard1 = new admin.wind.uc_Dashboard();
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
            this.panel1.Controls.Add(this.userLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userdemo
            // 
            this.userdemo.AutoSize = true;
            this.userdemo.Location = new System.Drawing.Point(28, 13);
            this.userdemo.Name = "userdemo";
            this.userdemo.Size = new System.Drawing.Size(33, 13);
            this.userdemo.TabIndex = 4;
            this.userdemo.Text = "demo";
            this.userdemo.Visible = false;
            // 
            // conStateLBL
            // 
            this.conStateLBL.AutoSize = true;
            this.conStateLBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conStateLBL.ForeColor = System.Drawing.Color.Orange;
            this.conStateLBL.Location = new System.Drawing.Point(1257, 4);
            this.conStateLBL.Name = "conStateLBL";
            this.conStateLBL.Size = new System.Drawing.Size(78, 17);
            this.conStateLBL.TabIndex = 3;
            this.conStateLBL.Text = "con :: Status";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(1198, 16);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(33, 17);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pharmacy Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1257, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "_Logout";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1130, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Cas_ExitBtn);
            this.panel2.Controls.Add(this.CreateSaleBtn);
            this.panel2.Controls.Add(this.ViewSaleBtn);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 676);
            this.panel2.TabIndex = 1;
            // 
            // Cas_ExitBtn
            // 
            this.Cas_ExitBtn.BorderRadius = 15;
            this.Cas_ExitBtn.CheckedState.Parent = this.Cas_ExitBtn;
            this.Cas_ExitBtn.CustomImages.Parent = this.Cas_ExitBtn;
            this.Cas_ExitBtn.FillColor = System.Drawing.Color.Maroon;
            this.Cas_ExitBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cas_ExitBtn.ForeColor = System.Drawing.Color.White;
            this.Cas_ExitBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.Cas_ExitBtn.HoverState.Parent = this.Cas_ExitBtn;
            this.Cas_ExitBtn.Location = new System.Drawing.Point(56, 581);
            this.Cas_ExitBtn.Name = "Cas_ExitBtn";
            this.Cas_ExitBtn.ShadowDecoration.Parent = this.Cas_ExitBtn;
            this.Cas_ExitBtn.Size = new System.Drawing.Size(101, 45);
            this.Cas_ExitBtn.TabIndex = 2;
            this.Cas_ExitBtn.Text = "EXIT";
            // 
            // CreateSaleBtn
            // 
            this.CreateSaleBtn.Animated = true;
            this.CreateSaleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.CreateSaleBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CreateSaleBtn.CheckedState.Parent = this.CreateSaleBtn;
            this.CreateSaleBtn.CustomImages.Parent = this.CreateSaleBtn;
            this.CreateSaleBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.CreateSaleBtn.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSaleBtn.ForeColor = System.Drawing.Color.White;
            this.CreateSaleBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.CreateSaleBtn.HoverState.Parent = this.CreateSaleBtn;
            this.CreateSaleBtn.Location = new System.Drawing.Point(56, 214);
            this.CreateSaleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateSaleBtn.Name = "CreateSaleBtn";
            this.CreateSaleBtn.ShadowDecoration.Parent = this.CreateSaleBtn;
            this.CreateSaleBtn.Size = new System.Drawing.Size(191, 37);
            this.CreateSaleBtn.TabIndex = 1;
            this.CreateSaleBtn.Text = "Create Sale";
            this.CreateSaleBtn.Click += new System.EventHandler(this.CreateSaleBtn_Click);
            // 
            // ViewSaleBtn
            // 
            this.ViewSaleBtn.Animated = true;
            this.ViewSaleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ViewSaleBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ViewSaleBtn.CheckedState.Parent = this.ViewSaleBtn;
            this.ViewSaleBtn.CustomImages.Parent = this.ViewSaleBtn;
            this.ViewSaleBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.ViewSaleBtn.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSaleBtn.ForeColor = System.Drawing.Color.White;
            this.ViewSaleBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.ViewSaleBtn.HoverState.Parent = this.ViewSaleBtn;
            this.ViewSaleBtn.Location = new System.Drawing.Point(55, 294);
            this.ViewSaleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ViewSaleBtn.Name = "ViewSaleBtn";
            this.ViewSaleBtn.ShadowDecoration.Parent = this.ViewSaleBtn;
            this.ViewSaleBtn.Size = new System.Drawing.Size(191, 37);
            this.ViewSaleBtn.TabIndex = 1;
            this.ViewSaleBtn.Text = "View Sale";
            this.ViewSaleBtn.Click += new System.EventHandler(this.ViewSaleBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(56, 125);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(191, 37);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.sale1);
            this.panel3.Controls.Add(this.viewSale1);
            this.panel3.Controls.Add(this.uc_Dashboard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(251, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 676);
            this.panel3.TabIndex = 2;
            // 
            // sale1
            // 
            this.sale1.Location = new System.Drawing.Point(0, 0);
            this.sale1.Name = "sale1";
            this.sale1.Size = new System.Drawing.Size(1099, 676);
            this.sale1.TabIndex = 2;
            this.sale1.Load += new System.EventHandler(this.sale1_Load);
            // 
            // viewSale1
            // 
            this.viewSale1.Location = new System.Drawing.Point(0, 0);
            this.viewSale1.Name = "viewSale1";
            this.viewSale1.Size = new System.Drawing.Size(1099, 686);
            this.viewSale1.TabIndex = 1;
            this.viewSale1.Visible = false;
            this.viewSale1.Load += new System.EventHandler(this.viewSale1_Load);
            // 
            // uc_Dashboard1
            // 
            this.uc_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uc_Dashboard1.Name = "uc_Dashboard1";
            this.uc_Dashboard1.Size = new System.Drawing.Size(1096, 686);
            this.uc_Dashboard1.TabIndex = 0;
            this.uc_Dashboard1.Load += new System.EventHandler(this.uc_Dashboard1_Load);
            // 
            // cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cashier";
            this.Text = "Pharmacy management System v 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cashier_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button ViewSaleBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private admin.wind.uc_Dashboard uc_Dashboard1;
        private admin.wind.viewSale viewSale1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label conStateLBL;
        private System.Windows.Forms.Label userLbl;
        private Guna.UI2.WinForms.Guna2Button Cas_ExitBtn;
        private admin.wind.Sale sale1;
        private Guna.UI2.WinForms.Guna2Button CreateSaleBtn;
        private System.Windows.Forms.Label userdemo;
        
    }
}

