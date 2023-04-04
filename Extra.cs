using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebLine
{
    class Extra
    {

        public static void AddFormToControl(Form form, Control control )
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Show();
            control.Controls.Add(form);
        }

        public static void AddFormToList(Form form, Control control)
        {
            form.TopLevel = false;
            form.Show();
            control.Controls.Add(form);
        }

        public static void AddControlToForm(Control control, Form form)
        {
            control.Dock = DockStyle.Fill;
            form.Controls.Add(control);
        }

        public static void AddControlToControl(Control control, Control pcontrol)
        {
            control.Dock = DockStyle.Fill;
            pcontrol.Controls.Add(control);
        }

        public static void ShowPopup(int h, int w, Point location, Form form, Popup popup)
        { 
            popup.Height = h;
            popup.Width = w;
            popup.StartPosition = FormStartPosition.Manual;
            popup.Location = location;

            AddFormToControl(form, popup.pnl);

            popup.Show();
        }

        public static void ClosePopup(Form popup)
        {
            popup.Close();
        }

        public static Point GetPosition(Point hc)
        {
            float hcy = hc.Y - (hc.Y * hc.Y);
            Point point = new Point(hc.X, (int)(hcy + (hc.X / 2)));

            return point;
        }
    }
}
