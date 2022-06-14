using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {
    public class TableDAO {

        private static TableDAO instance;

        public static TableDAO Instance {
            get {
                if (TableDAO.instance == null) {
                    TableDAO.instance = new TableDAO();
                }
                return TableDAO.instance;
            }
           private set => TableDAO.instance = value;
        }

        private TableDAO() {
        }

        public  List<Table> LoadTableList() {
            String sql = "EXEC dbo.USP_GetTableList";
            List<Table> tableList = new List<Table>();
                DataTable dataTable = DAO.DataProvider.Instance.ExecuteQuery(sql);
            tableList = (from DataRow row in dataTable.Rows
                         select new Table() {
                             Id = Convert.ToInt32(row[0]),
                             Name = row[1].ToString(),
                             Status = row[2].ToString()

                         }).ToList() ;

            return tableList;
        }

        public void ChangeTableStatus(int tableId) {
            String sql = "EXEC dbo.USP_ChangeTableStatus @tableid ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tableId });

        }

        public void SwitchTable(int id1,int id2) {
            String sql = "EXEC dbo.USP_SwitchTable @idTable1 , @idTable2 ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(sql,new object[] { id1, id2 });
        }
    }

}
