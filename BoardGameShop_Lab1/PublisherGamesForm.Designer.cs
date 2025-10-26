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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherGamesForm));
            System.Windows.Forms.Label publisher_idLabel;
            System.Windows.Forms.Label publisher_nameLabel;
            this.boardGameShop_LabDataSet = new BoardGameShop_Lab1.BoardGameShop_LabDataSet();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersTableAdapter = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.PublishersTableAdapter();
            this.tableAdapterManager = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.TableAdapterManager();
            this.publishersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.publishersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.publisher_idTextBox = new System.Windows.Forms.TextBox();
            this.publisher_nameTextBox = new System.Windows.Forms.TextBox();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.GamesTableAdapter();
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
            this.tableAdapterManager.GamesTableAdapter = this.gamesTableAdapter;
            this.tableAdapterManager.PublishersTableAdapter = this.publishersTableAdapter;
            this.tableAdapterManager.UpdateOrder = BoardGameShop_Lab1.BoardGameShop_LabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publishersBindingNavigator
            // 
            this.publishersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publishersBindingNavigator.BindingSource = this.publishersBindingSource;
            this.publishersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publishersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.publishersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publishersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.publishersBindingNavigator.TabIndex = 0;
            this.publishersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // publishersBindingNavigatorSaveItem
            // 
            this.publishersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publishersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publishersBindingNavigatorSaveItem.Image")));
            this.publishersBindingNavigatorSaveItem.Name = "publishersBindingNavigatorSaveItem";
            this.publishersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.publishersBindingNavigatorSaveItem.Text = "Save Data";
            this.publishersBindingNavigatorSaveItem.Click += new System.EventHandler(this.publishersBindingNavigatorSaveItem_Click);
            // 
            // publisher_idLabel
            // 
            publisher_idLabel.AutoSize = true;
            publisher_idLabel.Location = new System.Drawing.Point(18, 52);
            publisher_idLabel.Name = "publisher_idLabel";
            publisher_idLabel.Size = new System.Drawing.Size(63, 13);
            publisher_idLabel.TabIndex = 1;
            publisher_idLabel.Text = "publisher id:";
            publisher_idLabel.Click += new System.EventHandler(this.publisher_idLabel_Click);
            // 
            // publisher_idTextBox
            // 
            this.publisher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "publisher_id", true));
            this.publisher_idTextBox.Location = new System.Drawing.Point(105, 49);
            this.publisher_idTextBox.Name = "publisher_idTextBox";
            this.publisher_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisher_idTextBox.TabIndex = 2;
            // 
            // publisher_nameLabel
            // 
            publisher_nameLabel.AutoSize = true;
            publisher_nameLabel.Location = new System.Drawing.Point(18, 78);
            publisher_nameLabel.Name = "publisher_nameLabel";
            publisher_nameLabel.Size = new System.Drawing.Size(81, 13);
            publisher_nameLabel.TabIndex = 3;
            publisher_nameLabel.Text = "publisher name:";
            // 
            // publisher_nameTextBox
            // 
            this.publisher_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "publisher_name", true));
            this.publisher_nameTextBox.Location = new System.Drawing.Point(105, 75);
            this.publisher_nameTextBox.Name = "publisher_nameTextBox";
            this.publisher_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisher_nameTextBox.TabIndex = 4;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "fk_publisher";
            this.gamesBindingSource.DataSource = this.publishersBindingSource;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // gamesDataGridView
            // 
            this.gamesDataGridView.AutoGenerateColumns = false;
            this.gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gamesDataGridView.DataSource = this.gamesBindingSource;
            this.gamesDataGridView.Location = new System.Drawing.Point(37, 120);
            this.gamesDataGridView.Name = "gamesDataGridView";
            this.gamesDataGridView.Size = new System.Drawing.Size(542, 220);
            this.gamesDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "game_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "game_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stock_quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "stock_quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "publisher_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "publisher_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Підтвердити зміни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PublisherGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gamesDataGridView);
            this.Controls.Add(publisher_idLabel);
            this.Controls.Add(this.publisher_idTextBox);
            this.Controls.Add(publisher_nameLabel);
            this.Controls.Add(this.publisher_nameTextBox);
            this.Controls.Add(this.publishersBindingNavigator);
            this.Name = "PublisherGamesForm";
            this.Text = "PublisherGamesForm";
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