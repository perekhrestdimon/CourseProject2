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
    public partial class PublisherGamesForm : Form
    {
        public PublisherGamesForm()
        {
            InitializeComponent();
        }

        private void publishersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publishersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boardGameShop_LabDataSet);

        }

        private void PublisherGamesForm_Load(object sender, EventArgs e)
        {
            
            this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
            
            this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);

        }

        private void publisher_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Ви дійсно хочете підтвердити зміни?", "Збереження даних",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    
                    this.publishersBindingSource.EndEdit(); 
                    this.gamesBindingSource.EndEdit();    

                    
                    
                    this.publishersTableAdapter.Update(this.boardGameShop_LabDataSet.Publishers);
                    this.gamesTableAdapter.Update(this.boardGameShop_LabDataSet.Games);

                    MessageBox.Show("Зміни успішно збережено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження: " + ex.Message, "Помилка");
                }
            }
        }

        private void publishersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
