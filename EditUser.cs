using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKho1
{
    public partial class EditUser : Form
    {
        Context db = new Context();
        User user;
        long UserID;
        public EditUser(long UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            user = db.Users.Single(p => p.UserID == UserID);
            Text += " - Mã Us " + user.UserID.ToString();
            txtName.Text = user.NameUser;
            txtEmail.Text = user.Email;
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            txtRoleID.Text = user.RoleID.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                user.NameUser = txtName.Text;
                user.Email = txtEmail.Text;
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;
                user.RoleID = (byte)Convert.ToDecimal(txtRoleID.Text);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, -0,
               0, 1000);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
