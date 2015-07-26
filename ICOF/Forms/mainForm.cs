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
    /**
     * Represents 
     **/
    public partial class mainForm : Form
    {
        private String      _profile = "Guest";
        private Controller  _control;

        public mainForm()
        {
            InitializeComponent();
            this.Text += " - Invité";
            _control = new Controller();
            companyDGV.Visible = false;
            personDGV.Visible = false;            
        }

        //Gets the user logged in
        public String getUser() { return _profile; }

        //CloseForm event 
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        //Shows the person form to add
        private void addPersonMenuItem_Click(object sender, EventArgs e)
        {
            personForm person = new personForm();
            person.ShowDialog();
            personDGV.DataSource = _control.getPersons();
            personDGV.Visible = true; 
        }

        //Shows the company form to add
        private void addCompanyMenuItem_Click(object sender, EventArgs e)
        {
            companyForm company = new companyForm();
            company.ShowDialog();
            companyDGV.DataSource = _control.getCompanies();
            companyDGV.Visible = true;
        }

        //Closes the application
        private void close_form(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult exit = MessageBox.Show(this, "Voulez vous sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exit == DialogResult.No) e.Cancel = true;
            }
        }

        //Shows the acces form
        private void access_form(object sender, EventArgs e)
        {
            accessForm acces = new accessForm();
            acces.ShowDialog();
            _profile = acces.getProfile();
            this.Text = "Annuaire ICOF - " + _profile;

            if (!_profile.Equals("Guest"))
            {
                profile.Visible = true;
                data.Visible = true;

                companyDGV.Columns["payed_TA"].Visible = true;
                companyDGV.Columns["payed_TA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                companyDGV.Columns["current_year"].Visible = true;
                companyDGV.Columns["current_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                companyDGV.Columns["previous_year"].Visible = true;
                companyDGV.Columns["previous_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                companyDGV.Columns["previous_TA"].Visible = true;
                companyDGV.Columns["previous_TA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                companyDGV.Columns["company_activity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                companyDGV.Columns["previous_TA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            else
            {
                profile.Visible = false;
                data.Visible = false;
            }
        }

        //Shows the change password form
        private void changePassword_Click(object sender, EventArgs e)
        {
            changePasswordForm newPassword = new changePasswordForm();
            newPassword.setUser(_profile);
            newPassword.ShowDialog();
        }

        //Shows the personDGV
        private void searchPerson_Click(object sender, EventArgs e)
        {
            Controller control = new Controller();
            personDGV.AutoGenerateColumns = false;
            personDGV.DataSource = control.getPersons();
            personDGV.Visible = true;
            companyDGV.Visible = false;
        }

        //Shows the companyDGV
        private void searchCompany_Click(object sender, EventArgs e)
        {
            Controller control = new Controller();
            companyDGV.DataSource = control.getCompanies();
            if (_profile.Equals("Guest"))
            {
                payed_TA.Visible = false;
                companyDGV.Columns["payed_TA"].Visible = false;
                companyDGV.Columns["current_year"].Visible = false;
                companyDGV.Columns["current_TA"].Visible = false;
                companyDGV.Columns["previous_year"].Visible = false;
                companyDGV.Columns["previous_TA"].Visible = false;
                companyDGV.Columns["company_activity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            else
            {
                companyDGV.Columns["payed_TA"].Visible = true;
                companyDGV.Columns["current_year"].Visible = true;
                companyDGV.Columns["previous_year"].Visible = true;
                companyDGV.Columns["previous_TA"].Visible = true;
                company_activity.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                previous_TA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
                companyDGV.Visible = true;
                personDGV.Visible = false;
        }

        //Opens a _company form with the data of a _company
        private void getCompany(object sender, DataGridViewCellEventArgs e)
        {
            String year = DateTime.Now.Year.ToString();
            int current_year = Convert.ToInt32(year);
            int previous_year = current_year - 1;

            double current_TA = 0.0;
            double previous_TA = 0.0;

            int id =            Convert.ToInt32(companyDGV.CurrentRow.Cells["company_id"].Value);
            String name =       Convert.ToString(companyDGV.CurrentRow.Cells["company_name"].Value);
            String address =    Convert.ToString(companyDGV.CurrentRow.Cells["company_address"].Value);
            String phone =      Convert.ToString(companyDGV.CurrentRow.Cells["company_phone"].Value);
            String email =      Convert.ToString(companyDGV.CurrentRow.Cells["company_email"].Value);
            String fax =        Convert.ToString(companyDGV.CurrentRow.Cells["fax"].Value);
            String activity =   Convert.ToString(companyDGV.CurrentRow.Cells["company_activity"].Value);
            String payed_TA =   Convert.ToString(companyDGV.CurrentRow.Cells["payed_TA"].Value);
            Boolean TA = payed_TA.Equals("Yes");

            if (TA)
            {
                current_year =  Convert.ToInt32(companyDGV.CurrentRow.Cells["current_year"].Value);
                current_TA =    Convert.ToDouble(companyDGV.CurrentRow.Cells["current_TA"].Value);
                previous_year = Convert.ToInt32(companyDGV.CurrentRow.Cells["previous_year"].Value);
                previous_TA =   Convert.ToDouble(companyDGV.CurrentRow.Cells["previous_TA"].Value);
            }

            Company company = new Company(id, name, address, phone, email, fax, activity, TA, current_year, current_TA, previous_year, previous_TA);
      
            companyFoundForm companyForm = new companyFoundForm();
            companyForm.setCompany(company, _profile);
            companyForm.fillForm();
            companyForm.Enabled = true;
            companyForm.ShowDialog();
            companyDGV.DataSource = _control.getCompanies();
        }

        //Opens a _person form with the data of a _person
        private void getPerson(object sender, DataGridViewCellEventArgs e)
        {
            int id =                Convert.ToInt32(personDGV.CurrentRow.Cells["person_id"].Value);
            String mmmr =           Convert.ToString(personDGV.CurrentRow.Cells["mrmm"].Value);
            String lastName =       Convert.ToString(personDGV.CurrentRow.Cells["person_lastname"].Value);
            String firstName =      Convert.ToString(personDGV.CurrentRow.Cells["person_firstname"].Value);
            String phone =          Convert.ToString(personDGV.CurrentRow.Cells["person_phone"].Value);
            String email =          Convert.ToString(personDGV.CurrentRow.Cells["person_email"].Value);
            String icofPost =       Convert.ToString(personDGV.CurrentRow.Cells["icofPost"].Value);
            String companyName =    Convert.ToString(personDGV.CurrentRow.Cells["companyName"].Value);
            String companyPost =    Convert.ToString(personDGV.CurrentRow.Cells["companyPost"].Value);
            String birthDate =      Convert.ToString(personDGV.CurrentRow.Cells["birth_date"].Value);
            String courseDone =     Convert.ToString(personDGV.CurrentRow.Cells["courseDone"].Value);
            String yearIn =         Convert.ToString(personDGV.CurrentRow.Cells["yearIn"].Value);
            String yearOut =        Convert.ToString(personDGV.CurrentRow.Cells["yearOut"].Value);
            String diploma =        Convert.ToString(personDGV.CurrentRow.Cells["Diploma"].Value);

            Person person = new Person(id, mmmr, firstName, lastName, phone, email, icofPost, companyName, companyPost, birthDate, courseDone, yearIn, yearOut, diploma);
            
            personForm personForm = new personForm();
            personForm.setPerson(person, _profile);
            personForm.fillForm();
            personForm.ShowDialog();
            personDGV.DataSource = _control.getPersons();
        }
    }
}
