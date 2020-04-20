namespace Project_Cars
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.track_3 = new System.Windows.Forms.PictureBox();
            this.track_2 = new System.Windows.Forms.PictureBox();
            this.track_1 = new System.Windows.Forms.PictureBox();
            this.score_txt = new System.Windows.Forms.Label();
            this.gameOver_txt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.track_4 = new System.Windows.Forms.PictureBox();
            this.track_5 = new System.Windows.Forms.PictureBox();
            this.track_6 = new System.Windows.Forms.PictureBox();
            this.track_7 = new System.Windows.Forms.PictureBox();
            this.track_8 = new System.Windows.Forms.PictureBox();
            this.track_9 = new System.Windows.Forms.PictureBox();
            this.fuel_1 = new System.Windows.Forms.PictureBox();
            this.fuel_3 = new System.Windows.Forms.PictureBox();
            this.fuel_2 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(185, 402);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(69, 133);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.Image = ((System.Drawing.Image)(resources.GetObject("enemy_2.Image")));
            this.enemy_2.Location = new System.Drawing.Point(342, 39);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(69, 118);
            this.enemy_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_2.TabIndex = 2;
            this.enemy_2.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.Image = ((System.Drawing.Image)(resources.GetObject("enemy_1.Image")));
            this.enemy_1.Location = new System.Drawing.Point(514, 271);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(69, 118);
            this.enemy_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_1.TabIndex = 2;
            this.enemy_1.TabStop = false;
            // 
            // track_3
            // 
            this.track_3.BackColor = System.Drawing.Color.White;
            this.track_3.Location = new System.Drawing.Point(296, 402);
            this.track_3.Name = "track_3";
            this.track_3.Size = new System.Drawing.Size(30, 115);
            this.track_3.TabIndex = 1;
            this.track_3.TabStop = false;
            // 
            // track_2
            // 
            this.track_2.BackColor = System.Drawing.Color.White;
            this.track_2.Location = new System.Drawing.Point(296, 205);
            this.track_2.Name = "track_2";
            this.track_2.Size = new System.Drawing.Size(30, 107);
            this.track_2.TabIndex = 1;
            this.track_2.TabStop = false;
            // 
            // track_1
            // 
            this.track_1.BackColor = System.Drawing.Color.White;
            this.track_1.Location = new System.Drawing.Point(296, -3);
            this.track_1.Name = "track_1";
            this.track_1.Size = new System.Drawing.Size(30, 107);
            this.track_1.TabIndex = 1;
            this.track_1.TabStop = false;
            // 
            // score_txt
            // 
            this.score_txt.AutoSize = true;
            this.score_txt.BackColor = System.Drawing.Color.Gray;
            this.score_txt.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt.ForeColor = System.Drawing.Color.Red;
            this.score_txt.Location = new System.Drawing.Point(11, 12);
            this.score_txt.Name = "score_txt";
            this.score_txt.Size = new System.Drawing.Size(96, 29);
            this.score_txt.TabIndex = 4;
            this.score_txt.Text = "Score=0";
            // 
            // gameOver_txt
            // 
            this.gameOver_txt.AutoSize = true;
            this.gameOver_txt.BackColor = System.Drawing.Color.Yellow;
            this.gameOver_txt.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver_txt.ForeColor = System.Drawing.Color.Red;
            this.gameOver_txt.Location = new System.Drawing.Point(193, 50);
            this.gameOver_txt.MaximumSize = new System.Drawing.Size(300, 250);
            this.gameOver_txt.MinimumSize = new System.Drawing.Size(200, 50);
            this.gameOver_txt.Name = "gameOver_txt";
            this.gameOver_txt.Size = new System.Drawing.Size(230, 130);
            this.gameOver_txt.TabIndex = 5;
            this.gameOver_txt.Text = "GAME OVER";
            this.gameOver_txt.Click += new System.EventHandler(this.gameOver_txt_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy_3
            // 
            this.enemy_3.Image = ((System.Drawing.Image)(resources.GetObject("enemy_3.Image")));
            this.enemy_3.Location = new System.Drawing.Point(34, 86);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(69, 118);
            this.enemy_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_3.TabIndex = 6;
            this.enemy_3.TabStop = false;
            // 
            // track_4
            // 
            this.track_4.BackColor = System.Drawing.Color.White;
            this.track_4.Location = new System.Drawing.Point(446, -3);
            this.track_4.Name = "track_4";
            this.track_4.Size = new System.Drawing.Size(30, 107);
            this.track_4.TabIndex = 1;
            this.track_4.TabStop = false;
            // 
            // track_5
            // 
            this.track_5.BackColor = System.Drawing.Color.White;
            this.track_5.Location = new System.Drawing.Point(446, 205);
            this.track_5.Name = "track_5";
            this.track_5.Size = new System.Drawing.Size(30, 107);
            this.track_5.TabIndex = 1;
            this.track_5.TabStop = false;
            // 
            // track_6
            // 
            this.track_6.BackColor = System.Drawing.Color.White;
            this.track_6.Location = new System.Drawing.Point(446, 393);
            this.track_6.Name = "track_6";
            this.track_6.Size = new System.Drawing.Size(30, 115);
            this.track_6.TabIndex = 1;
            this.track_6.TabStop = false;
            // 
            // track_7
            // 
            this.track_7.BackColor = System.Drawing.Color.White;
            this.track_7.Location = new System.Drawing.Point(121, -3);
            this.track_7.Name = "track_7";
            this.track_7.Size = new System.Drawing.Size(30, 107);
            this.track_7.TabIndex = 1;
            this.track_7.TabStop = false;
            // 
            // track_8
            // 
            this.track_8.BackColor = System.Drawing.Color.White;
            this.track_8.Location = new System.Drawing.Point(121, 205);
            this.track_8.Name = "track_8";
            this.track_8.Size = new System.Drawing.Size(30, 107);
            this.track_8.TabIndex = 1;
            this.track_8.TabStop = false;
            // 
            // track_9
            // 
            this.track_9.BackColor = System.Drawing.Color.White;
            this.track_9.Location = new System.Drawing.Point(121, 393);
            this.track_9.Name = "track_9";
            this.track_9.Size = new System.Drawing.Size(30, 115);
            this.track_9.TabIndex = 1;
            this.track_9.TabStop = false;
            // 
            // fuel_1
            // 
            this.fuel_1.Image = ((System.Drawing.Image)(resources.GetObject("fuel_1.Image")));
            this.fuel_1.Location = new System.Drawing.Point(157, 39);
            this.fuel_1.Name = "fuel_1";
            this.fuel_1.Size = new System.Drawing.Size(30, 31);
            this.fuel_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fuel_1.TabIndex = 7;
            this.fuel_1.TabStop = false;
            // 
            // fuel_3
            // 
            this.fuel_3.Image = ((System.Drawing.Image)(resources.GetObject("fuel_3.Image")));
            this.fuel_3.Location = new System.Drawing.Point(361, 358);
            this.fuel_3.Name = "fuel_3";
            this.fuel_3.Size = new System.Drawing.Size(30, 31);
            this.fuel_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fuel_3.TabIndex = 7;
            this.fuel_3.TabStop = false;
            // 
            // fuel_2
            // 
            this.fuel_2.Image = ((System.Drawing.Image)(resources.GetObject("fuel_2.Image")));
            this.fuel_2.Location = new System.Drawing.Point(514, 105);
            this.fuel_2.Name = "fuel_2";
            this.fuel_2.Size = new System.Drawing.Size(30, 31);
            this.fuel_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fuel_2.TabIndex = 7;
            this.fuel_2.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.Location = new System.Drawing.Point(238, 215);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(153, 67);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreButton.Location = new System.Drawing.Point(238, 339);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(153, 67);
            this.scoreButton.TabIndex = 9;
            this.scoreButton.Text = "SCORE RANKING";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(618, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.fuel_2);
            this.Controls.Add(this.fuel_3);
            this.Controls.Add(this.fuel_1);
            this.Controls.Add(this.enemy_3);
            this.Controls.Add(this.gameOver_txt);
            this.Controls.Add(this.score_txt);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.track_6);
            this.Controls.Add(this.track_9);
            this.Controls.Add(this.track_3);
            this.Controls.Add(this.track_5);
            this.Controls.Add(this.track_8);
            this.Controls.Add(this.track_2);
            this.Controls.Add(this.track_4);
            this.Controls.Add(this.track_7);
            this.Controls.Add(this.track_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox track_1;
        private System.Windows.Forms.PictureBox track_2;
        private System.Windows.Forms.PictureBox track_3;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label score_txt;
        private System.Windows.Forms.Label gameOver_txt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox track_4;
        private System.Windows.Forms.PictureBox track_5;
        private System.Windows.Forms.PictureBox track_6;
        private System.Windows.Forms.PictureBox track_7;
        private System.Windows.Forms.PictureBox track_8;
        private System.Windows.Forms.PictureBox track_9;
        private System.Windows.Forms.PictureBox fuel_1;
        private System.Windows.Forms.PictureBox fuel_3;
        private System.Windows.Forms.PictureBox fuel_2;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button scoreButton;
        public System.Windows.Forms.Label label1;
    }
}

