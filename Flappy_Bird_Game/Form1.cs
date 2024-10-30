namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        int pepesShow = 0;

        int score = 0;
        int speed = 15;
        int gravity = 14;

        Form2 frm2 = new Form2();
        Random rand = new Random();



        //show the pepes after start game
        //private void ShowPepes()
        //{
        //    picColumn.Visible = true;
        //    picColumnx.Visible = true;
        //    picColumnX2.Visible = true;
        //    picColumn2.Visible = true;
        //}

        public Form1()
        {
            InitializeComponent();

            //picColumn.Visible = false;
            //picColumnx.Visible = false;
            //picColumnX2.Visible = false;
            //picColumn2.Visible = false;
        }


        //set pepes
        private void ResetPepesLocation(bool ifGameEnd)
        {

            if (picColumn.Left < -150 || ifGameEnd)
            {
                picColumn.Left = 1650;
                score++;
                labelScore.Text = score.ToString();
            }
            if (picColumnx.Left < -150 || ifGameEnd)
            {
                picColumnx.Left = 1800;
                score++;
                labelScore.Text = score.ToString();
            }
            if (picColumn2.Left < -150 || ifGameEnd)
            {
                picColumn2.Left = 1950;
                score++;
                labelScore.Text = score.ToString();
            }
            if (picColumnX2.Left < -150 || ifGameEnd)
            {
                picColumnX2.Left = 2150;
                score++;
                labelScore.Text = score.ToString();
            }


            //labelScore.Text = score .ToString();
        }


        // game over
        private void GameOver()
        {
            timer1.Enabled = false; //stop the game
            score = -1;
            MessageBox.Show("GAME OVER");
            picBird.Location = new Point(276, 232);
            ResetPepesLocation(true);
            this.Hide();
            frm2.Show();
            //reset bird and pepes location

        }

        //check the Collision and Game Over
        private void CheckCollision()
        {

            if (picBird.Bounds.IntersectsWith(picColumn.Bounds) ||
                picBird.Bounds.IntersectsWith(picColumnx.Bounds) ||
                picBird.Bounds.IntersectsWith(picColumnX2.Bounds) ||
                picBird.Bounds.IntersectsWith(picColumn2.Bounds) ||
                picBird.Bounds.Y < -50 ||
                picBird.Bounds.Y > this.Height)
            {
                GameOver();
            }

        }


        //the columns function left to right
        //private void columnAction()
        //{

        //    picColumn.Left -= speed;
        //    picColumn2.Left -= speed;
        //    picColumnx.Left -= speed;
        //    picColumnX2.Left -= speed;

        //}

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckCollision();
            ResetPepesLocation(false);
            //columnAction();
            picBird.Top += gravity;

            picColumn.Left -= speed;
            picColumn2.Left -= speed;
            picColumnx.Left -= speed;
            picColumnX2.Left -= speed;

        }

        //when pressing the space (jump)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            timer1.Enabled = true;  //if user pressig space start the game

            picBird.Top -= 130; // jump

            // show the pepes and random reset 
            //if (pepesShow == 0)
            //{
            //     //ShowPepes();
            //    //picColumn.Left = 1650;
            //    //picColumnx.Left = 1700;
            //    //picColumn2.Left = 1750;
            //    //picColumnX2.Left = 1850;
            //    pepesShow = 1;
            //}

        }


        public void ResetGame()
        {
            picColumn.Left = 1650;
            picColumnx.Left = 1800;
            //ResetPepesLocation(0);

            timer1.Enabled = true;

        }
    }
}
