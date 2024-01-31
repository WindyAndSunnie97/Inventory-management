namespace QuanlyKho1
{
    partial class FormUser
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
            dataGridView1 = new DataGridView();
            btAdd = new Button();
            label7 = new Label();
            btFind = new Button();
            txtName = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            UserID = new DataGridViewTextBoxColumn();
            NameUser = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            RoleID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserID, NameUser, Email, UserName, Password, RoleID, Edit, Delete });
            dataGridView1.Location = new Point(194, 436);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1453, 476);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.SeaGreen;
            btAdd.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btAdd.ForeColor = Color.White;
            btAdd.Location = new Point(194, 354);
            btAdd.Margin = new Padding(2);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(161, 48);
            btAdd.TabIndex = 51;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SeaGreen;
            label7.Location = new Point(36, 30);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 29);
            label7.TabIndex = 50;
            label7.Text = "User name:";
            // 
            // btFind
            // 
            btFind.BackColor = Color.SeaGreen;
            btFind.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btFind.ForeColor = Color.White;
            btFind.Location = new Point(490, 20);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(128, 48);
            btFind.TabIndex = 49;
            btFind.Text = "Find";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Honeydew;
            txtName.Location = new Point(182, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 31);
            txtName.TabIndex = 48;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 24);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1865, 102);
            panel2.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(550, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(674, 99);
            label2.TabIndex = 33;
            label2.Text = "MANAGE USER";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Location = new Point(1, 10);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1865, 26);
            panel1.TabIndex = 52;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaGreen;
            panel5.Location = new Point(1, 124);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1865, 17);
            panel5.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(433, 297);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(285, 57);
            label6.TabIndex = 55;
            label6.Text = "LIST USER";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btFind);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(993, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(654, 93);
            panel3.TabIndex = 56;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "UserID";
            UserID.MinimumWidth = 8;
            UserID.Name = "UserID";
            // 
            // NameUser
            // 
            NameUser.DataPropertyName = "NameUser";
            NameUser.HeaderText = "Name";
            NameUser.MinimumWidth = 8;
            NameUser.Name = "NameUser";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            // 
            // RoleID
            // 
            RoleID.DataPropertyName = "RoleID";
            RoleID.HeaderText = "RoleID";
            RoleID.MinimumWidth = 8;
            RoleID.Name = "RoleID";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1863, 1009);
            Controls.Add(label6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btAdd);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Name = "FormUser";
            Text = "QUẢN LÝ NGƯỜI DÙNG";
            WindowState = FormWindowState.Maximized;
            Activated += FormUser_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btAdd;
        private Label label7;
        private Button btFind;
        private TextBox txtName;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Panel panel5;
        private Label label6;
        private Panel panel3;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn NameUser;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn RoleID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}