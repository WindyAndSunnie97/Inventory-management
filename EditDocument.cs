using Microsoft.EntityFrameworkCore;
using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanlyKho1
{
    public partial class EditDocument : Form
    {
        Context db = new Context();
        Models.Document document;
        long DocumentID;
        public EditDocument(long DocumentID)
        {
            InitializeComponent();
            this.DocumentID = DocumentID;
        }

        private void EditDocument_Load(object sender, EventArgs e)
        {
            document = db.Documents.Include(p => p.Person).Single(p => p.DocumentID == DocumentID);
            comboBoxPerson.DisplayMember = "Name";
            comboBoxPerson.ValueMember = "PersonID";
            comboBoxPerson.DataSource = db.Persons.Select(i => new { Name = i.NamePerson, PersonID = i.PersonID }).ToList();
            comboBoxPerson.Text = document.Person.NamePerson;
            PersonAddress.Text = document.Person.Address;
            PersonEmail.Text = document.Person.Email;
            PersonPhone.Text = document.Person.Phone;

            document = db.Documents.Include(p => p.User).Single(p => p.DocumentID == DocumentID);
            cbUser.DisplayMember = "Name";
            cbUser.ValueMember = "UserID";
            cbUser.DataSource = db.Users.Select(i => new { Name = i.NameUser, UserID = i.UserID }).ToList();
            cbUser.Text = document.User.NameUser;
            UserEmail.Text = document.User.Email;

            CreateDate.Text = document.CreateDate.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                /*Models.Document document = new Models.Document();*/
                document.PersonID = Convert.ToInt64(comboBoxPerson.SelectedValue);
                document.UserID = Convert.ToInt64(cbUser.SelectedValue);
                document.CreateDate = CreateDate.Value.Date;
                /*db.Documents.Add(document);*/
                db.SaveChanges();
                toolTip1.Show("Lưu thành công", btSave, btSave.Width, 0, 2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            long personID = Convert.ToInt64(comboBoxPerson.SelectedValue);
            Person person = db.Persons.Single(i => i.PersonID == personID);
            PersonAddress.Text = person.Address;
            PersonEmail.Text = person.Email;
            PersonPhone.Text = person.Phone;
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            long userID = Convert.ToInt64(cbUser.SelectedValue);
            User user = db.Users.Single(i => i.UserID == userID);
            UserEmail.Text = user.Email;
        }

        private void EditDocument_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
