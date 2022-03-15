namespace admin.wind
{
    partial class costManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userBox = new System.Windows.Forms.ComboBox();
            this.C_RefreshBtn = new Guna.UI.WinForms.GunaButton();
            this.C_genReport = new Guna.UI.WinForms.GunaButton();
            this.C_Update = new Guna.UI.WinForms.GunaButton();
            this.C_Delete = new Guna.UI.WinForms.GunaButton();
            this.C_clear = new Guna.UI.WinForms.GunaButton();
            this.C_addCostBtn = new Guna.UI.WinForms.GunaButton();
            this.cost_Mg_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_Mg_DiscriptionBox = new System.Windows.Forms.TextBox();
            this.cost_Mg_AmountBox = new System.Windows.Forms.TextBox();
            this.cost_Mg_CostTypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost_Mg_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost Management";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userBox);
            this.panel3.Controls.Add(this.C_RefreshBtn);
            this.panel3.Controls.Add(this.C_genReport);
            this.panel3.Controls.Add(this.C_Update);
            this.panel3.Controls.Add(this.C_Delete);
            this.panel3.Controls.Add(this.C_clear);
            this.panel3.Controls.Add(this.C_addCostBtn);
            this.panel3.Controls.Add(this.cost_Mg_DataGridView);
            this.panel3.Controls.Add(this.cost_Mg_DiscriptionBox);
            this.panel3.Controls.Add(this.cost_Mg_AmountBox);
            this.panel3.Controls.Add(this.cost_Mg_CostTypeBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 629);
            this.panel3.TabIndex = 2;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.FormattingEnabled = true;
            this.userBox.Location = new System.Drawing.Point(141, 279);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(121, 24);
            this.userBox.TabIndex = 26;
            // 
            // C_RefreshBtn
            // 
            this.C_RefreshBtn.AnimationHoverSpeed = 0.07F;
            this.C_RefreshBtn.AnimationSpeed = 0.03F;
            this.C_RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.C_RefreshBtn.BaseColor = System.Drawing.Color.DarkCyan;
            this.C_RefreshBtn.BorderColor = System.Drawing.Color.Black;
            this.C_RefreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.C_RefreshBtn.FocusedColor = System.Drawing.Color.Empty;
            this.C_RefreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.C_RefreshBtn.Image = null;
            this.C_RefreshBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.C_RefreshBtn.Location = new System.Drawing.Point(919, 476);
            this.C_RefreshBtn.Name = "C_RefreshBtn";
            this.C_RefreshBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.C_RefreshBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.C_RefreshBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.C_RefreshBtn.OnHoverImage = null;
            this.C_RefreshBtn.OnPressedColor = System.Drawing.Color.Black;
            this.C_RefreshBtn.Radius = 15;
            this.C_RefreshBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_RefreshBtn.Size = new System.Drawing.Size(81, 43);
            this.C_RefreshBtn.TabIndex = 25;
            this.C_RefreshBtn.Text = "Refresh";
            this.C_RefreshBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_RefreshBtn.Click += new System.EventHandler(this.C_RefreshBtn_Click);
            // 
            // C_genReport
            // 
            this.C_genReport.AnimationHoverSpeed = 0.07F;
            this.C_genReport.AnimationSpeed = 0.03F;
            this.C_genReport.BackColor = System.Drawing.Color.Transparent;
            this.C_genReport.BaseColor = System.Drawing.Color.DarkCyan;
            this.C_genReport.BorderColor = System.Drawing.Color.Black;
            this.C_genReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.C_genReport.FocusedColor = System.Drawing.Color.Empty;
            this.C_genReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_genReport.ForeColor = System.Drawing.Color.White;
            this.C_genReport.Image = null;
            this.C_genReport.ImageSize = new System.Drawing.Size(20, 20);
            this.C_genReport.Location = new System.Drawing.Point(750, 476);
            this.C_genReport.Name = "C_genReport";
            this.C_genReport.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.C_genReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.C_genReport.OnHoverForeColor = System.Drawing.Color.White;
            this.C_genReport.OnHoverImage = null;
            this.C_genReport.OnPressedColor = System.Drawing.Color.Black;
            this.C_genReport.Radius = 15;
            this.C_genReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_genReport.Size = new System.Drawing.Size(148, 43);
            this.C_genReport.TabIndex = 24;
            this.C_genReport.Text = "Genarate Report";
            this.C_genReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // C_Update
            // 
            this.C_Update.AnimationHoverSpeed = 0.07F;
            this.C_Update.AnimationSpeed = 0.03F;
            this.C_Update.BackColor = System.Drawing.Color.Transparent;
            this.C_Update.BaseColor = System.Drawing.Color.DarkCyan;
            this.C_Update.BorderColor = System.Drawing.Color.Black;
            this.C_Update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.C_Update.FocusedColor = System.Drawing.Color.Empty;
            this.C_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Update.ForeColor = System.Drawing.Color.White;
            this.C_Update.Image = null;
            this.C_Update.ImageSize = new System.Drawing.Size(20, 20);
            this.C_Update.Location = new System.Drawing.Point(28, 348);
            this.C_Update.Name = "C_Update";
            this.C_Update.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.C_Update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.C_Update.OnHoverForeColor = System.Drawing.Color.White;
            this.C_Update.OnHoverImage = null;
            this.C_Update.OnPressedColor = System.Drawing.Color.Black;
            this.C_Update.Radius = 15;
            this.C_Update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_Update.Size = new System.Drawing.Size(91, 43);
            this.C_Update.TabIndex = 22;
            this.C_Update.Text = "Update";
            this.C_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_Update.Click += new System.EventHandler(this.C_Update_Click);
            // 
            // C_Delete
            // 
            this.C_Delete.AnimationHoverSpeed = 0.07F;
            this.C_Delete.AnimationSpeed = 0.03F;
            this.C_Delete.BackColor = System.Drawing.Color.Transparent;
            this.C_Delete.BaseColor = System.Drawing.Color.DarkCyan;
            this.C_Delete.BorderColor = System.Drawing.Color.Black;
            this.C_Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.C_Delete.FocusedColor = System.Drawing.Color.Empty;
            this.C_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Delete.ForeColor = System.Drawing.Color.White;
            this.C_Delete.Image = null;
            this.C_Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.C_Delete.Location = new System.Drawing.Point(125, 348);
            this.C_Delete.Name = "C_Delete";
            this.C_Delete.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.C_Delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.C_Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.C_Delete.OnHoverImage = null;
            this.C_Delete.OnPressedColor = System.Drawing.Color.Black;
            this.C_Delete.Radius = 15;
            this.C_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_Delete.Size = new System.Drawing.Size(88, 43);
            this.C_Delete.TabIndex = 21;
            this.C_Delete.Text = "Delete";
            this.C_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_Delete.Click += new System.EventHandler(this.C_Delete_Click);
            // 
            // C_clear
            // 
            this.C_clear.AnimationHoverSpeed = 0.07F;
            this.C_clear.AnimationSpeed = 0.03F;
            this.C_clear.BackColor = System.Drawing.Color.Transparent;
            this.C_clear.BaseColor = System.Drawing.Color.DarkCyan;
            this.C_clear.BorderColor = System.Drawing.Color.Black;
            this.C_clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.C_clear.FocusedColor = System.Drawing.Color.Empty;
            this.C_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_clear.ForeColor = System.Drawing.Color.White;
            this.C_clear.Image = null;
            this.C_clear.ImageSize = new System.Drawing.Size(20, 20);
            this.C_clear.Location = new System.Drawing.Point(219, 348);
            this.C_clear.Name = "C_clear";
            this.C_clear.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.C_clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.C_clear.OnHoverForeColor = System.Drawing.Color.White;
            this.C_clear.OnHoverImage = null;
            this.C_clear.OnPressedColor = System.Drawing.Color.Black;
            this.C_clear.Radius = 15;
            this.C_clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_clear.Size = new System.Drawing.Size(81, 43);
            this.C_clear.TabIndex = 20;
            this.C_clear.Text = "Clear";
            this.C_clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_clear.Click += new System.EventHandler(this.C_clear_Click);
            // 
            // C_addCostBtn
            // 
            this.C_addCostBtn.AnimationHoverSpeed = 0.07F;
            this.C_addCostBtn.AnimationSpeed = 0.03F;
            this.C_addCostBtn.BackColor = System.Drawing.Color.Transparent;
            this.C_addCostBtn.BaseColor = System.Drawing.Color.DarkCyan;
            this.C_addCostBtn.BorderColor = System.Drawing.Color.Black;
            this.C_addCostBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.C_addCostBtn.FocusedColor = System.Drawing.Color.Empty;
            this.C_addCostBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_addCostBtn.ForeColor = System.Drawing.Color.White;
            this.C_addCostBtn.Image = null;
            this.C_addCostBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.C_addCostBtn.Location = new System.Drawing.Point(39, 41);
            this.C_addCostBtn.Name = "C_addCostBtn";
            this.C_addCostBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.C_addCostBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.C_addCostBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.C_addCostBtn.OnHoverImage = null;
            this.C_addCostBtn.OnPressedColor = System.Drawing.Color.Black;
            this.C_addCostBtn.Radius = 15;
            this.C_addCostBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_addCostBtn.Size = new System.Drawing.Size(120, 43);
            this.C_addCostBtn.TabIndex = 19;
            this.C_addCostBtn.Text = "Add Cost";
            this.C_addCostBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_addCostBtn.Click += new System.EventHandler(this.C_addCostBtn_Click);
            // 
            // cost_Mg_DataGridView
            // 
            this.cost_Mg_DataGridView.AllowUserToAddRows = false;
            this.cost_Mg_DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cost_Mg_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cost_Mg_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cost_Mg_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.cost_Mg_DataGridView.Location = new System.Drawing.Point(352, 41);
            this.cost_Mg_DataGridView.Name = "cost_Mg_DataGridView";
            this.cost_Mg_DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_Mg_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.cost_Mg_DataGridView.Size = new System.Drawing.Size(651, 361);
            this.cost_Mg_DataGridView.TabIndex = 11;
            this.cost_Mg_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cost_Mg_DataGridView_CellContentClick);
            this.cost_Mg_DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cost_Mg_DataGridView_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cost_type";
            this.Column1.HeaderText = "Cost Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cost_price";
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "discription";
            this.Column3.HeaderText = "Discription";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "userid";
            this.Column4.HeaderText = "Assign User";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // cost_Mg_DiscriptionBox
            // 
            this.cost_Mg_DiscriptionBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_Mg_DiscriptionBox.Location = new System.Drawing.Point(141, 223);
            this.cost_Mg_DiscriptionBox.Name = "cost_Mg_DiscriptionBox";
            this.cost_Mg_DiscriptionBox.Size = new System.Drawing.Size(123, 23);
            this.cost_Mg_DiscriptionBox.TabIndex = 6;
            // 
            // cost_Mg_AmountBox
            // 
            this.cost_Mg_AmountBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_Mg_AmountBox.Location = new System.Drawing.Point(141, 173);
            this.cost_Mg_AmountBox.Name = "cost_Mg_AmountBox";
            this.cost_Mg_AmountBox.Size = new System.Drawing.Size(123, 23);
            this.cost_Mg_AmountBox.TabIndex = 5;
            // 
            // cost_Mg_CostTypeBox
            // 
            this.cost_Mg_CostTypeBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_Mg_CostTypeBox.Location = new System.Drawing.Point(141, 124);
            this.cost_Mg_CostTypeBox.Name = "cost_Mg_CostTypeBox";
            this.cost_Mg_CostTypeBox.Size = new System.Drawing.Size(123, 23);
            this.cost_Mg_CostTypeBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Discription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Assign User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost Type";
            // 
            // costManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "costManagement";
            this.Size = new System.Drawing.Size(1060, 686);
            this.Load += new System.EventHandler(this.costManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost_Mg_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox cost_Mg_DiscriptionBox;
        private System.Windows.Forms.TextBox cost_Mg_AmountBox;
        private System.Windows.Forms.TextBox cost_Mg_CostTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView cost_Mg_DataGridView;
        private Guna.UI.WinForms.GunaButton C_RefreshBtn;
        private Guna.UI.WinForms.GunaButton C_genReport;
        private Guna.UI.WinForms.GunaButton C_Update;
        private Guna.UI.WinForms.GunaButton C_Delete;
        private Guna.UI.WinForms.GunaButton C_clear;
        private Guna.UI.WinForms.GunaButton C_addCostBtn;
        private System.Windows.Forms.ComboBox userBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
