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
    public partial class hControl : Form
    {
        public bool btnSELisUp = true;
        public int index;

        private static Control pnlSide;

        public hControl()
        {
            InitializeComponent();
        }

        private void btnSEL_Click(object sender, EventArgs e)
        {
           
        }

        internal static void getPnlSide(Control _pnlSide)
        {
            pnlSide = _pnlSide;
        }

        private void hControl_Load(object sender, EventArgs e)
        {
            Extra.AddFormToControl(Form1.search, this.pnlSB);
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (!pnlSide.Visible)
            {
                pnlSide.Visible = true;
            }
            else
            {
                pnlSide.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DisableButton("back");
            Form1.browser.Backward();
        }

        private void btnFoward_Click(object sender, EventArgs e) {
            Form1.browser.Forward();
        }

        private void btnSorR_Click(object sender, EventArgs e)
        {
            Form1.browser.SorR();
            btnSorR.ImageIndex = index;
        }

        public void EnableButton(String name)
        {
            if (name == "back")
            {
                btnBack.Enabled = true;
            }
            else if(name == "foward")
            {
                btnFoward.Enabled = true;
            }
        }

        public void DisableButton(String name)
        {
            if (name == "back")
            {
                btnBack.Enabled = false;
            }
            else if (name == "foward")
            {
                btnFoward.Enabled = false;
            }
        }

        public void ChangeButtonImage()
        {

        }

    }
}
