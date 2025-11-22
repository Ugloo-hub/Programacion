using Microsoft.VisualBasic.Devices;
using System.Diagnostics.CodeAnalysis;

namespace mathsQ
{
    public partial class Form1 : Form
    {
        Random randimizer = new Random();
        int addNum1;
        int addNum2;

        int minusNum1;
        int minusNum2;

        int mulitplyNum1;
        int mulitplyNum2;

        int divideNum1;
        int divideNum2;

        int clock;


        public void StartQuiz()
        {
            addNum1 = randimizer.Next(51);
            addNum2 = randimizer.Next(51);
            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum2.ToString();
            sum.Value = 0;

            minusNum1 = randimizer.Next(1, 101);
            minusNum2 = randimizer.Next(1, minusNum1);
            minusLeftLabel.Text = minusNum1.ToString();
            minusRightLabel.Text = minusNum2.ToString();
            difference.Value = 0;

            mulitplyNum1 = randimizer.Next(2, 11);
            mulitplyNum2 = randimizer.Next(2, 11);
            timesLeftLabel.Text = mulitplyNum1.ToString();
            timesRightLabel.Text = mulitplyNum2.ToString();
            product.Value = 0;

            divideNum1 = randimizer.Next(1, 11);
            divideNum2 = randimizer.Next(1, 11);
            dividedLeftLabel.Text = divideNum1.ToString();
            dividedRightLabel.Text = divideNum2.ToString();
            quotient.Value = 0;

            clock = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                clock = clock - 1;
                timeLabel.Text = clock + "Seconds";

            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Times Up";
                MessageBox.Show("You didn't finish in time");
                sum.Value = addNum1 + addNum2;
                difference.Value = addNum1 - addNum2;
                product.Value = addNum1 * addNum2;
                quotient.Value = addNum1 / addNum2;
                startButton.Enabled = true;
            }
        }
        private bool CheckAnswers()
        {
            if ((((addNum1 + addNum2 == sum.Value)
                && (minusNum1 - minusNum2 == sum.Value))
                && (mulitplyNum1 * mulitplyNum2 == product.Value
                && (divideNum1 / divideNum2 == quotient.Value))))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lenghtofAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtofAnswer);
            }
        }
    }
}
