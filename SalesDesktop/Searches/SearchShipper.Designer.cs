namespace SalesDesktop
{
    partial class SearchShipper
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
            this.dataGridViewSearchShipper = new System.Windows.Forms.DataGridView();
            this.btnCancelSearchShipper = new System.Windows.Forms.Button();
            this.btnSearchShipper = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxShipperName = new System.Windows.Forms.TextBox();
            this.txtBoxHasTax = new System.Windows.Forms.TextBox();
            this.txtBoxTaxPercent = new System.Windows.Forms.TextBox();
            this.txtBoxShipperID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchShipper)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchShipper
            // 
            this.dataGridViewSearchShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchShipper.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewSearchShipper.Name = "dataGridViewSearchShipper";
            this.dataGridViewSearchShipper.Size = new System.Drawing.Size(705, 296);
            this.dataGridViewSearchShipper.TabIndex = 21;
            // 
            // btnCancelSearchShipper
            // 
            this.btnCancelSearchShipper.Location = new System.Drawing.Point(605, 36);
            this.btnCancelSearchShipper.Name = "btnCancelSearchShipper";
            this.btnCancelSearchShipper.Size = new System.Drawing.Size(112, 23);
            this.btnCancelSearchShipper.TabIndex = 20;
            this.btnCancelSearchShipper.Text = "Cancel";
            this.btnCancelSearchShipper.UseVisualStyleBackColor = true;
            this.btnCancelSearchShipper.Click += new System.EventHandler(this.btnCancelSearchShipper_Click);
            // 
            // btnSearchShipper
            // 
            this.btnSearchShipper.Location = new System.Drawing.Point(605, 10);
            this.btnSearchShipper.Name = "btnSearchShipper";
            this.btnSearchShipper.Size = new System.Drawing.Size(112, 23);
            this.btnSearchShipper.TabIndex = 19;
            this.btnSearchShipper.Text = "Search";
            this.btnSearchShipper.UseVisualStyleBackColor = true;
            this.btnSearchShipper.Click += new System.EventHandler(this.btnSearchShipper_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Shipper name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Has tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tax percent:";
            // 
            // txtBoxShipperName
            // 
            this.txtBoxShipperName.Location = new System.Drawing.Point(83, 38);
            this.txtBoxShipperName.Name = "txtBoxShipperName";
            this.txtBoxShipperName.Size = new System.Drawing.Size(171, 20);
            this.txtBoxShipperName.TabIndex = 15;
            // 
            // txtBoxHasTax
            // 
            this.txtBoxHasTax.Location = new System.Drawing.Point(383, 12);
            this.txtBoxHasTax.Name = "txtBoxHasTax";
            this.txtBoxHasTax.Size = new System.Drawing.Size(171, 20);
            this.txtBoxHasTax.TabIndex = 14;
            // 
            // txtBoxTaxPercent
            // 
            this.txtBoxTaxPercent.Location = new System.Drawing.Point(383, 38);
            this.txtBoxTaxPercent.Name = "txtBoxTaxPercent";
            this.txtBoxTaxPercent.Size = new System.Drawing.Size(171, 20);
            this.txtBoxTaxPercent.TabIndex = 13;
            // 
            // txtBoxShipperID
            // 
            this.txtBoxShipperID.Location = new System.Drawing.Point(83, 12);
            this.txtBoxShipperID.Name = "txtBoxShipperID";
            this.txtBoxShipperID.Size = new System.Drawing.Size(171, 20);
            this.txtBoxShipperID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shipper ID:";
            // 
            // SearchShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 370);
            this.Controls.Add(this.dataGridViewSearchShipper);
            this.Controls.Add(this.btnCancelSearchShipper);
            this.Controls.Add(this.btnSearchShipper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxShipperName);
            this.Controls.Add(this.txtBoxHasTax);
            this.Controls.Add(this.txtBoxTaxPercent);
            this.Controls.Add(this.txtBoxShipperID);
            this.Controls.Add(this.label1);
            this.Name = "SearchShipper";
            this.Text = "Search shipper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchShipper_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchShipper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearchShipper;
        private System.Windows.Forms.Button btnCancelSearchShipper;
        private System.Windows.Forms.Button btnSearchShipper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxShipperName;
        private System.Windows.Forms.TextBox txtBoxHasTax;
        private System.Windows.Forms.TextBox txtBoxTaxPercent;
        private System.Windows.Forms.TextBox txtBoxShipperID;
        private System.Windows.Forms.Label label1;
    }
}