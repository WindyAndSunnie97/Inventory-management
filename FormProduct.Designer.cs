namespace QuanlyKho1
{
    partial class FormProduct
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
            cbCategory = new ComboBox();
            cbInventory = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            btAdd = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Origin = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete, ProductID, ProductName, Price, Origin });
            dataGridView1.Location = new Point(32, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1636, 503);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Lavender;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(396, 54);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(511, 33);
            cbCategory.TabIndex = 1;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cbInventory
            // 
            cbInventory.BackColor = Color.Lavender;
            cbInventory.FormattingEnabled = true;
            cbInventory.Location = new Point(1073, 49);
            cbInventory.Name = "cbInventory";
            cbInventory.Size = new Size(510, 33);
            cbInventory.TabIndex = 2;
            cbInventory.SelectedIndexChanged += cbInventory_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(396, 22);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 29);
            label7.TabIndex = 28;
            label7.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1073, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 29);
            label2.TabIndex = 29;
            label2.Text = "Inventory";
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.FromArgb(128, 128, 255);
            btAdd.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btAdd.ForeColor = Color.White;
            btAdd.Location = new Point(54, 39);
            btAdd.Margin = new Padding(2);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(161, 48);
            btAdd.TabIndex = 31;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(82, 409);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1703, 559);
            panel3.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cbInventory);
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(btAdd);
            panel2.Location = new Point(82, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(1703, 118);
            panel2.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 22);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1865, 104);
            panel1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(540, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(857, 99);
            label1.TabIndex = 33;
            label1.Text = "MANAGE PRODUCT";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 128, 255);
            panel4.Location = new Point(0, 8);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1865, 16);
            panel4.TabIndex = 36;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(128, 128, 255);
            panel5.Location = new Point(0, 120);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1865, 17);
            panel5.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("High Tower Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(723, 337);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(408, 57);
            label3.TabIndex = 48;
            label3.Text = "LIST PRODUCT";
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
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 8;
            ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "NameProduct";
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            // 
            // Origin
            // 
            Origin.DataPropertyName = "Origin";
            Origin.HeaderText = "Origin";
            Origin.MinimumWidth = 8;
            Origin.Name = "Origin";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1863, 1009);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "FormProduct";
            Text = "QUẢN LÝ SẢN PHẨM";
            WindowState = FormWindowState.Maximized;
            Activated += FormProduct_Activated;
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cbCategory;
        private ComboBox cbInventory;
        private Label label7;
        private Label label2;
        private Button btAdd;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Origin;
    }
}