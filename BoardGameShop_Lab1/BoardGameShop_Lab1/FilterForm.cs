using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    public partial class FilterForm : Form
    {
        
        public decimal MinPrice { get; private set; }
        public decimal MaxPrice { get; private set; }
        public List<int> SelectedPublisherIds { get; private set; } = new List<int>();

        
        private DataTable publishersTable;

        
        public FilterForm(decimal currentMin, decimal currentMax, List<int> checkedIds, DataTable publishers)
        {
            InitializeComponent();

            publishersTable = publishers;

           
            numMin.Maximum = 100000;
            numMax.Maximum = 100000;

            
            numMin.Value = currentMin;
            numMax.Value = currentMax;

            LoadPublishers(checkedIds);
        }

        private void LoadPublishers(List<int> checkedIds)
        {
            clbPublishers.Items.Clear();

            
            foreach (DataRow row in publishersTable.Rows)
            {
                string name = row["publisher_name"].ToString();
                int id = Convert.ToInt32(row["publisher_id"]);

                
                PublisherItem item = new PublisherItem { Id = id, Name = name };
                int index = clbPublishers.Items.Add(item);

                
                if (checkedIds != null && checkedIds.Contains(id))
                {
                    clbPublishers.SetItemChecked(index, true);
                }
            }
            clbPublishers.DisplayMember = "Name"; 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            MinPrice = numMin.Value;
            MaxPrice = numMax.Value;

            SelectedPublisherIds.Clear();
            foreach (PublisherItem item in clbPublishers.CheckedItems)
            {
                SelectedPublisherIds.Add(item.Id);
            }

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }
    }


    public class PublisherItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() { return Name; }
    }
}