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
    public class CategoryRepository
    {
        //Connection
        private string connectionString = @"Server=DESKTOP-OKE8LIF\SQLEXPRESS; Database=StockManagementSystem; Integrated Security=True";
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;


        public int Insert(Category category)
        {
            sqlConnection = new SqlConnection(connectionString);
            //
            sqlConnection.Open();

            commandString = @"INSERT INTO Categories VALUES ('" + category.CategoryName + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            //
            sqlConnection.Close();
            return isExecuted;
        }

        public int Update(Category category)
        {
            sqlConnection = new SqlConnection(connectionString);
            //
            sqlConnection.Open();

            commandString = @"UPDATE Categories SET [CategoryName] = '" + category.CategoryName + "' WHERE Categories.CategoryID = '" + category.CategoryID+"'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            //
            sqlConnection.Close();
            return isExecuted;
        }

        public DataTable ShowCategory()
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
            //  displayDataGridView.DataSource = dataTable;
            //
            sqlConnection.Close();

            return dataTable;
        }
    }
}
