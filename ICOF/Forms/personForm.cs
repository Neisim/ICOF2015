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
using System.Collections;

namespace ICOF
{
    public partial class personForm : Form
    {
        private ControlModifier _checkInput;
        private Controller _control;
        private Person _person;
        private Boolean _wrongForm;
        private Boolean _fill;

        public personForm()
        {
            InitializeComponent();

            _checkInput = new ControlModifier();
            _control = new Controller();
            _wrongForm = true;
            _fill = false;
            _person = new Person();
            _person.setCourseDone("Inconnu");
            _person.setCompanyName("Inconnu");
            _person.setCompanyPost("Inconnu");
            _person.setBirthDate("Inconnu");
            _person.setYearIn("Inconnu");
            _person.setYearOut("Inconnu");
            _person.setDiploma("Inconnu");

            mmemr_CB.Items.Add("Mr");
            mmemr_CB.Items.Add("Mme");
            mmemr_CB.SelectedIndex = 0;

            diploma_CB.Items.Add("Oui");
            diploma_CB.Items.Add("Non");

            courseDone_CB.Enabled = false;
            yearIn_TB.Enabled = false;
            yearOut_TB.Enabled = false;
            diploma_CB.Enabled = false;

            ArrayList courses = _control.getCourses();
            for (int i = 0; i < courses.Count; ++i) courseDone_CB.Items.Add(courses[i]);

            ArrayList posts = _control.getPosts();
            for (int i = 0; i < posts.Count; ++i) postICOF_CB.Items.Add(posts[i]);
            postICOF_CB.SelectedItem = "Enseignant";
        }

        public void setPerson(Person person) { 
            _person = person;
            _fill = true;
        }

        public void fillForm(){

            person_LB.Text = "Personne";
            this.Text = "Resultat recherche";

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = false;
            }

            mmemr_CB.Text =             _person.getMmeMr();
            personLastname_TB.Text =    _person.getLastName();
            personFirstname_TB.Text =   _person.getFirstName();
            personPhone_TB.Text =       _person.getPhone();
            personEmail_TB.Text =       _person.getEmail();
            postICOF_CB.Text =          _person.getIcofPost();
            birthdate_TB.Text =         _person.getBirthDate();
            companyName_TB.Text =       _person.getCompanyName();
            companyPost_TB.Text =       _person.getCompanyPost();
            courseDone_CB.Text =        _person.getCourseDone();
            yearIn_TB.Text =            _person.getYearIn();
            yearOut_TB.Text =           _person.getYearOut();
            diploma_CB.Text =           _person.getDiploma();
        }

