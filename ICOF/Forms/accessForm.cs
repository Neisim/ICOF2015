using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICOF.Entities;

namespace ICOF
{
    public partial class accessForm : Form
    {
        private String              _profile;
        private Controller          _control;
        private ControlModifier     _checkInput;

        public accessForm()
        {
            InitializeComponent();
            _profile = "notLoged";
            _control = new Controller();
            _checkInput = new ControlModifier();    
        }

        public String getProfile() { return _profile; }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String value = tb.Text;
            if (String.IsNullOrEmpty(value)) _checkInput.setWrongColor(tb);
            else _checkInput.setCorrectColor(tb);
        }

        private void validateUser(object sender, EventArgs e)
        {
            String name = userTB.Text;
            String pwd = passwordTB.Text;
            User u = new User(name, pwd);
            _profile = _control.getUserProfile(u);
            if (_profile.Equals("wrong_user"))
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrecte.", "Acces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Profile actif: " + _profile, "Acces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
