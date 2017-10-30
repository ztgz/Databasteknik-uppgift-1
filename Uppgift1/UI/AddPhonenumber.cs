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
    public partial class AddPhonenumber : Form
    {
        public AddPhonenumber()
        {
            InitializeComponent();

            LoadPhonenumbers();
        }

        private void LoadPhonenumbers()
        {
            DataSet dataSet = SQLCommands.LoadPhonenumbers();

            telefonnummerDataGridView.DataSource = dataSet.Tables[0];
        }
    }
}
