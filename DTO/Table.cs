using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO {
   public class Table {

        private int id;
        private string name;
        private string status;
        private bool inUse;

        public Table(int id,string name,string status) {
            this.id = id;
            this.name = name;
            this.status = status;
        }

        public Table() {
        }

        public Table(DataRow row) {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = row["status"].ToString();
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
        public string Status {
            get => status;
            set => status = value;
        }
        public bool InUse {
            get => inUse;
            set => inUse = value;
        }
    }
}
