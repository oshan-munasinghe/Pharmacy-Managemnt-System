namespace admin.AddingNew
{
    partial class token_sh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(token_sh));
            this.label1 = new System.Windows.Forms.Label();
            this.tokenIdSe = new System.Windows.Forms.ComboBox();
            this.tokenGDv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.refreshBtn = new Guna.UI.WinForms.GunaButton();
            this.searchBtn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.tokenGDv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token ID";
            // 
            // tokenIdSe
            // 
            this.tokenIdSe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenIdSe.FormattingEnabled = true;
            this.tokenIdSe.Location = new System.Drawing.Point(91, 22);
            this.tokenIdSe.Name = "tokenIdSe";
            this.tokenIdSe.Size = new System.Drawing.Size(124, 25);
            this.tokenIdSe.TabIndex = 1;
            this.tokenIdSe.SelectedIndexChanged += new System.EventHandler(this.tokenIdSe_SelectedIndexChanged);
            // 
            // tokenGDv
            // 
            this.tokenGDv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tokenGDv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tokenGDv.Location = new System.Drawing.Point(13, 76);
            this.tokenGDv.Name = "tokenGDv";
            this.tokenGDv.Size = new System.Drawing.Size(402, 293);
            this.tokenGDv.TabIndex = 2;
            this.tokenGDv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tokenGDv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Token_Id";
            this.Column1.HeaderText = "Token ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "medicine_id";
            this.Column2.HeaderText = "Medicine ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "qty";
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            this.Column3.Width = 65;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "medicine_name";
            this.Column4.HeaderText = "Medicine Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "pharmasist:";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(348, 30);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(35, 20);
            this.userlbl.TabIndex = 0;
            this.userlbl.Text = "N/A";
            // 
            // refreshBtn
            // 
            this.refreshBtn.AnimationHoverSpeed = 0.07F;
            this.refreshBtn.AnimationSpeed = 0.03F;
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BaseColor = System.Drawing.Color.Teal;
            this.refreshBtn.BorderColor = System.Drawing.Color.Black;
            this.refreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshBtn.FocusedColor = System.Drawing.Color.Empty;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Image = null;
            this.refreshBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.refreshBtn.Location = new System.Drawing.Point(329, 375);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.refreshBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshBtn.OnHoverImage = null;
            this.refreshBtn.OnPressedColor = System.Drawing.Color.Black;
            this.refreshBtn.Radius = 15;
            this.refreshBtn.Size = new System.Drawing.Size(86, 38);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AnimationHoverSpeed = 0.07F;
            this.searchBtn.AnimationSpeed = 0.03F;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BaseColor = System.Drawing.Color.Turquoise;
            this.searchBtn.BorderColor = System.Drawing.Color.Black;
            this.searchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = global::admin.Properties.Resources.refresh1;
            this.searchBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.searchBtn.Location = new System.Drawing.Point(221, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBtn.OnHoverImage = null;
            this.searchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBtn.Radius = 8;
            this.searchBtn.Size = new System.Drawing.Size(36, 28);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // token_sh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 425);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.tokenGDv);
            this.Controls.Add(this.tokenIdSe);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "token_sh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Token";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.token_sh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tokenGDv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tokenIdSe;
        private System.Windows.Forms.DataGridView tokenGDv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI.WinForms.GunaButton refreshBtn;
        private Guna.UI.WinForms.GunaButton searchBtn;
    }
}