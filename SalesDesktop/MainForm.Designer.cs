namespace SalesDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waitingOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentTypesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPaymentTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippersReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchShipperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.paymentTypesToolStripMenuItem,
            this.shippersToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersReportToolStripMenuItem,
            this.searchOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // ordersReportToolStripMenuItem
            // 
            this.ordersReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waitingOrdersToolStripMenuItem,
            this.approvedToolStripMenuItem,
            this.rejectedToolStripMenuItem});
            this.ordersReportToolStripMenuItem.Name = "ordersReportToolStripMenuItem";
            this.ordersReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordersReportToolStripMenuItem.Text = "Orders report";
            // 
            // waitingOrdersToolStripMenuItem
            // 
            this.waitingOrdersToolStripMenuItem.Name = "waitingOrdersToolStripMenuItem";
            this.waitingOrdersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.waitingOrdersToolStripMenuItem.Text = "Waiting orders";
            this.waitingOrdersToolStripMenuItem.Click += new System.EventHandler(this.waitingOrdersToolStripMenuItem_Click);
            // 
            // approvedToolStripMenuItem
            // 
            this.approvedToolStripMenuItem.Name = "approvedToolStripMenuItem";
            this.approvedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.approvedToolStripMenuItem.Text = "Approved";
            this.approvedToolStripMenuItem.Click += new System.EventHandler(this.approvedToolStripMenuItem_Click);
            // 
            // rejectedToolStripMenuItem
            // 
            this.rejectedToolStripMenuItem.Name = "rejectedToolStripMenuItem";
            this.rejectedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rejectedToolStripMenuItem.Text = "Rejected";
            this.rejectedToolStripMenuItem.Click += new System.EventHandler(this.rejectedToolStripMenuItem_Click);
            // 
            // searchOrderToolStripMenuItem
            // 
            this.searchOrderToolStripMenuItem.Name = "searchOrderToolStripMenuItem";
            this.searchOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchOrderToolStripMenuItem.Text = "Search order";
            this.searchOrderToolStripMenuItem.Click += new System.EventHandler(this.searchOrderToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsReportToolStripMenuItem,
            this.searchProductToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // productsReportToolStripMenuItem
            // 
            this.productsReportToolStripMenuItem.Name = "productsReportToolStripMenuItem";
            this.productsReportToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.productsReportToolStripMenuItem.Text = "Products report";
            this.productsReportToolStripMenuItem.Click += new System.EventHandler(this.productsReportToolStripMenuItem_Click);
            // 
            // searchProductToolStripMenuItem
            // 
            this.searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            this.searchProductToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchProductToolStripMenuItem.Text = "Search product";
            this.searchProductToolStripMenuItem.Click += new System.EventHandler(this.searchProductToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsReportToolStripMenuItem,
            this.searchClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // clientsReportToolStripMenuItem
            // 
            this.clientsReportToolStripMenuItem.Name = "clientsReportToolStripMenuItem";
            this.clientsReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientsReportToolStripMenuItem.Text = "Clients report";
            this.clientsReportToolStripMenuItem.Click += new System.EventHandler(this.clientsReportToolStripMenuItem_Click);
            // 
            // searchClientToolStripMenuItem
            // 
            this.searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem";
            this.searchClientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchClientToolStripMenuItem.Text = "Search client";
            this.searchClientToolStripMenuItem.Click += new System.EventHandler(this.searchClientToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsReportToolStripMenuItem,
            this.searchGroupToolStripMenuItem});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // groupsReportToolStripMenuItem
            // 
            this.groupsReportToolStripMenuItem.Name = "groupsReportToolStripMenuItem";
            this.groupsReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.groupsReportToolStripMenuItem.Text = "Groups report";
            this.groupsReportToolStripMenuItem.Click += new System.EventHandler(this.groupsReportToolStripMenuItem_Click);
            // 
            // searchGroupToolStripMenuItem
            // 
            this.searchGroupToolStripMenuItem.Name = "searchGroupToolStripMenuItem";
            this.searchGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchGroupToolStripMenuItem.Text = "Search group";
            this.searchGroupToolStripMenuItem.Click += new System.EventHandler(this.searchGroupToolStripMenuItem_Click);
            // 
            // paymentTypesToolStripMenuItem
            // 
            this.paymentTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentTypesReportToolStripMenuItem,
            this.searchPaymentTypeToolStripMenuItem});
            this.paymentTypesToolStripMenuItem.Name = "paymentTypesToolStripMenuItem";
            this.paymentTypesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.paymentTypesToolStripMenuItem.Text = "Payment types";
            // 
            // paymentTypesReportToolStripMenuItem
            // 
            this.paymentTypesReportToolStripMenuItem.Name = "paymentTypesReportToolStripMenuItem";
            this.paymentTypesReportToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.paymentTypesReportToolStripMenuItem.Text = "Payment types report";
            this.paymentTypesReportToolStripMenuItem.Click += new System.EventHandler(this.paymentTypesReportToolStripMenuItem_Click);
            // 
            // searchPaymentTypeToolStripMenuItem
            // 
            this.searchPaymentTypeToolStripMenuItem.Name = "searchPaymentTypeToolStripMenuItem";
            this.searchPaymentTypeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.searchPaymentTypeToolStripMenuItem.Text = "Search payment type";
            this.searchPaymentTypeToolStripMenuItem.Click += new System.EventHandler(this.searchPaymentTypeToolStripMenuItem_Click);
            // 
            // shippersToolStripMenuItem
            // 
            this.shippersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shippersReportToolStripMenuItem,
            this.searchShipperToolStripMenuItem});
            this.shippersToolStripMenuItem.Name = "shippersToolStripMenuItem";
            this.shippersToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.shippersToolStripMenuItem.Text = "Shippers";
            // 
            // shippersReportToolStripMenuItem
            // 
            this.shippersReportToolStripMenuItem.Name = "shippersReportToolStripMenuItem";
            this.shippersReportToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.shippersReportToolStripMenuItem.Text = "Shippers report";
            this.shippersReportToolStripMenuItem.Click += new System.EventHandler(this.shippersReportToolStripMenuItem_Click);
            // 
            // searchShipperToolStripMenuItem
            // 
            this.searchShipperToolStripMenuItem.Name = "searchShipperToolStripMenuItem";
            this.searchShipperToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.searchShipperToolStripMenuItem.Text = "Search shipper";
            this.searchShipperToolStripMenuItem.Click += new System.EventHandler(this.searchShipperToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignmentToolStripMenuItem,
            this.closeAllWindowsToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // alignmentToolStripMenuItem
            // 
            this.alignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.cascadeToolStripMenuItem});
            this.alignmentToolStripMenuItem.Name = "alignmentToolStripMenuItem";
            this.alignmentToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.alignmentToolStripMenuItem.Text = "Alignment";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // closeAllWindowsToolStripMenuItem
            // 
            this.closeAllWindowsToolStripMenuItem.Name = "closeAllWindowsToolStripMenuItem";
            this.closeAllWindowsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeAllWindowsToolStripMenuItem.Text = "Close all windows";
            this.closeAllWindowsToolStripMenuItem.Click += new System.EventHandler(this.closeAllWindowsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 400);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sales Module";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentTypesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPaymentTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippersReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchShipperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waitingOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectedToolStripMenuItem;
    }
}