using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystem
{
    public partial class LoginFrame : Form
    {
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            foreach(var user in User.users){
                if(user != null)
                {
                    if(user.username == usernameText.Text && user.Password == passwordText.Text)
                    {
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Login Error","Error");
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupFrame signupFrame = new SignupFrame();
            signupFrame.ShowDialog();
        }
    }
}
