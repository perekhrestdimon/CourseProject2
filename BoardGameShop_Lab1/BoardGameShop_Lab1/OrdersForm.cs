using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Fill(this.boardGameShop_LabDataSet.Orders);

                foreach (DataGridViewColumn col in ordersDataGridView.Columns)
                {
                    switch (col.DataPropertyName)
                    {
                        case "order_id": col.HeaderText = "№"; col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; break;
                        case "order_date": col.HeaderText = "Дата"; break;
                        case "status": col.HeaderText = "Статус"; break;
                        case "total_amount":
                            col.HeaderText = "Сума (грн)";
                            col.DefaultCellStyle.Format = "N2";
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "payment_method": col.HeaderText = "Оплата"; break;
                        case "customer_id": col.HeaderText = "Клієнт"; break;
                        case "shipping_address":
                        case "shipping_method":
                        case "tracking_number": col.Visible = false; break;
                    }
                }

                ordersDataGridView.EnableHeadersVisualStyles = false;
                ordersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
                ordersDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                ordersDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                ordersDataGridView.ColumnHeadersHeight = 40;
                ordersDataGridView.DefaultCellStyle.Font = new Font("Arial", 10);
                ordersDataGridView.RowTemplate.Height = 30;
                ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private string GetVal(string dbColumnName)
        {
            foreach (DataGridViewColumn col in ordersDataGridView.Columns)
            {
                if (col.DataPropertyName == dbColumnName)
                {
                    var val = ordersDataGridView.CurrentRow.Cells[col.Index].Value;
                    return val != null ? val.ToString() : "";
                }
            }
            return "---";
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити замовлення? (Це також видалить історію товарів у ньому)",
                                    "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(GetVal("order_id"));
                        this.ordersTableAdapter.DeleteQuery(id);
                        this.ordersTableAdapter.Fill(this.boardGameShop_LabDataSet.Orders);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка видалення: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Оберіть замовлення!");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow != null)
            {
                string id = GetVal("order_id");
                string date = GetVal("order_date");
                string status = GetVal("status");
                string total = GetVal("total_amount");
                string address = GetVal("shipping_address");
                string method = GetVal("shipping_method");

                string info = $"Замовлення №{id}\n" +
                              $"Дата: {date}\n" +
                              $"Статус: {status}\n" +
                              $"СУМА: {total} грн\n\n" +
                              $"Доставка: {method}\n" +
                              $"Адреса: {address}";

                MessageBox.Show(info, "Деталі замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Оберіть замовлення!");
            }
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boardGameShop_LabDataSet);
        }
    }
}