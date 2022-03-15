namespace admin.AddingNew
{
    partial class addNewInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewInventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recerved_person = new System.Windows.Forms.ComboBox();
            this.I_clerBtn = new Guna.UI.WinForms.GunaButton();
            this.I_SubmitBtn = new Guna.UI.WinForms.GunaButton();
            this.invQuantity = new System.Windows.Forms.TextBox();
            this.Invdiscription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InvId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Inventory";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.recerved_person);
            this.panel2.Controls.Add(this.I_clerBtn);
            this.panel2.Controls.Add(this.I_SubmitBtn);
            this.panel2.Controls.Add(this.invQuantity);
            this.panel2.Controls.Add(this.Invdiscription);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.invName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.InvId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 479);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // recerved_person
            // 
            this.recerved_person.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recerved_person.FormattingEnabled = true;
            this.recerved_person.Location = new System.Drawing.Point(170, 316);
            this.recerved_person.Name = "recerved_person";
            this.recerved_person.Size = new System.Drawing.Size(164, 23);
            this.recerved_person.TabIndex = 6;
            // 
            // I_clerBtn
            // 
            this.I_clerBtn.AnimationHoverSpeed = 0.07F;
            this.I_clerBtn.AnimationSpeed = 0.03F;
            this.I_clerBtn.BackColor = System.Drawing.Color.Transparent;
            this.I_clerBtn.BaseColor = System.Drawing.Color.Teal;
            this.I_clerBtn.BorderColor = System.Drawing.Color.Black;
            this.I_clerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.I_clerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.I_clerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_clerBtn.ForeColor = System.Drawing.Color.White;
            this.I_clerBtn.Image = null;
            this.I_clerBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.I_clerBtn.Location = new System.Drawing.Point(113, 399);
            this.I_clerBtn.Name = "I_clerBtn";
            this.I_clerBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.I_clerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.I_clerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.I_clerBtn.OnHoverImage = null;
            this.I_clerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.I_clerBtn.Radius = 15;
            this.I_clerBtn.Size = new System.Drawing.Size(96, 42);
            this.I_clerBtn.TabIndex = 5;
            this.I_clerBtn.Text = "Clear";
            this.I_clerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_clerBtn.Click += new System.EventHandler(this.I_clerBtn_Click);
            // 
            // I_SubmitBtn
            // 
            this.I_SubmitBtn.AnimationHoverSpeed = 0.07F;
            this.I_SubmitBtn.AnimationSpeed = 0.03F;
            this.I_SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.I_SubmitBtn.BaseColor = System.Drawing.Color.Teal;
            this.I_SubmitBtn.BorderColor = System.Drawing.Color.Black;
            this.I_SubmitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.I_SubmitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.I_SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.I_SubmitBtn.Image = null;
            this.I_SubmitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.I_SubmitBtn.Location = new System.Drawing.Point(238, 399);
            this.I_SubmitBtn.Name = "I_SubmitBtn";
            this.I_SubmitBtn.OnHoverBaseColor = System.Drawing.Color.DarkTurquoise;
            this.I_SubmitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.I_SubmitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.I_SubmitBtn.OnHoverImage = null;
            this.I_SubmitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.I_SubmitBtn.Radius = 15;
            this.I_SubmitBtn.Size = new System.Drawing.Size(96, 42);
            this.I_SubmitBtn.TabIndex = 5;
            this.I_SubmitBtn.Text = "Submit";
            this.I_SubmitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_SubmitBtn.Click += new System.EventHandler(this.I_SubmitBtn_Click);
            // 
            // invQuantity
            // 
            this.invQuantity.BackColor = System.Drawing.SystemColors.Menu;
            this.invQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invQuantity.Location = new System.Drawing.Point(170, 259);
            this.invQuantity.Name = "invQuantity";
            this.invQuantity.Size = new System.Drawing.Size(164, 23);
            this.invQuantity.TabIndex = 3;
            // 
            // Invdiscription
            // 
            this.Invdiscription.BackColor = System.Drawing.SystemColors.Menu;
            this.Invdiscription.Location = new System.Drawing.Point(170, 154);
            this.Invdiscription.Name = "Invdiscription";
            this.Invdiscription.Size = new System.Drawing.Size(164, 86);
            this.Invdiscription.TabIndex = 2;
            this.Invdiscription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Recerved Person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Discription";
            // 
            // invName
            // 
            this.invName.BackColor = System.Drawing.SystemColors.Menu;
            this.invName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invName.Location = new System.Drawing.Point(170, 108);
            this.invName.Name = "invName";
            this.invName.Size = new System.Drawing.Size(164, 23);
            this.invName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inventory Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // InvId
            // 
            this.InvId.BackColor = System.Drawing.SystemColors.Menu;
            this.InvId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvId.Location = new System.Drawing.Point(170, 46);
            this.InvId.Name = "InvId";
            this.InvId.Size = new System.Drawing.Size(164, 23);
            this.InvId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inventory ID";
            // 
            // addNewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addNewInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Inventory";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox invName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InvId;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton I_clerBtn;
        private Guna.UI.WinForms.GunaButton I_SubmitBtn;
        private System.Windows.Forms.TextBox invQuantity;
        private System.Windows.Forms.RichTextBox Invdiscription;
        private System.Windows.Forms.ComboBox recerved_person;
    }
}