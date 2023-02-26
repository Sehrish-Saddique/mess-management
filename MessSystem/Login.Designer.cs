namespace MessSystem
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.Email = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.LinkLabel();
            this.Password = new System.Windows.Forms.Label();
            this.inputemail = new System.Windows.Forms.TextBox();
            this.inputpassword = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleapp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(283, 120);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Login.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.LinkVisited = true;
            this.Login.Location = new System.Drawing.Point(411, 372);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(48, 20);
            this.Login.TabIndex = 2;
            this.Login.TabStop = true;
            this.Login.Text = "Login";
            this.Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(283, 190);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputemail
            // 
            this.inputemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputemail.Location = new System.Drawing.Point(209, 143);
            this.inputemail.Name = "inputemail";
            this.inputemail.Size = new System.Drawing.Size(199, 26);
            this.inputemail.TabIndex = 4;
            this.inputemail.TextChanged += new System.EventHandler(this.inputemail_TextChanged);
            // 
            // inputpassword
            // 
            this.inputpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputpassword.Location = new System.Drawing.Point(209, 213);
            this.inputpassword.Name = "inputpassword";
            this.inputpassword.Size = new System.Drawing.Size(199, 26);
            this.inputpassword.TabIndex = 5;
            this.inputpassword.TextChanged += new System.EventHandler(this.inputpassword_TextChanged);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Register.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Register.LinkVisited = true;
            this.Register.Location = new System.Drawing.Point(485, 372);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(69, 20);
            this.Register.TabIndex = 6;
            this.Register.TabStop = true;
            this.Register.Text = "Register";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "/";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(258, 256);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(92, 36);
            this.Loginbtn.TabIndex = 8;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(242, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // titleapp
            // 
            this.titleapp.AutoSize = true;
            this.titleapp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleapp.Font = new System.Drawing.Font("Tasty Burger", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleapp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.titleapp.Location = new System.Drawing.Point(140, 32);
            this.titleapp.Name = "titleapp";
            this.titleapp.Size = new System.Drawing.Size(319, 28);
            this.titleapp.TabIndex = 11;
            this.titleapp.Text = "Mess Management System";
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 415);
            this.Controls.Add(this.titleapp);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.inputpassword);
            this.Controls.Add(this.inputemail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loginform";
            this.Text = "Mess";
            this.Load += new System.EventHandler(this.Loginform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.LinkLabel Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox inputemail;
        private System.Windows.Forms.TextBox inputpassword;
        private System.Windows.Forms.LinkLabel Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label titleapp;
    }
}

