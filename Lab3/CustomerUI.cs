using CustomerBusinessLogics;
using DataAccessLayer;
using System.Data;

namespace Lab3
{
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            CustomerDAL dal = new CustomerDAL();
            DataSet customers = dal.Read();
            customersDataGrid.DataSource = customers.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtBillAmount.Text, out decimal billAmount))
                {
                    MessageBox.Show("Bill Amount must be a valid number!");
                    return;
                }
                Customer customer = new Customer();
                customer.CustomerName = txtCustomerName.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;
                customer.ProductName = txtProductName.Text;
                customer.BillAmount = billAmount;
                if (customer.Validate())
                {
                    CustomerDAL dal = new CustomerDAL();
                    dal.Add(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CustomerUI_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
