using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {


    public class CategoryDAO {
        private static CategoryDAO instance;

        public static CategoryDAO Instance {
            get {
                if (CategoryDAO.instance == null) {
                    CategoryDAO.instance = new CategoryDAO();

                }
                return CategoryDAO.instance;
            }
            private set => instance = value;
        }

        private CategoryDAO() {
        }


        public List<Category> LoadAllCategory() {
            string sql = "select * from FoodCategory";
            List<Category> list = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows) {
                Category category = new Category(item);
                list.Add(category);

            }

            return list;
        }


        public int removeCategory(int id) {
            string sql = $"EXECUTE  [dbo].[USP_RemoveCategory]  @categoryId = {id} ;";

            return DataProvider.Instance.ExecuteNonQuery(sql);

        }

        public int addCategory(string name) {
            string sql = $"INSERT INTO [dbo].[FoodCategory] ([name]) VALUES ('{name}') ;";

            return DataProvider.Instance.ExecuteNonQuery(sql);

        }
    }
  
}
