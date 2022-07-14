using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO {
    public class RolesDAO {

        private static RolesDAO instance;

        public static RolesDAO Instance {
            get {
                if (RolesDAO.instance == null) {
                    RolesDAO.instance = new RolesDAO();
                }
                return RolesDAO.instance;
            }
            private set => RolesDAO.instance = value;
        }

        private RolesDAO() {
        }


        public List<Roles> LoadAllRoles() {

            string sql = $"select * from roles";
            List<Roles> list = new List<Roles>();
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows) {
                Roles role = new Roles(item);
                list.Add(role);

            }

            return list;
        }
    }
}
