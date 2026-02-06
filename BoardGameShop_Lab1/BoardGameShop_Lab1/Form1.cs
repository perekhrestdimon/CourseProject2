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
        string currentTable = "Games";
        private decimal filterMinPrice = 0;
        private decimal filterMaxPrice = 100000;
        private List<int> filterPublisherIds = new List<int>();
        private bool _isAdmin;

        public Form1(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            ApplyRoleAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
            this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);
            this.categoriesTableAdapter.Fill(this.boardGameShop_LabDataSet.Categories);

            dataGridView1.AutoGenerateColumns = true;

            if (cmbTableSelect.Items.Count == 0)
            {
                cmbTableSelect.Items.Add("Ігри");
                cmbTableSelect.Items.Add("Видавці");
                cmbTableSelect.Items.Add("Категорії");
            }
            cmbTableSelect.SelectedIndex = 0;

            StyleButtons();
            StyleDataGridView();
            CustomizeColumns();

            ApplyRoleAccess();
        }

        private void StyleButtons()
        {
            void SetBtnStyle(Button btn, Color color)
            {
                if (btn == null) return;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = color;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
            }

            SetBtnStyle(button1, Color.SeaGreen);
            SetBtnStyle(button2, Color.DarkOrange);
            SetBtnStyle(btnFilter, Color.SteelBlue);
            SetBtnStyle(btnResetFilter, Color.Gray);
        }

        private void StyleDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataGridView1.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dataGridView1.RowTemplate.Height = 35;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CustomizeColumns()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns) col.Visible = true;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                switch (col.DataPropertyName)
                {
                    case "game_id":
                        col.HeaderText = "ID";
                        col.Width = 50;
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        break;
                    case "title":
                        col.HeaderText = "Назва гри";
                        break;
                    case "price":
                        col.HeaderText = "Ціна (грн)";
                        col.DefaultCellStyle.Format = "N2";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        break;
                    case "stock_quantity":
                        col.HeaderText = "На складі (шт)";
                        break;
                    case "publisher_id":
                    case "game_category_id":
                        col.Visible = false;
                        break;
                    case "publisher_name": col.HeaderText = "Назва видавця"; break;
                    case "address": col.HeaderText = "Адреса"; break;
                    case "contact_email": col.HeaderText = "Email"; break;
                    case "category_id": col.HeaderText = "ID"; col.Width = 50; break;
                    case "category_name": col.HeaderText = "Категорія"; break;
                }
            }
        }

        private void ApplyRoleAccess()
        {
            if (!_isAdmin)
            {
                this.Text = "Магазин настільних ігор (Гість)";

                if (menuStrip1.Items.ContainsKey("замовленняToolStripMenuItem")) menuStrip1.Items["замовленняToolStripMenuItem"].Visible = false;
                if (menuStrip1.Items.ContainsKey("databaseToolStripMenuItem")) menuStrip1.Items["databaseToolStripMenuItem"].Visible = false;
                if (menuStrip1.Items.ContainsKey("клієнтиToolStripMenuItem")) menuStrip1.Items["клієнтиToolStripMenuItem"].Visible = false;
                if (menuStrip1.Items.ContainsKey("правкаToolStripMenuItem")) menuStrip1.Items["правкаToolStripMenuItem"].Visible = false;
                if (menuStrip1.Items.ContainsKey("статистикаToolStripMenuItem")) menuStrip1.Items["статистикаToolStripMenuItem"].Visible = false;

                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                bindingNavigator1.Visible = false;
            }
            else
            {
                this.Text = "Магазин настільних ігор (Адміністратор)";
                dataGridView1.ReadOnly = false;
                bindingNavigator1.Visible = true;
                if (menuStrip1.Items.ContainsKey("замовленняToolStripMenuItem")) menuStrip1.Items["замовленняToolStripMenuItem"].Visible = true;
            }
        }

        private void cmbTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableSelect.SelectedItem == null) return;

            string selected = cmbTableSelect.SelectedItem.ToString();

            switch (selected)
            {
                case "Ігри":
                    currentTable = "Games";
                    this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
                    dataGridView1.DataSource = gamesBindingSource1;
                    bindingNavigator1.BindingSource = gamesBindingSource1;
                    if (label1 != null) label1.Text = "Ігри";
                    break;

                case "Видавці":
                    currentTable = "Publishers";
                    this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);
                    dataGridView1.DataSource = publishersBindingSource1;
                    bindingNavigator1.BindingSource = publishersBindingSource1;
                    if (label1 != null) label1.Text = "Видавці";
                    break;

                case "Категорії":
                    currentTable = "Categories";
                    this.categoriesTableAdapter.Fill(this.boardGameShop_LabDataSet.Categories);
                    dataGridView1.DataSource = categoriesBindingSource1;
                    bindingNavigator1.BindingSource = categoriesBindingSource1;
                    if (label1 != null) label1.Text = "Категорії";
                    break;
            }

            txtSearch.Text = "";
            UpdateInterface();
            CustomizeColumns();
        }

        private void UpdateInterface()
        {
            bool isGames = (currentTable == "Games");
            button1.Visible = isGames;
            btnFilter.Visible = isGames;
            cmbSort.Visible = isGames;
            btnResetFilter.Visible = isGames;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = (row.Index % 2 == 0) ? Color.White : Color.FromArgb(245, 245, 245);
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(searchText)) return;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string valueToCheck = "";

                if (currentTable == "Games" && row.Cells["title"].Value != null)
                    valueToCheck = row.Cells["title"].Value.ToString().ToLower();
                else if (currentTable == "Publishers" && row.Cells["publisher_name"].Value != null)
                    valueToCheck = row.Cells["publisher_name"].Value.ToString().ToLower();
                else if (currentTable == "Categories" && row.Cells["category_name"].Value != null)
                    valueToCheck = row.Cells["category_name"].Value.ToString().ToLower();

                if (!string.IsNullOrEmpty(valueToCheck) && valueToCheck.Contains(searchText))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["game_id"].Value);
                    string title = dataGridView1.CurrentRow.Cells["title"].Value.ToString();
                    decimal price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["price"].Value);

                    ShoppingService.AddToCart(id, title, price);
                    MessageBox.Show($"Гру \"{title}\" додано в кошик!", "Успіх");
                }
                catch (Exception) { MessageBox.Show("Оберіть рядок з грою коректно!"); }
            }
            else MessageBox.Show("Будь ласка, виберіть гру зі списку.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (currentTable != "Games") return;

            DataTable dtPublishers = this.boardGameShop_LabDataSet.Publishers;
            FilterForm fForm = new FilterForm(filterMinPrice, filterMaxPrice, filterPublisherIds, dtPublishers);

            if (fForm.ShowDialog() == DialogResult.OK)
            {
                filterMinPrice = fForm.MinPrice;
                filterMaxPrice = fForm.MaxPrice;
                filterPublisherIds = fForm.SelectedPublisherIds;

                string min = filterMinPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string max = filterMaxPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string filterStr = $"price >= {min} AND price <= {max}";

                if (filterPublisherIds.Count > 0)
                {
                    string ids = string.Join(",", filterPublisherIds);
                    filterStr += $" AND publisher_id IN ({ids})";
                }
                gamesBindingSource1.Filter = filterStr;
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            gamesBindingSource1.RemoveFilter();
            filterMinPrice = 0;
            filterMaxPrice = 100000;
            filterPublisherIds.Clear();
            MessageBox.Show("Фільтри скинуто!");
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedItem == null) return;
            string selectedOption = cmbSort.SelectedItem.ToString();

            if (currentTable == "Games")
            {
                switch (selectedOption)
                {
                    case "Назва (А-Я)": gamesBindingSource1.Sort = "title ASC"; break;
                    case "Назва (Я-А)": gamesBindingSource1.Sort = "title DESC"; break;
                    case "Ціна (від дешевих)": gamesBindingSource1.Sort = "price ASC"; break;
                    case "Ціна (від дорогих)": gamesBindingSource1.Sort = "price DESC"; break;
                    case "Кількість (спочатку багато)": gamesBindingSource1.Sort = "stock_quantity DESC"; break;
                }
            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statForm = new StatisticsForm();
            statForm.ShowDialog();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void редакторЗапитівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryEdit qe = new QueryEdit();
            qe.Show();
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameEditForm editForm = new GameEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
                this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["game_id"].Value);
                    string title = dataGridView1.CurrentRow.Cells["title"].Value.ToString();
                    decimal price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["price"].Value);
                    int stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells["stock_quantity"].Value);
                    int pubId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["publisher_id"].Value);

                    GameEditForm editForm = new GameEditForm(id, title, price, stock, pubId);
                    if (editForm.ShowDialog() == DialogResult.OK)
                        this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
                }
                catch { MessageBox.Show("Помилка редагування!"); }
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити запис?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["game_id"].Value);
                        gamesTableAdapter.DeleteQuery(id);
                        this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
                    }
                    catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.publishersTableAdapter.Update(this.boardGameShop_LabDataSet.Publishers);
                this.gamesTableAdapter.Update(this.boardGameShop_LabDataSet.Games);
                this.categoriesTableAdapter.Update(this.boardGameShop_LabDataSet.Categories);
            }
            catch { }
        }

        private void видавціТаІгриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherGamesForm rsForm = new PublisherGamesForm();
            rsForm.ShowDialog();
            try
            {
                this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);
                this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
                dataGridView1.Refresh();
            }
            catch { }
        }

        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm orders = new OrdersForm();
            orders.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void databaseToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void gamesBindingSource_CurrentChanged(object sender, EventArgs e) { }
        private void gamesBindingSource1_CurrentChanged(object sender, EventArgs e) { }
        private void bindingNavigator1_RefreshItems(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void publishersToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void gamesToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e) { }
    }
}