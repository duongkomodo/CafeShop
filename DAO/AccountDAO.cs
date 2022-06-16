﻿using CafeShop.DAO;
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

        private AccountDAO() {
        }

       public Account Login(string username,string password) {

            string sql = $"EXEC dbo.USP_Login {username} , {password} ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            if (data !=null && data.Rows.Count > 0) {      
                    Account account = new Account(data.Rows[0]);
                    return account;           
            } else {
                return null;
            }
        
        }
    }
}
