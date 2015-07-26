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

namespace ICOF.Forms
{
    public partial class contactForm : Form
    {
        private ContactCompany  _contact;
        private ControlModifier _checkInput;
        private Controller      _control;
        private Company         _company;

        public contactForm()
        {
            InitializeComponent();
            _checkInput = new ControlModifier();
            _contact = new ContactCompany();
            _control = new Controller();
            _company = new Company();
        }

        public void setContact(ContactCompany contact) { _contact = contact; }

        public void setCompany(Company company) { _company = company; }

        public void fillForm(){
            modify.Visible = true;
            add.Visible = false;
            clear.Enabled = false;

            MessageBox.Show("Contact ID:" + _contact.getID());
            this.Text = "Contact";
            title_LB.Text = "Contact";
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = false;
            }
            firstName_TB.Text = _contact.getFirstName();
            lastName_TB.Text = _contact.getLastName();
            phone_TB.Text = _contact.getPhone();
            email_TB.Text = _contact.getEmail();
            post_TB.Text = _contact.getPost();
        }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String name = tb.Name;
            String value = tb.Text;

            if (String.IsNullOrEmpty(value)) _checkInput.setWrongColor(tb);
            else
            {
                switch (name)
                {
                    case "lastName_TB":
                        _contact.setLastName(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "firstName_TB":
                        _contact.setFirstName(value);
                        _checkInput.setCorrectColor(tb);
                        break;
                    
                    case "phone_TB":
                        try
                        {
                            Int64 phone = Convert.ToInt64(value);
                            if (phone <= 0)
                            {
                                _checkInput.setWrongColor(tb);
                            }
                            else
                            {
                                _contact.setPhone(value);
                                _checkInput.setCorrectColor(tb);
                            }
                        }
                        catch (FormatException)
                        {
                            _checkInput.setWrongColor(tb);
                        }
                        break;

                    case "email_TB":
                        _contact.setEmail(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "post_TB":
                        _contact.setPost(value);
                        _checkInput.setCorrectColor(tb);
                        break;
                }
            }
        }

        //Correct form
        private Boolean correctForm()
        {
            int errors = 0;
            foreach (Control c in Controls)
            {
                if (c.BackColor == Color.Red) ++errors;
            }
            return (errors == 0);
        }

        private void add_Click(object sender, EventArgs e)
        {
            _contact.setCompanyName(_company.getName());
            if (correctForm())
            {
                if (_control.insertContactCompany(_contact).Equals("OK"))
                {
                    MessageBox.Show("Contact ajouté correctement", "Ajouter contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible d'ajouter. Ce contact existe dejà." + _control.insertContactCompany(_contact), "Ajouter contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Revisez vos champs", "Ajouter contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void modify_Click(object sender, EventArgs e)
        {
            modify.Visible = false;
            clear.Enabled = true;
            confirm.Visible = true;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = true;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (correctForm())
            {
                DialogResult erase = MessageBox.Show("Voulez vous modifier le contact?", "Modifier contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.updateContact(_contact).Equals("OK")) { 
                        MessageBox.Show("Contact modifié correctement", "Modifier contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas possible de modifié. Ce contact existe dejà.", "Modifier contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Revisez vos champs", "Modifier contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            DialogResult erase = MessageBox.Show("Voulez vous suprimer le contact?", "Suprimer contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (erase == DialogResult.OK)
            {
                erase = MessageBox.Show("Voulez vous suprimer DEFINITIVEMENT le contact?", "Suprimer contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.deleteContact(_contact).Equals("OK"))
                    {
                        MessageBox.Show("Contact suprimé correctement.", "Suprimer contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas possible de suprimé le contact.", "Suprimer contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
