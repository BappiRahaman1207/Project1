using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WinAppStockManagementSystem.Presentation_Layer;
using System.Data;


namespace WinAppStockManagementSystem.Data_Layer
{
    public class StockInOutRepository
    {
        //Connection
        private string connectionString = @"Server=DESKTOP-OKE8LIF\SQLEXPRESS; Database=StockManagementSystem; Integrated Security=True";
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        public DataTable LoadItem(Company company)
        {
            sqlConnection = new SqlConnection(connectionString);
            //
            sqlConnection.Open();

            //
            //commandString = @"SELECT * FROM Items";
            commandString = @"SELECT * FROM Items WHERE CompanyID = '" + company.CompanyID + "'";
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
