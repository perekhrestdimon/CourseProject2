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

            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.Text = "Редагування: Видавці та їхні ігри";
        }

        private void PublisherGamesForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.gamesTableAdapter.Fill(this.boardGameShop_LabDataSet.Games);
                this.publishersTableAdapter.Fill(this.boardGameShop_LabDataSet.Publishers);

                StyleControls();
                StyleDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження: " + ex.Message);
            }
        }

        private void StyleControls()
        {
            if (button1 != null)
            {
                button1.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderSize = 0;
                button1.BackColor = Color.SeaGreen;
                button1.ForeColor = Color.White;
                button1.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                button1.Cursor = Cursors.Hand;
                button1.Text = "💾 ЗБЕРЕГТИ ЗМІНИ";
            }
        }

        private void StyleDataGridView()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is DataGridView dgv)
                {
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.BackgroundColor = Color.White;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.RowHeadersVisible = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dgv.ColumnHeadersHeight = 40;

                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
                    dgv.RowTemplate.Height = 30;
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        switch (col.DataPropertyName)
                        {
                            case "game_id": col.Visible = false; break;
                            case "publisher_id": col.Visible = false; break;
                            case "game_category_id": col.Visible = false; break;

                            case "title":
                                col.HeaderText = "Назва гри";
                                break;
                            case "price":
                                col.HeaderText = "Ціна (грн)";
                                col.DefaultCellStyle.Format = "N2";
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                break;
                            case "stock_quantity":
                                col.HeaderText = "Кількість";
                                break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете зберегти всі зміни в базі даних?",
                                "Підтвердження",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();

                    this.publishersBindingSource.EndEdit();
                    this.gamesBindingSource.EndEdit();

                    this.publishersTableAdapter.Update(this.boardGameShop_LabDataSet.Publishers);
                    this.gamesTableAdapter.Update(this.boardGameShop_LabDataSet.Games);

                    MessageBox.Show("✅ Дані успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Помилка при збереженні:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void publishersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publishersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boardGameShop_LabDataSet);
        }

        private void publisher_idLabel_Click(object sender, EventArgs e) { }
        private void publishersBindingNavigator_RefreshItems(object sender, EventArgs e) { }
        private void publisher_nameLabel_Click(object sender, EventArgs e) { }
    }
}