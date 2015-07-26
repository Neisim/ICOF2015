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
using System.Globalization;

namespace ICOF
{
    public partial class postItForm : Form
    {
        private ControlModifier _checkInput;
        private Controller      _control;
        private Boolean         _wrongForm;
        private PostIt          _postIt;
        private String          _profile;
        private Company         _company;

        public postItForm()
        {
            InitializeComponent();
            _checkInput = new ControlModifier();
            _control = new Controller();
            _wrongForm = true;
            _postIt = new PostIt();
            _company = new Company();
        }

        public void setCompany(Company company)
        {
            _company = company;
        }

        public void setPostIt(PostIt postIt, Company company, String profile)
        {
            _postIt = postIt;
            _company = company;
            _profile = profile;
        }

        public void fillForm()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = false;
            }
            dateDP.Enabled = false;

            this.Text = "Remarque";
            postIt_LB.Text = "Remarque";
            from_TB.Text =      _postIt.getFromName();
            to_TB.Text =        _postIt.getToName();
            subject_TB.Text =   _postIt.getSubject();
            notes_TB.Text =     _postIt.getNotes();
            IFormatProvider culture = new CultureInfo("fr-FR", true);
            dateDP.Value = DateTime.Parse(_postIt.getPostItDate(), culture, DateTimeStyles.NoCurrentDateDefault);
            add.Visible = false;
            clear.Visible = false;
            modifyPostIt.Visible = true;
            deletePostIt.Location = new Point(157, 451);
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
                _checkInput.setCorrectColor(tb);
                _postIt.setFromName(from_TB.Text);
                _postIt.setToName(to_TB.Text);
                _postIt.setSubject(subject_TB.Text);
                _postIt.setPostItDate(dateDP.Value.ToString("yyyy-MM-dd"));
                _postIt.setPhone(_company.getPhone());
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

        private void clearPostIt(object sender, EventArgs e)
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
                dateDP.Value = DateTime.Today;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(correctForm()){
                if(!String.IsNullOrEmpty(notes_TB.Text)) _postIt.setNotes(notes_TB.Text);
                if (_control.insertPostIt(_postIt).Equals("OK"))
                {
                    MessageBox.Show("Remarque ajouté correctement", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible d'ajouter. Cette remarque existe dejà.", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Pas possible d'ajouter. Revisez votre formulaire.", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void modifyPostIt_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox)) c.Enabled = true;
            }
            dateDP.Enabled = true;
            confirm.Visible = true;
            clear.Visible = true;
            modifyPostIt.Visible = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (correctForm())
            {
                if (!String.IsNullOrEmpty(notes_TB.Text)) _postIt.setNotes(notes_TB.Text);
                if (_control.updatePostIt(_postIt).Equals("OK"))
                {
                    MessageBox.Show("Remarque modifié correctement", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible de modifié. Cette remarque existe dejà.", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Pas possible de modifié. Revisez votre formulaire.", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deletePostIt_Click(object sender, EventArgs e)
        {
            DialogResult erase = MessageBox.Show("Voulez vous suprimer la remarque?", "Suprimer remarque", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (erase == DialogResult.OK)
            {
                erase = MessageBox.Show("Voulez vous suprimer DEFINITIVEMENT la remarque?", "Suprimer remarque", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (erase == DialogResult.OK)
                {
                    if (_control.deletePostIt(_postIt).Equals("OK"))
                    {
                        MessageBox.Show("Remarque suprimé correctement.", "Suprimer remarque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Pas possible de suprimé la remarque.", "Suprimer remarque", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
