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
using ICOF.Forms;

namespace ICOF
{
    public partial class companyForm : Form
    {
        private Company         _company;
        private Controller      _control;
        private ControlModifier _checkInput;

        public companyForm()
        {
            InitializeComponent();
            _company = new Company();
            _company.setFAX("Pas de fax");
            _company.setTaxe(false);
            _company.setCurrentYear(DateTime.Now.Year);
            _company.setCurrentTA(0);

            _company.setPreviousYear(DateTime.Now.Year);
            _company.setPreviousTA(0);

            _checkInput = new ControlModifier();
            _control = new Controller();
            
            taxeCB.Items.Add("Oui");
            taxeCB.Items.Add("Non");
            taxeCB.SelectedItem = "Non";
        }

        private void taxeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taxeCB.SelectedItem.Equals("Oui"))
            {
                currentTA_TB.Enabled = true;
                currentTA_TB.BackColor = Color.White;
                currentTA_TB.Focus();
                currentYear_TB.Enabled = true;
                currentYear_TB.BackColor = Color.White;
                previousTA_TB.Enabled = true;
                previousTA_TB.BackColor = Color.White;
                previousYear_TB.Enabled = true;
                previousYear_TB.BackColor = Color.White;
            }

            else
            {
                currentTA_TB.Enabled = false;
                currentTA_TB.BackColor = SystemColors.ButtonFace;
                currentTA_TB.Text = "";

                currentYear_TB.Enabled = false;
                currentYear_TB.BackColor = SystemColors.ButtonFace;
                currentYear_TB.Text = "";

                previousYear_TB.Enabled = false;
                previousYear_TB.BackColor = SystemColors.ButtonFace;
                previousYear_TB.Text = "";

                previousTA_TB.Enabled = false;
                previousTA_TB.BackColor = SystemColors.ButtonFace;
                previousTA_TB.Text = "";
            }
        }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String value = tb.Text;
            String name = tb.Name;

            if (String.IsNullOrEmpty(value) && !name.Equals("fax_tb"))
            {
                _checkInput.setWrongColor(tb);
            }

            else if (name.Equals("fax_tb"))
            {
                if (!String.IsNullOrEmpty(value))
                {
                    try
                    {
                        Int64 fax = Convert.ToInt64(value);
                        if (fax <= 0) _checkInput.setWrongColor(tb);
                        else
                        {
                            _company.setFAX(Convert.ToString(fax));
                            _checkInput.setCorrectColor(tb);
                        }
                    }
                    catch (FormatException)
                    {
                        _checkInput.setWrongColor(tb);
                    }
                }
            }

            else
            {
                switch (name)
                {
                    case "companyName_TB":
                        _company.setName(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "companyAddress_TB":
                        _company.setAddress(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "companyPhone_TB":
                        try
                        {
                            Int64 phone = Convert.ToInt64(value);
                            if (phone <= 0)
                            {
                                _checkInput.setWrongColor(tb);
                            }
                            else
                            {
                                _company.setPhone(value);
                                _checkInput.setCorrectColor(tb);
                            }
                        }
                        catch (FormatException)
                        {
                            _checkInput.setWrongColor(tb);
                        }
                        break;

                    case "companyEmail_TB":
                        _company.setEmail(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "companyActivity_TB":
                        _company.setActivity(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "currentTA_TB":
                        try
                        {
                            double current_TA = Convert.ToDouble(value);
                            if (current_TA < 0) _checkInput.setWrongColor(tb);
                            else
                            {
                                _company.setCurrentTA(current_TA);
                                _checkInput.setCorrectColor(tb);
                            }
                        }
                        catch (FormatException)
                        {
                            _checkInput.setWrongColor(tb);
                        }
                        break;

                    case "previousTA_TB":
                        try
                        {
                            double previousTA = Convert.ToDouble(value);
                            if (previousTA < 0) _checkInput.setWrongColor(tb);
                            else
                            {
                                _company.setCurrentTA(previousTA);
                                _checkInput.setCorrectColor(tb);
                            }
                        }
                        catch (FormatException)
                        {
                            _checkInput.setWrongColor(tb);
                        }
                        break;
                }
            }
        }

        private Boolean correctForm()
        {
             int errors = 0;
            foreach (Control c in Controls)
            {
                if (c.BackColor == Color.Red) ++errors;
            }
            return (errors == 0);
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
                
                //Taxe d'apprentisage  
                currentTA_TB.Enabled = false;
                currentTA_TB.BackColor = SystemColors.ButtonFace;
                currentTA_TB.Text = "";

                currentYear_TB.Enabled = false;
                currentYear_TB.BackColor = SystemColors.ButtonFace;
                currentYear_TB.Text = "";

                previousYear_TB.Enabled = false;
                previousYear_TB.BackColor = SystemColors.ButtonFace;
                previousYear_TB.Text = "";

                previousTA_TB.Enabled = false;
                previousTA_TB.BackColor = SystemColors.ButtonFace;
                previousTA_TB.Text = "";
              
            }
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
                MessageBox.Show(
                _company.getName() + " " +
                _company.getAddress() + " " +
                _company.getPhone() + " " +
                _company.getEmail() + " " +
                _company.getFAX() + " " +
                _company.getActivity() + " " +
                _company.getTaxe() + " " +
                _company.getCurrentTA() + " " +
                _company.getCurrentYear() + " " +
                _company.getPreviousYear() + " " +
                _company.getPreviousTA()
                );

            if (correctForm()){
                if(_control.insertCompany(_company).Equals("OK")){
                    DialogResult addContact = MessageBox.Show("Voulez vous ajouter un contact a cette entreprise?", "Ajouter contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (addContact == DialogResult.Yes)
                    {
                        contactForm contact = new contactForm();
                        contact.setCompany(_company);
                        contact.ShowDialog();
                    }

                    DialogResult addStudent = MessageBox.Show("Voulez vous ajouter un élève en stage a cette entreprise?", "Ajouter élève en stage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (addStudent == DialogResult.Yes)
                    {
                        studentForm student = new studentForm();
                        student.setCompany(_company);
                        student.ShowDialog();
                    }
                    MessageBox.Show("Entreprise ajoutée correctement", "Ajouter entreprise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Pas possible d'ajouter. Cette entreprise existe dejà." + _control.insertCompany(_company), "Ajouter entreprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else MessageBox.Show("Revisez vos champs", "Ajouter entreprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            contactForm contact = new contactForm();
            contact.ShowDialog();
        }
    }
}
