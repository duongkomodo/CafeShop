using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fLogin :Form {
        public fLogin() {
            InitializeComponent();
        }

      

        #region Function


        Account Login(string username,string password) {

            return DAO.AccountDAO.Instance.Login(username,password);
        }
        #endregion

        #region Event
        private void btnLogin_Click(object sender,EventArgs e) {
            string username = tbUserName.Text;
            string password = tbPassWord.Text;
            Account logined = Login(username,password);
            if (logined != null) {
                fTableManager fTable = new fTableManager();

                this.Hide();
                fTable.ShowDialog();
                this.Show();
                MessageBox.Show("Success");
            } else {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void fLogin_FormClosing(object sender,FormClosingEventArgs e) {
            if (MessageBox.Show("Do you really want to quit ?","Quit",MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) {
                e.Cancel = true;
            }
        }

        private void btnClear_Click(object sender,EventArgs e) {
            tbPassWord.Text = "";
            tbUserName.Text = "";
        }


        #endregion




    }
}
