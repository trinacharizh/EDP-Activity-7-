namespace Events.Tri
{
    partial class Form1
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
            this.signuptext = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pwword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.forget = new System.Windows.Forms.LinkLabel();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signuptext
            // 
            this.signuptext.AutoSize = true;
            this.signuptext.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuptext.ForeColor = System.Drawing.Color.Silver;
            this.signuptext.Location = new System.Drawing.Point(218, 20);
            this.signuptext.Name = "signuptext";
            this.signuptext.Size = new System.Drawing.Size(132, 37);
            this.signuptext.TabIndex = 15;
            this.signuptext.Text = "SIGN UP ";
            this.signuptext.Click += new System.EventHandler(this.signuptext_Click);
            // 
            // usrname
            // 
            this.usrname.Location = new System.Drawing.Point(111, 184);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(371, 20);
            this.usrname.TabIndex = 16;
            this.usrname.TextChanged += new System.EventHandler(this.usrname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(112, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwword
            // 
            this.pwword.Location = new System.Drawing.Point(111, 254);
            this.pwword.Name = "pwword";
            this.pwword.Size = new System.Drawing.Size(371, 20);
            this.pwword.TabIndex = 18;
            this.pwword.TextChanged += new System.EventHandler(this.pwword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(112, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(112, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(111, 117);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(165, 20);
            this.firstname.TabIndex = 21;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(313, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(317, 117);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(165, 20);
            this.lastname.TabIndex = 23;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.forget.Location = new System.Drawing.Point(222, 427);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(164, 13);
            this.forget.TabIndex = 25;
            this.forget.TabStop = true;
            this.forget.Text = "Already have an account? Login ";
            this.forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_LinkClicked);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(111, 322);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(371, 20);
            this.email.TabIndex = 26;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(112, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(324, 373);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 28;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(616, 520);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.forget);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.signuptext);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signuptext;
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.LinkLabel forget;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button button1;
    }
}