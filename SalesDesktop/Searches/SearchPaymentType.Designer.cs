namespace SalesDesktop
{
    partial class SearchPaymentType
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
            this.txtBoxPaymentID = new System.Windows.Forms.TextBox();
            this.txtBoxPaymentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchPayment = new System.Windows.Forms.Button();
            this.btnCancelSearchPayment = new System.Windows.Forms.Button();
            this.dataGridViewSearchPayment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment type ID:";
            // 
            // txtBoxPaymentID
            // 
            this.txtBoxPaymentID.Location = new System.Drawing.Point(107, 10);
            this.txtBoxPaymentID.Name = "txtBoxPaymentID";
            this.txtBoxPaymentID.Size = new System.Drawing.Size(170, 20);
            this.txtBoxPaymentID.TabIndex = 1;
            // 
            // txtBoxPaymentName
            // 
            this.txtBoxPaymentName.Location = new System.Drawing.Point(392, 10);
            this.txtBoxPaymentName.Name = "txtBoxPaymentName";
            this.txtBoxPaymentName.Size = new System.Drawing.Size(170, 20);
            this.txtBoxPaymentName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment type name:";
            // 
            // btnSearchPayment
            // 
            this.btnSearchPayment.Location = new System.Drawing.Point(583, 8);
            this.btnSearchPayment.Name = "btnSearchPayment";
            this.btnSearchPayment.Size = new System.Drawing.Size(109, 23);
            this.btnSearchPayment.TabIndex = 4;
            this.btnSearchPayment.Text = "Search";
            this.btnSearchPayment.UseVisualStyleBackColor = true;
            this.btnSearchPayment.Click += new System.EventHandler(this.btnSearchPayment_Click);
            // 
            // btnCancelSearchPayment
            // 
            this.btnCancelSearchPayment.Location = new System.Drawing.Point(583, 37);
            this.btnCancelSearchPayment.Name = "btnCancelSearchPayment";
            this.btnCancelSearchPayment.Size = new System.Drawing.Size(109, 23);
            this.btnCancelSearchPayment.TabIndex = 5;
            this.btnCancelSearchPayment.Text = "Cancel";
            this.btnCancelSearchPayment.UseVisualStyleBackColor = true;
            this.btnCancelSearchPayment.Click += new System.EventHandler(this.btnCancelSearchPayment_Click);
            // 
            // dataGridViewSearchPayment
            // 
            this.dataGridViewSearchPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchPayment.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewSearchPayment.Name = "dataGridViewSearchPayment";
            this.dataGridViewSearchPayment.Size = new System.Drawing.Size(705, 292);
            this.dataGridViewSearchPayment.TabIndex = 6;
            // 
            // SearchPaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 370);
            this.Controls.Add(this.dataGridViewSearchPayment);
            this.Controls.Add(this.btnCancelSearchPayment);
            this.Controls.Add(this.btnSearchPayment);
            this.Controls.Add(this.txtBoxPaymentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPaymentID);
            this.Controls.Add(this.label1);
            this.Name = "SearchPaymentType";
            this.Text = "Search payment type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchPaymentType_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPaymentID;
        private System.Windows.Forms.TextBox txtBoxPaymentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchPayment;
        private System.Windows.Forms.Button btnCancelSearchPayment;
        private System.Windows.Forms.DataGridView dataGridViewSearchPayment;
    }
}