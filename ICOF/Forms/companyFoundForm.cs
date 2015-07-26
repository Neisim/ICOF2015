using ICOF.Forms;
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
    public partial class companyFoundForm : Form
    {
        private Company         _company;
        private String          _profile;
        private Controller      _control;
        private ControlModifier _checkInput;
        private TabPage         _postIt;
        
        public companyFoundForm()
        {
            InitializeComponent();
            
            taxe_CB.Items.Add("Oui");
            taxe_CB.Items.Add("Non");
            taxe_CB.SelectedItem = "Non";
            _postIt = data_TAB.TabPages[data_TAB.TabPages.IndexOf(postIt)];
            _checkInput = new ControlModifier();
            _control = new Controller();
            _company = new Company();
        }

        public void setCompany(Company company, String profile) {
            _company = company;
            _profile = profile;
        }

        private void placeAt(Control control, Point point, Boolean visible)
        {
            control.Location = new Point(point.X, point.Y);
            control.Visible = true;
        }

        public void fillForm()
        {
            clearForm.Enabled = false;
            
            if (_profile.Equals("Secretariat"))
            {
                addContact.Visible = true;
                contactDGV.Size = new Size(996, 156);
                
                addStudentTraining.Visible = true;
                studentsTrainingDGV.Size = new Size(996, 156);
                
                addPostIt.Visible = true;
                postItDGV.Size = new Size(996, 156);

                this.Size = new Size(1118, 741);
            }

            else
            {
                //TabControl
                data_TAB.TabPages.Remove(_postIt);
                placeAt(data_TAB, new Point(phone.Location.X, phone.Location.Y + 45), true);

                //Email
                placeAt(email_LB, new Point(558, 114), true);
                placeAt(email_TB, new Point(currentYear_TB.Location.X, currentYear_TB.Location.Y), true);
                email_TB.Width = fax_TB.Size.Width;

                //Activity
                placeAt(activity_LB, new Point(currentTA_LB.Location.X, currentTA_LB.Location.Y), true);
                placeAt(activity_TB, new Point(currentTA_TB.Location.X, currentTA_TB.Location.Y), true);
                activity_TB.Width = fax_TB.Size.Width;

                taxe_LB.Visible = false;
                taxe_CB.Visible = false;

                currentYear_LB.Visible = false;
                currentYear_TB.Visible = false;
                currentTA_LB.Visible = false;
                currentTA_TB.Visible = false;

                previousYear_LB.Visible = false;
                previousYear_TB.Visible = false;

                previousTA_LB.Visible = false;
                previousTA_TB.Visible = false;

                addContact.Visible = false;
                contactDGV.Size = new Size(996, 199);

                addStudentTraining.Visible = false;
                studentsTrainingDGV.Size = new Size(996, 199);

                addPostIt.Visible = false;
                postItDGV.Size = new Size(996, 199);

                this.Size = new Size(1118, 501);
            }

            this.Text = "Resultat de la recherche - " + _company.getName();
            //Basic data
            companyName_TB.Text =       _company.getName();
            companyAddress_TB.Text =    _company.getAddress();
            companyPhone_TB.Text =      _company.getPhone();
            email_TB.Text =             _company.getEmail();
            activity_TB.Text =          _company.getActivity();
            
            //Taxe apprentissage
            if (_company.getTaxe()) taxe_CB.SelectedItem = "Oui";
            currentYear_TB.Text =   Convert.ToString(_company.getCurrentYear());
            currentTA_TB.Text =     Convert.ToString(_company.getCurrentTA()) + " €";
            previousYear_TB.Text =  Convert.ToString(_company.getPreviousYear());
            previousTA_TB.Text =    Convert.ToString(_company.getPreviousTA() + " €");

            //FAX
            if (!_company.getFAX().Equals("")) fax_TB.Text = _company.getFAX();
            else fax_TB.Text = "Pas de FAX";

            //Contacts DGV
            contactDGV.AutoGenerateColumns = false;
            contactDGV.DataSource = _control.getContacts(_company);
            if (contactDGV.RowCount == 0) contactsResult.Visible = true;
                
            //Training Students DGV
            studentsTrainingDGV.AutoGenerateColumns = false;
            studentsTrainingDGV.DataSource = _control.getTrainingStudents(_company);
 
            //PostIt DGV
            postItDGV.AutoGenerateColumns = false;
            postItDGV.DataSource = _control.getPostIt(_company);
            if (postItDGV.RowCount == 0) postItResult.Visible = true;
            else postItResult.Visible = false;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = false;
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

        //show the contact form
        private void addContact_Click(object sender, EventArgs e)
        {
            contactForm contact = new contactForm();
            contact.setCompany(_company);
            contact.ShowDialog();
            contactDGV.DataSource = _control.getContacts(_company);
            if(contactDGV.RowCount == 0) contactsResult.Visible = true;
            else contactsResult.Visible = false;
        }

        //shows the student form
        private void addStudentTraining_Click(object sender, EventArgs e)
        {
            studentForm student = new studentForm();
            student.setCompany(_company);
            student.ShowDialog();
            studentsTrainingDGV.DataSource = _control.getTrainingStudents(_company);
            if (studentsTrainingDGV.RowCount == 0) studentsResult.Visible = true;
            else studentsResult.Visible = false;
        }

        //show the post it form
        private void addPostIt_Click(object sender, EventArgs e)
        {
            postItForm postIt = new postItForm();
            postIt.setCompany(_company);
            postIt.ShowDialog();
            postItDGV.DataSource = _control.getPostIt(_company);
            if (postItDGV.RowCount == 0) postItResult.Visible = true;
            else postItResult.Visible = false;
        }

        //show the contact form filled
        private void getContact(object sender, EventArgs e)
        {
            if (_profile.Equals("Secretariat"))
            {
                String companyName = _company.getName();
                int id =            Convert.ToInt32(contactDGV.CurrentRow.Cells["contact_id"].Value);
                String lastName =   Convert.ToString(contactDGV.CurrentRow.Cells["contact_lastname"].Value);
                String firstName =  Convert.ToString(contactDGV.CurrentRow.Cells["contact_firstname"].Value);
                String phone =      Convert.ToString(contactDGV.CurrentRow.Cells["direct_phone"].Value);
                String email =      Convert.ToString(contactDGV.CurrentRow.Cells["email"].Value);
                String post =       Convert.ToString(contactDGV.CurrentRow.Cells["post"].Value);
                ContactCompany contactToShow = new ContactCompany(id, companyName, firstName, lastName, phone, email, post);

                contactForm contact = new contactForm();
                contact.setContact(contactToShow);
                contact.Enabled = true;
                contact.fillForm();
                contact.ShowDialog();
                contactDGV.DataSource = _control.getContacts(_company);
                if (contactDGV.RowCount == 0) contactsResult.Visible = true;
             }
        }

        //shows the student form filled
        private void getStudent(object sender, DataGridViewCellEventArgs e)
        {
            if (_profile.Equals("Secretariat"))
            {
                int id =                    Convert.ToInt32(studentsTrainingDGV.CurrentRow.Cells["student_id"].Value);
                String firstName =          Convert.ToString(studentsTrainingDGV.CurrentRow.Cells["student_firstname"].Value);
                String lastName =           Convert.ToString(studentsTrainingDGV.CurrentRow.Cells["student_lastname"].Value);
                int job_year =              Convert.ToInt32(studentsTrainingDGV.CurrentRow.Cells["job_year"].Value);
                String course_name =        Convert.ToString(studentsTrainingDGV.CurrentRow.Cells["course_name"].Value);
                String teacherFirstName =   Convert.ToString(studentsTrainingDGV.CurrentRow.Cells["teacher_lastname"].Value);
                String teacherLastName =    Convert.ToString(studentsTrainingDGV.CurrentRow.Cells["teacher_firstname"].Value);
                TrainingStudent studentToShow = new TrainingStudent(id, firstName, lastName, _company.getName(), job_year, course_name, teacherFirstName, teacherLastName);

                studentForm student = new studentForm();
                student.setStudent(studentToShow);
                student.Enabled = true;
                student.fillForm();
                student.ShowDialog();
                studentsTrainingDGV.DataSource = _control.getTrainingStudents(_company);
                if (studentsTrainingDGV.RowCount == 0) studentsResult.Visible = true;
            }
        }

        //show the post it form filled
        private void getPostIt(object sender, DataGridViewCellEventArgs e)
        {
            if (_profile.Equals("Secretariat"))
            {
                int id = Convert.ToInt32(postItDGV.CurrentRow.Cells["post_it_id"].Value);
                String from = Convert.ToString(postItDGV.CurrentRow.Cells["to_name"].Value);
                String to = Convert.ToString(postItDGV.CurrentRow.Cells["from_name"].Value);
                String date = Convert.ToString(postItDGV.CurrentRow.Cells["date"].Value);
                String subject = Convert.ToString(postItDGV.CurrentRow.Cells["subject"].Value);
                String notes = Convert.ToString(postItDGV.CurrentRow.Cells["notes"].Value);

                PostIt postIt = new PostIt(id, from, to, date, subject, notes, _company.getPhone());
                postItForm postItForm = new postItForm();
                postItForm.setPostIt(postIt, _company, _profile);
                postItForm.fillForm();
                postItForm.ShowDialog();
                postItDGV.DataSource = _control.getPostIt(_company);
                if (postItDGV.RowCount == 0) postItResult.Visible = true;
            }
        }

        private void modifyCompany_Click(object sender, EventArgs e)
        {
            confirm.Visible = true;
            modifyCompany.Visible = false;
            clearForm.Visible = true;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = true;
            }

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (correctForm())
            {
                Boolean taxe = taxe_CB.Text.Equals("Oui");
                _company.setTaxe(taxe);
                DialogResult erase = MessageBox.Show("Voulez vous modifier l'entreprise?", "Modifier entreprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.updateCompany(_company).Equals("OK"))
                    {
                        MessageBox.Show("Entreprise modifié correctement", "Modifier entreprise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas posible de modifier l'entreprise", "Modifier entreprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Revisez vos champs", "Modifier entreprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteCompany_Click(object sender, EventArgs e)
        {
            DialogResult erase = MessageBox.Show("Voulez vous suprimer l'entreprise avec touts les contacts, élèves en stage et remarques?", "Suprimer entreprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (erase == DialogResult.OK)
            {
                erase = MessageBox.Show("Voulez vous suprimer DEFINITIVEMENT Voulez vous suprimer l'entreprise avec touts les contacts, élèves en stage et remarques?", "Suprimer entreprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.deleteCompany(_company).Equals("OK"))
                    {
                        MessageBox.Show("Entreprise suprimé correctement.", "Suprimer entreprise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas possible de suprimé l'entreprise.", "Suprimer entreprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void taxe_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taxe_CB.Text.Equals("Non"))
            {
                currentTA_TB.Text = "0.0";
                currentTA_TB.Enabled = false;
                currentYear_TB.Text = Convert.ToString(DateTime.Now.Year);
                currentYear_TB.Enabled = false;

                previousTA_TB.Text = "0.0";
                previousTA_TB.Enabled = false;
                previousYear_TB.Text = Convert.ToString(DateTime.Now.Year);
                previousYear_TB.Enabled = false;

            }

            else {
                currentTA_TB.Enabled = true;
                currentYear_TB.Enabled = true;

                previousTA_TB.Enabled = true;
                previousYear_TB.Enabled = true;
            }
        }
    }
}
