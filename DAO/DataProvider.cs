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
            get { if (DataProvider.instance == null) {
                    DataProvider.instance = new DataProvider(); 
                } return DataProvider.instance; }
            private set {
                DataProvider.instance = value;
            }
        }

        private DataProvider() {
        }

        private string connectStr = "server=(local);database=QuanLyQuanCafe;user=sa;password=123456";

        public  DataTable ExecuteQuery(String sql, object[] parameters = null) {
          
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectStr)) {
                SqlCommand command = new SqlCommand(sql,connection);
                if(parameters != null) {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (String item in listPara) {

                        if (item.Contains('@')) {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
         
                adapter.Fill(dataTable);


            }
          

            return dataTable;

        }

        public  int ExecuteNonQuery(String sql,object[] parameters = null) {
            int dataLineSuccess ;

            SqlConnection connection = new SqlConnection(connectStr);
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
            return dataLineSuccess;
        }

        public  object ExecuteScalar(String sql,object[] parameters = null) {
            object dataRow;

            using (SqlConnection connection = new SqlConnection(connectStr)) {
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
