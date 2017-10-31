using System.Windows.Forms;

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

    }
}
