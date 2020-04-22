using Project_Cars.Controller;
using Project_Cars.Data;
using Project_Cars.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Cars
{
    public partial class Form2 : Form
    {
        ControlerScoreTable Controler = new ControlerScoreTable(new ScoreContext());
        ScoreContext scoreCn = new ScoreContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var top3 = scoreCn.rankingscore.OrderByDescending(x => x.score).ToList();
            first.Text = top3[0].score.ToString();
            second.Text = top3[1].score.ToString();
            third.Text = top3[2].score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }

        
    }
}
