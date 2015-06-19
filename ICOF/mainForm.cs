using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICOF
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void exit(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Voulez vous sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit != DialogResult.No)
            {
                this.Close();
            }
        }

        private void personneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPersonForm ajouter = new addPersonForm();
            ajouter.Show();
        }
    }
}
