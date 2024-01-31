using Microsoft.EntityFrameworkCore;
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
    public partial class NewInventory : Form
    {
        Inventory inventory;
        public NewInventory()
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
                inventory = new Inventory();
                inventory.NameInventory = txtName.Text;
                inventory.Address = txtAddress.Text;
                using (var db = new Context())
                {
                    db.Inventory.Add(inventory);
                    db.SaveChanges();
                }
                txtName.Text = null;
                txtAddress.Text = null;
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
