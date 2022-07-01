using CafeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace CafeShop.DAO {
    public  class FoodOrderedDAO {

        private static FoodOrderedDAO instance;

        public static FoodOrderedDAO Instance {
            get {
                if (FoodOrderedDAO.instance == null) {
                    FoodOrderedDAO.instance = new FoodOrderedDAO();

                }
                return FoodOrderedDAO.instance;
            }
            private set => instance = value;
        }

        private FoodOrderedDAO() {
        }
        public List<FoodOrdered> GetListMenu(int id) {

            List<FoodOrdered> listMenu = new List<FoodOrdered>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"EXEC dbo.USP_GetTableBill @tableid = {id}");
            foreach (DataRow item in dataTable.Rows) {
                FoodOrdered menu = new FoodOrdered(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<FoodOrdered> GetBillDetail(int billId) {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"EXEC dbo.USP_GetCheckoutBill @billId = {billId}");
            List<FoodOrdered> listBillDetail = new List<FoodOrdered>();

            foreach (DataRow item in dataTable.Rows) {
                FoodOrdered detail = new FoodOrdered(item);
                listBillDetail.Add(detail);
            }

            return listBillDetail;

        }
    }
}
