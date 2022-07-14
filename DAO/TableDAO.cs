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

        public  List<Table> LoadTableList(bool isAdmin) {
            String sql = "SELECT * FROM dbo.TableFood where inUse = 1 ";
            if (isAdmin) {
                sql = "SELECT * FROM dbo.TableFood";
            }
            List<Table> tableList = new List<Table>();
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);
                tableList = (from DataRow row in dataTable.Rows
                             select new Table(row)).ToList();
            return tableList;
        }

        public void UpdateTable(int tableId, string name, bool inUse) {
            String sql = $"UPDATE [dbo].[TableFood] SET [name] = '{name}' , [inUse] = '{inUse}' WHERE [id] = {tableId}";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(sql);

        }

        public void ChangeTableInUse(int tableId, bool inUse) {
            String sql = $"UPDATE [dbo].[TableFood] SET [inUse] = ? WHERE id = {tableId} ; ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(sql);

        }

        //public void SwitchTable(int id1,int id2) {
        //    String sql = $"EXEC dbo.USP_SwitchTable @idTable1 ={id1} , @idTable2 ={id2}";
        //    int result = DAO.DataProvider.Instance.ExecuteNonQuery(sql);
        //}
    }

}
