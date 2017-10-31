using System.Windows.Forms;
using Uppgift1.DAL;

namespace Uppgift1.UI
{
    public partial class MoreInfoWindow : Form
    {
        public MoreInfoWindow()
        {
            InitializeComponent();
        }

        public void LoadPerson(int Id, string postalCode, string street)
        {
            moreInfoDataGridView.DataSource = SQLCommands.LoadPersons(Id, postalCode, street).Tables[0];
        }

        private void moreInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (moreInfoDataGridView.Columns[e.ColumnIndex].HeaderText == "Id")
            {
                int id = (int)moreInfoDataGridView[0, e.RowIndex].Value;
                DataAccess dataAccess = new DataAccess();
                ChangeTypOfContact typOfContactForm = new ChangeTypOfContact(id,
                    SQLCommands.PersonIsJobbKontakt(dataAccess, id),
                    SQLCommands.PersonIsPersonligKontakt(dataAccess, id),
                    SQLCommands.PersonIsÖvrigKontakt(dataAccess, id));
                typOfContactForm.Show();
            }
        }
    }
}
