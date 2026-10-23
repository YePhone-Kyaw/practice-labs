using CustomerBusinessLogics;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    public class CustomerDAL
    {
        public bool Add(Customer obj)
        {
            // ADO.NET
            string connectionStr = @"Data Source=localhost;Initial Catalog=CustomerDb;Integrated Security=True;Trust Server Certificate=True";
            try
            {
                // Step 1: Open the connection
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                // Step 2: Execute SQL command
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Customer (CustomerName, PhoneNumber, ProductName, BillAmount) " +
                    "VALUES (@name, @phone, @product, @amount)", connection);

                command.Parameters.AddWithValue("@name", obj.CustomerName);
                command.Parameters.AddWithValue("@phone", obj.PhoneNumber);
                command.Parameters.AddWithValue("@product", obj.ProductName);
                command.Parameters.AddWithValue("@amount", obj.BillAmount);

                command.ExecuteNonQuery();

                // Step 3: Close the connection
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
