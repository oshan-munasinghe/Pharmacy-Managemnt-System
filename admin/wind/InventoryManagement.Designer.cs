namespace admin.wind
{
    partial class InventoryManagement
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.inv_Discription = new System.Windows.Forms.RichTextBox();
            this.I_ReservePerson = new System.Windows.Forms.ComboBox();
            this.I_ClearBtn = new Guna.UI.WinForms.GunaButton();
            this.I_UpdateBtn = new Guna.UI.WinForms.GunaButton();
            this.I_DeleteBtn = new Guna.UI.WinForms.GunaButton();
            this.Inv_Mg_Add_btn = new Guna.UI.WinForms.GunaButton();
            this.I_Quantitytext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.I_Name = new System.Windows.Forms.TextBox();
            this.I_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.I_Mg_DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_RefreshBtn = new Guna.UI.WinForms.GunaButton();
            this.I_genReportBtn = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.I_Mg_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Inventory";
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
            this.panel1.Size = new System.Drawing.Size(1060, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 35);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.inv_Discription);
            this.panel3.Controls.Add(this.I_ReservePerson);
            this.panel3.Controls.Add(this.I_ClearBtn);
            this.panel3.Controls.Add(this.I_UpdateBtn);
            this.panel3.Controls.Add(this.I_DeleteBtn);
            this.panel3.Controls.Add(this.Inv_Mg_Add_btn);
            this.panel3.Controls.Add(this.I_Quantitytext);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.I_Name);
            this.panel3.Controls.Add(this.I_ID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 591);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // inv_Discription
            // 
            this.inv_Discription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_Discription.Location = new System.Drawing.Point(173, 212);
            this.inv_Discription.Name = "inv_Discription";
            this.inv_Discription.Size = new System.Drawing.Size(132, 57);
            this.inv_Discription.TabIndex = 20;
            this.inv_Discription.Text = "";
            // 
            // I_ReservePerson
            // 
            this.I_ReservePerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_ReservePerson.FormattingEnabled = true;
            this.I_ReservePerson.Location = new System.Drawing.Point(173, 290);
            this.I_ReservePerson.Name = "I_ReservePerson";
            this.I_ReservePerson.Size = new System.Drawing.Size(132, 25);
            this.I_ReservePerson.TabIndex = 19;
            this.I_ReservePerson.SelectedIndexChanged += new System.EventHandler(this.I_ReservePerson_SelectedIndexChanged);
            // 
            // I_ClearBtn
            // 
            this.I_ClearBtn.AnimationHoverSpeed = 0.07F;
            this.I_ClearBtn.AnimationSpeed = 0.03F;
            this.I_ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.I_ClearBtn.BaseColor = System.Drawing.Color.Teal;
            this.I_ClearBtn.BorderColor = System.Drawing.Color.Black;
            this.I_ClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.I_ClearBtn.FocusedColor = System.Drawing.Color.Empty;
            this.I_ClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.I_ClearBtn.ForeColor = System.Drawing.Color.White;
            this.I_ClearBtn.Image = null;
            this.I_ClearBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.I_ClearBtn.Location = new System.Drawing.Point(226, 400);
            this.I_ClearBtn.Name = "I_ClearBtn";
            this.I_ClearBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.I_ClearBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.I_ClearBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.I_ClearBtn.OnHoverImage = null;
            this.I_ClearBtn.OnPressedColor = System.Drawing.Color.Black;
            this.I_ClearBtn.Radius = 15;
            this.I_ClearBtn.Size = new System.Drawing.Size(79, 42);
            this.I_ClearBtn.TabIndex = 9;
            this.I_ClearBtn.Text = "Clear";
            this.I_ClearBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_ClearBtn.Click += new System.EventHandler(this.I_ClearBtn_Click);
            // 
            // I_UpdateBtn
            // 
            this.I_UpdateBtn.AnimationHoverSpeed = 0.07F;
            this.I_UpdateBtn.AnimationSpeed = 0.03F;
            this.I_UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.I_UpdateBtn.BaseColor = System.Drawing.Color.Teal;
            this.I_UpdateBtn.BorderColor = System.Drawing.Color.Black;
            this.I_UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.I_UpdateBtn.FocusedColor = System.Drawing.Color.Empty;
            this.I_UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.I_UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.I_UpdateBtn.Image = null;
            this.I_UpdateBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.I_UpdateBtn.Location = new System.Drawing.Point(31, 400);
            this.I_UpdateBtn.Name = "I_UpdateBtn";
            this.I_UpdateBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.I_UpdateBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.I_UpdateBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.I_UpdateBtn.OnHoverImage = null;
            this.I_UpdateBtn.OnPressedColor = System.Drawing.Color.Black;
            this.I_UpdateBtn.Radius = 15;
            this.I_UpdateBtn.Size = new System.Drawing.Size(79, 42);
            this.I_UpdateBtn.TabIndex = 18;
            this.I_UpdateBtn.Text = "Update";
            this.I_UpdateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_UpdateBtn.Click += new System.EventHandler(this.I_UpdateBtn_Click);
            // 
            // I_DeleteBtn
            // 
            this.I_DeleteBtn.AnimationHoverSpeed = 0.07F;
            this.I_DeleteBtn.AnimationSpeed = 0.03F;
            this.I_DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.I_DeleteBtn.BaseColor = System.Drawing.Color.Teal;
            this.I_DeleteBtn.BorderColor = System.Drawing.Color.Black;
            this.I_DeleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.I_DeleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.I_DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.I_DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.I_DeleteBtn.Image = null;
            this.I_DeleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.I_DeleteBtn.Location = new System.Drawing.Point(126, 400);
            this.I_DeleteBtn.Name = "I_DeleteBtn";
            this.I_DeleteBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.I_DeleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.I_DeleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.I_DeleteBtn.OnHoverImage = null;
            this.I_DeleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.I_DeleteBtn.Radius = 15;
            this.I_DeleteBtn.Size = new System.Drawing.Size(79, 42);
            this.I_DeleteBtn.TabIndex = 8;
            this.I_DeleteBtn.Text = "Delete";
            this.I_DeleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_DeleteBtn.Click += new System.EventHandler(this.I_DeleteBtn_Click);
            // 
            // Inv_Mg_Add_btn
            // 
            this.Inv_Mg_Add_btn.AnimationHoverSpeed = 0.07F;
            this.Inv_Mg_Add_btn.AnimationSpeed = 0.03F;
            this.Inv_Mg_Add_btn.BackColor = System.Drawing.Color.Transparent;
            this.Inv_Mg_Add_btn.BaseColor = System.Drawing.Color.Teal;
            this.Inv_Mg_Add_btn.BorderColor = System.Drawing.Color.Black;
            this.Inv_Mg_Add_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Inv_Mg_Add_btn.FocusedColor = System.Drawing.Color.Empty;
            this.Inv_Mg_Add_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inv_Mg_Add_btn.ForeColor = System.Drawing.Color.White;
            this.Inv_Mg_Add_btn.Image = null;
            this.Inv_Mg_Add_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.Inv_Mg_Add_btn.Location = new System.Drawing.Point(21, 41);
            this.Inv_Mg_Add_btn.Name = "Inv_Mg_Add_btn";
            this.Inv_Mg_Add_btn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.Inv_Mg_Add_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Inv_Mg_Add_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Inv_Mg_Add_btn.OnHoverImage = null;
            this.Inv_Mg_Add_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Inv_Mg_Add_btn.Radius = 25;
            this.Inv_Mg_Add_btn.Size = new System.Drawing.Size(168, 48);
            this.Inv_Mg_Add_btn.TabIndex = 15;
            this.Inv_Mg_Add_btn.Text = "Add New Inventory";
            this.Inv_Mg_Add_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Inv_Mg_Add_btn.Click += new System.EventHandler(this.Inv_Mg_Add_btn_Click_1);
            // 
            // I_Quantitytext
            // 
            this.I_Quantitytext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_Quantitytext.Location = new System.Drawing.Point(173, 341);
            this.I_Quantitytext.Name = "I_Quantitytext";
            this.I_Quantitytext.Size = new System.Drawing.Size(132, 25);
            this.I_Quantitytext.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Receved Person";
            // 
            // I_Name
            // 
            this.I_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_Name.Location = new System.Drawing.Point(173, 165);
            this.I_Name.Name = "I_Name";
            this.I_Name.Size = new System.Drawing.Size(132, 25);
            this.I_Name.TabIndex = 8;
            // 
            // I_ID
            // 
            this.I_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_ID.Location = new System.Drawing.Point(173, 115);
            this.I_ID.Name = "I_ID";
            this.I_ID.Size = new System.Drawing.Size(132, 25);
            this.I_ID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inventory Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inventory ID";
            // 
            // I_Mg_DGV
            // 
            this.I_Mg_DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.I_Mg_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.I_Mg_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.I_Mg_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3});
            this.I_Mg_DGV.Location = new System.Drawing.Point(356, 101);
            this.I_Mg_DGV.Name = "I_Mg_DGV";
            this.I_Mg_DGV.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_Mg_DGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.I_Mg_DGV.Size = new System.Drawing.Size(651, 358);
            this.I_Mg_DGV.TabIndex = 5;
            this.I_Mg_DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.I_Mg_Inventry_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "inventory_id";
            this.Column1.HeaderText = "Inventory ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "inventory_name";
            this.Column2.HeaderText = "Inventory Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "discription";
            this.Column5.HeaderText = "Discription";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "quantity";
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 62;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "username";
            this.Column3.HeaderText = "Recerved Person";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // I_RefreshBtn
            // 
            this.I_RefreshBtn.AnimationHoverSpeed = 0.07F;
            this.I_RefreshBtn.AnimationSpeed = 0.03F;
            this.I_RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.I_RefreshBtn.BaseColor = System.Drawing.Color.Teal;
            this.I_RefreshBtn.BorderColor = System.Drawing.Color.Black;
            this.I_RefreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.I_RefreshBtn.FocusedColor = System.Drawing.Color.Empty;
            this.I_RefreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.I_RefreshBtn.Image = null;
            this.I_RefreshBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.I_RefreshBtn.Location = new System.Drawing.Point(709, 498);
            this.I_RefreshBtn.Name = "I_RefreshBtn";
            this.I_RefreshBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.I_RefreshBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.I_RefreshBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.I_RefreshBtn.OnHoverImage = null;
            this.I_RefreshBtn.OnPressedColor = System.Drawing.Color.Black;
            this.I_RefreshBtn.Radius = 15;
            this.I_RefreshBtn.Size = new System.Drawing.Size(131, 47);
            this.I_RefreshBtn.TabIndex = 8;
            this.I_RefreshBtn.Text = "Refresh";
            this.I_RefreshBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_RefreshBtn.Click += new System.EventHandler(this.I_RefreshBtn_Click);
            // 
            // I_genReportBtn
            // 
            this.I_genReportBtn.AnimationHoverSpeed = 0.07F;
            this.I_genReportBtn.AnimationSpeed = 0.03F;
            this.I_genReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.I_genReportBtn.BaseColor = System.Drawing.Color.Teal;
            this.I_genReportBtn.BorderColor = System.Drawing.Color.Black;
            this.I_genReportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.I_genReportBtn.FocusedColor = System.Drawing.Color.Empty;
            this.I_genReportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_genReportBtn.ForeColor = System.Drawing.Color.White;
            this.I_genReportBtn.Image = null;
            this.I_genReportBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.I_genReportBtn.Location = new System.Drawing.Point(876, 498);
            this.I_genReportBtn.Name = "I_genReportBtn";
            this.I_genReportBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.I_genReportBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.I_genReportBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.I_genReportBtn.OnHoverImage = null;
            this.I_genReportBtn.OnPressedColor = System.Drawing.Color.Black;
            this.I_genReportBtn.Radius = 15;
            this.I_genReportBtn.Size = new System.Drawing.Size(131, 47);
            this.I_genReportBtn.TabIndex = 9;
            this.I_genReportBtn.Text = "Genarate Report";
            this.I_genReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_genReportBtn.Click += new System.EventHandler(this.I_genReportBtn_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.I_genReportBtn);
            this.Controls.Add(this.I_RefreshBtn);
            this.Controls.Add(this.I_Mg_DGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryManagement";
            this.Size = new System.Drawing.Size(1060, 686);
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.I_Mg_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView I_Mg_DGV;
        private System.Windows.Forms.TextBox I_Quantitytext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox I_Name;
        private System.Windows.Forms.TextBox I_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton Inv_Mg_Add_btn;
        private Guna.UI.WinForms.GunaButton I_ClearBtn;
        private Guna.UI.WinForms.GunaButton I_DeleteBtn;
        private Guna.UI.WinForms.GunaButton I_UpdateBtn;
        private Guna.UI.WinForms.GunaButton I_genReportBtn;
        private Guna.UI.WinForms.GunaButton I_RefreshBtn;
        private System.Windows.Forms.ComboBox I_ReservePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox inv_Discription;
    }
}
