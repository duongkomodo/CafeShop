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
        private int roleId;
        private String avatar;
        private String phoneNumber;
        public Account(DataRow row) {
            this.Id = (int)row["id"];
            this.userName = row["userName"].ToString();
            this.displayName = row["displayName"].ToString();
            this.passWord = row["passWord"].ToString();
            this.RoleId = (int)row["roleId"];
            if (row["avatar"] is not null) {
                this.Avatar = row["avatar"].ToString();
            } else {
                this.Avatar = "";
            }
            this.PhoneNumber = row["phoneNumber"].ToString();
        }

        public Account() {
        }

        public Account(int id,string userName,string displayName,string passWord,int roleId,string avatar,string phoneNumber) {
            this.id = id;
            this.userName = userName;
            this.displayName = displayName;
            this.passWord = passWord;
            this.roleId = roleId;
            this.avatar = avatar;
            this.phoneNumber = phoneNumber;
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
     
        public int Id {
            get => id;
            set => id = value;
        }
        public int RoleId {
            get => roleId;
            set => roleId = value;
        }
        public string Avatar {
            get => avatar;
            set => avatar = value;
        }
        public string PhoneNumber {
            get => phoneNumber;
            set => phoneNumber = value;
        }
    }
}

