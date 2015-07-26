using System;
using System.Collections;
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
    public partial class studentForm : Form
    {
        private Controller      _control;
        private TrainingStudent _student;
        private ControlModifier _checkInput;
        private Company         _company;
       
        public studentForm()
        {
            InitializeComponent();
            this.Size = new Size(668, 469);
            _control = new Controller();
            _checkInput = new ControlModifier();
            _student = new TrainingStudent();

            ArrayList courses = _control.getCourses();
            for (int i = 0; i < courses.Count; ++i) courseDone_CB.Items.Add(courses[i]);

            courseDone_CB.SelectedIndex = 0;
            deleteStudent.Visible = false;
        }

        private void outControl(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String name = tb.Name;
            String value = tb.Text;

            if (String.IsNullOrEmpty(value))
            {
                _checkInput.setWrongColor(tb);
            }
            else
            {
                switch (name)
                {
                    case "firstName_TB":
                        _student.setFirstName(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "lastName_TB":
                        _student.setLastName(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "jobYear_TB":
                        try
                        {
                            if (Convert.ToInt32(value) <= 0) _checkInput.setWrongColor(tb);
                            else
                            {
                                _student.setJobYear(Convert.ToInt32(value));
                                _checkInput.setCorrectColor(tb);
                            }
                        }
                        catch (FormatException)
                        {
                            _checkInput.setWrongColor(tb);
                        }
                        break;

                    case "teacherFirstname_TB":
                        _student.setTeacherFirstName(value);
                        _checkInput.setCorrectColor(tb);
                        break;

                    case "teacherLastname_TB":
                        _student.setTeacherLastName(value);
                        _checkInput.setCorrectColor(tb);
                        break;
                }
            }
           
        }

        public void setStudent(TrainingStudent student){
            _student = student;
        }

        public void setCompany(Company company){
            _company = company; 
        }

        public void fillForm()
        {
            this.Size = new Size(668, 510);
            add.Visible = false;
            modifyStudent.Visible = true;
            deleteStudent.Visible = true;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = false;
            }

            this.Text = "Élève en stage";
            title_LB.Text = "Élève en stage";
            lastName_TB.Text = _student.getFirstName();
            firstName_TB.Text = _student.getLastName();
            jobYear_TB.Text = Convert.ToString(_student.getJobYear());
            courseDone_CB.Text = _student.getCourseName();
            teacherFirstname_TB.Text = _student.getTeacherFirstName();
            teacherLastname_TB.Text = _student.getTeacherLastName();
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

        private void add_Click(object sender, EventArgs e)
        {
            if (correctForm()) 
            {
                _student.setCompanyName(_company.getName());
                _student.setCourseName(courseDone_CB.Text);

                if (_control.insertTrainingStudent(_student).Equals("OK"))
                {
                    MessageBox.Show("Élève en stage ajouté correctement", "Ajouter élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible d'ajouter. L'élève existe deja.", "Ajouter élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }            
            else MessageBox.Show("Pas possible d'ajouter. Revisez votre formulaire.", "Ajouter élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clear_Click(object sender, EventArgs e)
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
                courseDone_CB.SelectedIndex = -1;
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            modifyStudent.Visible = false;
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
                DialogResult erase = MessageBox.Show("Voulez vous modifier l'élève?", "Modifier élève en stage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.updateStudent(_student).Equals("OK"))
                    {
                        MessageBox.Show("Élève modifié correctement", "Modifier élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas posible de modifier l'élève modifié: il existe dejà.", "Modifier élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Pas possible de modifier. Revisez votre formulaire.", "Modifier élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult erase = MessageBox.Show("Voulez vous suprimer l'élève?", "Suprimer élève en stage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (erase == DialogResult.OK)
            {
                erase = MessageBox.Show("Voulez vous suprimer DEFINITIVEMENT l'élève?", "Suprimer élève en stage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.deleteStudent(_student).Equals("OK"))
                    {
                        MessageBox.Show("Élève suprimé correctement.", "Suprimer élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas possible de suprimé l'élève.", "Suprimer élève en stage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
