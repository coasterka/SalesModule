namespace SalesDesktop
{
    partial class SearchProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxProdID = new System.Windows.Forms.TextBox();
            this.txtBoxProdBrand = new System.Windows.Forms.TextBox();
            this.txtBoxProdType = new System.Windows.Forms.TextBox();
            this.txtBoxProdAvail = new System.Windows.Forms.TextBox();
            this.txtBoxProdSale = new System.Windows.Forms.TextBox();
            this.txtBoxProdPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchProd = new System.Windows.Forms.Button();
            this.btnCancelSearchProd = new System.Windows.Forms.Button();
            this.dataGridViewSearchProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // txtBoxProdID
            // 
            this.txtBoxProdID.Location = new System.Drawing.Point(109, 10);
            this.txtBoxProdID.Name = "txtBoxProdID";
            this.txtBoxProdID.Size = new System.Drawing.Size(153, 20);
            this.txtBoxProdID.TabIndex = 1;
            // 
            // txtBoxProdBrand
            // 
            this.txtBoxProdBrand.Location = new System.Drawing.Point(109, 62);
            this.txtBoxProdBrand.Name = "txtBoxProdBrand";
            this.txtBoxProdBrand.Size = new System.Drawing.Size(153, 20);
            this.txtBoxProdBrand.TabIndex = 2;
            // 
            // txtBoxProdType
            // 
            this.txtBoxProdType.Location = new System.Drawing.Point(109, 36);
            this.txtBoxProdType.Name = "txtBoxProdType";
            this.txtBoxProdType.Size = new System.Drawing.Size(153, 20);
            this.txtBoxProdType.TabIndex = 3;
            // 
            // txtBoxProdAvail
            // 
            this.txtBoxProdAvail.Location = new System.Drawing.Point(404, 36);
            this.txtBoxProdAvail.Name = "txtBoxProdAvail";
            this.txtBoxProdAvail.Size = new System.Drawing.Size(153, 20);
            this.txtBoxProdAvail.TabIndex = 6;
            // 
            // txtBoxProdSale
            // 
            this.txtBoxProdSale.Location = new System.Drawing.Point(404, 62);
            this.txtBoxProdSale.Name = "txtBoxProdSale";
            this.txtBoxProdSale.Size = new System.Drawing.Size(153, 20);
            this.txtBoxProdSale.TabIndex = 5;
            // 
            // txtBoxProdPrice
            // 
            this.txtBoxProdPrice.Location = new System.Drawing.Point(404, 10);
            this.txtBoxProdPrice.Name = "txtBoxProdPrice";
            this.txtBoxProdPrice.Size = new System.Drawing.Size(153, 20);
            this.txtBoxProdPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Available:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Product brand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Product type:";
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Location = new System.Drawing.Point(594, 8);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(112, 23);
            this.btnSearchProd.TabIndex = 12;
            this.btnSearchProd.Text = "Search";
            this.btnSearchProd.UseVisualStyleBackColor = true;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // btnCancelSearchProd
            // 
            this.btnCancelSearchProd.Location = new System.Drawing.Point(594, 34);
            this.btnCancelSearchProd.Name = "btnCancelSearchProd";
            this.btnCancelSearchProd.Size = new System.Drawing.Size(112, 23);
            this.btnCancelSearchProd.TabIndex = 13;
            this.btnCancelSearchProd.Text = "Cancel";
            this.btnCancelSearchProd.UseVisualStyleBackColor = true;
            this.btnCancelSearchProd.Click += new System.EventHandler(this.btnCancelSearchProd_Click);
            // 
            // dataGridViewSearchProd
            // 
            this.dataGridViewSearchProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchProd.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewSearchProd.Name = "dataGridViewSearchProd";
            this.dataGridViewSearchProd.Size = new System.Drawing.Size(705, 259);
            this.dataGridViewSearchProd.TabIndex = 14;
            // 
            // SearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 370);
            this.Controls.Add(this.dataGridViewSearchProd);
            this.Controls.Add(this.btnCancelSearchProd);
            this.Controls.Add(this.btnSearchProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxProdAvail);
            this.Controls.Add(this.txtBoxProdSale);
            this.Controls.Add(this.txtBoxProdPrice);
            this.Controls.Add(this.txtBoxProdType);
            this.Controls.Add(this.txtBoxProdBrand);
            this.Controls.Add(this.txtBoxProdID);
            this.Controls.Add(this.label1);
            this.Name = "SearchProduct";
            this.Text = "Search product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchProduct_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxProdID;
        private System.Windows.Forms.TextBox txtBoxProdBrand;
        private System.Windows.Forms.TextBox txtBoxProdType;
        private System.Windows.Forms.TextBox txtBoxProdAvail;
        private System.Windows.Forms.TextBox txtBoxProdSale;
        private System.Windows.Forms.TextBox txtBoxProdPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchProd;
        private System.Windows.Forms.Button btnCancelSearchProd;
        private System.Windows.Forms.DataGridView dataGridViewSearchProd;
    }
}