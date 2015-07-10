namespace SalesDesktop
{
    partial class ReportOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOrders));
            this.aSPNETDB_DataSet = new SalesDesktop.ASPNETDB_DataSet();
            this.view_Order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Order_DetailsTableAdapter = new SalesDesktop.ASPNETDB_DataSetTableAdapters.View_Order_DetailsTableAdapter();
            this.tableAdapterManager = new SalesDesktop.ASPNETDB_DataSetTableAdapters.TableAdapterManager();
            this.view_Order_DetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.view_Order_DetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblHelp = new System.Windows.Forms.Label();
            this.view_Order_Details_DataSet = new SalesDesktop.View_Order_Details_DataSet();
            this.view_Order_DetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_Order_DetailsTableAdapter1 = new SalesDesktop.View_Order_Details_DataSetTableAdapters.View_Order_DetailsTableAdapter();
            this.tableAdapterManager1 = new SalesDesktop.View_Order_Details_DataSetTableAdapters.TableAdapterManager();
            this.view_Order_DetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aSPNETDB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsBindingNavigator)).BeginInit();
            this.view_Order_DetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_Details_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aSPNETDB_DataSet
            // 
            this.aSPNETDB_DataSet.DataSetName = "ASPNETDB_DataSet";
            this.aSPNETDB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Order_DetailsBindingSource
            // 
            this.view_Order_DetailsBindingSource.DataMember = "View_Order_Details";
            this.view_Order_DetailsBindingSource.DataSource = this.aSPNETDB_DataSet;
            // 
            // view_Order_DetailsTableAdapter
            // 
            this.view_Order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aspnet_ApplicationsTableAdapter = null;
            this.tableAdapterManager.aspnet_MembershipTableAdapter = null;
            this.tableAdapterManager.aspnet_PathsTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationAllUsersTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationPerUserTableAdapter = null;
            this.tableAdapterManager.aspnet_ProfileTableAdapter = null;
            this.tableAdapterManager.aspnet_RolesTableAdapter = null;
            this.tableAdapterManager.aspnet_SchemaVersionsTableAdapter = null;
            this.tableAdapterManager.aspnet_UsersInRolesTableAdapter = null;
            this.tableAdapterManager.aspnet_UsersTableAdapter = null;
            this.tableAdapterManager.aspnet_WebEvent_EventsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustGroupsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.OrderStatusTableAdapter = null;
            this.tableAdapterManager.PaymentTypesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.ShopCartTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SalesDesktop.ASPNETDB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_Order_DetailsBindingNavigator
            // 
            this.view_Order_DetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.view_Order_DetailsBindingNavigator.BindingSource = this.view_Order_DetailsBindingSource;
            this.view_Order_DetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_Order_DetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.view_Order_DetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_Order_DetailsBindingNavigatorSaveItem});
            this.view_Order_DetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_Order_DetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_Order_DetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_Order_DetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_Order_DetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_Order_DetailsBindingNavigator.Name = "view_Order_DetailsBindingNavigator";
            this.view_Order_DetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_Order_DetailsBindingNavigator.Size = new System.Drawing.Size(737, 25);
            this.view_Order_DetailsBindingNavigator.TabIndex = 0;
            this.view_Order_DetailsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // view_Order_DetailsBindingNavigatorSaveItem
            // 
            this.view_Order_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.view_Order_DetailsBindingNavigatorSaveItem.Enabled = false;
            this.view_Order_DetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_Order_DetailsBindingNavigatorSaveItem.Image")));
            this.view_Order_DetailsBindingNavigatorSaveItem.Name = "view_Order_DetailsBindingNavigatorSaveItem";
            this.view_Order_DetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.view_Order_DetailsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(12, 25);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(318, 13);
            this.lblHelp.TabIndex = 2;
            this.lblHelp.Text = "Double click on a row header to edit the desired order!";
            // 
            // view_Order_Details_DataSet
            // 
            this.view_Order_Details_DataSet.DataSetName = "View_Order_Details_DataSet";
            this.view_Order_Details_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Order_DetailsBindingSource1
            // 
            this.view_Order_DetailsBindingSource1.DataMember = "View_Order_Details";
            this.view_Order_DetailsBindingSource1.DataSource = this.view_Order_Details_DataSet;
            // 
            // view_Order_DetailsTableAdapter1
            // 
            this.view_Order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = SalesDesktop.View_Order_Details_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_Order_DetailsDataGridView
            // 
            this.view_Order_DetailsDataGridView.AllowUserToAddRows = false;
            this.view_Order_DetailsDataGridView.AllowUserToDeleteRows = false;
            this.view_Order_DetailsDataGridView.AutoGenerateColumns = false;
            this.view_Order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Order_DetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.view_Order_DetailsDataGridView.DataSource = this.view_Order_DetailsBindingSource1;
            this.view_Order_DetailsDataGridView.Location = new System.Drawing.Point(12, 41);
            this.view_Order_DetailsDataGridView.Name = "view_Order_DetailsDataGridView";
            this.view_Order_DetailsDataGridView.ReadOnly = true;
            this.view_Order_DetailsDataGridView.Size = new System.Drawing.Size(713, 325);
            this.view_Order_DetailsDataGridView.TabIndex = 2;
            this.view_Order_DetailsDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.view_Order_DetailsDataGridView_RowHeaderMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CustEmail";
            this.dataGridViewTextBoxColumn6.HeaderText = "CustEmail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PaymentTypeName";
            this.dataGridViewTextBoxColumn4.HeaderText = "PaymentTypeName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ShipperName";
            this.dataGridViewTextBoxColumn5.HeaderText = "ShipperName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DeliveryNotes";
            this.dataGridViewTextBoxColumn7.HeaderText = "DeliveryNotes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderAmount";
            this.dataGridViewTextBoxColumn8.HeaderText = "OrderAmount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 378);
            this.Controls.Add(this.view_Order_DetailsDataGridView);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.view_Order_DetailsBindingNavigator);
            this.Name = "ReportOrders";
            this.Text = "Waiting orders report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportOrders_FormClosing);
            this.Load += new System.EventHandler(this.ReportOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aSPNETDB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsBindingNavigator)).EndInit();
            this.view_Order_DetailsBindingNavigator.ResumeLayout(false);
            this.view_Order_DetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_Details_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order_DetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ASPNETDB_DataSet aSPNETDB_DataSet;
        private System.Windows.Forms.BindingSource view_Order_DetailsBindingSource;
        private ASPNETDB_DataSetTableAdapters.View_Order_DetailsTableAdapter view_Order_DetailsTableAdapter;
        private ASPNETDB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_Order_DetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton view_Order_DetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label lblHelp;
        private View_Order_Details_DataSet view_Order_Details_DataSet;
        private System.Windows.Forms.BindingSource view_Order_DetailsBindingSource1;
        private View_Order_Details_DataSetTableAdapters.View_Order_DetailsTableAdapter view_Order_DetailsTableAdapter1;
        private View_Order_Details_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView view_Order_DetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}