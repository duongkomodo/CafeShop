using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO {
   public class Account {
        private string userName;
        private string displayName;
        private string passWord;
        private string type;

        public Account(string userName,string displayName,string passWord,string type) {
            this.userName = userName;
            this.displayName = displayName;
            this.passWord = passWord;
            this.type = type;
        }

        public Account(DataRow row) {
            this.userName = row["userName"].ToString();
            this.displayName = row["displayName"].ToString();
            this.passWord = row["passWord"].ToString();
            this.type = row["type"].ToString();
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
        public string Type {
            get => type;
            set => type = value;
        }
    }
}

