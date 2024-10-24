namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        bool IsGameActive = true;
        int pepesShow = 0;

        //show the pepes after start game
        private void ShowPepes()
        {
            picColumn.Visible = true;
            picColumnx.Visible = true;
            picColumnX2.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();

            picColumn.Visible = false;
            picColumnx.Visible = false;
            picColumnX2.Visible = false;
        }

        //check the Collision and Game Over
        private bool CheckCollision()
        {

            if (picBird.Bounds.IntersectsWith(picColumn.Bounds) ||
                picBird.Bounds.IntersectsWith(picColumnx.Bounds) ||
                picBird.Bounds.IntersectsWith(picColumnX2.Bounds) ||
                picBird.Bounds.Y < -50 ||
                picBird.Bounds.Y > this.Height)
            {
                IsGameActive = false;   // game over
                timer1.Enabled = false; //stop the game
                MessageBox.Show("GAME OVER");
            }
            return IsGameActive;
        }


        // reset the pepe(columns ) location
        private void ResetColumn()
        {

            Random rand = new Random();

            int x = rand.Next(930, 1000);
            int y = rand.Next(-350, -300);
            int bottomY = rand.Next(410, 430);// this for bottom pepe

            if (picColumn.Left < -50) // column
                picColumn.Location = new Point(x, bottomY);

            if (picColumnx.Left < -50) //columnx
                picColumnx.Location = new Point(x, y);

            if (picColumnX2.Left < -50)
                picColumnX2.Location = new Point((x -90), (y+75)); //new pepe(columnX2)

            //if (picColumnX2.Left < -30)
            //    HiedePepes();
        }


        //the columns function left to right
        private void columnAction()
        {
            picColumn.Left -= 6;
            picColumnx.Left -= 6;
            picColumnX2.Left -= 6; //new pepe(columnX2)

        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckCollision();
            ResetColumn(); // function
            columnAction(); //function
            picBird.Top += 10; //bird is fall

        }

        //when pressing the space (jump)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            timer1.Enabled = IsGameActive;  //if user pressig space start the game
            if (IsGameActive)
                picBird.Top -= 60; // jump

            if (pepesShow == 0)
            {
                ShowPepes();
                pepesShow = 1;
            }
        }

        // when start game show the pepes and close the timer2
        
    }
}
