namespace admin.wind
{
    partial class viewSale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catSaleBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new Guna.UI.WinForms.GunaButton();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportGenBtn = new Guna.UI.WinForms.GunaButton();
            this.refreshbtn = new Guna.UI.WinForms.GunaButton();
            this.Vi_sale_DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vi_sale_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 52);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 34);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.reportGenBtn);
            this.panel3.Controls.Add(this.refreshbtn);
            this.panel3.Controls.Add(this.Vi_sale_DGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 600);
            this.panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.catSaleBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 75);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search & Filter";
            // 
            // catSaleBox
            // 
            this.catSaleBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.catSaleBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catSaleBox.FormattingEnabled = true;
            this.catSaleBox.Items.AddRange(new object[] {
            "sale_id",
            "token_id",
            "medicine_id",
            "cashier_id",
            "pharmacist_id",
            "date"});
            this.catSaleBox.Location = new System.Drawing.Point(93, 22);
            this.catSaleBox.Name = "catSaleBox";
            this.catSaleBox.Size = new System.Drawing.Size(121, 25);
            this.catSaleBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Category";
            // 
            // searchBtn
            // 
            this.searchBtn.AnimationHoverSpeed = 0.07F;
            this.searchBtn.AnimationSpeed = 0.03F;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BaseColor = System.Drawing.Color.Teal;
            this.searchBtn.BorderColor = System.Drawing.Color.Black;
            this.searchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = null;
            this.searchBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBtn.Location = new System.Drawing.Point(449, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.searchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBtn.OnHoverImage = null;
            this.searchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBtn.Radius = 15;
            this.searchBtn.Size = new System.Drawing.Size(81, 29);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(297, 22);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(121, 25);
            this.SearchBox.TabIndex = 22;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Value";
            // 
            // reportGenBtn
            // 
            this.reportGenBtn.AnimationHoverSpeed = 0.07F;
            this.reportGenBtn.AnimationSpeed = 0.03F;
            this.reportGenBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportGenBtn.BaseColor = System.Drawing.Color.Teal;
            this.reportGenBtn.BorderColor = System.Drawing.Color.Black;
            this.reportGenBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reportGenBtn.FocusedColor = System.Drawing.Color.Empty;
            this.reportGenBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportGenBtn.ForeColor = System.Drawing.Color.White;
            this.reportGenBtn.Image = null;
            this.reportGenBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.reportGenBtn.Location = new System.Drawing.Point(705, 518);
            this.reportGenBtn.Name = "reportGenBtn";
            this.reportGenBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.reportGenBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.reportGenBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.reportGenBtn.OnHoverImage = null;
            this.reportGenBtn.OnPressedColor = System.Drawing.Color.Black;
            this.reportGenBtn.Radius = 15;
            this.reportGenBtn.Size = new System.Drawing.Size(138, 42);
            this.reportGenBtn.TabIndex = 23;
            this.reportGenBtn.Text = "Report Genarate";
            this.reportGenBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reportGenBtn.Click += new System.EventHandler(this.reportGenBtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.AnimationHoverSpeed = 0.07F;
            this.refreshbtn.AnimationSpeed = 0.03F;
            this.refreshbtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshbtn.BaseColor = System.Drawing.Color.Teal;
            this.refreshbtn.BorderColor = System.Drawing.Color.Black;
            this.refreshbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshbtn.FocusedColor = System.Drawing.Color.Empty;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.Image = null;
            this.refreshbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.refreshbtn.Location = new System.Drawing.Point(861, 518);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.refreshbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshbtn.OnHoverImage = null;
            this.refreshbtn.OnPressedColor = System.Drawing.Color.Black;
            this.refreshbtn.Radius = 15;
            this.refreshbtn.Size = new System.Drawing.Size(105, 42);
            this.refreshbtn.TabIndex = 17;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // Vi_sale_DGV
            // 
            this.Vi_sale_DGV.AllowUserToAddRows = false;
            this.Vi_sale_DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Vi_sale_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Vi_sale_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vi_sale_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Vi_sale_DGV.Location = new System.Drawing.Point(36, 84);
            this.Vi_sale_DGV.Name = "Vi_sale_DGV";
            this.Vi_sale_DGV.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vi_sale_DGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Vi_sale_DGV.Size = new System.Drawing.Size(930, 408);
            this.Vi_sale_DGV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "date";
            this.Column1.HeaderText = "Sale Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sale_id";
            this.Column2.HeaderText = "Sale ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "token_id";
            this.Column3.HeaderText = "Token ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "medicine_id";
            this.Column4.HeaderText = "Medicine ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sale_quantity";
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "cashier_id";
            this.Column6.HeaderText = "Cashier ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "pharmacist_id";
            this.Column7.HeaderText = "Pharmacist ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "total_price";
            this.Column8.HeaderText = "Price";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // viewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "viewSale";
            this.Size = new System.Drawing.Size(1060, 686);
            this.Load += new System.EventHandler(this.viewSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vi_sale_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Vi_sale_DGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton refreshbtn;
        private Guna.UI.WinForms.GunaButton reportGenBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox catSaleBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton searchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
