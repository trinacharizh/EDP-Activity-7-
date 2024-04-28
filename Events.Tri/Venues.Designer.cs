namespace Events.Tri
{
    partial class Venues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venues));
            this.loga = new System.Windows.Forms.Button();
            this.dbt = new System.Windows.Forms.Button();
            this.addven = new System.Windows.Forms.Button();
            this.cap = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.locloc = new System.Windows.Forms.Label();
            this.en = new System.Windows.Forms.Label();
            this.vname = new System.Windows.Forms.TextBox();
            this.bgindigo = new System.Windows.Forms.PictureBox();
            this.Tlist = new System.Windows.Forms.DataGridView();
            this.aesearch = new System.Windows.Forms.Button();
            this.esearch = new System.Windows.Forms.TextBox();
            this.eve = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bgindigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loga
            // 
            this.loga.BackColor = System.Drawing.Color.Purple;
            this.loga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loga.ForeColor = System.Drawing.Color.Silver;
            this.loga.Location = new System.Drawing.Point(158, 442);
            this.loga.Name = "loga";
            this.loga.Size = new System.Drawing.Size(75, 23);
            this.loga.TabIndex = 147;
            this.loga.Text = "Logout ";
            this.loga.UseVisualStyleBackColor = false;
            this.loga.Click += new System.EventHandler(this.loga_Click);
            // 
            // dbt
            // 
            this.dbt.BackColor = System.Drawing.Color.White;
            this.dbt.ForeColor = System.Drawing.Color.Black;
            this.dbt.Location = new System.Drawing.Point(15, 442);
            this.dbt.Name = "dbt";
            this.dbt.Size = new System.Drawing.Size(75, 23);
            this.dbt.TabIndex = 146;
            this.dbt.Text = "Dashboard";
            this.dbt.UseVisualStyleBackColor = false;
            this.dbt.Click += new System.EventHandler(this.dbt_Click);
            // 
            // addven
            // 
            this.addven.BackColor = System.Drawing.Color.White;
            this.addven.ForeColor = System.Drawing.Color.Black;
            this.addven.Location = new System.Drawing.Point(712, 465);
            this.addven.Name = "addven";
            this.addven.Size = new System.Drawing.Size(147, 23);
            this.addven.TabIndex = 145;
            this.addven.Text = "Add Venue";
            this.addven.UseVisualStyleBackColor = false;
            this.addven.Click += new System.EventHandler(this.addven_Click);
            // 
            // cap
            // 
            this.cap.AutoSize = true;
            this.cap.BackColor = System.Drawing.Color.Indigo;
            this.cap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap.ForeColor = System.Drawing.Color.Silver;
            this.cap.Location = new System.Drawing.Point(318, 426);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(76, 21);
            this.cap.TabIndex = 142;
            this.cap.Text = "Capacity ";
            this.cap.Click += new System.EventHandler(this.cap_Click);
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(393, 429);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(177, 20);
            this.capacity.TabIndex = 141;
            this.capacity.TextChanged += new System.EventHandler(this.capacity_TextChanged);
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(393, 467);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(292, 20);
            this.loc.TabIndex = 139;
            this.loc.TextChanged += new System.EventHandler(this.loc_TextChanged);
            // 
            // locloc
            // 
            this.locloc.AutoSize = true;
            this.locloc.BackColor = System.Drawing.Color.Indigo;
            this.locloc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locloc.ForeColor = System.Drawing.Color.Silver;
            this.locloc.Location = new System.Drawing.Point(316, 466);
            this.locloc.Name = "locloc";
            this.locloc.Size = new System.Drawing.Size(77, 21);
            this.locloc.TabIndex = 138;
            this.locloc.Text = "Location ";
            this.locloc.Click += new System.EventHandler(this.locloc_Click);
            // 
            // en
            // 
            this.en.AutoSize = true;
            this.en.BackColor = System.Drawing.Color.Indigo;
            this.en.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.en.ForeColor = System.Drawing.Color.Silver;
            this.en.Location = new System.Drawing.Point(290, 388);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(102, 21);
            this.en.TabIndex = 137;
            this.en.Text = "Venue Name";
            this.en.Click += new System.EventHandler(this.en_Click);
            // 
            // vname
            // 
            this.vname.Location = new System.Drawing.Point(393, 391);
            this.vname.Name = "vname";
            this.vname.Size = new System.Drawing.Size(355, 20);
            this.vname.TabIndex = 136;
            this.vname.TextChanged += new System.EventHandler(this.vname_TextChanged);
            // 
            // bgindigo
            // 
            this.bgindigo.BackColor = System.Drawing.Color.Indigo;
            this.bgindigo.Location = new System.Drawing.Point(266, 370);
            this.bgindigo.Name = "bgindigo";
            this.bgindigo.Size = new System.Drawing.Size(752, 156);
            this.bgindigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bgindigo.TabIndex = 135;
            this.bgindigo.TabStop = false;
            this.bgindigo.Click += new System.EventHandler(this.bgindigo_Click);
            // 
            // Tlist
            // 
            this.Tlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tlist.Location = new System.Drawing.Point(294, 130);
            this.Tlist.Name = "Tlist";
            this.Tlist.Size = new System.Drawing.Size(710, 226);
            this.Tlist.TabIndex = 134;
            this.Tlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tlist_CellContentClick);
            // 
            // aesearch
            // 
            this.aesearch.BackColor = System.Drawing.Color.Purple;
            this.aesearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aesearch.ForeColor = System.Drawing.Color.Silver;
            this.aesearch.Location = new System.Drawing.Point(712, 97);
            this.aesearch.Name = "aesearch";
            this.aesearch.Size = new System.Drawing.Size(75, 23);
            this.aesearch.TabIndex = 133;
            this.aesearch.Text = "Search";
            this.aesearch.UseVisualStyleBackColor = false;
            this.aesearch.Click += new System.EventHandler(this.aesearch_Click);
            // 
            // esearch
            // 
            this.esearch.Location = new System.Drawing.Point(432, 98);
            this.esearch.Name = "esearch";
            this.esearch.Size = new System.Drawing.Size(253, 20);
            this.esearch.TabIndex = 132;
            this.esearch.TextChanged += new System.EventHandler(this.esearch_TextChanged);
            // 
            // eve
            // 
            this.eve.AutoSize = true;
            this.eve.BackColor = System.Drawing.Color.Plum;
            this.eve.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eve.ForeColor = System.Drawing.Color.Black;
            this.eve.Location = new System.Drawing.Point(570, 22);
            this.eve.Name = "eve";
            this.eve.Size = new System.Drawing.Size(125, 36);
            this.eve.TabIndex = 131;
            this.eve.Text = "Venues ";
            this.eve.Click += new System.EventHandler(this.eve_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Plum;
            this.pictureBox10.Location = new System.Drawing.Point(265, -4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(753, 91);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 130;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 199);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 129;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 533);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Venues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 498);
            this.Controls.Add(this.loga);
            this.Controls.Add(this.dbt);
            this.Controls.Add(this.addven);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.locloc);
            this.Controls.Add(this.en);
            this.Controls.Add(this.vname);
            this.Controls.Add(this.bgindigo);
            this.Controls.Add(this.Tlist);
            this.Controls.Add(this.aesearch);
            this.Controls.Add(this.esearch);
            this.Controls.Add(this.eve);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Venues";
            this.Text = "Venues";
            this.Load += new System.EventHandler(this.Venues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgindigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loga;
        private System.Windows.Forms.Button dbt;
        private System.Windows.Forms.Button addven;
        private System.Windows.Forms.Label cap;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.Label locloc;
        private System.Windows.Forms.Label en;
        private System.Windows.Forms.TextBox vname;
        private System.Windows.Forms.PictureBox bgindigo;
        private System.Windows.Forms.DataGridView Tlist;
        private System.Windows.Forms.Button aesearch;
        private System.Windows.Forms.TextBox esearch;
        private System.Windows.Forms.Label eve;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}