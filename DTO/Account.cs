using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO {
   public class Account {
        private int id;
        private string userName;
        private string displayName;
        private string passWord;
        private int type;

        public Account(DataRow row) {
            this.Id = (int)row["id"];
            this.userName = row["userName"].ToString();
            this.displayName = row["displayName"].ToString();
            this.passWord = row["passWord"].ToString();
            this.type = (int)row["type"];
        }

        public Account() {
        }

        public string UserName {
            get => userName;
            set => userName = value;
        }
        public string DisplayName {
            get => displayName;
            set => displayName = value;
        }
        public string PassWord {
            get => passWord;
            set => passWord = value;
        }
        public int Type {
            get => type;
            set => type = value;
        }
        public int Id {
            get => id;
            set => id = value;
        }
    }
}

