using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyTabs;
using CefSharp.WinForms;
using System.IO;
using System.Net;

namespace WebLine
{
    public partial class Form1 : Form
    {
        public static Browser browser;
        public static hControl hControl;
        public static Search search;
        public static Resources.SidePane sidePane;
        public static ImageList iconList;
        public static TextBox tuc = new TextBox();
        public static int tabIndex;

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabIndex = ParentTabs.SelectedTabIndex;
            this.ParentTabs.SelectedTabIndex = tabIndex;

            tuc.TextChanged += Tuc_TextChanged;
            tuc.KeyUp += Tuc_KeyUp;

            browser = new Browser();
            search = new Search();
            hControl = new hControl();
            sidePane = new Resources.SidePane();
            iconList = new ImageList();
            Extra.AddFormToControl(hControl, this.pnlHeader);
            Extra.AddFormToControl(browser, this.pnlBrowser);
            Extra.AddFormToControl(sidePane, this.pnlSide);
            hControl.getPnlSide(this.pnlSide);
        }

        private void Tuc_KeyUp(object sender, KeyEventArgs e)
        {
            WebIconsAndTitles();
        }

        public static void LoadB(string url)
        {
            browser.LoadUrl(url);
        }

        private void Tuc_TextChanged(object sender, EventArgs e)
        {
            //WebIconsAndTitles();
        }

        public void WebIconsAndTitles()
        {
            WebClient wc = new WebClient();
            MemoryStream ms = new MemoryStream(wc.DownloadData("http://" + browser.urlStr + "/favicon.ico"));
            Icon icon = new Icon(ms);

            this.ParentTabs.SelectedTab.Icon = icon;
            this.ParentTabs.SelectedTab.Caption = browser.t;
        }

    }
}