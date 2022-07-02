using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO {
  public  class Category {
        private int id;
        private string name;
        private bool inUse;
        public Category(int id,string name) {
            this.id = id;
            this.name = name;
        }

        public Category() {
        }

        public Category(DataRow row) {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
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
        public bool InUse {
            get => inUse;
            set => inUse = value;
        }
    }
}
