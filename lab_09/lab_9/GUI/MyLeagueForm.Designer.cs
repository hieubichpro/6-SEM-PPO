
namespace FootballLeague.WindowFormViews
{
    partial class MyLeagueForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMyLeague = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbRating = new System.Windows.Forms.ComboBox();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyLeague)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(512, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LEAGUE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 76);
            this.panel1.TabIndex = 15;
            // 
            // dgvMyLeague
            // 
            this.dgvMyLeague.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyLeague.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.rating});
            this.dgvMyLeague.Location = new System.Drawing.Point(0, 75);
            this.dgvMyLeague.Name = "dgvMyLeague";
            this.dgvMyLeague.RowHeadersWidth = 51;
            this.dgvMyLeague.Size = new System.Drawing.Size(496, 356);
            this.dgvMyLeague.TabIndex = 13;
            this.dgvMyLeague.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyLeague_CellClick);
            this.dgvMyLeague.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyLeague_CellDoubleClick);
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(527, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbbRating);
            this.panel2.Controls.Add(this.btnRating);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 56);
            this.panel2.TabIndex = 17;
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
            this.cbbRating.Location = new System.Drawing.Point(280, 19);
            this.cbbRating.Margin = new System.Windows.Forms.Padding(0);
            this.cbbRating.Name = "cbbRating";
            this.cbbRating.Size = new System.Drawing.Size(55, 23);
            this.cbbRating.TabIndex = 17;
            this.cbbRating.Text = "5";
            // 
            // btnRating
            // 
            this.btnRating.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRating.FlatAppearance.BorderSize = 0;
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRating.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRating.Location = new System.Drawing.Point(338, 19);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(67, 21);
            this.btnRating.TabIndex = 16;
            this.btnRating.Text = "RATING";
            this.btnRating.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Fuchsia;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(626, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 34);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Location = new System.Drawing.Point(421, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 34);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(643, 207);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rating";
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(643, 258);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(156, 20);
            this.tbRating.TabIndex = 20;
            // 
            // MyLeagueForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1033, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMyLeague);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyLeagueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLeagueForm";
            this.Load += new System.EventHandler(this.MyLeagueForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyLeague)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbbRating;
        private System.Windows.Forms.Button btnRating;
        public System.Windows.Forms.DataGridView dgvMyLeague;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
    }
}