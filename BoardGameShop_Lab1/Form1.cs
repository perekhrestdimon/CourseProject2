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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);
            this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
            this.categoriesTableAdapter.Fill(this.boardGameShop_LabDataSet.Categories);

            
            dataGridView1.AutoGenerateColumns = true;

            
            publishersToolStripMenuItem_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bindingNavigator1.BindingSource = publishersBindingSource1;
            dataGridView1.DataSource = publishersBindingSource1;
            label1.Text = "Видавці";
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bindingNavigator1.BindingSource = gamesBindingSource1;
            dataGridView1.DataSource = gamesBindingSource1;
            label1.Text = "Ігри";
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bindingNavigator1.BindingSource = categoriesBindingSource1;
            dataGridView1.DataSource = categoriesBindingSource1;
            label1.Text = "Категорії";
        }

        private void gamesBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
                this.publishersTableAdapter.Update(this.boardGameShop_LabDataSet.Publishers);
                this.gamesTableAdapter.Update(this.boardGameShop_LabDataSet.Games);
                this.categoriesTableAdapter.Update(this.boardGameShop_LabDataSet.Categories);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження даних при закритті: " + ex.Message, "Помилка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void видавціТаІгриToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            
            PublisherGamesForm rsForm = new PublisherGamesForm();

            
            rsForm.ShowDialog();

            
            try
            {
                this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);
                this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
                this.categoriesTableAdapter.Fill(this.boardGameShop_LabDataSet.Categories);

                
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення даних: " + ex.Message, "Помилка");
            }
        }
    }
}
