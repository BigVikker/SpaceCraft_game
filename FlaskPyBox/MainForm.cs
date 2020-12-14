using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskPyBox
{
    public partial class MainForm : Form
    {
        public Random rand = new Random();
        public Point positionPile1 { set; get; }
        public Point positionPile2 { set; get; }
        public Point positionPile3 { set; get; }
        public Point positionPile4 { set; get; }

        
        public MainForm()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            positionPile1 = pile1.Location;
            positionPile2 = pile2.Location;
            positionPile3 = pile3.Location;
            positionPile4 = pile4.Location;
        }
        public int speedPileLower = 10;
        public int speedPileUpper = 10;
        public int pileGap = 150;
        public int lengthBetweenPile = 200;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Box.Location.Y + pictureBox_Box.Height + 50 < this.Height)
            {
                pictureBox_Box.Location = new Point (pictureBox_Box.Location.X, pictureBox_Box.Location.Y + 5);
            }
            pile1.Location = new Point(pile1.Location.X - speedPileLower, pile1.Location.Y);
            pile2.Location = new Point(pile2.Location.X - speedPileUpper, pile2.Location.Y);
            pile3.Location = new Point(pile3.Location.X - speedPileLower, pile3.Location.Y);
            pile4.Location = new Point(pile4.Location.X - speedPileUpper, pile4.Location.Y);
            if (pile1.Location.X <= -50) { 
                pile1.Location = new Point(this.Width - 30, positionPile1.Y + rand.Next(0, 75));
                int Score = Convert.ToInt32(label_Score.Text.ToString());
                Score += 1;
                label_Score.Text = Score.ToString();
                speedPileLower += 1;
            }
            if (pile2.Location.X <= -50) { 
                pile2.Location = new Point(this.Width - 30, positionPile2.Y + rand.Next(0, 75));
                int Score = Convert.ToInt32(label_Score.Text.ToString());
                Score += 1;
                label_Score.Text = Score.ToString();
                speedPileUpper += 1;
            }
            if (pile3.Location.X <= -50)
            {
                pile3.Location = new Point(this.Width - 30, positionPile3.Y + rand.Next(0, 75));
                int Score = Convert.ToInt32(label_Score.Text.ToString());
                Score += 1;
                label_Score.Text = Score.ToString();
                speedPileLower += 1;
            }
                
            if (pile4.Location.X <= -50)
            {
                pile4.Location = new Point(this.Width - 30, positionPile4.Y + rand.Next(0, 75));
                int Score = Convert.ToInt32(label_Score.Text.ToString());
                Score += 1;
                label_Score.Text = Score.ToString();
                speedPileUpper += 1;
            }
                
            if (pile4.Bounds.IntersectsWith(pictureBox_Box.Bounds) || pile3.Bounds.IntersectsWith(pictureBox_Box.Bounds) ||
                pile1.Bounds.IntersectsWith(pictureBox_Box.Bounds) || pile2.Bounds.IntersectsWith(pictureBox_Box.Bounds))
            {
                timer_G.Enabled = false;
                ScoreForm broadScore = new ScoreForm(this, Convert.ToInt32(label_Score.Text.ToString()));
                broadScore.Show();
                button_start.Show();
                resetPosition();
            }
            return;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Space || e.KeyData == Keys.Up)
            //{
            //    if (pictureBox_Box.Location.Y >= 5 && timer_G.Enabled == true)
            //        pictureBox_Box.Location = new Point(pictureBox_Box.Location.X, pictureBox_Box.Location.Y - 20);
            //}
        }
        public void resetPosition()
        {
            speedPileLower = speedPileUpper = 10;
            label_Score.Text = "0";
            pictureBox_Box.Location = new Point(15, 200);
            pile1.Location = positionPile1;
            pile2.Location = positionPile2;
            pile3.Location = positionPile3;
            pile4.Location = positionPile4;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer_G.Enabled = true;
            button_start.Hide();
            return;
        }

        private void pictureBox_Box_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space || e.KeyData == Keys.Up)
            { 
                if(pictureBox_Box.Location.Y >= 5) 
                     pictureBox_Box.Location = new Point(pictureBox_Box.Location.X, pictureBox_Box.Location.Y - 20);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_G.Enabled = false;
            if (MessageBox.Show("Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.No)
            {
                e.Cancel = true;
                if (button_start.Visible == false)
                    timer_G.Enabled = true;
            }
        }
    }
}
