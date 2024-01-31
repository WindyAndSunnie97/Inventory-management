namespace QuanlyKho1
{
    partial class FormInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btAdd = new Button();
            btFind = new Button();
            txtName = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            InventoryID = new DataGridViewTextBoxColumn();
            NameInventory = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.HotPink;
            btAdd.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btAdd.ForeColor = Color.White;
            btAdd.Location = new Point(12, 7);
            btAdd.Margin = new Padding(2);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(161, 48);
            btAdd.TabIndex = 30;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // btFind
            // 
            btFind.BackColor = Color.HotPink;
            btFind.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btFind.ForeColor = Color.White;
            btFind.Location = new Point(438, 9);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(128, 48);
            btFind.TabIndex = 29;
            btFind.Text = "Find";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.LavenderBlush;
            txtName.Location = new Point(96, 19);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(311, 31);
            txtName.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.HotPink;
            label7.Location = new Point(15, 19);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 29);
            label7.TabIndex = 27;
            label7.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(267, 461);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1338, 444);
            panel3.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { InventoryID, NameInventory, Address, Edit, Delete });
            dataGridView1.Location = new Point(29, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1273, 382);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // InventoryID
            // 
            InventoryID.DataPropertyName = "InventoryID";
            InventoryID.HeaderText = "InventoryID";
            InventoryID.MinimumWidth = 8;
            InventoryID.Name = "InventoryID";
            // 
            // NameInventory
            // 
            NameInventory.DataPropertyName = "NameInventory";
            NameInventory.HeaderText = "NameInventory";
            NameInventory.MinimumWidth = 8;
            NameInventory.Name = "NameInventory";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
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
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Location = new Point(-2, 8);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1865, 18);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-2, 22);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1865, 108);
            panel2.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.HotPink;
            label2.Location = new Point(431, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(951, 99);
            label2.TabIndex = 33;
            label2.Text = "MANAGE INVENTORY";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(btAdd);
            panel6.Location = new Point(267, 370);
            panel6.Name = "panel6";
            panel6.Size = new Size(183, 62);
            panel6.TabIndex = 36;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(txtName);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(btFind);
            panel7.Location = new Point(1023, 370);
            panel7.Name = "panel7";
            panel7.Size = new Size(582, 69);
            panel7.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.HotPink;
            label6.Location = new Point(519, 274);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(471, 57);
            label6.TabIndex = 38;
            label6.Text = "LIST INVENTORY";
            // 
            // panel5
            // 
            panel5.BackColor = Color.HotPink;
            panel5.Location = new Point(-2, 126);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1865, 18);
            panel5.TabIndex = 35;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1863, 1009);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "FormInventory";
            Text = "QUẢN LÝ KHO HÀNG";
            WindowState = FormWindowState.Maximized;
            Activated += FormInventory_Activated;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btAdd;
        private Button btFind;
        private TextBox txtName;
        private Label label7;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel6;
        private Panel panel7;
        private Label label6;
        private Panel panel5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn InventoryID;
        private DataGridViewTextBoxColumn NameInventory;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}