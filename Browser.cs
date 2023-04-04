using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyTabs;

namespace WebLine
{
    public partial class Browser : Form
    {
        public String urlStr, t;

        Control tU;

        static ChromiumWebBrowser chrome;

        public Browser()
        {
            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            tU = Form1.search.txtUrl;

            CefSettings settings = new CefSettings();

            // Initialization
            tU.Text = "https://youtube.com";

            urlStr = new Uri(tU.Text).Host;

            chrome = new ChromiumWebBrowser(Form1.search.txtUrl.Text);
            chrome.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(chrome);
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void Chrome_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                t = e.Title;
                Form1.tuc.Text = t;
            }));
        }

        public void LoadUrl(string text)
        {
            chrome.Load(text);
        }

        public void RefreshUrl()
        {
            chrome.Refresh();
        }

        public void StopUrl()
        {
            chrome.Stop();
        }

        public void Forward()
        {
            if (chrome.CanGoForward)
            {
                chrome.Forward();
            }
        }

        public void Backward()
        {
            if (chrome.CanGoBack)
            {
                chrome.Back();
            }
        }

        public void SorR()
        {
            if (chrome.IsLoading)
            {
                StopUrl();
            }
            else
            {
                RefreshUrl();
            }
        }

        private void Chrome_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tU.Text = e.Address;
                urlStr = new Uri(tU.Text).Host;
                t = urlStr;
                Form1.tuc.Text = urlStr;
            }));
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
