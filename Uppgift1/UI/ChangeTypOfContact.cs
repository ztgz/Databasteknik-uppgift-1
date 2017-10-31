using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uppgift1.DAL;

namespace Uppgift1.UI
{
    public partial class ChangeTypOfContact : Form
    {

        private int id;
        public ChangeTypOfContact(int id, bool jobbKontakt, bool personligKontakt, bool övrigKontakt)
        {
            InitializeComponent();

            this.id = id;

            JobbCheckBox.Checked = jobbKontakt;
            personligCheckBox.Checked = personligKontakt;
            ÖvrigCheckBox.Checked = övrigKontakt;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            SQLCommands.ChangeKontakt(dataAccess, id, JobbCheckBox.Checked,
                personligCheckBox.Checked, ÖvrigCheckBox.Checked);

            Close();
        }
    }
}
