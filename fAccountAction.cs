using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fAccountAction :Form {
        public fAccountAction() {
            loginedUser = DAO.AccountDAO.Instance.LoginedUser;
            InitializeComponent();
        }

        public Account currEditAccount {
            get;
        }

        public Account loginedUser {
            get;
        }
        public fAccountAction(int id) {
            loginedUser = DAO.AccountDAO.Instance.LoginedUser;
            currEditAccount = DAO.AccountDAO.Instance.GetAccountById(id);
            InitializeComponent();

        }

        #region Function
        public void SetUp() {
            
            if (currEditAccount != null) {
        
                this.Text = $"{currEditAccount.DisplayName}'s detail ";
                pnIsUpdatePassword.Visible = true;
                pnUpdatePassword.Enabled = false;
             
                cbRole.DataSource = DAO.RolesDAO.Instance.LoadAllRoles();
                cbRole.DisplayMember = "roleName";
                cbRole.ValueMember = "id";
                cbRole.SelectedValue = currEditAccount.RoleId;
                tbDisplayName.Text = currEditAccount.DisplayName;
                tbUsername.Text = currEditAccount.UserName;
                tbUsername.Enabled = false;
                tbPhonenumber.Text = currEditAccount.PhoneNumber;
                if (File.Exists(currEditAccount.Avatar)) {
                    ptbAvatar.BackgroundImage = Image.FromFile(currEditAccount.Avatar);
                    ptbAvatar.Tag = currEditAccount.Avatar;
                } else {
                    ptbAvatar.BackgroundImage = Image.FromFile(@"Image\Food\placeholder (Custom).png");

                }

            } else {
                this.Text = $"Create new account ";
                cbRole.DataSource = DAO.RolesDAO.Instance.LoadAllRoles();
                if (loginedUser.RoleId == 1) {
                    cbRole.Enabled = true;
                }
                cbRole.DisplayMember = "roleName";
                cbRole.ValueMember = "id";
                cbRole.SelectedIndex = 1;

                pnCreateAccount.Visible = true;
                ptbAvatar.BackgroundImage = Image.FromFile(@"Image\Food\placeholder (Custom).png");
            }
 
            ptbAvatar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public bool checkAccountSaveChanges = false;
        public void updateAccount() {
            String displayName = tbDisplayName.Text.Trim();
            String userName = tbUsername.Text.Trim();

            String phoneNumber = tbPhonenumber.Text.Trim();
            if (displayName == "") {
                MessageBox.Show("Displayname cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (userName == "") {
                MessageBox.Show("Username cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (phoneNumber == "" || phoneNumber.Length > 11) {
                MessageBox.Show("Phone number is wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
    


            string password = currEditAccount.PassWord;

            if (chxbChangePassword.Checked) {
                String oldPassword = tbUpdOldPassword.Text.Trim();
                String newPassword = tbUpdNewPassword.Text.Trim();
                String confirmPassword = tbUpdConfirmPassword.Text.Trim();

                if (oldPassword == "") {
                    MessageBox.Show("Please input your old password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (newPassword == "") {
                    MessageBox.Show("New password cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (confirmPassword == "") {
                    MessageBox.Show("Please confirm the new password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (!confirmPassword.Equals(newPassword)) {
                    MessageBox.Show("New password not match the confirm password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                bool verified = BCrypt.Net.BCrypt.Verify(oldPassword,currEditAccount.PassWord);
                if (verified is false) {
                    MessageBox.Show("Old password not match the current password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                password = BCrypt.Net.BCrypt.HashPassword(confirmPassword);

            }
            string avatarPath = "";
            if (ptbAvatar.Tag != null) {
                avatarPath = ptbAvatar.Tag.ToString();
            }


            int roleId = (int)cbRole.SelectedValue;
            Account account = new Account(currEditAccount.Id,userName,displayName,password,roleId,avatarPath,phoneNumber);
            int updateResult = DAO.AccountDAO.Instance.updateAccount(account);
            if (updateResult > 0) {
                checkAccountSaveChanges = true;
                MessageBox.Show("Update account successfully!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void CreateAccount() {
            String displayName = tbDisplayName.Text.Trim();
            String userName = tbUsername.Text.Trim();

            String phoneNumber = tbPhonenumber.Text.Trim();
            if (displayName == "") {
                MessageBox.Show("Displayname cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (userName == "") {
                MessageBox.Show("Username cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (DAO.AccountDAO.Instance.checkExistAccount(userName) > 0) {
                MessageBox.Show("Username exist, try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (phoneNumber == "" && phoneNumber.Length < 12) {
                MessageBox.Show("Phone number is wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            String newPassword = tbCreatepassword.Text.Trim();
            String confirmPassword = tbCreateconfirmpassword.Text.Trim();
            if (newPassword == "") {
                MessageBox.Show("Password cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (confirmPassword == "") {
                MessageBox.Show("Please confirm the new password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!confirmPassword.Equals(newPassword)) {
                MessageBox.Show("New password not match the confirm password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string avatarPath = "";
            if (ptbAvatar.Tag != null) {
                avatarPath = ptbAvatar.Tag.ToString();
            }
            int roleId = (int)cbRole.SelectedValue;
            if (roleId == 1) {
                fConfirm confirm = new fConfirm();
                confirm.ShowDialog();
                if (confirm.DialogResult != DialogResult.Yes) {
                    return;
                }
            }

            confirmPassword = BCrypt.Net.BCrypt.HashPassword(confirmPassword);
            Account account = new Account(0,userName,displayName,confirmPassword,roleId,avatarPath,phoneNumber);
            int createResult = DAO.AccountDAO.Instance.addAccount(account);
 
            if (createResult >0) {
                checkAccountSaveChanges = true;
                MessageBox.Show("Create account successfully!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Event
        private void fAccountAction_Load(object sender,EventArgs e) {
            if (loginedUser.RoleId != 1){
                this.Close();
            }
            SetUp();
        }

        private void chxbChangePassword_CheckedChanged(object sender,EventArgs e) {
            if (currEditAccount != null && chxbChangePassword.Checked is true) {
                pnUpdatePassword.Enabled = true;
            } else {
                pnUpdatePassword.Enabled = false;
            }
        }
        private void tbPhonenumber_KeyPress(object sender,KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void btnUploadAvatar_Click(object sender,EventArgs e) {
            //Create a new instance of openFileDialog
            OpenFileDialog image = new OpenFileDialog();
            image.InitialDirectory = @"D:\.Net Project\CafeShop\Image\Food";
            //Filter
            image.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tif;...";

            //When the user select the file
            if (image.ShowDialog() == DialogResult.OK) {
                //Get the file's path
                string imgPath = image.FileName;
                //Do something
                ptbAvatar.BackgroundImage = Image.FromFile(imgPath);
                ptbAvatar.BackgroundImageLayout = ImageLayout.Zoom;
                ptbAvatar.Tag = imgPath;


            }
        }

        private void btnSaveChanges_Click(object sender,EventArgs e) {
            if (currEditAccount != null) {
                updateAccount();
          
            } else {
                CreateAccount();
              
            }
            if (checkAccountSaveChanges is true) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnReset_Click(object sender,EventArgs e) {
            SetUp();
        }

        #endregion





    }
}
