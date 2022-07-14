using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO {
   public class Roles {
        private int id;
        private string roleName;

        public Roles(DataRow row) {
            this.Id = (int)row["id"];
            this.roleName = row["roleName"].ToString();
        }

        public Roles() {
        }

        public Roles(int id,string roleName) {
            this.id = id;
            this.roleName = roleName;
        }

        public int Id {
            get => id;
            set => id = value;
        }
        public string RoleName {
            get => roleName;
            set => roleName = value;
        }
    }
}
