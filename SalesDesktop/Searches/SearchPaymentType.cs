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
    public partial class SearchPaymentType : Form
    {
        public SearchPaymentType()
        {
            InitializeComponent();
        }

        private void btnCancelSearchPayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchPaymentType_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }

        private void btnSearchPayment_Click(object sender, EventArgs e)
        {
            SqlConnection con = Program.CreateConnection();
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                if (txtBoxPaymentID.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT PaymentTypeID, PaymentTypeName FROM PaymentTypes WHERE PaymentTypeID LIKE '%" + txtBoxPaymentID.Text + "%' ", con);
                    txtBoxPaymentID.Clear();
                }
                else if (txtBoxPaymentName.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT PaymentTypeID, PaymentTypeName FROM PaymentTypes WHERE PaymentTypeName LIKE '%" + txtBoxPaymentName.Text + "%' ", con);
                    txtBoxPaymentName.Clear();
                }
                else
                {
                    sda = new SqlDataAdapter("SELECT PaymentTypeID, PaymentTypeName FROM PaymentTypes", con);
                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSearchPayment.DataSource = dt;
            }
        }
    }
}