        //PostICOF Combobx
        private void postICOF_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_fill) {
                if (postICOF_CB.SelectedItem.Equals("Ancien élève"))
                {
                    courseDone_CB.Enabled = true;
                    courseDone_CB.BackColor = Color.White;

                    yearIn_TB.Enabled = true;
                    yearIn_TB.BackColor = Color.White;

                    yearOut_TB.Enabled = true;
                    yearOut_TB.BackColor = Color.White;

                    diploma_CB.Enabled = true;
                    diploma_CB.BackColor = Color.White;

                    diploma_CB.SelectedIndex = 0;
                    courseDone_CB.SelectedIndex = 0;

                    yearIn_TB.Focus();
                }

                else
                {
                    courseDone_CB.Enabled = false;
                    courseDone_CB.BackColor = SystemColors.ButtonFace;
                    courseDone_CB.SelectedIndex = -1;

                    yearIn_TB.Enabled = false;
                    yearIn_TB.BackColor = SystemColors.ButtonFace;
                    yearIn_TB.Text = "";

                    yearOut_TB.Enabled = false;
                    yearOut_TB.BackColor = SystemColors.ButtonFace;
                    yearOut_TB.Text = "";

                    diploma_CB.Enabled = false;
                    diploma_CB.BackColor = SystemColors.ButtonFace;
                    diploma_CB.SelectedIndex = -1;

                    _person.setCourseDone("");
                    _person.setYearIn(Convert.ToString(DateTime.Now.Year));
                    _person.setYearOut(Convert.ToString(DateTime.Now.Year));
                }

                _person.setIcofPost(postICOF_CB.Text);
            }
        }

        //Control check
        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String name = tb.Name;
            String value = tb.Text;

            if (String.IsNullOrEmpty(value))
            {
                _checkInput.setWrongColor(tb);
                _wrongForm = true;
            }

            else
            {
                _checkInput.setCorrectColor(tb);
                _wrongForm = false;

                Person person = new Person();
                _person.setMmeMR(mmemr_CB.Text);
                _person.setFirstName(personFirstname_TB.Text);
                _person.setLastName(personLastname_TB.Text);
                _person.setPhone(personPhone_TB.Text);
                _person.setEmail(personEmail_TB.Text);
                _person.setIcofPost(postICOF_CB.Text);
            }
        }

        //ClearForm
        private void clearPerson(object sender, EventArgs e)
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
                mmemr_CB.SelectedItem = "Mr";
                postICOF_CB.SelectedItem = "Enseignant";
                diploma_CB.SelectedIndex = -1;
                courseDone_CB.SelectedIndex = -1;

                courseDone_CB.Enabled = false;
                courseDone_CB.BackColor = SystemColors.ButtonFace;

                yearIn_TB.Enabled = false;
                yearIn_TB.BackColor = SystemColors.ButtonFace;

                yearOut_TB.Enabled = false;
                yearOut_TB.BackColor = SystemColors.ButtonFace;

                diploma_CB.Enabled = false;
                diploma_CB.BackColor = SystemColors.ButtonFace;
            }
        }

        //Add
        private void add_Click(object sender, EventArgs e)
        {
            if (_wrongForm) MessageBox.Show("Revisez vos champs", "Ajouter personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Old student
                if (_person.getIcofPost().Equals("Ancien élève"))
                {
                    _person.setCourseDone(courseDone_CB.Text);
                    _person.setYearIn(yearIn_TB.Text);
                    _person.setYearOut(yearOut_TB.Text);
                    _person.setDiploma(diploma_CB.Text);
                }

                else {
                    courseDone_CB.SelectedIndex = -1;
                    diploma_CB.SelectedIndex = -1;
                    yearIn_TB.Text = "";
                    yearOut_TB.Text = "";
                }

                //Optionat data: Birthdate
                if (!String.IsNullOrEmpty(birthdate_TB.Text))
                {
                    _person.setBirthDate(birthdate_TB.Text);
                }

                //Optionat data: Company Name
                if (!String.IsNullOrEmpty(companyName_TB.Text))
                {
                    _person.setCompanyName(companyName_TB.Text);
                }

                //Optional data: Company post
                if (!String.IsNullOrEmpty(companyPost_TB.Text))
                {
                    _person.setCompanyPost(companyPost_TB.Text);
                }

                if (_control.insertPerson(_person).Equals("OK"))
                {
                    MessageBox.Show("Personne ajouté correctement", "Ajouter personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible d'ajouter. Cette persone existe dejà.", "Ajouter personne", MessageBoxButtons.OK, MessageBoxIcon.Error);

                /*MessageBox.Show(_person.getMmeMr() + " " +
                                _person.getLastName() + " " +
                                _person.getFirstName() + " " +
                                _person.getPhone() + " " +
                                _person.getEmail() + " " +
                                _person.getIcofPost() + " " +
                                _person.getBirthDate() + " " +
                                _person.getCompanyName() + " " +
                                _person.getCompanyPost() + " " +
                                _person.getCourseDone() + " " +
                                _person.getYearIn() + " " + 
                                _person.getYearOut() + " " + 
                                _person.getDiploma(), "TO ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
        }
    }
}
