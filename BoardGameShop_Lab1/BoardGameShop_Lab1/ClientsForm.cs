using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Text = "База клієнтів";
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.clientsTableAdapter.Fill(this.boardGameShop_LabDataSet.Clients);

                StyleDataGridView();
                CustomizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження: " + ex.Message);
            }
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boardGameShop_LabDataSet);
            MessageBox.Show("Зміни збережено!");
        }

        private void StyleDataGridView()
        {
            clientsDataGridView.BorderStyle = BorderStyle.None;
            clientsDataGridView.BackgroundColor = Color.White;
            clientsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            clientsDataGridView.RowHeadersVisible = false;
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            clientsDataGridView.EnableHeadersVisualStyles = false;
            clientsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            clientsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            clientsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            clientsDataGridView.ColumnHeadersHeight = 40;

            clientsDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            clientsDataGridView.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            clientsDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            clientsDataGridView.RowTemplate.Height = 30;

            clientsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CustomizeColumns()
        {
            foreach (DataGridViewColumn col in clientsDataGridView.Columns)
            {
                switch (col.DataPropertyName)
                {
                    case "customer_id":
                        col.HeaderText = "ID";
                        col.Width = 50;
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        break;

                    case "last_name":
                        col.HeaderText = "Прізвище";
                        break;

                    case "first_name":
                        col.HeaderText = "Ім'я";
                        break;

                    case "middle_name":
                        col.HeaderText = "По батькові";
                        break;

                    case "phone_number":
                        col.HeaderText = "Телефон";
                        break;

                    case "email":
                        col.HeaderText = "Email";
                        break;

                    case "registration_date":
                        col.HeaderText = "Дата реєстрації";
                        break;

                    case "password_hash":
                        col.Visible = false;
                        break;
                }
            }
        }

        private void clientsBindingNavigator_RefreshItems(object sender, EventArgs e) { }
    }
}