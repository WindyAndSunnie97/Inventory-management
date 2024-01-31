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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Activated(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Users.Select(user => new { UserID = user.UserID, NameUser = user.NameUser, Email = user.Email, UserName = user.UserName, Password = user.Password, RoleID = user.RoleID }).ToList();
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Users.Select(user => new { UserID = user.UserID, NameUser = user.NameUser, Email = user.Email, UserName = user.UserName, Password = user.Password, RoleID = user.RoleID }).Where(c => c.NameUser.Contains(txtName.Text)).ToList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("NewUser"))
                return;
            NewUser f = new NewUser();
            f.MdiParent = this.MdiParent;
            f.Show();

            /*var form = new NewUser();
            form.Show();*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long UserID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["UserID"].Value);
                    using (var db = new Context())
                    {
                        User user =
                        db.Users.Single(c => c.UserID == UserID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + user.NameUser, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Users.Remove(user);
                            db.SaveChanges();
                            FormUser_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("EditUser"))
                    return;
                EditUser f = new EditUser
               (Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["UserID"].
               Value));
                f.MdiParent = this.MdiParent;
                f.Show();

                /*var form = new EditUser(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value));
                form.Show();*/
            }
        }
    }
}
