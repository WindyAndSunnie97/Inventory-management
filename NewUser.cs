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
    public partial class NewUser : Form
    {
        User user;
        public NewUser()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                user = new User();
                user.NameUser = txtName.Text;
                user.Email = txtEmail.Text;
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;
                user.RoleID = (byte)Convert.ToDecimal(txtRoleID.Text);
                using (var db = new Context())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                txtName.Text = null;
                txtEmail.Text = null;
                txtUserName.Text = null;
                txtPassword.Text = null;
                txtRoleID.Text = null;
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            txtName.Focus();
        }
    }
}
