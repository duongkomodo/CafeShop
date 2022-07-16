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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = "+ TableId +" AND status = 0 " );

            if (data.Rows.Count > 0) {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }

            return -1;
        }

        public Bill GetBill(int billId) {
            DataTable data = DataProvider.Instance.ExecuteQuery($"SELECT * FROM dbo.Bill WHERE id = {billId} AND status = 1");

            if (data.Rows.Count > 0) {
                Bill bill = new Bill(data.Rows[0]);
                return bill;
            }

            return null;
        }

        public List<Bill> GetBillTakeAway() {

            List<Bill> tableBill = new List<Bill>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"SELECT * FROM dbo.Bill WHERE IdTable = 1 AND status = 0");
            tableBill = (from DataRow row in dataTable.Rows
                         select new Bill(row)).ToList();
  

            return tableBill;
        }

        public int InsertBill(int idTable, int accountId) {
            int result = (int)DataProvider.Instance.ExecuteScalar($"exec USP_InsertBill {idTable} , {accountId} ; ");
            return result;
        }



        public DataTable GetCheckOutBillsByDate(String fromDate, String toDate) {

         
            DataTable data = DataProvider.Instance.ExecuteQuery($"exec USP_GetAllCheckoutBillByDate '{fromDate}' , '{toDate}'");

            return data;
        
        }

        public void CheckOut(int billId, int discount,decimal total) {
            string sql = $"[dbo].[USP_CheckOut] @billId = {billId}, @discount = {discount} , @total = {total}" ;
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public void RemoveTakeawayBill(int billId) {
            string sql = $"[dbo].[USP_RemoveTakeAwayBill] @billId =  {billId}";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
