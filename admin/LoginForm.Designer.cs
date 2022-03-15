namespace admin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.log_username = new Guna.UI.WinForms.GunaLineTextBox();
            this.log_password = new Guna.UI.WinForms.GunaLineTextBox();
            this.log_userRole = new Guna.UI.WinForms.GunaComboBox();
            this.Username = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.clearLog = new Guna.UI.WinForms.GunaLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.passCharSh_hi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logBtnLogin = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-174, -190);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(372, 362);
            this.guna2CircleButton1.TabIndex = 0;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            // 
            // log_username
            // 
            this.log_username.Animated = true;
            this.log_username.BackColor = System.Drawing.Color.White;
            this.log_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.log_username.FocusedLineColor = System.Drawing.Color.Lime;
            this.log_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_username.LineColor = System.Drawing.Color.Gainsboro;
            this.log_username.LineSize = 5;
            this.log_username.Location = new System.Drawing.Point(353, 162);
            this.log_username.Name = "log_username";
            this.log_username.PasswordChar = '\0';
            this.log_username.SelectedText = "";
            this.log_username.Size = new System.Drawing.Size(193, 34);
            this.log_username.TabIndex = 3;
            // 
            // log_password
            // 
            this.log_password.Animated = true;
            this.log_password.BackColor = System.Drawing.Color.White;
            this.log_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.log_password.FocusedLineColor = System.Drawing.Color.Lime;
            this.log_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_password.LineColor = System.Drawing.Color.Gainsboro;
            this.log_password.LineSize = 5;
            this.log_password.Location = new System.Drawing.Point(353, 215);
            this.log_password.Name = "log_password";
            this.log_password.PasswordChar = '.';
            this.log_password.SelectedText = "";
            this.log_password.Size = new System.Drawing.Size(193, 34);
            this.log_password.TabIndex = 4;
            // 
            // log_userRole
            // 
            this.log_userRole.BackColor = System.Drawing.Color.Transparent;
            this.log_userRole.BaseColor = System.Drawing.Color.White;
            this.log_userRole.BorderColor = System.Drawing.Color.Silver;
            this.log_userRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.log_userRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.log_userRole.FocusedColor = System.Drawing.Color.Empty;
            this.log_userRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.log_userRole.ForeColor = System.Drawing.Color.Black;
            this.log_userRole.FormattingEnabled = true;
            this.log_userRole.Items.AddRange(new object[] {
            "admin",
            "cashier",
            "pharmacist",
            "store_keeper"});
            this.log_userRole.Location = new System.Drawing.Point(353, 270);
            this.log_userRole.Name = "log_userRole";
            this.log_userRole.OnHoverItemBaseColor = System.Drawing.Color.LimeGreen;
            this.log_userRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.log_userRole.Size = new System.Drawing.Size(193, 26);
            this.log_userRole.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(247, 171);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(81, 19);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(247, 224);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(90, 19);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Passsword";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(247, 275);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(90, 19);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "User Role";
            // 
            // clearLog
            // 
            this.clearLog.AutoSize = true;
            this.clearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearLog.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLog.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearLog.Location = new System.Drawing.Point(498, 398);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(48, 21);
            this.clearLog.TabIndex = 10;
            this.clearLog.Text = "Clear";
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(451, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // passCharSh_hi
            // 
            this.passCharSh_hi.AutoSize = true;
            this.passCharSh_hi.Location = new System.Drawing.Point(531, 224);
            this.passCharSh_hi.Name = "passCharSh_hi";
            this.passCharSh_hi.Size = new System.Drawing.Size(15, 14);
            this.passCharSh_hi.TabIndex = 13;
            this.passCharSh_hi.UseVisualStyleBackColor = true;
            this.passCharSh_hi.CheckedChanged += new System.EventHandler(this.passCharSh_hi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pharmacy Management System";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::admin.Properties.Resources.lgn;
            this.guna2PictureBox1.Location = new System.Drawing.Point(339, 56);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(87, 86);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // logBtnLogin
            // 
            this.logBtnLogin.AnimationHoverSpeed = 0.07F;
            this.logBtnLogin.AnimationSpeed = 0.03F;
            this.logBtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.logBtnLogin.BaseColor = System.Drawing.Color.LimeGreen;
            this.logBtnLogin.BorderColor = System.Drawing.Color.Black;
            this.logBtnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logBtnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.logBtnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtnLogin.ForeColor = System.Drawing.Color.White;
            this.logBtnLogin.Image = global::admin.Properties.Resources.lgbt;
            this.logBtnLogin.ImageSize = new System.Drawing.Size(30, 30);
            this.logBtnLogin.Location = new System.Drawing.Point(433, 344);
            this.logBtnLogin.Name = "logBtnLogin";
            this.logBtnLogin.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.logBtnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logBtnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.logBtnLogin.OnHoverImage = null;
            this.logBtnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.logBtnLogin.Radius = 20;
            this.logBtnLogin.Size = new System.Drawing.Size(113, 42);
            this.logBtnLogin.TabIndex = 9;
            this.logBtnLogin.Text = "Login";
            this.logBtnLogin.Click += new System.EventHandler(this.logBtnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.passCharSh_hi);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.logBtnLogin);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.log_userRole);
            this.Controls.Add(this.log_password);
            this.Controls.Add(this.log_username);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy Management System v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI.WinForms.GunaLineTextBox log_username;
        private Guna.UI.WinForms.GunaLineTextBox log_password;
        private Guna.UI.WinForms.GunaComboBox log_userRole;
        private Guna.UI.WinForms.GunaLabel Username;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton logBtnLogin;
        private Guna.UI.WinForms.GunaLabel clearLog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox passCharSh_hi;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}