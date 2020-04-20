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
    public partial class Register : Form
    {
        private ControlerScoreTable scoreTable = new ControlerScoreTable(new ScoreContext());
        private UserController userCt = new UserController(new ScoreContext());
        public Register()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var login = new Login();
            userCt.Add(registerBox.Text);
            scoreTable.Add(0, userCt.GetAll());
            MessageBox.Show("Register Succesfuly");
            this.Hide();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
