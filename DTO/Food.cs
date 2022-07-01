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
        private string image;
        private bool inUse;

        public Food(int id,string name,int idCategory,double price,string image , bool inUse) {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
            this.image = image;
            this.inUse = inUse;
        }

        public Food() {
        }

        public Food(DataRow row) {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.idCategory = (int)row["idCategory"];
            this.price = (double)row["price"];
            this.image = row["image"].ToString();
            this.InUse = (bool)row["inUse"];
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
        public string Image {
            get => image;
            set => image = value;
        }
        public bool InUse {
            get => inUse;
            set => inUse = value;
        }
    }
}
