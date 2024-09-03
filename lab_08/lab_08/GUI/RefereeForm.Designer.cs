
namespace lab_07.GUI
{
    partial class RefereeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefereeForm));
            this.btnClub = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLeague = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMyLeague = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClub
            // 
            this.btnClub.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClub.FlatAppearance.BorderSize = 0;
            this.btnClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClub.Location = new System.Drawing.Point(0, 381);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(175, 230);
            this.btnClub.TabIndex = 18;
            this.btnClub.Text = "Clubs";
            this.btnClub.UseVisualStyleBackColor = false;
            this.btnClub.Click += new System.EventHandler(this.btnClub_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnLeague
            // 
            this.btnLeague.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLeague.FlatAppearance.BorderSize = 0;
            this.btnLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeague.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeague.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeague.Location = new System.Drawing.Point(2, 105);
            this.btnLeague.Name = "btnLeague";
            this.btnLeague.Size = new System.Drawing.Size(173, 280);
            this.btnLeague.TabIndex = 17;
            this.btnLeague.Text = "Leagues";
            this.btnLeague.UseVisualStyleBackColor = false;
            this.btnLeague.Click += new System.EventHandler(this.btnLeague_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnMyLeague);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 105);
            this.panel1.TabIndex = 21;
            // 
            // btnMyLeague
            // 
            this.btnMyLeague.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMyLeague.FlatAppearance.BorderSize = 0;
            this.btnMyLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyLeague.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMyLeague.Location = new System.Drawing.Point(231, 67);
            this.btnMyLeague.Name = "btnMyLeague";
            this.btnMyLeague.Size = new System.Drawing.Size(127, 35);
            this.btnMyLeague.TabIndex = 16;
            this.btnMyLeague.Text = "My League";
            this.btnMyLeague.UseVisualStyleBackColor = false;
            this.btnMyLeague.Click += new System.EventHandler(this.btnMyLeague_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(383, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 46);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(227, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Role Referee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(227, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hello";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(281, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1114, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Location = new System.Drawing.Point(172, 105);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1117, 506);
            this.panel_main.TabIndex = 22;
            // 
            // RefereeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 611);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.btnLeague);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RefereeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RefereeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClub;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLeague;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMyLeague;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_main;
    }
}