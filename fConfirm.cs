using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fConfirm :Form {

        public Account loginedUser {
            get;
        }
        public fConfirm() {
            loginedUser = DAO.AccountDAO.Instance.LoginedUser;
            InitializeComponent();

       
        }
        public void Checking() {
            int count = 5;
            string password = tbPassword.Text.Trim();
          bool verified = BCrypt.Net.BCrypt.Verify(password,loginedUser.PassWord);
            if (verified is true) {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } else {
                MessageBox.Show($"Wrong password, you have {count} tries left!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                count--;
            }
            if (count == 0) {
                MessageBox.Show($"Too many failed input password attempts, exiting the system...","Warning");
                int milliseconds = 3000;
                Thread.Sleep(milliseconds);
                Environment.Exit(1);
            }

        }

        private void btnOk_Click(object sender,EventArgs e) {
            Checking();
        }

        private void btnCancel_Click(object sender,EventArgs e) {
            this.Close();
        }
    }
}
