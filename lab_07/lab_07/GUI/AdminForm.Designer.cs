
namespace WindowFormViews
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelRole = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnClub = new System.Windows.Forms.Button();
            this.btnLeague = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(84, 24);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 21);
            this.labelRole.TabIndex = 9;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Location = new System.Drawing.Point(147, 24);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(0, 21);
            this.labelFullname.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1287, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnClub);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnLeague);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 621);
            this.panel2.TabIndex = 17;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsers.Location = new System.Drawing.Point(0, 467);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(171, 140);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnClub
            // 
            this.btnClub.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClub.FlatAppearance.BorderSize = 0;
            this.btnClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClub.Location = new System.Drawing.Point(0, 302);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(175, 159);
            this.btnClub.TabIndex = 1;
            this.btnClub.Text = "Clubs";
            this.btnClub.UseVisualStyleBackColor = false;
            this.btnClub.Click += new System.EventHandler(this.btnClub_Click);
            // 
            // btnLeague
            // 
            this.btnLeague.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLeague.FlatAppearance.BorderSize = 0;
            this.btnLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeague.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeague.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeague.Location = new System.Drawing.Point(2, 148);
            this.btnLeague.Name = "btnLeague";
            this.btnLeague.Size = new System.Drawing.Size(173, 148);
            this.btnLeague.TabIndex = 0;
            this.btnLeague.Text = "Leagues";
            this.btnLeague.UseVisualStyleBackColor = false;
            this.btnLeague.Click += new System.EventHandler(this.btnLeague_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(173, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1283, 52);
            this.panel3.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel5);
            this.panel_main.Controls.Add(this.panel4);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Location = new System.Drawing.Point(173, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1290, 913);
            this.panel_main.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 640);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1290, 173);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 813);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1290, 100);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(40, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Role    Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(261, -1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 46);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbName.Location = new System.Drawing.Point(93, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 21);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Hello";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 92);
            this.panel1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1456, 621);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.labelRole);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLeague;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnClub;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}