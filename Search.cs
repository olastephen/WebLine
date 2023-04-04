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
    public partial class Search : Form
    {
        public TextBox txtUrl;

        static bool isSE = false;
        Popup popup;
        Uri uriResult;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            txtUrl = new TextBox();
            Extra.AddControlToControl(txtUrl, pnlUrl);

            txtUrl.KeyUp += TxtUrl_KeyUp;

        }

        private void TxtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            bool result = Uri.TryCreate(txtUrl.Text, UriKind.Absolute, out uriResult)
                     && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Form1.browser.LoadUrl(txtUrl.Text);
                }
            }
            else
            {
                SEL nSEL = new SEL();

                if (e.KeyCode == Keys.Enter)
                {
                    Form1.browser.LoadUrl(nSEL.lstSearchEngines.SelectedItem + txtUrl.Text);
                }
            }
        }

        private void btnSEL_Click(object sender, EventArgs e)
        {
            int h = ((new ImageButton("btn").Height * (new SEL().lstSearchEngines.Items.Count + 1)) - 10);
            if (!isSE)
            {
                popup = new Popup();
                Extra.ShowPopup(h, 200, Extra.GetPosition(new hControl().pnlSB.Location), new SEL(), popup);
                isSE = true;
            }
            else
            {
                Extra.ClosePopup(popup);
                isSE = false;
            }
        }

    }
}
