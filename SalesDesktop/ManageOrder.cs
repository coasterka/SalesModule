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
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
        }

        private void ManageOrder_Load(object sender, EventArgs e)
        {            
            CenterToScreen();

            DataTable dt = new DataTable();
            DataRow dataRowFiller;
            if (this.Owner.Name.ToString() == "SearchOrder")
            {
                Text = "View order №" + SearchOrder.CurrentOrderID.ToString();
                dt = getOrderByID(SearchOrder.CurrentOrderID.ToString());
                btnApprove.Visible = false;
                btnDisapprove.Visible = false;
                btnCancel.Text = "OK";
                lblInfo.Visible = true;
            }
            else if (this.Owner.Name.ToString() == "ReportOrders")
            {
                Text = "Manage order №" + ReportOrders.CurrentOrderID.ToString();
                dt = getOrderByID(ReportOrders.CurrentOrderID.ToString());
            }
            dataRowFiller = dt.Rows[0];
            this.txtBoxOrderID.Text = dataRowFiller["OrderID"].ToString();
            this.ordersTableAdapter.FillBy(this.aSPNETDB_DataSet.Orders, Convert.ToInt32(this.txtBoxOrderID.Text));
            txtBoxUsername.Text = dataRowFiller["UserName"].ToString();
            txtBoxProdName.Text = dataRowFiller["ProdName"].ToString();
            txtBoxPayment.Text = dataRowFiller["PaymentTypeName"].ToString();
            txtBoxShipper.Text = dataRowFiller["ShipperName"].ToString();
            txtBoxEmail.Text = dataRowFiller["CustEmail"].ToString();
            txtBoxDelivNotes.Text = dataRowFiller["DeliveryNotes"].ToString();
            txtBoxOrderAmount.Text = dataRowFiller["OrderAmount"].ToString();

            string isRisky = "";
            SqlConnection connIsRisky = Program.CreateConnection();
            SqlCommand commandIsRisky = new SqlCommand();
            try
            {
                using (connIsRisky)
                {
                    connIsRisky.Open();
                    commandIsRisky.Connection = connIsRisky;
                    commandIsRisky.CommandText = "SELECT isRisky FROM aspnet_Users WHERE UserName='" + txtBoxUsername.Text + "'";
                    isRisky = commandIsRisky.ExecuteScalar().ToString();
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message.ToString());
                connIsRisky.Close();
            }

            txtBoxRiskyCustomer.Text = isRisky;
        }        

        public DataTable getOrderByID(String pStrID)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = Program.CreateConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (conn)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT OrderID, UserName, ProdName, PaymentTypeName, ShipperName, CustEmail, DeliveryNotes, OrderAmount FROM Orders WHERE OrderID='" + pStrID + "' " +
                                      "UNION " +
                                      "SELECT OrderID, UserName, ProdName, PaymentTypeName, ShipperName, CustEmail, DeliveryNotes, OrderAmount FROM RejectedOrders WHERE OrderID='" + pStrID + "' " +
                                      "UNION " +
                                      "SELECT OrderID, UserName, ProdName, PaymentTypeName, ShipperName, CustEmail, DeliveryNotes, OrderAmount FROM ApprovedOrders WHERE OrderID='" + pStrID + "'";
                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (SqlException)
            {
                conn.Close();
            }
            return dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = Program.CreateConnection();

            using (sqlConn)
            {
                //insert approved order in dbo.ApprovedOrders

                SqlCommand command = new SqlCommand("insert_approved_order", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "insert_approved_order";

                SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.Int);
                OrderID.Value = ordersDataGridView.Rows[0].Cells[0].Value;
                command.Parameters.Add(OrderID);

                SqlParameter CustID = new SqlParameter("@CustID", SqlDbType.UniqueIdentifier);
                CustID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[1].Value.ToString());
                command.Parameters.Add(CustID);

                SqlParameter ProdID = new SqlParameter("@ProdID", SqlDbType.UniqueIdentifier);
                ProdID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[2].Value.ToString());
                command.Parameters.Add(ProdID);

                SqlParameter ShipperID = new SqlParameter("@ShipperID", SqlDbType.UniqueIdentifier);
                ShipperID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[3].Value.ToString());
                command.Parameters.Add(ShipperID);

                SqlParameter PaymentTypeID = new SqlParameter("@PaymentTypeID", SqlDbType.UniqueIdentifier);
                PaymentTypeID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[4].Value.ToString());
                command.Parameters.Add(PaymentTypeID);

                SqlParameter ShipperName = new SqlParameter("@ShipperName", SqlDbType.NVarChar);
                ShipperName.Value = ordersDataGridView.Rows[0].Cells[5].Value;
                command.Parameters.Add(ShipperName);

                SqlParameter PaymentTypeName = new SqlParameter("@PaymentTypeName", SqlDbType.NVarChar);
                PaymentTypeName.Value = ordersDataGridView.Rows[0].Cells[6].Value;
                command.Parameters.Add(PaymentTypeName);

                SqlParameter ProdName = new SqlParameter("@ProdName", SqlDbType.NVarChar);
                ProdName.Value = ordersDataGridView.Rows[0].Cells[7].Value;
                command.Parameters.Add(ProdName);

                SqlParameter CustEmail = new SqlParameter("@CustEmail", SqlDbType.NVarChar);
                CustEmail.Value = ordersDataGridView.Rows[0].Cells[8].Value;
                command.Parameters.Add(CustEmail);

                SqlParameter ProdPrice = new SqlParameter("@ProdPrice", SqlDbType.Money);
                ProdPrice.Value = ordersDataGridView.Rows[0].Cells[9].Value;
                command.Parameters.Add(ProdPrice);

                SqlParameter Quantity = new SqlParameter("@Quantity", SqlDbType.Int);
                Quantity.Value = ordersDataGridView.Rows[0].Cells[10].Value;
                command.Parameters.Add(Quantity);

                SqlParameter OrderDate = new SqlParameter("@OrderDate", SqlDbType.Date);
                OrderDate.Value = ordersDataGridView.Rows[0].Cells[11].Value;
                command.Parameters.Add(OrderDate);

                SqlParameter DeliveryNotes = new SqlParameter("@DeliveryNotes", SqlDbType.NVarChar);
                DeliveryNotes.Value = ordersDataGridView.Rows[0].Cells[12].Value;
                command.Parameters.Add(DeliveryNotes);

                SqlParameter UserName = new SqlParameter("@UserName", SqlDbType.NVarChar);
                UserName.Value = ordersDataGridView.Rows[0].Cells[13].Value;
                command.Parameters.Add(UserName);

                SqlParameter OrderAmount = new SqlParameter("@OrderAmount", SqlDbType.Money);
                OrderAmount.Value = ordersDataGridView.Rows[0].Cells[14].Value;
                command.Parameters.Add(OrderAmount);

                try
                {
                    sqlConn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Order approved successfully!");
                    Close();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message.ToString());
                }
                sqlConn.Close();
            }
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = Program.CreateConnection();

            using (sqlConn)
            {
                //insert rejected order in dbo.RejectedOrders

                SqlCommand command = new SqlCommand("insert_rejected_order", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "insert_rejected_order";

                SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.Int);
                OrderID.Value = ordersDataGridView.Rows[0].Cells[0].Value;
                command.Parameters.Add(OrderID);

                SqlParameter CustID = new SqlParameter("@CustID", SqlDbType.UniqueIdentifier);
                CustID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[1].Value.ToString());
                command.Parameters.Add(CustID);

                SqlParameter ProdID = new SqlParameter("@ProdID", SqlDbType.UniqueIdentifier);
                ProdID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[2].Value.ToString());
                command.Parameters.Add(ProdID);

                SqlParameter ShipperID = new SqlParameter("@ShipperID", SqlDbType.UniqueIdentifier);
                ShipperID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[3].Value.ToString());
                command.Parameters.Add(ShipperID);

                SqlParameter PaymentTypeID = new SqlParameter("@PaymentTypeID", SqlDbType.UniqueIdentifier);
                PaymentTypeID.Value = Guid.Parse(ordersDataGridView.Rows[0].Cells[4].Value.ToString());
                command.Parameters.Add(PaymentTypeID);

                SqlParameter ShipperName = new SqlParameter("@ShipperName", SqlDbType.NVarChar);
                ShipperName.Value = ordersDataGridView.Rows[0].Cells[5].Value;
                command.Parameters.Add(ShipperName);

                SqlParameter PaymentTypeName = new SqlParameter("@PaymentTypeName", SqlDbType.NVarChar);
                PaymentTypeName.Value = ordersDataGridView.Rows[0].Cells[6].Value;
                command.Parameters.Add(PaymentTypeName);

                SqlParameter ProdName = new SqlParameter("@ProdName", SqlDbType.NVarChar);
                ProdName.Value = ordersDataGridView.Rows[0].Cells[7].Value;
                command.Parameters.Add(ProdName);

                SqlParameter CustEmail = new SqlParameter("@CustEmail", SqlDbType.NVarChar);
                CustEmail.Value = ordersDataGridView.Rows[0].Cells[8].Value;
                command.Parameters.Add(CustEmail);

                SqlParameter ProdPrice = new SqlParameter("@ProdPrice", SqlDbType.Money);
                ProdPrice.Value = ordersDataGridView.Rows[0].Cells[9].Value;
                command.Parameters.Add(ProdPrice);

                SqlParameter Quantity = new SqlParameter("@Quantity", SqlDbType.Int);
                Quantity.Value = ordersDataGridView.Rows[0].Cells[10].Value;
                command.Parameters.Add(Quantity);

                SqlParameter OrderDate = new SqlParameter("@OrderDate", SqlDbType.Date);
                OrderDate.Value = ordersDataGridView.Rows[0].Cells[11].Value;
                command.Parameters.Add(OrderDate);

                SqlParameter DeliveryNotes = new SqlParameter("@DeliveryNotes", SqlDbType.NVarChar);
                DeliveryNotes.Value = ordersDataGridView.Rows[0].Cells[12].Value;
                command.Parameters.Add(DeliveryNotes);

                SqlParameter UserName = new SqlParameter("@UserName", SqlDbType.NVarChar);
                UserName.Value = ordersDataGridView.Rows[0].Cells[13].Value;
                command.Parameters.Add(UserName);

                SqlParameter OrderAmount = new SqlParameter("@OrderAmount", SqlDbType.Money);
                OrderAmount.Value = ordersDataGridView.Rows[0].Cells[14].Value;
                command.Parameters.Add(OrderAmount);

                try
                {
                    sqlConn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Order rejected successfully!");
                    Close();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message.ToString());
                }
                sqlConn.Close();
            }
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aSPNETDB_DataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillBy(this.aSPNETDB_DataSet.Orders, ((int)(System.Convert.ChangeType(currOrdIdToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
