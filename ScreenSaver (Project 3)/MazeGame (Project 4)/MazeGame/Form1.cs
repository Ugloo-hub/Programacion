namespace MazeGame
{
    public partial class Form1 : Form

    {
            
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            
            MessageBox.Show("Congrats!");
            Close();
        }
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

         
    }
}
