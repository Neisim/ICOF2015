using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICOF.Entities
{
    class ControlModifier
    {
        public ControlModifier() { }

        public void setCorrectColor(Control control)
        {
            control.BackColor = Color.White;
            control.ForeColor = Color.Black;

        }

        public void setWrongColor(Control control)
        {
            control.BackColor = Color.Red;
            control.ForeColor = Color.White;

        }
    }
}
