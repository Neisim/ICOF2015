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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.Text += " - Invité"; 
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPersonForm ajouterPersonnel = new addPersonForm();
            ajouterPersonnel.ShowDialog();
        }

        private void entrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCompanyForm ajouterEntreprise = new addCompanyForm();
            ajouterEntreprise.ShowDialog();
        }

        private void afficherRemarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addContactForm ajouterRemarque = new addContactForm();
            ajouterRemarque.ShowDialog();
        }

        private void close_form(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult exit = MessageBox.Show(this, "Voulez vous sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exit == DialogResult.No) e.Cancel = true;
            }
        }

        private void access_form(object sender, EventArgs e)
        {
            accessForm acces = new accessForm();
            acces.ShowDialog();
            String userProfile = acces.getProfile();
            this.Text = "Annuaire ICOF - " + userProfile;

            if (!userProfile.Equals("Guest")) profile.Visible = true;
            else profile.Visible = false;

            if (userProfile.Equals("Office"))
            {
                contact.Visible = true;
                data.Visible = true;
            }

            else
            {
                contact.Visible = false;
                data.Visible = false;
            }
        }
    }
}
