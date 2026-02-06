using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters;

namespace BoardGameShop_Lab1
{
    public partial class GameEditForm : Form
    {
        private int? gameId = null;
        private bool isEditMode = false;

        GamesTableAdapter gamesAdapter = new GamesTableAdapter();

        public GameEditForm()
        {
            InitializeComponent();
            isEditMode = false;
            this.Text = "Додавання гри";
        }

        public GameEditForm(int id, string title, decimal price, int stock, int publisherId)
            : this()
        {
            isEditMode = true;
            gameId = id;

            txtTitle.Text = title;
            txtPrice.Text = price.ToString();
            txtStock.Text = stock.ToString();

            this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);
            cmbPublisher.SelectedValue = publisherId;

            this.Text = "Редагування гри";
        }

        private void GameEditForm_Load(object sender, EventArgs e)
        {
            this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Будь ласка, введіть назву гри.");
                    return;
                }
                if (cmbPublisher.SelectedValue == null)
                {
                    MessageBox.Show("Оберіть видавця!");
                    return;
                }

                string title = txtTitle.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                int publisherId = Convert.ToInt32(cmbPublisher.SelectedValue);

                if (isEditMode)
                {
                    gamesAdapter.UpdateQuery(
                        title,
                        price,
                        stock,
                        publisherId,
                        (int)gameId
                    );
                }
                else
                {
                    gamesAdapter.InsertQuery(
                        title,
                        price,
                        stock,
                        publisherId
                    );
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка формату! Перевірте ціну (має бути число, наприклад 500,00) та кількість.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void txtTitle_TextChanged(object sender, EventArgs e) { }
        private void txtPrice_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void txtStock_TextChanged(object sender, EventArgs e) { }
        private void cmbPublisher_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}