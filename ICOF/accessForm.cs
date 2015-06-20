using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICOF
{
    public partial class accessForm : Form
    {
        public accessForm()
        {
            InitializeComponent();
        }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            ControlChecker check = new ControlChecker();
            check.controlCheck(tb);
        }
    }
}
