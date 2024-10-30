namespace Flappy_Bird_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void pictRestart_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm1 = (Form1)Application.OpenForms[0];

            frm1.ResetGame();

            frm1.Show();
        }
    }
}
