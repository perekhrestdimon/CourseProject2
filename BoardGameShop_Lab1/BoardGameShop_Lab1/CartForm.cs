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

            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Мій кошик";
            this.BackColor = Color.White;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.boardGameShop_LabDataSet.Clients);

            dgvCart.DataSource = null;
            dgvCart.DataSource = ShoppingService.CartItems;

            UpdateTotal();

            StyleDataGridView();
            StyleControls();
            CustomizeColumns();
        }

        private void StyleControls()
        {
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.BackColor = Color.SeaGreen;
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnCheckout.Cursor = Cursors.Hand;
            btnCheckout.Text = "✅ ОФОРМИТИ ЗАМОВЛЕННЯ";

            lblTotal.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkSlateGray;

            if (comboClients != null)
            {
                comboClients.Font = new Font("Segoe UI", 10);
                comboClients.BackColor = Color.WhiteSmoke;
            }
        }

        private void StyleDataGridView()
        {
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCart.ColumnHeadersHeight = 40;

            dgvCart.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCart.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvCart.RowTemplate.Height = 35;

            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CustomizeColumns()
        {
            foreach (DataGridViewColumn col in dgvCart.Columns)
            {
                switch (col.DataPropertyName)
                {
                    case "GameId":
                        col.Visible = false;
                        break;
                    case "Title":
                        col.HeaderText = "Назва товару";
                        break;
                    case "Price":
                        col.HeaderText = "Ціна (грн)";
                        col.DefaultCellStyle.Format = "N2";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "Quantity":
                        col.HeaderText = "Кількість";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "TotalPrice":
                        col.HeaderText = "Вартість";
                        col.DefaultCellStyle.Format = "N2";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        break;
                }
            }
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
            lblTotal.Text = $"Всього до сплати: {total:N2} грн";
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            if (comboClients.SelectedValue == null)
            {
                MessageBox.Show("Будь ласка, оберіть клієнта зі списку!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ShoppingService.CartItems.Count == 0)
            {
                MessageBox.Show("Кошик порожній!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                DialogResult result = MessageBox.Show($"Замовлення №{newOrderId} успішно оформлено!\nРоздрукувати чек?",
                                                      "Успіх",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }

                ClearCart();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оформленні:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 12);
            Font fontSmall = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 12, FontStyle.Bold);

            float y = 20;
            float x = 20;

            e.Graphics.DrawString("МАГАЗИН НАСТІЛЬНИХ ІГОР", fontTitle, Brushes.Black, x, y);
            y += 35;
            e.Graphics.DrawString("ЧЕК ЗАМОВЛЕННЯ", fontBold, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Дата: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"), fontSmall, Brushes.Gray, x, y);
            y += 30;
            e.Graphics.DrawString("----------------------------------------------------------------", fontRegular, Brushes.Black, x, y);
            y += 25;

            decimal totalSum = 0;
            foreach (var item in ShoppingService.CartItems)
            {
                string productLine = item.Title;
                if (productLine.Length > 25) productLine = productLine.Substring(0, 25) + "...";
                e.Graphics.DrawString(productLine, fontRegular, Brushes.Black, x, y);

                string priceInfo = $"{item.Quantity} x {item.Price:N0} = {item.TotalPrice:N2}";
                e.Graphics.DrawString(priceInfo, fontSmall, Brushes.Black, x + 200, y);

                totalSum += item.TotalPrice;
                y += 25;
            }

            e.Graphics.DrawString("----------------------------------------------------------------", fontRegular, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"ВСЬОГО: {totalSum:N2} грн", fontTitle, Brushes.Black, x, y);
            y += 50;
            e.Graphics.DrawString("Дякуємо за покупку!", fontRegular, Brushes.Black, x + 50, y);
        }

        private void btnCheckout_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Label_Click(object sender, EventArgs e) { }
    }
}