namespace SalesDesktop
{
    partial class SearchGroup
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
            this.txtBoxGroupID = new System.Windows.Forms.TextBox();
            this.txtBoxDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtBoxHasDiscount = new System.Windows.Forms.TextBox();
            this.txtBoxGroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchGroup = new System.Windows.Forms.Button();
            this.btnCancelSearchGroup = new System.Windows.Forms.Button();
            this.dataGridViewSearchGroup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group ID:";
            // 
            // txtBoxGroupID
            // 
            this.txtBoxGroupID.Location = new System.Drawing.Point(83, 10);
            this.txtBoxGroupID.Name = "txtBoxGroupID";
            this.txtBoxGroupID.Size = new System.Drawing.Size(171, 20);
            this.txtBoxGroupID.TabIndex = 1;
            // 
            // txtBoxDiscountPercent
            // 
            this.txtBoxDiscountPercent.Location = new System.Drawing.Point(383, 36);
            this.txtBoxDiscountPercent.Name = "txtBoxDiscountPercent";
            this.txtBoxDiscountPercent.Size = new System.Drawing.Size(171, 20);
            this.txtBoxDiscountPercent.TabIndex = 2;
            // 
            // txtBoxHasDiscount
            // 
            this.txtBoxHasDiscount.Location = new System.Drawing.Point(383, 10);
            this.txtBoxHasDiscount.Name = "txtBoxHasDiscount";
            this.txtBoxHasDiscount.Size = new System.Drawing.Size(171, 20);
            this.txtBoxHasDiscount.TabIndex = 3;
            // 
            // txtBoxGroupName
            // 
            this.txtBoxGroupName.Location = new System.Drawing.Point(83, 36);
            this.txtBoxGroupName.Name = "txtBoxGroupName";
            this.txtBoxGroupName.Size = new System.Drawing.Size(171, 20);
            this.txtBoxGroupName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Discount percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Has discount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Group name:";
            // 
            // btnSearchGroup
            // 
            this.btnSearchGroup.Location = new System.Drawing.Point(605, 8);
            this.btnSearchGroup.Name = "btnSearchGroup";
            this.btnSearchGroup.Size = new System.Drawing.Size(112, 23);
            this.btnSearchGroup.TabIndex = 8;
            this.btnSearchGroup.Text = "Search";
            this.btnSearchGroup.UseVisualStyleBackColor = true;
            this.btnSearchGroup.Click += new System.EventHandler(this.btnSearchGroup_Click);
            // 
            // btnCancelSearchGroup
            // 
            this.btnCancelSearchGroup.Location = new System.Drawing.Point(605, 34);
            this.btnCancelSearchGroup.Name = "btnCancelSearchGroup";
            this.btnCancelSearchGroup.Size = new System.Drawing.Size(112, 23);
            this.btnCancelSearchGroup.TabIndex = 9;
            this.btnCancelSearchGroup.Text = "Cancel";
            this.btnCancelSearchGroup.UseVisualStyleBackColor = true;
            this.btnCancelSearchGroup.Click += new System.EventHandler(this.btnCancelSearchGroup_Click);
            // 
            // dataGridViewSearchGroup
            // 
            this.dataGridViewSearchGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchGroup.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewSearchGroup.Name = "dataGridViewSearchGroup";
            this.dataGridViewSearchGroup.Size = new System.Drawing.Size(705, 296);
            this.dataGridViewSearchGroup.TabIndex = 10;
            // 
            // SearchGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 370);
            this.Controls.Add(this.dataGridViewSearchGroup);
            this.Controls.Add(this.btnCancelSearchGroup);
            this.Controls.Add(this.btnSearchGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxGroupName);
            this.Controls.Add(this.txtBoxHasDiscount);
            this.Controls.Add(this.txtBoxDiscountPercent);
            this.Controls.Add(this.txtBoxGroupID);
            this.Controls.Add(this.label1);
            this.Name = "SearchGroup";
            this.Text = "Search group";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchGroup_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxGroupID;
        private System.Windows.Forms.TextBox txtBoxDiscountPercent;
        private System.Windows.Forms.TextBox txtBoxHasDiscount;
        private System.Windows.Forms.TextBox txtBoxGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchGroup;
        private System.Windows.Forms.Button btnCancelSearchGroup;
        private System.Windows.Forms.DataGridView dataGridViewSearchGroup;
    }
}