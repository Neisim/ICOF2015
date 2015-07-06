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
    public partial class changePasswordForm : Form
    {
        private String userName;

        public changePasswordForm()
        {
            InitializeComponent();
        }

        public void setUser(String name) { userName = name; }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
        }

        //changes the user hash if the two inputs are equal
        private void change_Click(object sender, EventArgs e)
        {
            string newHash = newpasswordTB.Text;
            string reHash = repasswordTB.Text;

            if (!newHash.Equals(reHash)) MessageBox.Show("Les mots de passe ne coincident pas.", "Changer mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (newHash.Equals("")) MessageBox.Show("Les mots de passe ne peux pas etre vide.", "Changer mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult changePass = MessageBox.Show(this, "Voulez vous confirmer le nouveau mot de passe?", "Changer mot de passe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (changePass == DialogResult.Yes)
                {
                    User new_user = new User(userName, newHash);
                    Controller control = new Controller();
                    string change = control.userHash(new_user);
                    if (change.Equals("OK"))
                    {
                        MessageBox.Show(this, "Mot de passe changé correctement.", "Changer mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }                             
            }
        }
    }
}
