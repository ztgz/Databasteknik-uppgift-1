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
            else if (!string.IsNullOrEmpty(PostortTextBox.Text) &&
                     string.IsNullOrEmpty(NamnTextBox.Text))
            {
                searchResultDataGridView.DataSource = SQLCommands.LoadAdress(PostortTextBox.Text).Tables[0];
            }
            else if (!string.IsNullOrEmpty(PostortTextBox.Text) &&
                     !string.IsNullOrEmpty(NamnTextBox.Text))
            {
                searchResultDataGridView.DataSource = SQLCommands.LoadPersonsWithAdress(NamnTextBox.Text,
                    PostortTextBox.Text, JobKontakterBTN.Checked, PersonligaKontakterBTN.Checked,
                    ÖvrigaKontakterBTN.Checked).Tables[0];
            }

        }

        private void searchResultDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            MoreInfoWindow infoWindow = new MoreInfoWindow();

            for (int i = 0; i < searchResultDataGridView.RowCount; i++)
            {

                //Only person Id, person name, person epost in datagrid
                if (searchResultDataGridView.ColumnCount == 3 && searchResultDataGridView.Columns[0].HeaderText == "Id")
                {
                    if (int.TryParse(searchResultDataGridView[0, e.RowIndex].Value.ToString(), out int id))
                    {
                        infoWindow.LoadPerson(id, "", "");
                        infoWindow.Show();
                    }
                }
                //Shows Postnummer, Gatuadress, Postort
                else if (searchResultDataGridView.ColumnCount == 3 &&
                         searchResultDataGridView.Columns[0].HeaderText == "Postnummer")
                {
                     infoWindow.LoadPerson(-1, searchResultDataGridView[0,e.RowIndex].Value.ToString(), 
                         searchResultDataGridView[1, e.RowIndex].Value.ToString());
                     infoWindow.Show();
                }
                //adress and person
                else if (searchResultDataGridView.ColumnCount == 5)
                {
                    if (int.TryParse(searchResultDataGridView[0, e.RowIndex].Value.ToString(), out int id))
                    {
                        infoWindow.LoadPerson(id, searchResultDataGridView[2, e.RowIndex].Value.ToString(),
                            searchResultDataGridView[3, e.RowIndex].Value.ToString());
                        infoWindow.Show();
                    }
                }
                
            }
        }
    }
}
