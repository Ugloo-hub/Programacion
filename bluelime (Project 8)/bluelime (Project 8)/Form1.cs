using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace bluelime__Project_8_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            // Inicializar WebView2 correctamente
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateToPage();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
                webView21.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
                webView21.GoForward();
        }

        private void NavigateToPage()
        {
            string url = cboLocation.Text.Trim();

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            if (webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(url);
            }
        }
    }
}
