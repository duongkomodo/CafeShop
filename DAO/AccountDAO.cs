using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departmentList.DAO {
    public class AccountDAO {

        private static AccountDAO instance;

        public static AccountDAO Instance {
            get {
                if (AccountDAO.instance == null) {
                    AccountDAO.instance = new AccountDAO();
                } return AccountDAO.instance; }
           private set => AccountDAO.instance = value;
        }

        private AccountDAO() {
        }

       public bool Login(string username,string password) {

            string sql = "EXEC dbo.USP_Login @username , @password ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] {username,password} );



            return data.Rows.Count > 0;
        }
    }
}
