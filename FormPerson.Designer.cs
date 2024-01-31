namespace QuanlyKho1
{
    partial class FormPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btAdd = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            btFind = new Button();
            txtName = new TextBox();
            panel2 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            Delete = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            PersonID = new DataGridViewTextBoxColumn();
            PersonName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.DarkCyan;
            btAdd.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btAdd.ForeColor = Color.White;
            btAdd.Location = new Point(133, 230);
            btAdd.Margin = new Padding(2);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(161, 48);
            btAdd.TabIndex = 46;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete, Edit, PersonID, PersonName, Phone, Address, Email });
            dataGridView1.Location = new Point(133, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1566, 379);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(1082, 240);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(168, 29);
            label7.TabIndex = 44;
            label7.Text = "Person Name:";
            // 
            // btFind
            // 
            btFind.BackColor = Color.DarkCyan;
            btFind.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btFind.ForeColor = Color.White;
            btFind.Location = new Point(1566, 230);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(128, 48);
            btFind.TabIndex = 43;
            btFind.Text = "Find";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(1255, 240);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 31);
            txtName.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btAdd);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btFind);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(25, 175);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1812, 808);
            panel2.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(524, 169);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(359, 57);
            label6.TabIndex = 47;
            label6.Text = "LIST PERSON";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 22);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1865, 116);
            panel1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(507, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(793, 99);
            label2.TabIndex = 33;
            label2.Text = "MANAGE PERSON";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Location = new Point(0, 13);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1865, 18);
            panel3.TabIndex = 45;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.Location = new Point(0, 129);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1865, 19);
            panel5.TabIndex = 47;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "PersonID";
            PersonID.MinimumWidth = 8;
            PersonID.Name = "PersonID";
            // 
            // PersonName
            // 
            PersonName.DataPropertyName = "NamePerson";
            PersonName.HeaderText = "Name";
            PersonName.MinimumWidth = 8;
            PersonName.Name = "PersonName";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1863, 1009);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormPerson";
            Text = "QUẢN LÝ KHÁCH HÀNG VÀ NHÀ CUNG CẤP";
            WindowState = FormWindowState.Maximized;
            Activated += FormPerson_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btAdd;
        private DataGridView dataGridView1;
        private Label label7;
        private Button btFind;
        private TextBox txtName;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Panel panel5;
        private Label label6;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Edit;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn PersonName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Email;
    }
}