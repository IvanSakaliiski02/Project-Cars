using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Cars
{
    public partial class Form1 : Form
    {
         Random random = new Random();
         int x;
         int collectedFuel = 0;
         int gameSpeed = 0;

        public Form1()
        {
            InitializeComponent();
            gameOver_txt.Visible = false;
            restartButton.Visible = false;
            scoreButton.Visible = false;
        }
        private void track_line(int speed) 
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gameSpeed);
            enemy(gameSpeed);
            gameOver();
            fuel(gameSpeed);
            CollectedFuel();
        }
        void fuel(int speed)
        {
            if (fuel_1.Top >= 609)
            {
                x = random.Next(0, 200);
                fuel_1.Location = new Point(x, 0);
            }
            else { fuel_1.Top += speed; }

            if (fuel_2.Top >= 609)
            {
                x = random.Next(250, 400);
                fuel_2.Location = new Point(x, 0);
            }
            else { fuel_2.Top += speed; }

            if (fuel_3.Top >= 609)
            {
                x = random.Next(300, 600);
                fuel_3.Location = new Point(x, 0);
            }
            else { fuel_3.Top += speed; }        
        }    
       
        void enemy(int speed)
        {
            if (enemy_3.Top >= 609)
            {
                x = random.Next(0, 200);             
                enemy_3.Location = new Point(x, 0);
            }
            else { enemy_3.Top += speed; }

            if (enemy_2.Top >= 609)
            {
                x = random.Next(250, 400);              
                enemy_2.Location = new Point(x, 0);
            }
             else { enemy_2.Top += speed; }

            if (enemy_1.Top >= 609)
            {
                x = random.Next(300, 600);              
                enemy_1.Location = new Point(x, 0);
            }
            else { enemy_1.Top += speed; }
        }

        void moveline(int speed)
        {
            if (track_1.Top >= 609)
            {
                track_1.Top = 0;
            }
            else { track_1.Top += speed; }

            if (track_2.Top >= 609)
            {
                track_2.Top = 0;
            }
            else { track_2.Top += speed; }

            if (track_3.Top >= 609)
            {
                track_3.Top = 0;
            }
            else { track_3.Top += speed; }
            
            if (track_4.Top >= 609)
            {
                track_4.Top = 0;
            }
            else { track_4.Top += speed; }

            if (track_5.Top >= 609)
            {
                track_5.Top = 0;
            }
            else { track_5.Top += speed; }

            if (track_6.Top >= 609)
            {
                track_6.Top = 0;
            }
            else { track_6.Top += speed; }

            if (track_7.Top >= 609)
            {
                track_7.Top = 0;
            }
            else { track_7.Top += speed; }

            if (track_8.Top >= 609)
            {
                track_8.Top = 0;
            }
            else { track_8.Top += speed; }

            if (track_9.Top >= 609)
            {
                track_9.Top = 0;
            }
            else { track_9.Top += speed; }
        }
        void CollectedFuel()
        {
            if (player.Bounds.IntersectsWith(fuel_1.Bounds))
            {
                collectedFuel++;
                score_txt.Text = "Score=" + collectedFuel.ToString();
                                
                    x = random.Next(300, 600);
                    fuel_1.Location = new Point(x, 0);
               
            }
            if (player.Bounds.IntersectsWith(fuel_2.Bounds))
            {
                collectedFuel++;
                score_txt.Text = "Score=" + collectedFuel.ToString();
                             
                    x = random.Next(300, 600);
                    fuel_2.Location = new Point(x, 0);           
            }
            if (player.Bounds.IntersectsWith(fuel_3.Bounds))
            {
                collectedFuel++;
                score_txt.Text = "Score=" + collectedFuel.ToString();

                    x = random.Next(300, 600);
                    fuel_3.Location = new Point(x, 0);
            }
        }
        
        //Player Car Controll
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {         
            if(e.KeyCode==Keys.Left)
            {
                if (player.Left >0)            
                player.Left += -gameSpeed;
            }

            if (e.KeyCode == Keys.Right)
            {
                if(player.Right<634)
                player.Left += gameSpeed;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21) 
                {
                    gameSpeed++; 
                }
            }
            if (e.KeyCode == Keys.Down) 
            { 
                if (gameSpeed > 0) 
                { 
                    gameSpeed--; 
                }
            }                   
        }
        void gameOver() 
        {
            if (player.Bounds.IntersectsWith(enemy_2.Bounds)) 
            {
                timer1.Enabled = false;
                gameOver_txt.Visible = true;
                restartButton.Visible = true;
                scoreButton.Visible = true;
            }
            if (player.Bounds.IntersectsWith(enemy_1.Bounds))
            {
                timer1.Enabled = false;
                gameOver_txt.Visible = true;
                restartButton.Visible = true;
                scoreButton.Visible = true;
            }
            if (player.Bounds.IntersectsWith(enemy_3.Bounds))
            {
                timer1.Enabled = false;
                gameOver_txt.Visible = true;
                restartButton.Visible = true;
                scoreButton.Visible = true;
            }
        }
        private void gameOver_txt_Click(object sender, EventArgs e)
        {

        }
        private void scoreButton_Click(object sender, EventArgs e)
        {
            
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            gameOver_txt.Visible = false;
            restartButton.Visible = false;
            scoreButton.Visible = false;

            collectedFuel = 0;

            player.Location = new Point(185,402);

            enemy_3.Location = new Point(34,86);
            enemy_2.Location = new Point(342,39);
            enemy_1.Location = new Point(514,271);
         
            enemy(gameSpeed);           
            fuel(gameSpeed);
            CollectedFuel();
        }      
    }

}
