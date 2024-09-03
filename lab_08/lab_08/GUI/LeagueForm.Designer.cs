
namespace FootballLeague.WindowFormViews
{
    partial class LeagueForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbRating = new System.Windows.Forms.ComboBox();
            this.btnRating = new System.Windows.Forms.Button();
            this.dgvLeague = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.games = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.losts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeague)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(353, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "League";
            // 
            // dgvTable
            // 
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b,
            this.Column2,
            this.games,
            this.wins,
            this.draws,
            this.loses,
            this.Column1,
            this.losts,
            this.diff,
            this.points});
            this.dgvTable.Location = new System.Drawing.Point(208, 89);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(744, 260);
            this.dgvTable.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(544, -55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(636, -55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "SHOW APPLICATIONS";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(451, -55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 48);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbbRating);
            this.panel2.Controls.Add(this.btnRating);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 84);
            this.panel2.TabIndex = 12;
            // 
            // cbbRating
            // 
            this.cbbRating.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbRating.FormattingEnabled = true;
            this.cbbRating.ItemHeight = 15;
            this.cbbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbbRating.Location = new System.Drawing.Point(603, 10);
            this.cbbRating.Margin = new System.Windows.Forms.Padding(0);
            this.cbbRating.Name = "cbbRating";
            this.cbbRating.Size = new System.Drawing.Size(55, 23);
            this.cbbRating.TabIndex = 15;
            this.cbbRating.Text = "5";
            // 
            // btnRating
            // 
            this.btnRating.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRating.FlatAppearance.BorderSize = 0;
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRating.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRating.Location = new System.Drawing.Point(661, 10);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(67, 21);
            this.btnRating.TabIndex = 6;
            this.btnRating.Text = "RATING";
            this.btnRating.UseVisualStyleBackColor = false;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // dgvLeague
            // 
            this.dgvLeague.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeague.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.rating});
            this.dgvLeague.Location = new System.Drawing.Point(0, 48);
            this.dgvLeague.Name = "dgvLeague";
            this.dgvLeague.RowHeadersWidth = 51;
            this.dgvLeague.Size = new System.Drawing.Size(211, 383);
            this.dgvLeague.TabIndex = 0;
            this.dgvLeague.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeague_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // rating
            // 
            this.rating.HeaderText = "rating";
            this.rating.Name = "rating";
            // 
            // b
            // 
            this.b.HeaderText = "name";
            this.b.Name = "b";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "allgames";
            this.Column2.Name = "Column2";
            // 
            // games
            // 
            this.games.HeaderText = "games";
            this.games.Name = "games";
            // 
            // wins
            // 
            this.wins.HeaderText = "wins";
            this.wins.Name = "wins";
            // 
            // draws
            // 
            this.draws.HeaderText = "draws";
            this.draws.Name = "draws";
            // 
            // loses
            // 
            this.loses.HeaderText = "loses";
            this.loses.Name = "loses";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "goals";
            this.Column1.Name = "Column1";
            // 
            // losts
            // 
            this.losts.HeaderText = "losts";
            this.losts.Name = "losts";
            // 
            // diff
            // 
            this.diff.HeaderText = "diff";
            this.diff.Name = "diff";
            // 
            // points
            // 
            this.points.HeaderText = "points";
            this.points.Name = "points";
            // 
            // LeagueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 431);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.dgvLeague);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "LeagueForm";
            this.Text = "League";
            this.Load += new System.EventHandler(this.LeagueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeague)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvLeague;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.ComboBox cbbRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn games;
        private System.Windows.Forms.DataGridViewTextBoxColumn wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn loses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn losts;
        private System.Windows.Forms.DataGridViewTextBoxColumn diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
    }
}