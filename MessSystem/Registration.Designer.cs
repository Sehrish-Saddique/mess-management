namespace MessSystem
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
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Loginlbl = new System.Windows.Forms.LinkLabel();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.inputemail = new System.Windows.Forms.TextBox();
            this.inputpassword = new System.Windows.Forms.TextBox();
            this.Registerlbl = new System.Windows.Forms.LinkLabel();
            this.ConfirmPasswordlbl = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.Regidlbl = new System.Windows.Forms.Label();
            this.txtregid = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Roomnolbl = new System.Windows.Forms.Label();
            this.txtroomno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Registrationbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(80, 199);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(48, 20);
            this.Emaillbl.TabIndex = 7;
            this.Emaillbl.Text = "Email";
            this.Emaillbl.Click += new System.EventHandler(this.Email_Click);
            // 
            // Loginlbl
            // 
            this.Loginlbl.AutoSize = true;
            this.Loginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Loginlbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loginlbl.LinkVisited = true;
            this.Loginlbl.Location = new System.Drawing.Point(183, 419);
            this.Loginlbl.Name = "Loginlbl";
            this.Loginlbl.Size = new System.Drawing.Size(48, 20);
            this.Loginlbl.TabIndex = 8;
            this.Loginlbl.TabStop = true;
            this.Loginlbl.Text = "Login";
            this.Loginlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(80, 262);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(78, 20);
            this.Passwordlbl.TabIndex = 9;
            this.Passwordlbl.Text = "Password";
            this.Passwordlbl.Click += new System.EventHandler(this.Password_Click);
            // 
            // inputemail
            // 
            this.inputemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputemail.Location = new System.Drawing.Point(248, 190);
            this.inputemail.Name = "inputemail";
            this.inputemail.Size = new System.Drawing.Size(199, 26);
            this.inputemail.TabIndex = 10;
            this.inputemail.TextChanged += new System.EventHandler(this.inputemail_TextChanged);
            // 
            // inputpassword
            // 
            this.inputpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputpassword.Location = new System.Drawing.Point(248, 256);
            this.inputpassword.Name = "inputpassword";
            this.inputpassword.Size = new System.Drawing.Size(199, 26);
            this.inputpassword.TabIndex = 11;
            this.inputpassword.TextChanged += new System.EventHandler(this.inputpassword_TextChanged);
            // 
            // Registerlbl
            // 
            this.Registerlbl.AutoSize = true;
            this.Registerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerlbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Registerlbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Registerlbl.LinkVisited = true;
            this.Registerlbl.Location = new System.Drawing.Point(257, 419);
            this.Registerlbl.Name = "Registerlbl";
            this.Registerlbl.Size = new System.Drawing.Size(69, 20);
            this.Registerlbl.TabIndex = 12;
            this.Registerlbl.TabStop = true;
            this.Registerlbl.Text = "Register";
            this.Registerlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // ConfirmPasswordlbl
            // 
            this.ConfirmPasswordlbl.AutoSize = true;
            this.ConfirmPasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordlbl.Location = new System.Drawing.Point(80, 318);
            this.ConfirmPasswordlbl.Name = "ConfirmPasswordlbl";
            this.ConfirmPasswordlbl.Size = new System.Drawing.Size(137, 20);
            this.ConfirmPasswordlbl.TabIndex = 13;
            this.ConfirmPasswordlbl.Text = "Confirm Password";
            this.ConfirmPasswordlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(248, 312);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(199, 26);
            this.txtconfirmpassword.TabIndex = 14;
            this.txtconfirmpassword.TextChanged += new System.EventHandler(this.txtconfirmpassword_TextChanged);
            // 
            // Regidlbl
            // 
            this.Regidlbl.AutoSize = true;
            this.Regidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regidlbl.Location = new System.Drawing.Point(80, 88);
            this.Regidlbl.Name = "Regidlbl";
            this.Regidlbl.Size = new System.Drawing.Size(116, 20);
            this.Regidlbl.TabIndex = 15;
            this.Regidlbl.Text = "Registration ID";
            this.Regidlbl.Click += new System.EventHandler(this.Regid_Click);
            // 
            // txtregid
            // 
            this.txtregid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregid.Location = new System.Drawing.Point(248, 85);
            this.txtregid.Name = "txtregid";
            this.txtregid.Size = new System.Drawing.Size(199, 26);
            this.txtregid.TabIndex = 16;
            this.txtregid.TextChanged += new System.EventHandler(this.txtregid_TextChanged);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(80, 29);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(51, 20);
            this.Namelbl.TabIndex = 17;
            this.Namelbl.Text = "Name";
            this.Namelbl.Click += new System.EventHandler(this.Name_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(248, 26);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(199, 26);
            this.txtname.TabIndex = 18;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // Roomnolbl
            // 
            this.Roomnolbl.AutoSize = true;
            this.Roomnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomnolbl.Location = new System.Drawing.Point(80, 143);
            this.Roomnolbl.Name = "Roomnolbl";
            this.Roomnolbl.Size = new System.Drawing.Size(78, 20);
            this.Roomnolbl.TabIndex = 19;
            this.Roomnolbl.Text = "Room no.";
            this.Roomnolbl.Click += new System.EventHandler(this.Roomno_Click);
            // 
            // txtroomno
            // 
            this.txtroomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomno.Location = new System.Drawing.Point(248, 140);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.Size = new System.Drawing.Size(199, 26);
            this.txtroomno.TabIndex = 20;
            this.txtroomno.TextChanged += new System.EventHandler(this.txtroomno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "/";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Registrationbtn
            // 
            this.Registrationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrationbtn.Location = new System.Drawing.Point(197, 367);
            this.Registrationbtn.Name = "Registrationbtn";
            this.Registrationbtn.Size = new System.Drawing.Size(116, 36);
            this.Registrationbtn.TabIndex = 22;
            this.Registrationbtn.Text = "Registration";
            this.Registrationbtn.UseVisualStyleBackColor = true;
            this.Registrationbtn.Click += new System.EventHandler(this.Registrationbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(506, 511);
            this.Controls.Add(this.Registrationbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registerlbl);
            this.Controls.Add(this.Loginlbl);
            this.Controls.Add(this.txtroomno);
            this.Controls.Add(this.Roomnolbl);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.txtregid);
            this.Controls.Add(this.Regidlbl);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.ConfirmPasswordlbl);
            this.Controls.Add(this.inputpassword);
            this.Controls.Add(this.inputemail);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.LinkLabel Loginlbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox inputemail;
        private System.Windows.Forms.TextBox inputpassword;
        private System.Windows.Forms.LinkLabel Registerlbl;
        private System.Windows.Forms.Label ConfirmPasswordlbl;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label Regidlbl;
        private System.Windows.Forms.TextBox txtregid;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label Roomnolbl;
        private System.Windows.Forms.TextBox txtroomno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Registrationbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}