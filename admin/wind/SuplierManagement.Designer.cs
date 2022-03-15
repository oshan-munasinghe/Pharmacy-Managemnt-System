namespace admin.wind
{
    partial class SuplierManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.S_suplierDGV = new System.Windows.Forms.DataGridView();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.RefreshBtn = new Guna.UI.WinForms.GunaButton();
            this.S_deleteBtn = new Guna.UI.WinForms.GunaButton();
            this.S_clesrBtn = new Guna.UI.WinForms.GunaButton();
            this.S_updateBtn = new Guna.UI.WinForms.GunaButton();
            this.S_addbtn = new Guna.UI.WinForms.GunaButton();
            this.S_contactNo = new System.Windows.Forms.TextBox();
            this.S_Email = new System.Windows.Forms.TextBox();
            this.S_Address = new System.Windows.Forms.TextBox();
            this.S_NameSuplier = new System.Windows.Forms.TextBox();
            this.S_IDSuplier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.catSaleBox = new System.Windows.Forms.ComboBox();
            this.searchBtn1 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_suplierDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suplier Management";
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
            this.panel1.Size = new System.Drawing.Size(1060, 53);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.S_suplierDGV);
            this.panel2.Controls.Add(this.gunaButton3);
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.S_deleteBtn);
            this.panel2.Controls.Add(this.S_clesrBtn);
            this.panel2.Controls.Add(this.S_updateBtn);
            this.panel2.Controls.Add(this.S_addbtn);
            this.panel2.Controls.Add(this.S_contactNo);
            this.panel2.Controls.Add(this.S_Email);
            this.panel2.Controls.Add(this.S_Address);
            this.panel2.Controls.Add(this.S_NameSuplier);
            this.panel2.Controls.Add(this.S_IDSuplier);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 633);
            this.panel2.TabIndex = 2;
            // 
            // S_suplierDGV
            // 
            this.S_suplierDGV.AllowUserToAddRows = false;
            this.S_suplierDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.S_suplierDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.S_suplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.S_suplierDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.S_suplierDGV.Location = new System.Drawing.Point(310, 112);
            this.S_suplierDGV.Name = "S_suplierDGV";
            this.S_suplierDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.S_suplierDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.S_suplierDGV.Size = new System.Drawing.Size(735, 388);
            this.S_suplierDGV.TabIndex = 3;
            this.S_suplierDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.S_suplierDGV_CellMouseClick);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.Teal;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(755, 534);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 15;
            this.gunaButton3.Size = new System.Drawing.Size(148, 42);
            this.gunaButton3.TabIndex = 2;
            this.gunaButton3.Text = "Genarate Report";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AnimationHoverSpeed = 0.07F;
            this.RefreshBtn.AnimationSpeed = 0.03F;
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.BaseColor = System.Drawing.Color.Teal;
            this.RefreshBtn.BorderColor = System.Drawing.Color.Black;
            this.RefreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RefreshBtn.FocusedColor = System.Drawing.Color.Empty;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Image = null;
            this.RefreshBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.RefreshBtn.Location = new System.Drawing.Point(945, 534);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.RefreshBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RefreshBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.RefreshBtn.OnHoverImage = null;
            this.RefreshBtn.OnPressedColor = System.Drawing.Color.Black;
            this.RefreshBtn.Radius = 15;
            this.RefreshBtn.Size = new System.Drawing.Size(91, 42);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // S_deleteBtn
            // 
            this.S_deleteBtn.AnimationHoverSpeed = 0.07F;
            this.S_deleteBtn.AnimationSpeed = 0.03F;
            this.S_deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.S_deleteBtn.BaseColor = System.Drawing.Color.Teal;
            this.S_deleteBtn.BorderColor = System.Drawing.Color.Black;
            this.S_deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.S_deleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.S_deleteBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.S_deleteBtn.Image = null;
            this.S_deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.S_deleteBtn.Location = new System.Drawing.Point(191, 367);
            this.S_deleteBtn.Name = "S_deleteBtn";
            this.S_deleteBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.S_deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.S_deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.S_deleteBtn.OnHoverImage = null;
            this.S_deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.S_deleteBtn.Radius = 15;
            this.S_deleteBtn.Size = new System.Drawing.Size(91, 42);
            this.S_deleteBtn.TabIndex = 2;
            this.S_deleteBtn.Text = "Delete";
            this.S_deleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.S_deleteBtn.Click += new System.EventHandler(this.S_deleteBtn_Click);
            // 
            // S_clesrBtn
            // 
            this.S_clesrBtn.AnimationHoverSpeed = 0.07F;
            this.S_clesrBtn.AnimationSpeed = 0.03F;
            this.S_clesrBtn.BackColor = System.Drawing.Color.Transparent;
            this.S_clesrBtn.BaseColor = System.Drawing.Color.Teal;
            this.S_clesrBtn.BorderColor = System.Drawing.Color.Black;
            this.S_clesrBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.S_clesrBtn.FocusedColor = System.Drawing.Color.Empty;
            this.S_clesrBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_clesrBtn.ForeColor = System.Drawing.Color.White;
            this.S_clesrBtn.Image = null;
            this.S_clesrBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.S_clesrBtn.Location = new System.Drawing.Point(52, 367);
            this.S_clesrBtn.Name = "S_clesrBtn";
            this.S_clesrBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.S_clesrBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.S_clesrBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.S_clesrBtn.OnHoverImage = null;
            this.S_clesrBtn.OnPressedColor = System.Drawing.Color.Black;
            this.S_clesrBtn.Radius = 15;
            this.S_clesrBtn.Size = new System.Drawing.Size(91, 42);
            this.S_clesrBtn.TabIndex = 2;
            this.S_clesrBtn.Text = "Clear";
            this.S_clesrBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.S_clesrBtn.Click += new System.EventHandler(this.S_clesrBtn_Click);
            // 
            // S_updateBtn
            // 
            this.S_updateBtn.AnimationHoverSpeed = 0.07F;
            this.S_updateBtn.AnimationSpeed = 0.03F;
            this.S_updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.S_updateBtn.BaseColor = System.Drawing.Color.Teal;
            this.S_updateBtn.BorderColor = System.Drawing.Color.Black;
            this.S_updateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.S_updateBtn.FocusedColor = System.Drawing.Color.Empty;
            this.S_updateBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_updateBtn.ForeColor = System.Drawing.Color.White;
            this.S_updateBtn.Image = null;
            this.S_updateBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.S_updateBtn.Location = new System.Drawing.Point(191, 300);
            this.S_updateBtn.Name = "S_updateBtn";
            this.S_updateBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.S_updateBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.S_updateBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.S_updateBtn.OnHoverImage = null;
            this.S_updateBtn.OnPressedColor = System.Drawing.Color.Black;
            this.S_updateBtn.Radius = 15;
            this.S_updateBtn.Size = new System.Drawing.Size(91, 42);
            this.S_updateBtn.TabIndex = 2;
            this.S_updateBtn.Text = "Update";
            this.S_updateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.S_updateBtn.Click += new System.EventHandler(this.S_updateBtn_Click);
            // 
            // S_addbtn
            // 
            this.S_addbtn.AnimationHoverSpeed = 0.07F;
            this.S_addbtn.AnimationSpeed = 0.03F;
            this.S_addbtn.BackColor = System.Drawing.Color.Transparent;
            this.S_addbtn.BaseColor = System.Drawing.Color.Teal;
            this.S_addbtn.BorderColor = System.Drawing.Color.Black;
            this.S_addbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.S_addbtn.FocusedColor = System.Drawing.Color.Empty;
            this.S_addbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_addbtn.ForeColor = System.Drawing.Color.White;
            this.S_addbtn.Image = null;
            this.S_addbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.S_addbtn.Location = new System.Drawing.Point(52, 300);
            this.S_addbtn.Name = "S_addbtn";
            this.S_addbtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.S_addbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.S_addbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.S_addbtn.OnHoverImage = null;
            this.S_addbtn.OnPressedColor = System.Drawing.Color.Black;
            this.S_addbtn.Radius = 15;
            this.S_addbtn.Size = new System.Drawing.Size(91, 42);
            this.S_addbtn.TabIndex = 2;
            this.S_addbtn.Text = "Add";
            this.S_addbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.S_addbtn.Click += new System.EventHandler(this.S_addbtn_Click);
            // 
            // S_contactNo
            // 
            this.S_contactNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_contactNo.Location = new System.Drawing.Point(161, 246);
            this.S_contactNo.Name = "S_contactNo";
            this.S_contactNo.Size = new System.Drawing.Size(121, 25);
            this.S_contactNo.TabIndex = 1;
            // 
            // S_Email
            // 
            this.S_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Email.Location = new System.Drawing.Point(161, 191);
            this.S_Email.Name = "S_Email";
            this.S_Email.Size = new System.Drawing.Size(121, 25);
            this.S_Email.TabIndex = 1;
            // 
            // S_Address
            // 
            this.S_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Address.Location = new System.Drawing.Point(161, 132);
            this.S_Address.Name = "S_Address";
            this.S_Address.Size = new System.Drawing.Size(121, 25);
            this.S_Address.TabIndex = 1;
            // 
            // S_NameSuplier
            // 
            this.S_NameSuplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_NameSuplier.Location = new System.Drawing.Point(161, 77);
            this.S_NameSuplier.Name = "S_NameSuplier";
            this.S_NameSuplier.Size = new System.Drawing.Size(121, 25);
            this.S_NameSuplier.TabIndex = 1;
            // 
            // S_IDSuplier
            // 
            this.S_IDSuplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_IDSuplier.Location = new System.Drawing.Point(161, 21);
            this.S_IDSuplier.Name = "S_IDSuplier";
            this.S_IDSuplier.Size = new System.Drawing.Size(121, 25);
            this.S_IDSuplier.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contact No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suplier ID";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "suplier_id";
            this.Column1.HeaderText = "Suppliier ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "suplier_name";
            this.Column2.HeaderText = "Supplier Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "suplier_address";
            this.Column3.HeaderText = "Supplier Address";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "suplier_email";
            this.Column4.HeaderText = "Supplier Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "suplier_contact";
            this.Column5.HeaderText = "Contact No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.catSaleBox);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.searchBtn1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(310, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search & Filter";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(310, 29);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(120, 25);
            this.SearchBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Value";
            // 
            // catSaleBox
            // 
            this.catSaleBox.FormattingEnabled = true;
            this.catSaleBox.Items.AddRange(new object[] {
            "suplier_id",
            "suplier_name"});
            this.catSaleBox.Location = new System.Drawing.Point(87, 25);
            this.catSaleBox.Name = "catSaleBox";
            this.catSaleBox.Size = new System.Drawing.Size(129, 25);
            this.catSaleBox.TabIndex = 1;
            // 
            // searchBtn1
            // 
            this.searchBtn1.AnimationHoverSpeed = 0.07F;
            this.searchBtn1.AnimationSpeed = 0.03F;
            this.searchBtn1.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn1.BaseColor = System.Drawing.Color.Teal;
            this.searchBtn1.BorderColor = System.Drawing.Color.Black;
            this.searchBtn1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtn1.FocusedColor = System.Drawing.Color.Empty;
            this.searchBtn1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn1.ForeColor = System.Drawing.Color.White;
            this.searchBtn1.Image = null;
            this.searchBtn1.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBtn1.Location = new System.Drawing.Point(462, 24);
            this.searchBtn1.Name = "searchBtn1";
            this.searchBtn1.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.searchBtn1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBtn1.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBtn1.OnHoverImage = null;
            this.searchBtn1.OnPressedColor = System.Drawing.Color.Black;
            this.searchBtn1.Radius = 15;
            this.searchBtn1.Size = new System.Drawing.Size(89, 28);
            this.searchBtn1.TabIndex = 2;
            this.searchBtn1.Text = "Search";
            this.searchBtn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBtn1.Click += new System.EventHandler(this.searchBtn1_Click);
            // 
            // SuplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SuplierManagement";
            this.Size = new System.Drawing.Size(1060, 686);
            this.Load += new System.EventHandler(this.SuplierManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_suplierDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView S_suplierDGV;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton RefreshBtn;
        private Guna.UI.WinForms.GunaButton S_deleteBtn;
        private Guna.UI.WinForms.GunaButton S_clesrBtn;
        private Guna.UI.WinForms.GunaButton S_updateBtn;
        private Guna.UI.WinForms.GunaButton S_addbtn;
        private System.Windows.Forms.TextBox S_contactNo;
        private System.Windows.Forms.TextBox S_Email;
        private System.Windows.Forms.TextBox S_Address;
        private System.Windows.Forms.TextBox S_NameSuplier;
        private System.Windows.Forms.TextBox S_IDSuplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox catSaleBox;
        private System.Windows.Forms.TextBox SearchBox;
        private Guna.UI.WinForms.GunaButton searchBtn1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
    }
}
