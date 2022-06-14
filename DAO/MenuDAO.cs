using CafeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace CafeShop.DAO {
    public  class ListFoodOnTableDAO {

        private static ListFoodOnTableDAO instance;

        public static ListFoodOnTableDAO Instance {
            get {
                if (ListFoodOnTableDAO.instance == null) {
                    ListFoodOnTableDAO.instance = new ListFoodOnTableDAO();

                }
                return ListFoodOnTableDAO.instance;
            }
            private set => instance = value;
        }

        private ListFoodOnTableDAO() {
        }
        public List<ListFoodOnTable> GetListMenu(int id) {

            List<ListFoodOnTable> listMenu = new List<ListFoodOnTable>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"EXEC dbo.USP_GetTableBill @tableid = {id}");
            foreach (DataRow item in dataTable.Rows) {
                ListFoodOnTable menu = new ListFoodOnTable(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
