
namespace WindowFormViews
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxRepassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboboxRole = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkMatchPassword = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkMatchPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 102);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(99, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "USER REGISTRATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-enter password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // textboxUsername
            // 
            this.textboxUsername.AutoRoundedCorners = true;
            this.textboxUsername.BorderRadius = 13;
            this.textboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxUsername.DefaultText = "";
            this.textboxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("textboxUsername.IconLeft")));
            this.textboxUsername.Location = new System.Drawing.Point(177, 134);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.PasswordChar = '\0';
            this.textboxUsername.PlaceholderText = "username";
            this.textboxUsername.SelectedText = "";
            this.textboxUsername.Size = new System.Drawing.Size(202, 29);
            this.textboxUsername.TabIndex = 8;
            // 
            // textboxPassword
            // 
            this.textboxPassword.AutoRoundedCorners = true;
            this.textboxPassword.BorderRadius = 13;
            this.textboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPassword.DefaultText = "";
            this.textboxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("textboxPassword.IconLeft")));
            this.textboxPassword.Location = new System.Drawing.Point(177, 176);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.PlaceholderText = "password";
            this.textboxPassword.SelectedText = "";
            this.textboxPassword.Size = new System.Drawing.Size(202, 29);
            this.textboxPassword.TabIndex = 9;
            // 
            // textboxRepassword
            // 
            this.textboxRepassword.AutoRoundedCorners = true;
            this.textboxRepassword.BorderRadius = 13;
            this.textboxRepassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxRepassword.DefaultText = "";
            this.textboxRepassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxRepassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxRepassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxRepassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxRepassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxRepassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxRepassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxRepassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("textboxRepassword.IconLeft")));
            this.textboxRepassword.Location = new System.Drawing.Point(177, 221);
            this.textboxRepassword.Name = "textboxRepassword";
            this.textboxRepassword.PasswordChar = '*';
            this.textboxRepassword.PlaceholderText = "password";
            this.textboxRepassword.SelectedText = "";
            this.textboxRepassword.Size = new System.Drawing.Size(202, 29);
            this.textboxRepassword.TabIndex = 10;
            this.textboxRepassword.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // textboxFirstname
            // 
            this.textboxFirstname.AutoRoundedCorners = true;
            this.textboxFirstname.BorderRadius = 13;
            this.textboxFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxFirstname.DefaultText = "";
            this.textboxFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxFirstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxFirstname.Location = new System.Drawing.Point(177, 308);
            this.textboxFirstname.Name = "textboxFirstname";
            this.textboxFirstname.PasswordChar = '\0';
            this.textboxFirstname.PlaceholderText = "Andrey";
            this.textboxFirstname.SelectedText = "";
            this.textboxFirstname.Size = new System.Drawing.Size(202, 29);
            this.textboxFirstname.TabIndex = 11;
            // 
            // comboboxRole
            // 
            this.comboboxRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboboxRole.FormattingEnabled = true;
            this.comboboxRole.ItemHeight = 15;
            this.comboboxRole.Items.AddRange(new object[] {
            "Referee"});
            this.comboboxRole.Location = new System.Drawing.Point(177, 265);
            this.comboboxRole.Margin = new System.Windows.Forms.Padding(0);
            this.comboboxRole.Name = "comboboxRole";
            this.comboboxRole.Size = new System.Drawing.Size(121, 23);
            this.comboboxRole.TabIndex = 14;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(100, 374);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 34);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(236, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkMatchPassword
            // 
            this.checkMatchPassword.Image = ((System.Drawing.Image)(resources.GetObject("checkMatchPassword.Image")));
            this.checkMatchPassword.Location = new System.Drawing.Point(346, 220);
            this.checkMatchPassword.Name = "checkMatchPassword";
            this.checkMatchPassword.Size = new System.Drawing.Size(33, 30);
            this.checkMatchPassword.TabIndex = 17;
            this.checkMatchPassword.TabStop = false;
            // 
            // Registration
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(430, 423);
            this.Controls.Add(this.checkMatchPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboboxRole);
            this.Controls.Add(this.textboxFirstname);
            this.Controls.Add(this.textboxRepassword);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkMatchPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox textboxUsername;
        private Guna.UI2.WinForms.Guna2TextBox textboxPassword;
        private Guna.UI2.WinForms.Guna2TextBox textboxRepassword;
        private Guna.UI2.WinForms.Guna2TextBox textboxFirstname;
        private System.Windows.Forms.ComboBox comboboxRole;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox checkMatchPassword;
    }
}