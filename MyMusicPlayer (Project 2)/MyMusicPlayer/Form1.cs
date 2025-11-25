namespace MyMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }

            Player.URL = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
