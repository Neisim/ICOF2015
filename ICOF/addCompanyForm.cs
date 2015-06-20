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
    public partial class addCompanyForm : Form
    {
        public addCompanyForm()
        {
            InitializeComponent();
            taxeCB.Items.Add("Oui");
            taxeCB.Items.Add("Non");
            taxeCB.SelectedItem = "Non";

            stageCB.Items.Add("Oui"); 
            stageCB.Items.Add("Non");
            stageCB.SelectedItem = "Non";
        }

        private void taxeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taxeCB.SelectedItem.Equals("Oui"))
            {
                montantLB.Visible = true;
                montantTB.Visible = true;
                euroLB.Visible = true;
                anneeLB.Visible = true;
                anneeTB.Visible = true;
            }

            else
            {
                montantLB.Visible = false;
                montantTB.Visible = false;
                euroLB.Visible = false;
                anneeLB.Visible = false;
                anneeTB.Visible = false;
            }
        }

        private void stageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stageCB.SelectedItem.Equals("Oui"))
            {
                annee_stageLB.Visible = true;
                annee_stageTB.Visible = true;
            }

            else
            {
                annee_stageLB.Visible = false;
                annee_stageTB.Visible = false;
            }
        }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            ControlChecker check = new ControlChecker();
            check.controlCheck(tb);
        }

        private void clearCompany(object sender, EventArgs e)
        {
            DialogResult erase = MessageBox.Show("Voulez vous effacer le formulaire?", "Effacer formulaire", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (erase == DialogResult.OK)
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        c.Text = "";
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }
                }
                //Comboboxes options
                taxeCB.SelectedItem = "Non";
                stageCB.SelectedItem = "Non";

                //Taxe d'apprentisage  
                montantLB.Visible = false;
                montantTB.Visible = false;
                euroLB.Visible = false;
                anneeLB.Visible = false;
                anneeTB.Visible = false;

                //Elève stage
                annee_stageLB.Visible = false;
                annee_stageTB.Visible = false;
            }
        }
    }
}
