using System;
using CefSharp;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace CEFSimplifiedVS17Project
{
    public partial class frmMain : Form
    {
        private static CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser;
        private const string Url = "https://www.google.com/";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            // EnableHighDPISupport
            Cef.EnableHighDPISupport();

            chromiumWebBrowser = new CefSharp.WinForms.ChromiumWebBrowser(Url);
            this.panel1.Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
