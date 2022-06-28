using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {
    public class BillDAO {
        private static BillDAO instance;

        public static BillDAO Instance {
            get {
                if (BillDAO.instance == null) {
                    BillDAO.instance = new BillDAO();

                } return BillDAO.instance; }
           private set => instance = value;
        }

        private BillDAO() {
            }

        public int GetUncheckBillIDByTableID(int TableId) {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + TableId + " AND status = 0");

            if (data.Rows.Count > 0) {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }

            return -1;
        }

        public int InsertBill(int idTable) {
            int result = (int)DataProvider.Instance.ExecuteScalar($"exec USP_InsertBill {idTable} ; ");
            return result;
        }

        public DataTable GetBillsCheckOut(String fromDate, String toDate) {
         
            DataTable data = DataProvider.Instance.ExecuteQuery($"exec USP_GetAllCheckOutBill '{fromDate}' , '{toDate}'");

            return data;
        
        }

        public void CheckOut(int billId, int discount,decimal total) {
            string sql = $"Update Bill SET status = 1, discount = {discount}, DateCheckOut = GETDATE(), total = {total} where Bill.id = {billId}" ;
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
