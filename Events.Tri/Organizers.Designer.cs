namespace Events.Tri
{
    partial class Organizers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizers));
            this.loga = new System.Windows.Forms.Button();
            this.dbt = new System.Windows.Forms.Button();
            this.orgreg = new System.Windows.Forms.Button();
            this.cap = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.locloc = new System.Windows.Forms.Label();
            this.en = new System.Windows.Forms.Label();
            this.bgindigo = new System.Windows.Forms.PictureBox();
            this.Olist = new System.Windows.Forms.DataGridView();
            this.aesearch = new System.Windows.Forms.Button();
            this.esearch = new System.Windows.Forms.TextBox();
            this.org = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bgindigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Olist)).BeginInit();
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
            this.loga.Location = new System.Drawing.Point(154, 442);
            this.loga.Name = "loga";
            this.loga.Size = new System.Drawing.Size(75, 23);
            this.loga.TabIndex = 164;
            this.loga.Text = "Logout ";
            this.loga.UseVisualStyleBackColor = false;
            // 
            // dbt
            // 
            this.dbt.BackColor = System.Drawing.Color.White;
            this.dbt.ForeColor = System.Drawing.Color.Black;
            this.dbt.Location = new System.Drawing.Point(11, 442);
            this.dbt.Name = "dbt";
            this.dbt.Size = new System.Drawing.Size(75, 23);
            this.dbt.TabIndex = 163;
            this.dbt.Text = "Dashboard";
            this.dbt.UseVisualStyleBackColor = false;
            this.dbt.Click += new System.EventHandler(this.dbt_Click);
            // 
            // orgreg
            // 
            this.orgreg.BackColor = System.Drawing.Color.White;
            this.orgreg.ForeColor = System.Drawing.Color.Black;
            this.orgreg.Location = new System.Drawing.Point(746, 464);
            this.orgreg.Name = "orgreg";
            this.orgreg.Size = new System.Drawing.Size(147, 23);
            this.orgreg.TabIndex = 162;
            this.orgreg.Text = "Register Organizer";
            this.orgreg.UseVisualStyleBackColor = false;
            this.orgreg.Click += new System.EventHandler(this.orgreg_Click);
            // 
            // cap
            // 
            this.cap.AutoSize = true;
            this.cap.BackColor = System.Drawing.Color.Indigo;
            this.cap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap.ForeColor = System.Drawing.Color.Silver;
            this.cap.Location = new System.Drawing.Point(338, 429);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(52, 21);
            this.cap.TabIndex = 161;
            this.cap.Text = "Email ";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(420, 429);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(177, 20);
            this.email.TabIndex = 160;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(420, 467);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(292, 20);
            this.phone.TabIndex = 159;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // locloc
            // 
            this.locloc.AutoSize = true;
            this.locloc.BackColor = System.Drawing.Color.Indigo;
            this.locloc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locloc.ForeColor = System.Drawing.Color.Silver;
            this.locloc.Location = new System.Drawing.Point(294, 463);
            this.locloc.Name = "locloc";
            this.locloc.Size = new System.Drawing.Size(120, 21);
            this.locloc.TabIndex = 158;
            this.locloc.Text = "Phone Number";
            // 
            // en
            // 
            this.en.AutoSize = true;
            this.en.BackColor = System.Drawing.Color.Indigo;
            this.en.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.en.ForeColor = System.Drawing.Color.Silver;
            this.en.Location = new System.Drawing.Point(286, 388);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(128, 21);
            this.en.TabIndex = 157;
            this.en.Text = "Organizer Name";
            this.en.Click += new System.EventHandler(this.en_Click);
            // 
            // bgindigo
            // 
            this.bgindigo.BackColor = System.Drawing.Color.Indigo;
            this.bgindigo.Location = new System.Drawing.Point(262, 370);
            this.bgindigo.Name = "bgindigo";
            this.bgindigo.Size = new System.Drawing.Size(752, 156);
            this.bgindigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bgindigo.TabIndex = 155;
            this.bgindigo.TabStop = false;
            // 
            // Olist
            // 
            this.Olist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Olist.Location = new System.Drawing.Point(279, 124);
            this.Olist.Name = "Olist";
            this.Olist.Size = new System.Drawing.Size(614, 226);
            this.Olist.TabIndex = 154;
            this.Olist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Olist_CellContentClick);
            // 
            // aesearch
            // 
            this.aesearch.BackColor = System.Drawing.Color.Purple;
            this.aesearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aesearch.ForeColor = System.Drawing.Color.Silver;
            this.aesearch.Location = new System.Drawing.Point(708, 97);
            this.aesearch.Name = "aesearch";
            this.aesearch.Size = new System.Drawing.Size(75, 23);
            this.aesearch.TabIndex = 153;
            this.aesearch.Text = "Search";
            this.aesearch.UseVisualStyleBackColor = false;
            // 
            // esearch
            // 
            this.esearch.Location = new System.Drawing.Point(428, 98);
            this.esearch.Name = "esearch";
            this.esearch.Size = new System.Drawing.Size(253, 20);
            this.esearch.TabIndex = 152;
            // 
            // org
            // 
            this.org.AutoSize = true;
            this.org.BackColor = System.Drawing.Color.Plum;
            this.org.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org.ForeColor = System.Drawing.Color.Black;
            this.org.Location = new System.Drawing.Point(483, 20);
            this.org.Name = "org";
            this.org.Size = new System.Drawing.Size(170, 36);
            this.org.TabIndex = 151;
            this.org.Text = "Organizers";
            this.org.Click += new System.EventHandler(this.eve_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Plum;
            this.pictureBox10.Location = new System.Drawing.Point(261, -4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(753, 91);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 150;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 199);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 149;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 533);
            this.dataGridView1.TabIndex = 148;
            // 
            // oname
            // 
            this.oname.Location = new System.Drawing.Point(420, 388);
            this.oname.Name = "oname";
            this.oname.Size = new System.Drawing.Size(292, 20);
            this.oname.TabIndex = 165;
            // 
            // Organizers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.oname);
            this.Controls.Add(this.loga);
            this.Controls.Add(this.dbt);
            this.Controls.Add(this.orgreg);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.locloc);
            this.Controls.Add(this.en);
            this.Controls.Add(this.bgindigo);
            this.Controls.Add(this.Olist);
            this.Controls.Add(this.aesearch);
            this.Controls.Add(this.esearch);
            this.Controls.Add(this.org);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Organizers";
            this.Text = "Organizers";
            this.Load += new System.EventHandler(this.Organizers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgindigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Olist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loga;
        private System.Windows.Forms.Button dbt;
        private System.Windows.Forms.Button orgreg;
        private System.Windows.Forms.Label cap;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label locloc;
        private System.Windows.Forms.Label en;
        private System.Windows.Forms.PictureBox bgindigo;
        private System.Windows.Forms.DataGridView Olist;
        private System.Windows.Forms.Button aesearch;
        private System.Windows.Forms.TextBox esearch;
        private System.Windows.Forms.Label org;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox oname;
    }
}