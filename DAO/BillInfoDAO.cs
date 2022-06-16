using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {
    public class BillInfoDAO {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance {
            get {
                if (BillInfoDAO.instance == null) {
                    BillInfoDAO.instance = new BillInfoDAO();
                }
                return BillInfoDAO.instance;
            }
            private set => instance = value;
        }

        private BillInfoDAO() {

        }

        public List<BillInfo> GetListBillInfo(int idBill) {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery($"Select * from BillInfo where idBill = {idBill} ");
            foreach (DataRow item in data.Rows) {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill,int idFood,int count) {
            SqlParameter p1 = new SqlParameter("@idBill",SqlDbType.Int);
            p1.Value = idBill;
            SqlParameter p2 = new SqlParameter("@idFood",SqlDbType.Int);
            p2.Value = idFood;
            SqlParameter p3= new SqlParameter("@count",SqlDbType.Int);
            p3.Value = count;
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count",new SqlParameter[] { p1, p2, p3 });
        }
    }
}
