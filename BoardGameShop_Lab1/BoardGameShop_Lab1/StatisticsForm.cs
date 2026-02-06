using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    public partial class StatisticsForm : Form
    {
        const string ConnectionString = @"Data Source=DMYTRO\SQLEXPRESS;Initial Catalog=BoardGameShop_Lab;Integrated Security=True;TrustServerCertificate=True";

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void LoadStatistics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string sqlCount = "SELECT COUNT(*) FROM Games";
                    SqlCommand cmdCount = new SqlCommand(sqlCount, conn);
                    object countResult = cmdCount.ExecuteScalar();
                    lblGameCount.Text = countResult.ToString() + " шт.";

                    string sqlSum = "SELECT SUM(price * stock_quantity) FROM Games";
                    SqlCommand cmdSum = new SqlCommand(sqlSum, conn);
                    object sumResult = cmdSum.ExecuteScalar();

                    if (sumResult != DBNull.Value)
                        lblTotalSum.Text = string.Format("{0:N2} грн", sumResult);
                    else
                        lblTotalSum.Text = "0.00 грн";

                    string sqlMax = "SELECT TOP 1 title FROM Games ORDER BY price DESC";
                    SqlCommand cmdMax = new SqlCommand(sqlMax, conn);
                    object maxResult = cmdMax.ExecuteScalar();
                    lblMaxPrice.Text = maxResult != null ? maxResult.ToString() : "Немає даних";

                    string sqlAvg = "SELECT AVG(price) FROM Games";
                    SqlCommand cmdAvg = new SqlCommand(sqlAvg, conn);
                    object avgResult = cmdAvg.ExecuteScalar();

                    if (avgResult != DBNull.Value)
                        lblAvgPrice.Text = string.Format("{0:N2} грн", avgResult);
                    else
                        lblAvgPrice.Text = "0.00 грн";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка отримання статистики: " + ex.Message);
            }
        }

        private void StatisticsForm_Load_1(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticsForm_Load(object sender, EventArgs e) { }
        private void btnClose_Click(object sender, EventArgs e) { }
    }
}