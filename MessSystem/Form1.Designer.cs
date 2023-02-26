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
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(96, 108);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Login.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.LinkVisited = true;
            this.Login.Location = new System.Drawing.Point(166, 281);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(68, 20);
            this.Login.TabIndex = 2;
            this.Login.TabStop = true;
            this.Login.Text = "Login    /";
            this.Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(96, 174);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputemail
            // 
            this.inputemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputemail.Location = new System.Drawing.Point(209, 105);
            this.inputemail.Name = "inputemail";
            this.inputemail.Size = new System.Drawing.Size(199, 26);
            this.inputemail.TabIndex = 4;
            this.inputemail.TextChanged += new System.EventHandler(this.inputemail_TextChanged);
            // 
            // inputpassword
            // 
            this.inputpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputpassword.Location = new System.Drawing.Point(209, 171);
            this.inputpassword.Name = "inputpassword";
            this.inputpassword.Size = new System.Drawing.Size(199, 26);
            this.inputpassword.TabIndex = 5;
            this.inputpassword.TextChanged += new System.EventHandler(this.inputpassword_TextChanged);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Register.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Register.LinkVisited = true;
            this.Register.Location = new System.Drawing.Point(240, 281);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(69, 20);
            this.Register.TabIndex = 6;
            this.Register.TabStop = true;
            this.Register.Text = "Register";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.inputpassword);
            this.Controls.Add(this.inputemail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loginform";
            this.Text = "Mess";
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
    }
}

