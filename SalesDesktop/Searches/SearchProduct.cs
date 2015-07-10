using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDesktop
{
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void btnCancelSearchProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }

        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            SqlConnection con = Program.CreateConnection();
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                if (txtBoxProdID.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ProdID, ProdType, ProdBrand, ProdPrice, ProdQty, ProdSale FROM Products WHERE ProdID LIKE '%" + txtBoxProdID.Text + "%' ", con);
                    txtBoxProdID.Clear();
                }
                else if (txtBoxProdType.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ProdID, ProdType, ProdBrand, ProdPrice, ProdQty, ProdSale FROM Products WHERE ProdType LIKE '%" + txtBoxProdType.Text + "%' ", con);
                    txtBoxProdType.Clear();
                }
                else if (txtBoxProdBrand.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ProdID, ProdType, ProdBrand, ProdPrice, ProdQty, ProdSale FROM Products WHERE ProdBrand LIKE '%" + txtBoxProdBrand.Text + "%' ", con);
                    txtBoxProdBrand.Clear();
                }
                else if (txtBoxProdPrice.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ProdID, ProdType, ProdBrand, ProdPrice, ProdQty, ProdSale FROM Products WHERE ProdPrice LIKE '%" + txtBoxProdPrice.Text + "%' ", con);
                    txtBoxProdPrice.Clear();
                }
                else if (txtBoxProdAvail.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ProdID, ProdType, ProdBrand, ProdPrice, ProdQty, ProdSale FROM Products WHERE ProdQty LIKE '" + txtBoxProdAvail.Text + "%' ", con);
                    txtBoxProdAvail.Clear();
                }
                else if (txtBoxProdSale.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ProdID, ProdType, ProdBrand, ProdPrice, ProdQty, ProdSale FROM Products WHERE ProdSale LIKE '%" + txtBoxProdSale.Text + "%' ", con);
                    txtBoxProdSale.Clear();
                }
                else
                {
                    sda = new SqlDataAdapter("SELECT ProdID, ProdType, ProdBrand, ProdPrice, ProdQty, ProdSale FROM Products", con);
                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSearchProd.DataSource = dt;
                DataGridViewColumn dgvc = dataGridViewSearchProd.Columns[0];
                dgvc.Width = 162;
            }
        }
    }
}
