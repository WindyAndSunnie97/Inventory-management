using QuanlyKho1;
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

namespace QLKH
{
    public partial class NewDocument : Form
    {
        private const byte DOCUMENT_TYPE_IM = 1;
        private const byte DOCUMENT_TYPE_EX = 0;
        private Context db = new Context();
        public NewDocument()
        {
            InitializeComponent();
        }

        private void NewDocument_Load(object sender, EventArgs e)
        {
            comboBoxPerson.DisplayMember = "Name";
            comboBoxPerson.ValueMember = "PersonID";
            comboBoxPerson.DataSource = db.Persons.Select(i => new { Name = i.NamePerson, PersonID = i.PersonID }).ToList();
            /*
                        comboBoxInventory.DisplayMember = "Name";
                        comboBoxInventory.ValueMember = "InventoryID";
                        comboBoxInventory.DataSource = db.Inventory.Select(i => new { Name = i.Name, InventoryID = i.InventoryID }).ToList();*/

            cbUser.DisplayMember = "Name";
            cbUser.ValueMember = "UserID";
            cbUser.DataSource = db.Users.Select(i => new { Name = i.NameUser, UserID = i.UserID }).ToList();
        }

        private void comboBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            long personID = Convert.ToInt64(comboBoxPerson.SelectedValue);
            Person person = db.Persons.Single(i => i.PersonID == personID);
            PersonAddress.Text = person.Address;
            PersonEmail.Text = person.Email;
            PersonPhone.Text = person.Phone;
        }

        /*        private void comboBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
                {
                    long inventoryID = Convert.ToInt64(comboBoxInventory.SelectedValue);
                    Inventory inventory = db.Inventory.Single(i => i.InventoryID == inventoryID);
                    InventoryAddress.Text = inventory.Address;
                }*/

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                Document document = new Document();
                document.PersonID = Convert.ToInt64(comboBoxPerson.SelectedValue);
                document.UserID = Convert.ToInt64(cbUser.SelectedValue);
                document.CreateDate = CreateDate.Value.Date;
                document.Classify = comboBoxType.Text == "Đơn nhập" ? DOCUMENT_TYPE_IM : DOCUMENT_TYPE_EX;
                db.Documents.Add(document);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công", btSave, btSave.Width, 0, 2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            long userID = Convert.ToInt64(cbUser.SelectedValue);
            User user = db.Users.Single(i => i.UserID == userID);
            UserEmail.Text = user.Email;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
