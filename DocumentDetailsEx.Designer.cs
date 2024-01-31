namespace QuanlyKho1
{
    partial class DocumentDetailsEx
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBoxPerson = new GroupBox();
            PersonName = new TextBox();
            label3 = new Label();
            PersonEmail = new TextBox();
            PersonPhone = new TextBox();
            PersonAddress = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            comboBoxDocument = new ComboBox();
            Classify = new TextBox();
            comboBoxInventory = new ComboBox();
            groupBoxInventory = new GroupBox();
            textBoxInventoryAddress = new TextBox();
            textBoxEmployeeName = new TextBox();
            textBoxEmployeeTitle = new TextBox();
            textBoxCreateDate = new TextBox();
            label17 = new Label();
            UserEmail = new TextBox();
            groupBox1 = new GroupBox();
            toolTip1 = new ToolTip(components);
            comboBoxProduct = new ComboBox();
            textBoxCategory = new TextBox();
            label14 = new Label();
            maskedTextBoxQuantityCurrent = new MaskedTextBox();
            maskedTextBoxQuantity = new MaskedTextBox();
            textBoxPriceCurrent = new TextBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            Delete = new DataGridViewButtonColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            InventoryID_ = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ProductID_ = new DataGridViewTextBoxColumn();
            DcDetailID = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            label19 = new Label();
            label20 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBoxPerson.SuspendLayout();
            groupBoxInventory.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 8;
            label1.Text = "Client:";
            // 
            // groupBoxPerson
            // 
            groupBoxPerson.BackColor = Color.PowderBlue;
            groupBoxPerson.Controls.Add(PersonName);
            groupBoxPerson.Controls.Add(label3);
            groupBoxPerson.Controls.Add(PersonEmail);
            groupBoxPerson.Controls.Add(PersonPhone);
            groupBoxPerson.Controls.Add(PersonAddress);
            groupBoxPerson.Controls.Add(label4);
            groupBoxPerson.Controls.Add(label2);
            groupBoxPerson.Controls.Add(label1);
            groupBoxPerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxPerson.ForeColor = SystemColors.ControlText;
            groupBoxPerson.Location = new Point(78, 33);
            groupBoxPerson.Margin = new Padding(2);
            groupBoxPerson.Name = "groupBoxPerson";
            groupBoxPerson.Padding = new Padding(2);
            groupBoxPerson.Size = new Size(802, 232);
            groupBoxPerson.TabIndex = 19;
            groupBoxPerson.TabStop = false;
            groupBoxPerson.Text = "PERSON";
            groupBoxPerson.Paint += groupBoxPerson_Paint;
            // 
            // PersonName
            // 
            PersonName.BorderStyle = BorderStyle.FixedSingle;
            PersonName.Enabled = false;
            PersonName.Location = new Point(124, 50);
            PersonName.Margin = new Padding(4);
            PersonName.Name = "PersonName";
            PersonName.Size = new Size(627, 31);
            PersonName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 162);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 15;
            label3.Text = "Phone: ";
            // 
            // PersonEmail
            // 
            PersonEmail.BorderStyle = BorderStyle.FixedSingle;
            PersonEmail.Enabled = false;
            PersonEmail.Location = new Point(124, 164);
            PersonEmail.Margin = new Padding(4);
            PersonEmail.Name = "PersonEmail";
            PersonEmail.Size = new Size(262, 31);
            PersonEmail.TabIndex = 14;
            // 
            // PersonPhone
            // 
            PersonPhone.BorderStyle = BorderStyle.FixedSingle;
            PersonPhone.Enabled = false;
            PersonPhone.Location = new Point(531, 164);
            PersonPhone.Margin = new Padding(4);
            PersonPhone.Name = "PersonPhone";
            PersonPhone.Size = new Size(220, 31);
            PersonPhone.TabIndex = 13;
            // 
            // PersonAddress
            // 
            PersonAddress.BorderStyle = BorderStyle.FixedSingle;
            PersonAddress.Enabled = false;
            PersonAddress.Location = new Point(124, 106);
            PersonAddress.Margin = new Padding(4);
            PersonAddress.Name = "PersonAddress";
            PersonAddress.Size = new Size(627, 31);
            PersonAddress.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 9;
            label2.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(122, 292);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 21;
            // 
            // comboBoxDocument
            // 
            comboBoxDocument.BackColor = Color.Azure;
            comboBoxDocument.FormattingEnabled = true;
            comboBoxDocument.Location = new Point(211, 469);
            comboBoxDocument.Margin = new Padding(2);
            comboBoxDocument.Name = "comboBoxDocument";
            comboBoxDocument.Size = new Size(248, 33);
            comboBoxDocument.TabIndex = 22;
            comboBoxDocument.SelectedIndexChanged += comboBoxDocument_SelectedIndexChanged;
            // 
            // Classify
            // 
            Classify.BackColor = Color.Azure;
            Classify.BorderStyle = BorderStyle.FixedSingle;
            Classify.Enabled = false;
            Classify.Location = new Point(608, 472);
            Classify.Margin = new Padding(4);
            Classify.Name = "Classify";
            Classify.Size = new Size(272, 31);
            Classify.TabIndex = 24;
            // 
            // comboBoxInventory
            // 
            comboBoxInventory.FormattingEnabled = true;
            comboBoxInventory.Location = new Point(169, 48);
            comboBoxInventory.Margin = new Padding(2);
            comboBoxInventory.Name = "comboBoxInventory";
            comboBoxInventory.Size = new Size(225, 33);
            comboBoxInventory.TabIndex = 13;
            comboBoxInventory.SelectedIndexChanged += comboBoxInventory_SelectedIndexChanged;
            // 
            // groupBoxInventory
            // 
            groupBoxInventory.BackColor = Color.PowderBlue;
            groupBoxInventory.Controls.Add(label11);
            groupBoxInventory.Controls.Add(label10);
            groupBoxInventory.Controls.Add(textBoxInventoryAddress);
            groupBoxInventory.Controls.Add(comboBoxInventory);
            groupBoxInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxInventory.Location = new Point(927, 348);
            groupBoxInventory.Margin = new Padding(4);
            groupBoxInventory.Name = "groupBoxInventory";
            groupBoxInventory.Padding = new Padding(4);
            groupBoxInventory.Size = new Size(851, 102);
            groupBoxInventory.TabIndex = 20;
            groupBoxInventory.TabStop = false;
            groupBoxInventory.Text = "INVENTORY";
            groupBoxInventory.Paint += groupBoxInventory_Paint;
            // 
            // textBoxInventoryAddress
            // 
            textBoxInventoryAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxInventoryAddress.Enabled = false;
            textBoxInventoryAddress.Location = new Point(515, 48);
            textBoxInventoryAddress.Margin = new Padding(4);
            textBoxInventoryAddress.Name = "textBoxInventoryAddress";
            textBoxInventoryAddress.Size = new Size(313, 31);
            textBoxInventoryAddress.TabIndex = 15;
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeName.Enabled = false;
            textBoxEmployeeName.Location = new Point(133, 45);
            textBoxEmployeeName.Margin = new Padding(4);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(316, 31);
            textBoxEmployeeName.TabIndex = 2;
            // 
            // textBoxEmployeeTitle
            // 
            textBoxEmployeeTitle.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeTitle.Enabled = false;
            textBoxEmployeeTitle.Location = new Point(564, 45);
            textBoxEmployeeTitle.Margin = new Padding(4);
            textBoxEmployeeTitle.Name = "textBoxEmployeeTitle";
            textBoxEmployeeTitle.Size = new Size(192, 31);
            textBoxEmployeeTitle.TabIndex = 3;
            // 
            // textBoxCreateDate
            // 
            textBoxCreateDate.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreateDate.Enabled = false;
            textBoxCreateDate.Location = new Point(564, 105);
            textBoxCreateDate.Margin = new Padding(4);
            textBoxCreateDate.Name = "textBoxCreateDate";
            textBoxCreateDate.Size = new Size(192, 31);
            textBoxCreateDate.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(63, 111);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(63, 25);
            label17.TabIndex = 14;
            label17.Text = "Email:";
            // 
            // UserEmail
            // 
            UserEmail.Enabled = false;
            UserEmail.Location = new Point(129, 105);
            UserEmail.Margin = new Padding(4);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(322, 31);
            UserEmail.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PowderBlue;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(UserEmail);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(textBoxCreateDate);
            groupBox1.Controls.Add(textBoxEmployeeTitle);
            groupBox1.Controls.Add(textBoxEmployeeName);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(78, 292);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(802, 158);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "EMLOYEE";
            groupBox1.Paint += groupBox1_Paint;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(241, 39);
            comboBoxProduct.Margin = new Padding(2);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(539, 33);
            comboBoxProduct.TabIndex = 14;
            comboBoxProduct.SelectionChangeCommitted += comboBoxProduct_SelectionChangeCommitted;
            // 
            // textBoxCategory
            // 
            textBoxCategory.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategory.Enabled = false;
            textBoxCategory.Location = new Point(579, 106);
            textBoxCategory.Margin = new Padding(4);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(201, 31);
            textBoxCategory.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(60, 108);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(173, 25);
            label14.TabIndex = 18;
            label14.Text = "Available quantity:";
            // 
            // maskedTextBoxQuantityCurrent
            // 
            maskedTextBoxQuantityCurrent.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxQuantityCurrent.Enabled = false;
            maskedTextBoxQuantityCurrent.Location = new Point(241, 106);
            maskedTextBoxQuantityCurrent.Margin = new Padding(4);
            maskedTextBoxQuantityCurrent.Name = "maskedTextBoxQuantityCurrent";
            maskedTextBoxQuantityCurrent.Size = new Size(218, 31);
            maskedTextBoxQuantityCurrent.TabIndex = 19;
            // 
            // maskedTextBoxQuantity
            // 
            maskedTextBoxQuantity.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxQuantity.Location = new Point(241, 168);
            maskedTextBoxQuantity.Margin = new Padding(4);
            maskedTextBoxQuantity.Name = "maskedTextBoxQuantity";
            maskedTextBoxQuantity.Size = new Size(218, 31);
            maskedTextBoxQuantity.TabIndex = 21;
            maskedTextBoxQuantity.Validating += maskedTextBoxQuantity_Validating;
            // 
            // textBoxPriceCurrent
            // 
            textBoxPriceCurrent.BorderStyle = BorderStyle.FixedSingle;
            textBoxPriceCurrent.Enabled = false;
            textBoxPriceCurrent.Location = new Point(241, 228);
            textBoxPriceCurrent.Margin = new Padding(4);
            textBoxPriceCurrent.Name = "textBoxPriceCurrent";
            textBoxPriceCurrent.Size = new Size(218, 31);
            textBoxPriceCurrent.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(568, 203);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(211, 52);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PowderBlue;
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBoxPriceCurrent);
            groupBox3.Controls.Add(maskedTextBoxQuantity);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(maskedTextBoxQuantityCurrent);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBoxCategory);
            groupBox3.Controls.Add(comboBoxProduct);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(927, 33);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(851, 284);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "PRODUCT";
            groupBox3.Paint += groupBox3_Paint;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // TotalPrice
            // 
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // InventoryID_
            // 
            InventoryID_.DataPropertyName = "InventoryID";
            InventoryID_.HeaderText = "InventoryID";
            InventoryID_.MinimumWidth = 6;
            InventoryID_.Name = "InventoryID_";
            InventoryID_.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // ProductID_
            // 
            ProductID_.DataPropertyName = "ProductID";
            ProductID_.HeaderText = "ProductID";
            ProductID_.MinimumWidth = 6;
            ProductID_.Name = "ProductID_";
            ProductID_.ReadOnly = true;
            // 
            // DcDetailID
            // 
            DcDetailID.DataPropertyName = "DcDetailID";
            DcDetailID.HeaderText = "DcDetailID";
            DcDetailID.MinimumWidth = 6;
            DcDetailID.Name = "DcDetailID";
            DcDetailID.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DcDetailID, ProductID_, Price, Quantity, InventoryID_, TotalPrice, Delete });
            dataGridView1.Location = new Point(78, 527);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1700, 401);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(174, 230);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(59, 25);
            label19.TabIndex = 29;
            label19.Text = "Price:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(99, 47);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(134, 25);
            label20.TabIndex = 28;
            label20.Text = "NameProduct:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(141, 170);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(92, 25);
            label15.TabIndex = 30;
            label15.Text = "Quantity:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(476, 108);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 31;
            label13.Text = "Category:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(81, 472);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(124, 25);
            label12.TabIndex = 28;
            label12.Text = "DocumentID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(519, 474);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 29;
            label6.Text = "Classify:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 51);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 16;
            label7.Text = "Emloyee:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(503, 107);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 18;
            label9.Text = "Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(475, 47);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 17;
            label8.Text = "Position:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 55);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 16;
            label10.Text = "Name inventory:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(422, 52);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 17;
            label11.Text = "Address:";
            // 
            // DocumentDetailsEx
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1854, 953);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInventory);
            Controls.Add(Classify);
            Controls.Add(comboBoxDocument);
            Controls.Add(label5);
            Controls.Add(groupBoxPerson);
            Margin = new Padding(4);
            Name = "DocumentDetailsEx";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Xử lý chi tiết xuất kho";
            Load += DocumentDetailsEx_Load;
            groupBoxPerson.ResumeLayout(false);
            groupBoxPerson.PerformLayout();
            groupBoxInventory.ResumeLayout(false);
            groupBoxInventory.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBoxPerson;
        private TextBox PersonName;
        private Label label3;
        private TextBox PersonEmail;
        private TextBox PersonPhone;
        private TextBox PersonAddress;
        private Label label4;
        private Label label2;
        private Label label5;
        private ComboBox comboBoxDocument;
        private TextBox Classify;
        private ComboBox comboBoxInventory;
        private GroupBox groupBoxInventory;
        private TextBox textBoxInventoryAddress;
        private TextBox textBoxEmployeeName;
        private TextBox textBoxEmployeeTitle;
        private TextBox textBoxCreateDate;
        private Label label17;
        private TextBox UserEmail;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private ComboBox comboBoxProduct;
        private TextBox textBoxCategory;
        private Label label14;
        private MaskedTextBox maskedTextBoxQuantityCurrent;
        private MaskedTextBox maskedTextBoxQuantity;
        private TextBox textBoxPriceCurrent;
        private Button button1;
        private GroupBox groupBox3;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn InventoryID_;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn ProductID_;
        private DataGridViewTextBoxColumn DcDetailID;
        private DataGridView dataGridView1;
        private Label label20;
        private Label label19;
        private Label label15;
        private Label label13;
        private Label label12;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
    }
}