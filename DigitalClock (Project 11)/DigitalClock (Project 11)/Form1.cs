using System;
using System.Windows.Forms;

namespace DigitalClock__Project_11_
{
    public partial class clock : Form
    {
        // Especificar el timer correcto para evitar el error CS0104
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public clock()
        {
            InitializeComponent();
        }

        private void clock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += t_Tick;
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            // Hours
            time += (hh < 10 ? "0" + hh : hh.ToString()) + ":";

            // Minutes
            time += (mm < 10 ? "0" + mm : mm.ToString()) + ":";

            // Seconds
            time += (ss < 10 ? "0" + ss : ss.ToString());

            // Asegúrate de tener un label con este nombre
            label1.Text = time;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // NO USAS ESTE TIMER ? puedes borrarlo si quieres
        }
    }
}
