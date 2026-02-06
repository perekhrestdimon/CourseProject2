using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    public partial class QueryEdit : Form
    {

        const string ConnectionString = @"Data Source=DMYTRO\SQLEXPRESS;Initial Catalog=BoardGameShop_Lab;Integrated Security=True;TrustServerCertificate=True";

        public QueryEdit()
        {
            InitializeComponent();
        }

        
        private void QueryEdit_Load(object sender, EventArgs e)
        {
            
            if (TestInput != null)
            {
                TestInput.Text = "SELECT * FROM Games";
            }
        }

        
        private void DoSQL_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlConnection sqlconn = new SqlConnection(ConnectionString))
                {
                    sqlconn.Open();

                    
                    SqlDataAdapter oda = new SqlDataAdapter(TestInput.Text, sqlconn);

                    DataTable dt = new DataTable();
                    oda.Fill(dt);

                    
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка SQL: " + ex.Message);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "SELECT ";
            TestInput.Focus();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void TestInput_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}