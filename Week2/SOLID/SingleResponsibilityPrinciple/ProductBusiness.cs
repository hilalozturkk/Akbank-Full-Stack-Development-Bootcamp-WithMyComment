using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    //product operations
    public class ProductBusiness
    {//task -> add data to database and return result
        public int AddProduct(string name, decimal price)
        {
            var connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            DBHelper dBHelper = new DBHelper(connectionString);
            var commandText = "INSERT into Products(ProductName, UnitPrice) values (@name, @price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            int affectedRowCount = dBHelper.Execute(commandText, parameters);

            //SqlConnection sqlConnecion = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            //SqlCommand sqlCommand = new SqlCommand("INSERT into Products(ProductName, UnitPrice) values (@name, @price)", sqlConnecion);
            //sqlCommand.Parameters.AddWithValue("@name", name);
            //sqlCommand.Parameters.AddWithValue("@price", price);

            //sqlConnecion.Open();
            //var affectedRowCount = sqlCommand.ExecuteNonQuery();
            //sqlConnecion.Close();



            return affectedRowCount;
            //var message = affectedRowCount > 0 ? "Success" : "Failed";

        }
    }
}
