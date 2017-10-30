using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift1.UI
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            allaKontakterBTN.Checked = true;
        }
        
        private void searchBTN_Click(object sender, EventArgs e)
        {
            searchResultDataGridView.DataSource = null;

            /*Sök 1: Bara namn
             * 2: Bara adress
             * 3: Namn och address */
            if (string.IsNullOrEmpty(PostortTextBox.Text) &&
                !string.IsNullOrEmpty(NamnTextBox.Text))
            {
                searchResultDataGridView.DataSource = SQLCommands.LoadPersons(NamnTextBox.Text,
                    JobKontakterBTN.Checked, PersonligaKontakterBTN.Checked,
                    ÖvrigaKontakterBTN.Checked).Tables[0];
            }

        }
    }
}
