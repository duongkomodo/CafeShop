using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {
 public  class FoodDAO {
        private static FoodDAO instance;

        public static FoodDAO Instance {
            get {
                if (FoodDAO.instance == null) {
                    FoodDAO.instance = new FoodDAO();

                }
                return FoodDAO.instance;
            }
            private set => instance = value;
        }

        private FoodDAO() {
        }


        public List<Food> LoadAllFood() {

            string sql = $"select * from food ";
            List<Food> list = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows) {
                Food food = new Food(item);
                list.Add(food);

            }

            return list;
        }

        public List<Food> LoadAllFoodById(int id) {

            string sql =  $"select * from food where IdCategory = {id} ;";
            List<Food> list = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows) {
                Food food = new Food(item);
                list.Add(food);

            }

            return list;
        }

        public Food getFoodById(int id) {

            string sql = $"select * from food where id = {id} ;";
            Food food = new Food();
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            if (data.Rows.Count > 0) {
                food = new Food(data.Rows[0]);
                return food;
            } else {
                return null;
            }

        }
    }
}
