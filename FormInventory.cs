
using Microsoft.EntityFrameworkCore;
using QuanlyKho1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using Microsoft.IdentityModel.Tokens;

namespace QuanlyKho1
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Inventory.Select(inventory => new { InventoryID = inventory.InventoryID, NameInventory = inventory.NameInventory, Address = inventory.Address }).Where(c => c.NameInventory.Contains(txtName.Text)).ToList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("NewInventory"))
                return;
            NewInventory f = new NewInventory();
            f.MdiParent = this.MdiParent;
            f.Show();

            /*var form = new NewInventory();
            form.Show();*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long InventoryID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["InventoryID"].Value);
                    using (var db = new Context())
                    {
                        Inventory inventory =
                        db.Inventory.Single(c => c.InventoryID == InventoryID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + inventory.NameInventory, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                        {
                            db.Inventory.Remove(inventory);
                            db.SaveChanges();
                            FormInventory_Activated(sender, e);
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
                if (Utility.IsOpeningForm("EditInventory"))
                    return;
                EditInventory f = new EditInventory
               (Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["InventoryID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();

            }
        }

        private void FormInventory_Activated(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                db.Inventory.Load();
                dataGridView1.DataSource = db.Inventory.Select(inventory => new { InventoryID = inventory.InventoryID, NameInventory = inventory.NameInventory, Address = inventory.Address }).ToList();
            }
        }
    }
}