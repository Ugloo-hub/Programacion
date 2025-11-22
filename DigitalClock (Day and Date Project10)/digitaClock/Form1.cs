namespace digitaClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hourMinuteLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinuteLabel.Text = DateTime.Now.ToString("HH:mm");
            secondsLabel.Text = DateTime.Now.ToString("ss");
            dateLabel.Text = DateTime.Now.ToString("MMM:dd:yyyy");
            weekdayLabel.Text = DateTime.Now.ToString("dddd");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
