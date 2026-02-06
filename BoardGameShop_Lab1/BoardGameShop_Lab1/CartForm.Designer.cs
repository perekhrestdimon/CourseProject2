namespace BoardGameShop_Lab1
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.comboClients = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boardGameShop_LabDataSet = new BoardGameShop_Lab1.BoardGameShop_LabDataSet();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.ClientsTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.TableAdapterManager();
            this.order_ItemsTableAdapter = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.Order_ItemsTableAdapter();
            this.order_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameShop_LabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(12, 79);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 82;
            this.dgvCart.RowTemplate.Height = 33;
            this.dgvCart.Size = new System.Drawing.Size(1228, 482);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Всього: 0.00";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboClients
            // 
            this.comboClients.DataSource = this.clientsBindingSource;
            this.comboClients.DisplayMember = "last_name";
            this.comboClients.FormattingEnabled = true;
            this.comboClients.Location = new System.Drawing.Point(563, 9);
            this.comboClients.Name = "comboClients";
            this.comboClients.Size = new System.Drawing.Size(232, 33);
            this.comboClients.TabIndex = 2;
            this.comboClients.ValueMember = "customer_id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.boardGameShop_LabDataSet;
            // 
            // boardGameShop_LabDataSet
            // 
            this.boardGameShop_LabDataSet.DataSetName = "BoardGameShop_LabDataSet";
            this.boardGameShop_LabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(844, 9);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(396, 52);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Оформити";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click_1);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.boardGameShop_LabDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.Game_CategoriesTableAdapter = null;
            this.tableAdapterManager.Game_MechanicsTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.MechanicsTableAdapter = null;
            this.tableAdapterManager.Order_ItemsTableAdapter = this.order_ItemsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // order_ItemsTableAdapter
            // 
            this.order_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // order_ItemsBindingSource
            // 
            this.order_ItemsBindingSource.DataMember = "Order_Items";
            this.order_ItemsBindingSource.DataSource = this.boardGameShop_LabDataSet;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 573);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.comboClients);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCart);
            this.MinimumSize = new System.Drawing.Size(1278, 578);
            this.Name = "CartForm";
            this.Text = "Кошик";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameShop_LabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comboClients;
        private System.Windows.Forms.Button btnCheckout;
        private BoardGameShop_LabDataSet boardGameShop_LabDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private BoardGameShop_LabDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BoardGameShop_LabDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private BoardGameShop_LabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BoardGameShop_LabDataSetTableAdapters.Order_ItemsTableAdapter order_ItemsTableAdapter;
        private System.Windows.Forms.BindingSource order_ItemsBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}