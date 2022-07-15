using CafeShop.DAO;
using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {
    public class AccountDAO {

        private static AccountDAO instance;

        public static AccountDAO Instance {
            get {
                if (AccountDAO.instance == null) {
                    AccountDAO.instance = new AccountDAO();
                } return AccountDAO.instance; }
            private set => AccountDAO.instance = value;
        }
        private Account loginedUser;

        public Account LoginedUser {
            get {
                return loginedUser;
            }

 
        }
        private AccountDAO() {
        }

       public Account Login(string username,string password) {

            string sql = $"EXEC dbo.USP_Login {username} ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            if (data !=null && data.Rows.Count > 0) {      
                    Account account = new Account(data.Rows[0]);
                bool verified = BCrypt.Net.BCrypt.Verify(password,account.PassWord);
                if (verified is true) {
                    loginedUser = account;
                    return account;
                } else {
                    return null;
                }
                   
            } else {
                return null;
            }
        
        }

        public Account GetAccountById(int id) {

            string sql = $"select * from Account where id = {id} ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            if (data != null && data.Rows.Count > 0) {
                Account account = new Account(data.Rows[0]);
                loginedUser = account;
                return account;
            } else {
                return null;
            }


        }


        public int removeAccount(int id) {
            string sql = $"UPDATE [dbo].[Food] SET [inUse] = 0 WHERE dbo.Food.id = {id}";

            return DataProvider.Instance.ExecuteNonQuery(sql);

        }
        public int addAccount(Account account) {
            string sql = $"INSERT INTO [dbo].[Account]([UserName] ,[DisplayName],[PassWord] ,[roleId],[avatar],[phoneNumber])" +
                $" VALUES (N'{account.UserName}',N'{account.DisplayName}',N'{account.PassWord}',{account.RoleId},N'{account.Avatar}',N'{account.PhoneNumber}')";

            return DataProvider.Instance.ExecuteNonQuery(sql);

        }
        public int checkExistAccount(string username) {
            string sql = $"Select count(*) from account where inUse = 1 and username = '{username}'";

            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(sql));

        }

        public int DeleteAccount(int id) {
            string sql = $"[dbo].[USP_RemoveAccount] @accountId = {id} ";

            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(sql));

        }

        public int updateAccount(Account account) {
            string sql = $"UPDATE [dbo].[Account] SET" +
                $" [UserName] = N'{account.UserName}',[DisplayName] = N'{account.DisplayName}' ," +
                $"[PassWord] = N'{account.PassWord}',[roleId] = {account.RoleId},[avatar] = N'{account.Avatar}',[phoneNumber] =N'{account.PhoneNumber}' " +
                $"WHERE Account.id = {account.Id}";


            return DataProvider.Instance.ExecuteNonQuery(sql);

        }
        public List<Account> LoadAllAccount() {

            string sql = $"USP_GetAccountList";
            List<Account> list = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            if (data != null && data.Rows.Count > 0) {
                foreach (DataRow item in data.Rows) {
                    Account account = new Account(item);
                    list.Add(account);
                }
          
            } else {
                return null;
            }

            return list;
        }
        public string CashierName(int accountId) {
            string sql = $"Select displayName from Account where id = {accountId}";
            string data = DataProvider.Instance.ExecuteScalar(sql).ToString();
            return data;

        }

        public void InvalidateAccount() {
            loginedUser = null;
        }
    }
}
