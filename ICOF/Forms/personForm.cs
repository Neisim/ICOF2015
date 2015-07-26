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
        private Controller      _control;
        private Person          _person;
        private Boolean         _fill;
        private String          _profile;

        public personForm()
        {
            InitializeComponent();
            this.Size = new Size(1026, 495);
            deletePerson.Visible = false;

            _checkInput = new ControlModifier();
            _control = new Controller();
            _fill = false;
            _person = new Person();
            _person.setCourseDone("Inconnu");
            _person.setCompanyName("Inconnu");
            _person.setCompanyPost("Inconnu");
            _person.setBirthDate("Inconnu");
            _person.setYearIn("Inconnu");
            _person.setYearOut("Inconnu");
            _person.setDiploma("Non");

            mmemr_CB.Items.Add("Mr");
            mmemr_CB.Items.Add("Mme");
            mmemr_CB.SelectedItem = "Mr";

            diploma_CB.Items.Add("Oui");
            diploma_CB.Items.Add("Non");
            diploma_CB.SelectedItem = "Non";

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

        public void setPerson(Person person, String profile) { 
            _person = person;
            _profile = profile;
            _fill = true;
        }

        //Fill form with data
        public void fillForm(){

            this.Size = new Size(1026, 539);
            deletePerson.Visible = true;
            add.Visible = false;
            clear.Enabled = false;
            person_LB.Text = "Personne";
            this.Text = "Resultat recherche";
            MessageBox.Show("Person ID: " + _person.getID());

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = false;
            }

            mmemr_CB.Text =             _person.getMmeMr();
            lastName_TB.Text =          _person.getLastName();
            firstName_TB.Text =         _person.getFirstName();
            phone_TB.Text =             _person.getPhone();
            email_TB.Text =             _person.getEmail();
            postICOF_CB.Text =          _person.getIcofPost();
            birthdate_TB.Text =         _person.getBirthDate();
            companyName_TB.Text =       _person.getCompanyName();
            companyPost_TB.Text =       _person.getCompanyPost();
            courseDone_CB.Text =        _person.getCourseDone();
            yearIn_TB.Text =            _person.getYearIn();
            yearOut_TB.Text =           _person.getYearOut();
            diploma_CB.Text =           _person.getDiploma();

            if (_profile.Equals("Secretariat"))
            {
                this.Size = new Size(1026, 539);
                modify.Visible = true;
                clear.Visible = true;
                deletePerson.Visible = true;
            }

            else
            {
                this.Size = new Size(1026, 389);
                add.Visible = false;
                modify.Visible = false;
                deletePerson.Visible = false;
                confirm.Visible = false;
                clear.Visible = false;
            }
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

                    yearOut_TB.Focus();
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

            if (String.IsNullOrEmpty(value) && !name.Equals("yearIn_TB") && !name.Equals("birthdate_TB")) 
            {
                _checkInput.setWrongColor(tb);
            }

            else if (name.Equals("birthdate_TB"))
            {
                if (!String.IsNullOrEmpty(value))
                {
                    try
                    {
                        int birth = Convert.ToInt32(value);
                        if (birth <= 0 || birth >= 2100) _checkInput.setWrongColor(tb);
                        else
                        {
                            _person.setBirthDate(Convert.ToString(birth));
                            _checkInput.setCorrectColor(tb);
                        }
                    }
                    catch (FormatException)
                    {
                        _checkInput.setWrongColor(tb);
                    }
                }
            }

            else if (name.Equals("yearIn_TB"))
            {
                if (!String.IsNullOrEmpty(value))
                {
                    try
                    {
                        int yearIn = Convert.ToInt32(yearIn_TB.Text);
                        if (yearIn <= 0 || yearIn > 2100) _checkInput.setWrongColor(tb);
                        else {
                            _person.setYearIn(Convert.ToString(yearIn));
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
                    case "firstName_TB":
                        _person.setFirstName(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "lastName_TB":
                        _person.setLastName(value);
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
                                _person.setPhone(value);
                                _checkInput.setCorrectColor(tb);
                            }
                        }
                        catch (FormatException)
                        {
                            _checkInput.setWrongColor(tb);
                        }
                        break;

                    case "email_TB":
                        _person.setEmail(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "yearOut_TB":
                        try
                        {
                            int yearOut = Convert.ToInt32(value);
                            if (yearOut <= 0 || yearOut > 2100) _checkInput.setWrongColor(tb);
                            else
                            {
                                _person.setYearOut(Convert.ToString(yearOut));
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
            _person.setMmeMR(mmemr_CB.Text);
            //if ancien eleve, get year out 
            if (postICOF_CB.SelectedItem.Equals("Ancien élève"))
            {
                //course done
                _person.setCourseDone(courseDone_CB.Text);

                //year in
                if (!String.IsNullOrEmpty(yearIn_TB.Text))
                {
                    try
                    {
                        int yearIn = Convert.ToInt32(yearIn_TB.Text);
                        if (yearIn <= 0) _checkInput.setWrongColor(yearIn_TB);
                        else
                        {
                            _person.setYearOut(Convert.ToString(yearIn));
                            _checkInput.setCorrectColor(yearOut_TB);
                        }
                    }
                    catch (FormatException)
                    {
                        _checkInput.setWrongColor(yearIn_TB);
                    }
                }

                //diploma
                _person.setDiploma(diploma_CB.Text);
            }
            //else get optional data
            if (!String.IsNullOrEmpty(birthdate_TB.Text))   _person.setBirthDate(birthdate_TB.Text);
            if (!String.IsNullOrEmpty(companyName_TB.Text)) _person.setCompanyName(companyName_TB.Text);
            if (!String.IsNullOrEmpty(companyPost_TB.Text)) _person.setCompanyPost(companyPost_TB.Text);

            MessageBox.Show("Mmr "  + _person.getMmeMr() +
                            " Firstname: " + _person.getFirstName() +
                            " Lastname: "  + _person.getLastName() +
                            " Phone: " +     _person.getPhone() +
                            " Email: " +     _person.getEmail() +
                            " ICOF Poste: " + _person.getIcofPost() +
                            " Company name: " + _person.getCompanyName() +
                            " Company poste: " + _person.getCompanyPost() +
                            " Birthdate: " + _person.getBirthDate() +
                            " Course done: " + _person.getCourseDone() +
                            " Year In: " + _person.getYearIn() +
                            " Year Out: " + _person.getYearOut() +
                            " Diploma: " + _person.getDiploma()
                            );
            if (correctForm()) 
            {
                if (_control.insertPerson(_person).Equals("OK"))
                {
                    MessageBox.Show(_person.getIcofPost() + " ajouté correctement", "Ajouter " + _person.getIcofPost().ToLower(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else MessageBox.Show("Pas possible d'ajouter. Ce " + _person.getIcofPost().ToLower() + " existe dejà.", "Ajouter " + _person.getIcofPost(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Revisez vos champs", "Ajouter " + _person.getIcofPost().ToLower(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Modify
        private void modifyPerson_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (!c.Name.Equals("yearOut_TB") && !c.Name.Equals("yearIn_TB")) c.Enabled = true;
                    if (c.Text.Equals("Inconnu")) c.Text = "";
                }
            }

            _fill = false;
            postICOF_CB.Enabled = true;
            mmemr_CB.Enabled = true;
            clear.Enabled = true;
            confirm.Visible = true;
            modify.Visible = false;
        }

        //Confirm modification
        private void confirm_Click(object sender, EventArgs e)
        {
            _person.setMmeMR(mmemr_CB.Text);
            //if ancien eleve, get year out 
            if (postICOF_CB.SelectedItem.Equals("Ancien élève"))
            {
                //course done
                _person.setCourseDone(courseDone_CB.Text);

                //year in
                if (!String.IsNullOrEmpty(yearIn_TB.Text))
                {
                    try
                    {
                        int yearIn = Convert.ToInt32(yearIn_TB.Text);
                        if (yearIn <= 0) _checkInput.setWrongColor(yearIn_TB);
                        else
                        {
                            _person.setYearOut(Convert.ToString(yearIn));
                            _checkInput.setCorrectColor(yearOut_TB);
                        }
                    }
                    catch (FormatException)
                    {
                        _checkInput.setWrongColor(yearIn_TB);
                    }
                }

                //diploma
                _person.setDiploma(diploma_CB.Text);
            }

            if (correctForm())
            {
                MessageBox.Show("Mmr " + _person.getMmeMr() +
                            " Firstname: " + _person.getFirstName() +
                            " Lastname: " + _person.getLastName() +
                            " Phone: " + _person.getPhone() +
                            " Email: " + _person.getEmail() +
                            " ICOF Poste: " + _person.getIcofPost() +
                            " Company name: " + _person.getCompanyName() +
                            " Company poste: " + _person.getCompanyPost() +
                            " Birthdate: " + _person.getBirthDate() +
                            " Course done: " + _person.getCourseDone() +
                            " Year In: " + _person.getYearIn() +
                            " Year Out: " + _person.getYearOut() +
                            " Diploma: " + _person.getDiploma()
                            );
                if (_control.updatePerson(_person).Equals("OK"))
                {
                    MessageBox.Show(_person.getIcofPost() + " modifié correctement", "Modifier " + _person.getIcofPost(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible de modifié. Ce " + _person.getIcofPost() + " existe dejà.", "Modifier " + _person.getIcofPost(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Revisez vos champs", "Modifier " + _person.getIcofPost(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Delete
        private void deletePerson_Click(object sender, EventArgs e)
        {
            DialogResult erase = MessageBox.Show("Voulez vous suprimer la personne?", "Suprimer personne", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (erase == DialogResult.OK)
            {
                erase = MessageBox.Show("Voulez vous suprimer DEFINITIVEMENT la personne?", "Suprimer personne", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.deletePerson(_person).Equals("OK"))
                    {
                        MessageBox.Show("Personne suprimé correctement.", "Suprimer personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas possible de suprimé la personne.", "Suprimer personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
