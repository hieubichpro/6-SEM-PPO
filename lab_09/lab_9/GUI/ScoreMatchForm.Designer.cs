
namespace FootballLeague.WindowFormViews
{
    partial class ScoreMatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreMatchForm));
            this.textBoxHomeGoal = new System.Windows.Forms.TextBox();
            this.textBoxGuestGoal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.labelHomeName = new System.Windows.Forms.Label();
            this.labelNameGuest = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHomeGoal
            // 
            this.textBoxHomeGoal.Location = new System.Drawing.Point(221, 39);
            this.textBoxHomeGoal.Name = "textBoxHomeGoal";
            this.textBoxHomeGoal.Size = new System.Drawing.Size(35, 27);
            this.textBoxHomeGoal.TabIndex = 0;
            // 
            // textBoxGuestGoal
            // 
            this.textBoxGuestGoal.Location = new System.Drawing.Point(328, 39);
            this.textBoxGuestGoal.Name = "textBoxGuestGoal";
            this.textBoxGuestGoal.Size = new System.Drawing.Size(35, 27);
            this.textBoxGuestGoal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "---";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(262, 75);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(0, 21);
            this.labelStadium.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(262, 99);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 21);
            this.labelDate.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 33);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(235, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "MATCH SCORE";
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(561, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelHomeName
            // 
            this.labelHomeName.AutoSize = true;
            this.labelHomeName.Location = new System.Drawing.Point(82, 45);
            this.labelHomeName.Name = "labelHomeName";
            this.labelHomeName.Size = new System.Drawing.Size(0, 21);
            this.labelHomeName.TabIndex = 6;
            // 
            // labelNameGuest
            // 
            this.labelNameGuest.AutoSize = true;
            this.labelNameGuest.Location = new System.Drawing.Point(401, 45);
            this.labelNameGuest.Name = "labelNameGuest";
            this.labelNameGuest.Size = new System.Drawing.Size(0, 21);
            this.labelNameGuest.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(516, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 21);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ScoreMatchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 129);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelNameGuest);
            this.Controls.Add(this.labelHomeName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGuestGoal);
            this.Controls.Add(this.textBoxHomeGoal);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreMatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreMatchForm";
            this.Load += new System.EventHandler(this.ScoreMatchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHomeGoal;
        private System.Windows.Forms.TextBox textBoxGuestGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label labelHomeName;
        private System.Windows.Forms.Label labelNameGuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}