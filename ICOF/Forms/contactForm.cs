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
        private Boolean         _wrongForm;

        public contactForm()
        {
            InitializeComponent();
            _checkInput = new ControlModifier();
            _contact = new ContactCompany();
            _control = new Controller();
            _company = new Company();
            _wrongForm = true;
        }

        public void setContact(ContactCompany contact) { _contact = contact; }

        public void setCompany(Company company) { _company = company; }

        public void fillForm(){
            modify.Visible = true;
            add.Visible = false;

            this.Text = "Contact";
            title_LB.Text = "Contact";
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = false;
            }
            firstName_TB.Text = _contact.getcontactFirstName();
            lastName_TB.Text = _contact.getcontactLastName();
            phone_TB.Text = _contact.getPhone();
            email_TB.Text = _contact.getEmail();
            post_TB.Text = _contact.getPost();
        }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String value = tb.Text;

            if (String.IsNullOrEmpty(value)) _checkInput.setWrongColor(tb);
            else
            {
                _checkInput.setCorrectColor(tb);
                _wrongForm = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (_wrongForm) MessageBox.Show("Revisez vos champs", "Ajouter contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //DOES NOT WORK
                _contact.setcontactFirstName(firstName_TB.Text);
                _contact.setcontactLastName(lastName_TB.Text);
                _contact.setPhone(phone_TB.Text);
                _contact.setEmail(email_TB.Text);
                _contact.setCompanyName(_company.getName());
                _contact.setPost(post_TB.Text);

                if (_control.insertContactCompany(_contact).Equals("OK"))
                {
                    MessageBox.Show("Contact ajouté correctement", "Ajouter contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible d'ajouter. Cette remarque existe dejà.", "Ajouter contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            modify.Visible = false;
            confirm.Visible = true;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = true;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(!_wrongForm){
                DialogResult erase = MessageBox.Show("Voulez vous modifier le _contact?", "Modifier _contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    MessageBox.Show("Contact modifié correctement", "Modifier _contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Revisez vos champs", "Modifier contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
