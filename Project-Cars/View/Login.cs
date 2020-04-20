using Project_Cars.Controller;
using Project_Cars.Data;
using Project_Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Cars.View
{
    public partial class Login : Form
    {
        private UserController userCt = new UserController(new ScoreContext());
        private ScoreContext scoreCt = new ScoreContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var register = new Register();
            this.Hide();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var CheckIfExists = scoreCt.users.FirstOrDefault(x => x.name == loginBox.Text);
            if(CheckIfExists.name==loginBox.Text)
            {
               
                this.Hide();
                var Form1 = new Form1();
                Form1.Show(); 
                Form1.label1.Text = loginBox.Text;
            }
        }
    }
}
