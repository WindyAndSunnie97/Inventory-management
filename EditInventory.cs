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
    public partial class EditInventory : Form
    {
        Context db = new Context();
        Inventory inventory;
        long InventoryID;
        public EditInventory(long InventoryID)
        {
            InitializeComponent();
            this.InventoryID = InventoryID;
        }

        private void EditInventory_Load(object sender, EventArgs e)
        {
            inventory = db.Inventory.Single(p => p.InventoryID == InventoryID);
            Text += " - Mã Kho " + inventory.InventoryID.ToString();
            txtName.Text = inventory.NameInventory;
            txtAddress.Text = inventory.Address;


        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.NameInventory = txtName.Text;
                inventory.Address = txtAddress.Text;
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

        private void EditInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
