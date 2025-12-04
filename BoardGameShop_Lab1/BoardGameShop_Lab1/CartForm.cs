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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.boardGameShop_LabDataSet.Clients);
            dgvCart.DataSource = null;
            dgvCart.DataSource = ShoppingService.CartItems;
            UpdateTotal();
        }

        private void ClearCart()
        {
            ShoppingService.CartItems.Clear();
            dgvCart.DataSource = null;
            dgvCart.DataSource = ShoppingService.CartItems;
            lblTotal.Text = "Всього до сплати: 0.00 грн";
            comboClients.SelectedIndex = -1;
        }

        private void UpdateTotal()
        {
            decimal total = ShoppingService.CartItems.Sum(x => x.TotalPrice);
            lblTotal.Text = $"Всього до сплати: {total} грн";
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            if (comboClients.SelectedValue == null)
            {
                MessageBox.Show("Будь ласка, оберіть клієнта зі списку!", "Увага");
                return;
            }

            try
            {
                int customerId = (int)comboClients.SelectedValue;
                decimal totalAmount = ShoppingService.CartItems.Sum(x => x.TotalPrice);
                DateTime orderDate = DateTime.Now;

                var newOrder = this.boardGameShop_LabDataSet.Orders.NewOrdersRow();

                newOrder.customer_id = customerId;
                newOrder.order_date = orderDate;
                newOrder.total_amount = totalAmount;
                newOrder.status = "Нове";

                newOrder.shipping_address = "Самовивіз";
                newOrder.payment_method = "Готівка";
                newOrder.shipping_method = "Самовивіз";
                newOrder.tracking_number = "";

                this.boardGameShop_LabDataSet.Orders.AddOrdersRow(newOrder);
                this.ordersTableAdapter.Update(this.boardGameShop_LabDataSet.Orders);

                int newOrderId = newOrder.order_id;

                foreach (var item in ShoppingService.CartItems)
                {
                    this.order_ItemsTableAdapter.Insert(item.Quantity, item.Price, newOrderId, item.GameId);
                }

                MessageBox.Show($"Замовлення №{newOrderId} успішно оформлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearCart();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оформленні замовлення:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Label_Click(object sender, EventArgs e) { }
    }
}