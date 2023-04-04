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

namespace WebLine
{
    public partial class Container : TitleBarTabs
    {
        public static Icon tclass;

        public Container()
        {
            InitializeComponent();

            AeroPeekEnabled = false;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = "New Tab"
                }
            };
        }

        private void Container_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            //this.BackColor = ControlPaint.Light(Color.White, 10.0f);
        }

    }
}