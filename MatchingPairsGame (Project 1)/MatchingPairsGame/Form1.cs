namespace MatchingPairsGame
{
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;

        Random random = new Random();
        List<String> icons = new List<String>()
        {
            "!","!","N","N",",",",","K","K","B","B","V","V","W","W","Z","Z"

        };

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquare();
        }

        private void AssignIconsToSquare()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                {
                    if (clickedLabel.ForeColor == Color.Black)
                        return;

                    //clickedLabel.ForeColor = Color.Black;
                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;
                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start(); 
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    if (iconlabel.ForeColor == iconlabel.BackColor)
                        return;
                }

            }
            MessageBox.Show("GG's, you beat the game. Well done!");
            Close();

        }
    }
}

