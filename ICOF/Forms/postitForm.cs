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
    public partial class postItForm : Form
    {
        private ControlModifier _checkInput;
        private Controller      _control;
        private Boolean         _wrongForm;
        private PostIt          _postIt;

        public postItForm()
        {
            InitializeComponent();
            _checkInput = new ControlModifier();
            _control = new Controller();
            _wrongForm = true;
            _postIt = new PostIt();
        }

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
                _postIt.setFromName(from_TB.Text);
                _postIt.setToName(to_TB.Text);
                _postIt.setSubject(subject_TB.Text);
                _postIt.setNotes(notes_TB.Text);
                _postIt.setPhone("124");
            }
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
            if (_wrongForm) MessageBox.Show("Revisez vos champs", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (_control.insertPostIt(_postIt).Equals("OK"))
                {
                    MessageBox.Show("Remarque ajouté correctement", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Pas possible d'ajouter. Cette remarque existe dejà.", "Ajouter remarque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
