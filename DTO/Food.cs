using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO {
   public class Food {
        private int id;
        private string name;
        private int idCategory;
        private double price;

        public Food(int id,string name,int idCategory,double price) {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
        }

        public Food(DataRow row) {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.idCategory = (int)row["idCategory"];
            this.price = (double)row["price"];
        }

        public int Id {
            get => id;
            set => id = value;
        }
        public string Name {
            get => name;
            set => name = value;
        }
        public int IdCategory {
            get => idCategory;
            set => idCategory = value;
        }
        public double Price {
            get => price;
            set => price = value;
        }
    }
}
