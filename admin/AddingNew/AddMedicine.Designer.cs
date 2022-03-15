namespace admin.AddingNew
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_medicine = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userIdbox = new System.Windows.Forms.ComboBox();
            this.supIdbox = new System.Windows.Forms.ComboBox();
            this.M_ClearBtn = new Guna.UI.WinForms.GunaButton();
            this.M_submitBtn = new Guna.UI.WinForms.GunaButton();
            this.M_EXP = new System.Windows.Forms.DateTimePicker();
            this.M_MFD = new System.Windows.Forms.DateTimePicker();
            this.M_Quantity = new System.Windows.Forms.TextBox();
            this.M_UnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.M_Medicine_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.M_Medicine_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.add_medicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 64);
            this.panel1.TabIndex = 0;
            // 
            // add_medicine
            // 
            this.add_medicine.AutoSize = true;
            this.add_medicine.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_medicine.Location = new System.Drawing.Point(75, 9);
            this.add_medicine.Name = "add_medicine";
            this.add_medicine.Size = new System.Drawing.Size(195, 32);
            this.add_medicine.TabIndex = 0;
            this.add_medicine.Text = "Add Medicine";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.userIdbox);
            this.panel2.Controls.Add(this.supIdbox);
            this.panel2.Controls.Add(this.M_ClearBtn);
            this.panel2.Controls.Add(this.M_submitBtn);
            this.panel2.Controls.Add(this.M_EXP);
            this.panel2.Controls.Add(this.M_MFD);
            this.panel2.Controls.Add(this.M_Quantity);
            this.panel2.Controls.Add(this.M_UnitPrice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.M_Medicine_Name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.M_Medicine_ID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 564);
            this.panel2.TabIndex = 1;
            // 
            // userIdbox
            // 
            this.userIdbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userIdbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdbox.FormattingEnabled = true;
            this.userIdbox.Items.AddRange(new object[] {
            "Tablet/ capsule",
            "Injection",
            "cyrap"});
            this.userIdbox.Location = new System.Drawing.Point(149, 305);
            this.userIdbox.Name = "userIdbox";
            this.userIdbox.Size = new System.Drawing.Size(180, 23);
            this.userIdbox.TabIndex = 5;
            // 
            // supIdbox
            // 
            this.supIdbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supIdbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supIdbox.FormattingEnabled = true;
            this.supIdbox.Location = new System.Drawing.Point(149, 141);
            this.supIdbox.Name = "supIdbox";
            this.supIdbox.Size = new System.Drawing.Size(180, 23);
            this.supIdbox.TabIndex = 4;
            // 
            // M_ClearBtn
            // 
            this.M_ClearBtn.AnimationHoverSpeed = 0.07F;
            this.M_ClearBtn.AnimationSpeed = 0.03F;
            this.M_ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.M_ClearBtn.BaseColor = System.Drawing.Color.Teal;
            this.M_ClearBtn.BorderColor = System.Drawing.Color.Black;
            this.M_ClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.M_ClearBtn.FocusedColor = System.Drawing.Color.Empty;
            this.M_ClearBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_ClearBtn.ForeColor = System.Drawing.Color.White;
            this.M_ClearBtn.Image = null;
            this.M_ClearBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.M_ClearBtn.Location = new System.Drawing.Point(68, 470);
            this.M_ClearBtn.Name = "M_ClearBtn";
            this.M_ClearBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.M_ClearBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.M_ClearBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.M_ClearBtn.OnHoverImage = null;
            this.M_ClearBtn.OnPressedColor = System.Drawing.Color.Black;
            this.M_ClearBtn.Radius = 15;
            this.M_ClearBtn.Size = new System.Drawing.Size(105, 42);
            this.M_ClearBtn.TabIndex = 3;
            this.M_ClearBtn.Text = "Clear";
            this.M_ClearBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M_submitBtn
            // 
            this.M_submitBtn.AnimationHoverSpeed = 0.07F;
            this.M_submitBtn.AnimationSpeed = 0.03F;
            this.M_submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.M_submitBtn.BaseColor = System.Drawing.Color.Teal;
            this.M_submitBtn.BorderColor = System.Drawing.Color.Black;
            this.M_submitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.M_submitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.M_submitBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_submitBtn.ForeColor = System.Drawing.Color.White;
            this.M_submitBtn.Image = null;
            this.M_submitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.M_submitBtn.Location = new System.Drawing.Point(192, 470);
            this.M_submitBtn.Name = "M_submitBtn";
            this.M_submitBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.M_submitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.M_submitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.M_submitBtn.OnHoverImage = null;
            this.M_submitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.M_submitBtn.Radius = 15;
            this.M_submitBtn.Size = new System.Drawing.Size(105, 42);
            this.M_submitBtn.TabIndex = 3;
            this.M_submitBtn.Text = "Submit";
            this.M_submitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M_submitBtn.Click += new System.EventHandler(this.M_submitBtn_Click);
            // 
            // M_EXP
            // 
            this.M_EXP.CalendarTitleBackColor = System.Drawing.Color.LawnGreen;
            this.M_EXP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_EXP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.M_EXP.Location = new System.Drawing.Point(149, 248);
            this.M_EXP.Name = "M_EXP";
            this.M_EXP.Size = new System.Drawing.Size(180, 25);
            this.M_EXP.TabIndex = 2;
            // 
            // M_MFD
            // 
            this.M_MFD.CalendarTitleBackColor = System.Drawing.Color.LawnGreen;
            this.M_MFD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_MFD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.M_MFD.Location = new System.Drawing.Point(149, 197);
            this.M_MFD.Name = "M_MFD";
            this.M_MFD.Size = new System.Drawing.Size(180, 25);
            this.M_MFD.TabIndex = 2;
            // 
            // M_Quantity
            // 
            this.M_Quantity.BackColor = System.Drawing.SystemColors.Menu;
            this.M_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Quantity.Location = new System.Drawing.Point(149, 408);
            this.M_Quantity.Name = "M_Quantity";
            this.M_Quantity.Size = new System.Drawing.Size(180, 25);
            this.M_Quantity.TabIndex = 1;
            // 
            // M_UnitPrice
            // 
            this.M_UnitPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.M_UnitPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_UnitPrice.Location = new System.Drawing.Point(149, 352);
            this.M_UnitPrice.Name = "M_UnitPrice";
            this.M_UnitPrice.Size = new System.Drawing.Size(180, 25);
            this.M_UnitPrice.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "EXP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "MFD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supplier ID";
            // 
            // M_Medicine_Name
            // 
            this.M_Medicine_Name.BackColor = System.Drawing.SystemColors.Menu;
            this.M_Medicine_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Medicine_Name.Location = new System.Drawing.Point(149, 91);
            this.M_Medicine_Name.Name = "M_Medicine_Name";
            this.M_Medicine_Name.Size = new System.Drawing.Size(180, 25);
            this.M_Medicine_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medicine Name";
            // 
            // M_Medicine_ID
            // 
            this.M_Medicine_ID.BackColor = System.Drawing.SystemColors.Menu;
            this.M_Medicine_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Medicine_ID.Location = new System.Drawing.Point(149, 36);
            this.M_Medicine_ID.Name = "M_Medicine_ID";
            this.M_Medicine_ID.Size = new System.Drawing.Size(180, 25);
            this.M_Medicine_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine ID";
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMedicine";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label add_medicine;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton M_ClearBtn;
        private Guna.UI.WinForms.GunaButton M_submitBtn;
        private System.Windows.Forms.DateTimePicker M_EXP;
        private System.Windows.Forms.DateTimePicker M_MFD;
        private System.Windows.Forms.TextBox M_Quantity;
        private System.Windows.Forms.TextBox M_UnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox M_Medicine_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox M_Medicine_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userIdbox;
        private System.Windows.Forms.ComboBox supIdbox;
    }
}