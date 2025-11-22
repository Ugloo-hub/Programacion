using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLimeMaps__Project_15_
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txtBoxStreet.Text;
            string city = txtBoxCity.Text;
            string state = txtBoxState.Text;
            string zip = txtBoxZip.Text;

            try
            {
                // Construimos la dirección completa
                StringBuilder address = new StringBuilder();

                if (!string.IsNullOrWhiteSpace(street))
                    address.Append(street + ", ");

                if (!string.IsNullOrWhiteSpace(city))
                    address.Append(city + ", ");

                if (!string.IsNullOrWhiteSpace(state))
                    address.Append(state + ", ");

                if (!string.IsNullOrWhiteSpace(zip))
                    address.Append(zip);

                // Codificamos la dirección para que funcione en una URL
                string encodedAddress = Uri.EscapeDataString(address.ToString());

                // URL correcta de Google Maps
                string url = $"https://www.google.com/maps/search/?api=1&query={encodedAddress}";

                webBrowser1.Source = new Uri(url);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }
}
