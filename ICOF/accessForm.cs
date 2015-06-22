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
        private String profile;

        public accessForm()
        {
            profile = "guest";
            InitializeComponent();
        }

        public String getProfile() { return profile; }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            ControlChecker check = new ControlChecker();
            check.controlCheck(tb);
        }

        private void validateUser(object sender, EventArgs e)
        {
            String name = userTB.Text;
            String pwd = passwordTB.Text;
            User u = new User(name, pwd);
            MessageBox.Show("User: " + name + " Password: " + pwd);
            Controller control = new Controller();
            profile = control.userProfile(u);
            this.Close();
        }
    }
}
