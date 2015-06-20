using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICOF
{
    class ControlChecker
    {
        public void controlCheck(TextBox control)
        {
            string name = control.Name;
            string text = control.Text;
            switch (name)
            {
                /*ACCESS FORM*/
                case "userTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "passwordTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                /*PERSONNE FORM*/
                case "nomTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "prenomTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "emailTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "telephoneTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "entreeTB":
                    if (text.Equals("") || Int32.Parse(text) <= 0) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "sortieTB":
                    if (text.Equals("") || Int32.Parse(text) <= 0) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                /*ENTREPRISE FORM*/
                case "nom_entTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "adresseTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "email_entTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "telephone_entTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "activiteTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "montantTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "anneeTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "annee_stageTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;

                /*REMARQUE FORM*/
                case "de_contacteTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "a_contacteTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
                case "objetTB":
                    if (text.Equals("")) changeColorWrong(control);
                    else changeColorCorrect(control);
                    break;
            }
        }

        private void changeColorWrong(TextBox control) {
            control.BackColor = Color.Red;
            control.ForeColor = Color.White;
        }

        private void changeColorCorrect(TextBox control)
        {
            control.BackColor = Color.White;
            control.ForeColor = Color.Black;
        }
    }
}
