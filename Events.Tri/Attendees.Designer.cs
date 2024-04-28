namespace Events.Tri
{
    partial class Attendees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendees));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dba = new System.Windows.Forms.Button();
            this.loga = new System.Windows.Forms.Button();
            this.attend = new System.Windows.Forms.Label();
            this.Alist = new System.Windows.Forms.DataGridView();
            this.asearch = new System.Windows.Forms.TextBox();
            this.absearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.regd = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.eml = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.regdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 533);
            this.dataGridView1.TabIndex = 97;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Plum;
            this.pictureBox10.Location = new System.Drawing.Point(262, -3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(745, 91);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 98;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 199);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dba
            // 
            this.dba.BackColor = System.Drawing.Color.White;
            this.dba.ForeColor = System.Drawing.Color.Black;
            this.dba.Location = new System.Drawing.Point(12, 442);
            this.dba.Name = "dba";
            this.dba.Size = new System.Drawing.Size(75, 23);
            this.dba.TabIndex = 105;
            this.dba.Text = "Dashboard";
            this.dba.UseVisualStyleBackColor = false;
            this.dba.Click += new System.EventHandler(this.dba_Click);
            // 
            // loga
            // 
            this.loga.BackColor = System.Drawing.Color.Purple;
            this.loga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loga.ForeColor = System.Drawing.Color.Silver;
            this.loga.Location = new System.Drawing.Point(160, 442);
            this.loga.Name = "loga";
            this.loga.Size = new System.Drawing.Size(75, 23);
            this.loga.TabIndex = 106;
            this.loga.Text = "Logout ";
            this.loga.UseVisualStyleBackColor = false;
            this.loga.Click += new System.EventHandler(this.loga_Click);
            // 
            // attend
            // 
            this.attend.AutoSize = true;
            this.attend.BackColor = System.Drawing.Color.Plum;
            this.attend.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attend.ForeColor = System.Drawing.Color.Black;
            this.attend.Location = new System.Drawing.Point(538, 24);
            this.attend.Name = "attend";
            this.attend.Size = new System.Drawing.Size(160, 36);
            this.attend.TabIndex = 107;
            this.attend.Text = "Attendees ";
            this.attend.Click += new System.EventHandler(this.attend_Click);
            // 
            // Alist
            // 
            this.Alist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alist.Location = new System.Drawing.Point(272, 127);
            this.Alist.Name = "Alist";
            this.Alist.Size = new System.Drawing.Size(710, 226);
            this.Alist.TabIndex = 108;
            this.Alist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateAcc_CellContentClick);
            // 
            // asearch
            // 
            this.asearch.Location = new System.Drawing.Point(410, 101);
            this.asearch.Name = "asearch";
            this.asearch.Size = new System.Drawing.Size(253, 20);
            this.asearch.TabIndex = 109;
            this.asearch.TextChanged += new System.EventHandler(this.asearch_TextChanged);
            // 
            // absearch
            // 
            this.absearch.BackColor = System.Drawing.Color.Purple;
            this.absearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.absearch.ForeColor = System.Drawing.Color.Silver;
            this.absearch.Location = new System.Drawing.Point(694, 98);
            this.absearch.Name = "absearch";
            this.absearch.Size = new System.Drawing.Size(75, 23);
            this.absearch.TabIndex = 110;
            this.absearch.Text = "Search";
            this.absearch.UseVisualStyleBackColor = false;
            this.absearch.Click += new System.EventHandler(this.absearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox1.Location = new System.Drawing.Point(262, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(378, 375);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(195, 20);
            this.fname.TabIndex = 112;
            this.fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.BackColor = System.Drawing.Color.Indigo;
            this.fn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.ForeColor = System.Drawing.Color.Silver;
            this.fn.Location = new System.Drawing.Point(283, 375);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(88, 21);
            this.fn.TabIndex = 113;
            this.fn.Text = "First Name";
            this.fn.Click += new System.EventHandler(this.fn_Click);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(378, 417);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(195, 20);
            this.lname.TabIndex = 114;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.BackColor = System.Drawing.Color.Indigo;
            this.ln.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.ForeColor = System.Drawing.Color.Silver;
            this.ln.Location = new System.Drawing.Point(286, 417);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(86, 21);
            this.ln.TabIndex = 115;
            this.ln.Text = "Last Name";
            // 
            // eid
            // 
            this.eid.Location = new System.Drawing.Point(378, 459);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(195, 20);
            this.eid.TabIndex = 116;
            this.eid.TextChanged += new System.EventHandler(this.eid_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Indigo;
            this.id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Silver;
            this.id.Location = new System.Drawing.Point(283, 458);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(70, 21);
            this.id.TabIndex = 117;
            this.id.Text = "Event ID";
            // 
            // regd
            // 
            this.regd.AutoSize = true;
            this.regd.BackColor = System.Drawing.Color.Indigo;
            this.regd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regd.ForeColor = System.Drawing.Color.Silver;
            this.regd.Location = new System.Drawing.Point(660, 372);
            this.regd.Name = "regd";
            this.regd.Size = new System.Drawing.Size(141, 21);
            this.regd.TabIndex = 118;
            this.regd.Text = "Registration Date ";
            this.regd.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(714, 417);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(251, 20);
            this.email.TabIndex = 120;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // eml
            // 
            this.eml.AutoSize = true;
            this.eml.BackColor = System.Drawing.Color.Indigo;
            this.eml.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eml.ForeColor = System.Drawing.Color.Silver;
            this.eml.Location = new System.Drawing.Point(660, 417);
            this.eml.Name = "eml";
            this.eml.Size = new System.Drawing.Size(48, 21);
            this.eml.TabIndex = 121;
            this.eml.Text = "Email";
            this.eml.Click += new System.EventHandler(this.eml_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.White;
            this.Register.ForeColor = System.Drawing.Color.Black;
            this.Register.Location = new System.Drawing.Point(748, 459);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(171, 23);
            this.Register.TabIndex = 122;
            this.Register.Text = "Register Attendee";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // regdate
            // 
            this.regdate.Location = new System.Drawing.Point(807, 375);
            this.regdate.Name = "regdate";
            this.regdate.Size = new System.Drawing.Size(184, 20);
            this.regdate.TabIndex = 123;
            // 
            // Attendees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 514);
            this.Controls.Add(this.regdate);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.eml);
            this.Controls.Add(this.email);
            this.Controls.Add(this.regd);
            this.Controls.Add(this.id);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.absearch);
            this.Controls.Add(this.asearch);
            this.Controls.Add(this.Alist);
            this.Controls.Add(this.attend);
            this.Controls.Add(this.loga);
            this.Controls.Add(this.dba);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Attendees";
            this.Text = "Attendees";
            this.Load += new System.EventHandler(this.Attendees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button dba;
        private System.Windows.Forms.Button loga;
        private System.Windows.Forms.Label attend;
        private System.Windows.Forms.DataGridView Alist;
        private System.Windows.Forms.TextBox asearch;
        private System.Windows.Forms.Button absearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label regd;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label eml;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.DateTimePicker regdate;
    }
}