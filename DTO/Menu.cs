using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO {
   public class ListFoodOnTable {

        private string foodName;
        private int count;
        private double price;
        private double totalPrice;

        public ListFoodOnTable(string foodName,int count,double price,double totalPrice = 0  ) {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }

        public ListFoodOnTable(DataRow row) {
            this.foodName = row["name"].ToString();
            this.count = (int)row["count"];
            this.price = (double)row["price"];
            this.totalPrice = (double)row["total"] ;
        }

        public string FoodName {
            get => foodName;
            set => foodName = value;
        }
        public int Count {
            get => count;
            set => count = value;
        }
        public double Price {
            get => price;
            set => price = value;
        }
        public double TotalPrice {
            get => totalPrice;
            set => totalPrice = value;
        }
    }
}
