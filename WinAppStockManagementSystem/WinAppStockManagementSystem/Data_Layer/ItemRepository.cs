using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WinAppStockManagementSystem.Presentation_Layer;
using System.Data;
using System.Windows.Forms;

namespace WinAppStockManagementSystem.Data_Layer
{
    public class ItemRepository
    {
        //Connection
        private string connectionString = @"Server=DESKTOP-OKE8LIF\SQLEXPRESS; Database=StockManagementSystem; Integrated Security=True";
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        public int Insert(Item item)
        {
            sqlConnection = new SqlConnection(connectionString);
            //
            sqlConnection.Open();

            commandString = @"INSERT INTO Items VALUES ('" + item.ItemName + "','"+item.CategoryName+"', '"+item.CompanyName+"','"+item.ReorderLevel+"')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            //
            sqlConnection.Close();
            return isExecuted;
        }
        public DataTable LoadCategory()
        {
            sqlConnection = new SqlConnection(connectionString);
            //
            sqlConnection.Open();

            //
            commandString = @"SELECT * FROM Categories";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //dataGridView.DataSource = dataTable;
            //
            sqlConnection.Close();

            return dataTable;
        }

        public DataTable LoadCompany()
        {
            sqlConnection = new SqlConnection(connectionString);
            //
            sqlConnection.Open();

            //
            commandString = @"SELECT * FROM Companies";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    dataGridView.DataSource = dataTable;
            //
            sqlConnection.Close();

            return dataTable;
        }

       

    }
}
