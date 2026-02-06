namespace BoardGameShop_Lab1
{
    partial class PublisherGamesForm
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
            System.Windows.Forms.Label publisher_idLabel;
            System.Windows.Forms.Label publisher_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherGamesForm));
            this.boardGameShop_LabDataSet = new BoardGameShop_Lab1.BoardGameShop_LabDataSet();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersTableAdapter = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.PublishersTableAdapter();
            this.tableAdapterManager = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.TableAdapterManager();
            this.gamesTableAdapter = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.GamesTableAdapter();
            this.publishersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.publishersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.publisher_idTextBox = new System.Windows.Forms.TextBox();
            this.publisher_nameTextBox = new System.Windows.Forms.TextBox();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            publisher_idLabel = new System.Windows.Forms.Label();
            publisher_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameShop_LabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingNavigator)).BeginInit();
            this.publishersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // publisher_idLabel
            // 
            publisher_idLabel.AutoSize = true;
            publisher_idLabel.Location = new System.Drawing.Point(15, 94);
            publisher_idLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            publisher_idLabel.Name = "publisher_idLabel";
            publisher_idLabel.Size = new System.Drawing.Size(129, 25);
            publisher_idLabel.TabIndex = 1;
            publisher_idLabel.Text = "publisher id:";
            publisher_idLabel.Click += new System.EventHandler(this.publisher_idLabel_Click);
            // 
            // publisher_nameLabel
            // 
            publisher_nameLabel.AutoSize = true;
            publisher_nameLabel.Location = new System.Drawing.Point(380, 94);
            publisher_nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            publisher_nameLabel.Name = "publisher_nameLabel";
            publisher_nameLabel.Size = new System.Drawing.Size(165, 25);
            publisher_nameLabel.TabIndex = 3;
            publisher_nameLabel.Text = "publisher name:";
            publisher_nameLabel.Click += new System.EventHandler(this.publisher_nameLabel_Click);
            // 
            // boardGameShop_LabDataSet
            // 
            this.boardGameShop_LabDataSet.DataSetName = "BoardGameShop_LabDataSet";
            this.boardGameShop_LabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.boardGameShop_LabDataSet;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Game_CategoriesTableAdapter = null;
            this.tableAdapterManager.Game_MechanicsTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = this.gamesTableAdapter;
            this.tableAdapterManager.MechanicsTableAdapter = null;
            this.tableAdapterManager.Order_ItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = this.publishersTableAdapter;
            this.tableAdapterManager.UpdateOrder = BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // publishersBindingNavigator
            // 
            this.publishersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publishersBindingNavigator.BindingSource = this.publishersBindingSource;
            this.publishersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publishersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.publishersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.publishersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.publishersBindingNavigatorSaveItem});
            this.publishersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publishersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publishersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publishersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publishersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publishersBindingNavigator.Name = "publishersBindingNavigator";
            this.publishersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.publishersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publishersBindingNavigator.Size = new System.Drawing.Size(1120, 50);
            this.publishersBindingNavigator.TabIndex = 0;
            this.publishersBindingNavigator.Text = "bindingNavigator1";
            this.publishersBindingNavigator.RefreshItems += new System.EventHandler(this.publishersBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // publishersBindingNavigatorSaveItem
            // 
            this.publishersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publishersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publishersBindingNavigatorSaveItem.Image")));
            this.publishersBindingNavigatorSaveItem.Name = "publishersBindingNavigatorSaveItem";
            this.publishersBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.publishersBindingNavigatorSaveItem.Text = "Save Data";
            this.publishersBindingNavigatorSaveItem.Click += new System.EventHandler(this.publishersBindingNavigatorSaveItem_Click);
            // 
            // publisher_idTextBox
            // 
            this.publisher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "publisher_id", true));
            this.publisher_idTextBox.Location = new System.Drawing.Point(156, 91);
            this.publisher_idTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.publisher_idTextBox.Name = "publisher_idTextBox";
            this.publisher_idTextBox.Size = new System.Drawing.Size(196, 31);
            this.publisher_idTextBox.TabIndex = 2;
            // 
            // publisher_nameTextBox
            // 
            this.publisher_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "publisher_name", true));
            this.publisher_nameTextBox.Location = new System.Drawing.Point(557, 88);
            this.publisher_nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.publisher_nameTextBox.Name = "publisher_nameTextBox";
            this.publisher_nameTextBox.Size = new System.Drawing.Size(196, 31);
            this.publisher_nameTextBox.TabIndex = 4;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "fk_publisher";
            this.gamesBindingSource.DataSource = this.publishersBindingSource;
            // 
            // gamesDataGridView
            // 
            this.gamesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesDataGridView.AutoGenerateColumns = false;
            this.gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gamesDataGridView.DataSource = this.gamesBindingSource;
            this.gamesDataGridView.Location = new System.Drawing.Point(15, 176);
            this.gamesDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.gamesDataGridView.Name = "gamesDataGridView";
            this.gamesDataGridView.RowHeadersWidth = 82;
            this.gamesDataGridView.Size = new System.Drawing.Size(1084, 423);
            this.gamesDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "game_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "game_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stock_quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "stock_quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "publisher_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "publisher_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Підтвердити зміни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PublisherGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gamesDataGridView);
            this.Controls.Add(publisher_idLabel);
            this.Controls.Add(this.publisher_idTextBox);
            this.Controls.Add(publisher_nameLabel);
            this.Controls.Add(this.publisher_nameTextBox);
            this.Controls.Add(this.publishersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1146, 686);
            this.Name = "PublisherGamesForm";
            this.Text = "Видавці Ігор";
            this.Load += new System.EventHandler(this.PublisherGamesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardGameShop_LabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingNavigator)).EndInit();
            this.publishersBindingNavigator.ResumeLayout(false);
            this.publishersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoardGameShop_LabDataSet boardGameShop_LabDataSet;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private BoardGameShop_LabDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private BoardGameShop_LabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publishersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton publishersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox publisher_idTextBox;
        private System.Windows.Forms.TextBox publisher_nameTextBox;
        private BoardGameShop_LabDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private System.Windows.Forms.DataGridView gamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}