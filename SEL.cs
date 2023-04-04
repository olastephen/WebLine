using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebLine
{
    public partial class SEL : Form
    {
        public SEL()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SEL_Load(object sender, EventArgs e)
        {
            lstSearchEngines.SelectedIndex = 0;

            foreach (var searchEngine in lstSearchEngines.Items)
            {
                Extra.AddFormToList(new ImageButton(searchEngine.ToString()), flp);
            }
        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
