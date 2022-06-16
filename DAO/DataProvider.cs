using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {
    public class DataProvider {

        private static DataProvider instance;
        public static DataProvider Instance {
            get {
                if (DataProvider.instance == null) {
                    DataProvider.instance = new DataProvider();
                }
                return DataProvider.instance;
            }
            private set {
                DataProvider.instance = value;
            }
        }

        private DataProvider() {
        }

        public static SqlConnection GetConnection() {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string ConStr = config.GetConnectionString("CafeConStr");
            return new SqlConnection(ConStr);
        }


        public DataTable ExecuteQuery(String sql,object[] parameters = null) {

            DataTable dataTable = new DataTable();
            try {
                using (SqlConnection connection = GetConnection()) {
                    SqlCommand command = new SqlCommand(sql,connection);
                    if (parameters != null) {
                        string[] listPara = sql.Split(' ');
                        int i = 0;
                        foreach (String item in listPara) {

                            if (item.Contains('@')) {
                                command.Parameters.AddWithValue(item,parameters[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(dataTable);


                }
            } catch (Exception) {

                return null;
            }
      

            return dataTable;

        }

        public int ExecuteNonQuery(String sql,object[] parameters = null) {
            int dataLineSuccess;
            try {
                SqlConnection connection = GetConnection();
                SqlCommand command = new SqlCommand(sql,connection);
                connection.Open();
                if (parameters != null) {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (String item in listPara) {

                        if (item.Contains('@')) {
                            command.Parameters.AddWithValue(item,parameters[i]);
                            i++;
                        }
                    }
                }
                dataLineSuccess = command.ExecuteNonQuery();
                connection.Close();
            } catch (Exception) {

                return -1;
            }
      
            return dataLineSuccess;
        }

        public int ExecuteNonQuerySql(String sql,SqlParameter[] parameters = null) {
            int dataLineSuccess;

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql,connection);
            connection.Open();
            if (parameters != null) {


                foreach (SqlParameter item in parameters) {
                    command.Parameters.Add(item);
                }
            }
            dataLineSuccess = command.ExecuteNonQuery();
            connection.Close();
            return dataLineSuccess;
        }

        public object ExecuteScalar(String sql,object[] parameters = null) {
            object dataRow;

            using (SqlConnection connection = GetConnection()) {
                SqlCommand command = new SqlCommand(sql,connection);

                if (parameters != null) {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (String item in listPara) {

                        if (item.Contains('@')) {
                            command.Parameters.AddWithValue(item,parameters[i]);
                            i++;
                        }
                    }
                }
                dataRow = command.ExecuteScalar();
            }
            return dataRow;

        }

    }
}
