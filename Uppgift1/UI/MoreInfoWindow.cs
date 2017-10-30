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
