using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessSystem
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

         

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();  
        }

        private void inputemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Loginform loginfrm = new Loginform();
            loginfrm.ShowDialog();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();   
            //form.ShowDialog();

        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
