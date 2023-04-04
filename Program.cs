using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebLine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container container = new Container();

            // add initial tab
            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new Form1
                    {
                        Text = "New Tab"
                    }
                }
              );

            // set the initial tabs
            container.SelectedTabIndex = 0;

            // create tabs
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);

            // start application
            Application.Run(applicationContext);
        }
    }
}
