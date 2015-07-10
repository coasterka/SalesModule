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
    public partial class SearchOrder : Form
    {
        public static int CurrentOrderID;
        public SearchOrder()
        {
            InitializeComponent();
        }

        private void btnCancelSearchOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            SqlConnection con = Program.CreateConnection();
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                if (txtBoxOrderID.Text != "")
                {
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE OrderID LIKE '%" + txtBoxOrderID.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE OrderID LIKE '%" + txtBoxOrderID.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE OrderID LIKE '%" + txtBoxOrderID.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxOrderID.Clear();
                }
                else if (txtBoxCustID.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE CustID LIKE '%" + txtBoxCustID.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE CustID LIKE '%" + txtBoxCustID.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE CustID LIKE '%" + txtBoxCustID.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE CustID LIKE '%" + txtBoxCustID.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxCustID.Clear();
                }
                else if (txtBoxProdID.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ProdID LIKE '%" + txtBoxProdID.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ProdID LIKE '%" + txtBoxProdID.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE ProdID LIKE '%" + txtBoxProdID.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE ProdID LIKE '%" + txtBoxProdID.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxProdID.Clear();
                }
                else if (txtBoxShipperName.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ShipperName LIKE '%" + txtBoxShipperName.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ShipperName LIKE '%" + txtBoxShipperName.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE ShipperName LIKE '%" + txtBoxShipperName.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE ShipperName LIKE '%" + txtBoxShipperName.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxShipperName.Clear();
                }
                else if (txtBoxPaymentType.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE PaymentTypeName LIKE '%" + txtBoxPaymentType.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE PaymentTypeName LIKE '%" + txtBoxPaymentType.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE PaymentTypeName LIKE '%" + txtBoxPaymentType.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE PaymentTypeName LIKE '%" + txtBoxPaymentType.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxPaymentType.Clear();
                }
                else if (txtBoxUsername.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE UserName LIKE '%" + txtBoxUsername.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE UserName LIKE '%" + txtBoxUsername.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE UserName LIKE '%" + txtBoxUsername.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE UserName LIKE '%" + txtBoxUsername.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxUsername.Clear();
                }
                else if (txtBoxProdName.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ProdName LIKE '%" + txtBoxProdName.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ProdName LIKE '%" + txtBoxProdName.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE ProdName LIKE '%" + txtBoxProdName.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE ProdName LIKE '%" + txtBoxProdName.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxProdName.Clear();
                }
                else if (txtBoxEmail.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE CustEmail LIKE '%" + txtBoxEmail.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE CustEmail LIKE '%" + txtBoxEmail.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE CustEmail LIKE '%" + txtBoxEmail.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE CustEmail LIKE '%" + txtBoxEmail.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxEmail.Clear();
                }
                else if (txtBoxProdPrice.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ProdPrice LIKE '%" + txtBoxProdPrice.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE ProdPrice LIKE '%" + txtBoxProdPrice.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE ProdPrice LIKE '%" + txtBoxProdPrice.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE ProdPrice LIKE '%" + txtBoxProdPrice.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxProdPrice.Clear();
                }
                else if (txtBoxQuantity.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE Quantity LIKE '" + txtBoxQuantity.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE Quantity LIKE '%" + txtBoxQuantity.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE Quantity LIKE '%" + txtBoxQuantity.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE Quantity LIKE '%" + txtBoxQuantity.Text + "%' " +
                        "ORDER BY OrderID",
                        con);
                    txtBoxQuantity.Clear();
                }
                else if (txtBoxOrderAmount.Text != "")
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE OrderAmount LIKE '%" + txtBoxOrderAmount.Text + "%' ", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders WHERE OrderAmount LIKE '%" + txtBoxOrderAmount.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders WHERE OrderAmount LIKE '%" + txtBoxOrderAmount.Text + "%' " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders WHERE OrderAmount LIKE '%" + txtBoxOrderAmount.Text + "%' " +
                        "ORDER BY OrderID",
                        con);                    
                    txtBoxOrderAmount.Clear();
                }
                else
                {
                    //sda = new SqlDataAdapter("SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders", con);
                    sda = new SqlDataAdapter(
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM Orders " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM RejectedOrders " +
                        "UNION " +
                        "SELECT OrderID, CustID, ProdID, ShipperName, PaymentTypeName, UserName, ProdName, CustEmail, ProdPrice, Quantity, OrderDate, OrderAmount FROM ApprovedOrders " +
                        "ORDER BY OrderID",
                        con);
                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSearchOrder.DataSource = dt;
            }
        }

        private void dataGridViewSearchOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CurrentOrderID = Convert.ToInt16(dataGridViewSearchOrder.SelectedRows[0].Cells[0].Value);
            ManageOrder manageOrderFrm = new ManageOrder();
            manageOrderFrm.Owner = this;
            manageOrderFrm.ShowDialog();
        }
    }
}
