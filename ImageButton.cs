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
    public partial class ImageButton : Form
    {
        String text;

        public ImageButton(String _text)
        {
            InitializeComponent();
            text = _text;
        }

        private void ImageButton_Load(object sender, EventArgs e)
        {
            label1.Text = text;
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
