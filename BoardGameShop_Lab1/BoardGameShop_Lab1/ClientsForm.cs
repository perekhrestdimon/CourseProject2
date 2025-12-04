using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boardGameShop_LabDataSet);

        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
           
            this.clientsTableAdapter.Fill(this.boardGameShop_LabDataSet.Clients);

        }

        private void clientsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
