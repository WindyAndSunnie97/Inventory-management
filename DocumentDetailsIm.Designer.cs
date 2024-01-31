namespace QuanlyKho1
{
    partial class DocumentDetailsIm
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
            groupBoxPerson = new GroupBox();
            PersonName = new TextBox();
            label3 = new Label();
            PersonEmail = new TextBox();
            PersonPhone = new TextBox();
            PersonAddress = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            comboBoxDocument = new ComboBox();
            label6 = new Label();
            Classify = new TextBox();
            groupBox1 = new GroupBox();
            UserEmail = new TextBox();
            label17 = new Label();
            textBoxCreateDate = new TextBox();
            label9 = new Label();
            textBoxEmployeeTitle = new TextBox();
            textBoxEmployeeName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBoxInventory = new GroupBox();
            textBoxInventoryAddress = new TextBox();
            label11 = new Label();
            comboBoxInventory = new ComboBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            DcDetailID = new DataGridViewTextBoxColumn();
            ProductID_ = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            InventoryID_ = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            groupBox3 = new GroupBox();
            button1 = new Button();
            textBoxPriceCurrent = new TextBox();
            label16 = new Label();
            maskedTextBoxQuantity = new MaskedTextBox();
            label15 = new Label();
            maskedTextBoxPrice = new MaskedTextBox();
            label14 = new Label();
            textBoxCategory = new TextBox();
            label13 = new Label();
            label12 = new Label();
            comboBoxProduct = new ComboBox();
            toolTip1 = new ToolTip(components);
            groupBoxPerson.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            groupBoxPerson.Location = new Point(23, 25);
            groupBoxPerson.Margin = new Padding(2);
            groupBoxPerson.Name = "groupBoxPerson";
            groupBoxPerson.Padding = new Padding(2);
            groupBoxPerson.Size = new Size(841, 231);
            groupBoxPerson.TabIndex = 0;
            groupBoxPerson.TabStop = false;
            groupBoxPerson.Text = "PERSON";
            groupBoxPerson.Paint += groupBoxPerson_Paint;
            groupBoxPerson.Enter += groupBoxPerson_Enter;
            // 
            // PersonName
            // 
            PersonName.BorderStyle = BorderStyle.FixedSingle;
            PersonName.Enabled = false;
            PersonName.Location = new Point(114, 51);
            PersonName.Margin = new Padding(4);
            PersonName.Name = "PersonName";
            PersonName.Size = new Size(678, 31);
            PersonName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 176);
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
            PersonEmail.Location = new Point(114, 174);
            PersonEmail.Margin = new Padding(4);
            PersonEmail.Name = "PersonEmail";
            PersonEmail.Size = new Size(248, 31);
            PersonEmail.TabIndex = 14;
            // 
            // PersonPhone
            // 
            PersonPhone.BorderStyle = BorderStyle.FixedSingle;
            PersonPhone.Enabled = false;
            PersonPhone.Location = new Point(572, 174);
            PersonPhone.Margin = new Padding(4);
            PersonPhone.Name = "PersonPhone";
            PersonPhone.Size = new Size(220, 31);
            PersonPhone.TabIndex = 13;
            // 
            // PersonAddress
            // 
            PersonAddress.BorderStyle = BorderStyle.FixedSingle;
            PersonAddress.Enabled = false;
            PersonAddress.Location = new Point(114, 107);
            PersonAddress.Margin = new Padding(4);
            PersonAddress.Name = "PersonAddress";
            PersonAddress.Size = new Size(678, 31);
            PersonAddress.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 176);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 109);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 9;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 8;
            label1.Text = "Supplier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 453);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 11;
            label5.Text = "DocumentID:";
            // 
            // comboBoxDocument
            // 
            comboBoxDocument.BackColor = Color.Azure;
            comboBoxDocument.FormattingEnabled = true;
            comboBoxDocument.Location = new Point(155, 449);
            comboBoxDocument.Margin = new Padding(2);
            comboBoxDocument.Name = "comboBoxDocument";
            comboBoxDocument.Size = new Size(248, 33);
            comboBoxDocument.TabIndex = 12;
            comboBoxDocument.SelectedIndexChanged += comboBoxDocument_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(475, 449);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 13;
            label6.Text = "Classify:";
            // 
            // Classify
            // 
            Classify.BackColor = Color.Azure;
            Classify.BorderStyle = BorderStyle.FixedSingle;
            Classify.Enabled = false;
            Classify.Location = new Point(564, 447);
            Classify.Margin = new Padding(4);
            Classify.Name = "Classify";
            Classify.Size = new Size(300, 31);
            Classify.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PowderBlue;
            groupBox1.Controls.Add(UserEmail);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(textBoxCreateDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxEmployeeTitle);
            groupBox1.Controls.Add(textBoxEmployeeName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 276);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(841, 142);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "EMLOYEE";
            groupBox1.Paint += groupBox1_Paint;
            // 
            // UserEmail
            // 
            UserEmail.Enabled = false;
            UserEmail.Location = new Point(124, 88);
            UserEmail.Margin = new Padding(4);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(316, 31);
            UserEmail.TabIndex = 17;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(53, 91);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(63, 25);
            label17.TabIndex = 16;
            label17.Text = "Email:";
            // 
            // textBoxCreateDate
            // 
            textBoxCreateDate.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreateDate.Enabled = false;
            textBoxCreateDate.Location = new Point(606, 89);
            textBoxCreateDate.Margin = new Padding(4);
            textBoxCreateDate.Name = "textBoxCreateDate";
            textBoxCreateDate.Size = new Size(186, 31);
            textBoxCreateDate.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(541, 91);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 4;
            label9.Text = "Date:";
            // 
            // textBoxEmployeeTitle
            // 
            textBoxEmployeeTitle.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeTitle.Enabled = false;
            textBoxEmployeeTitle.Location = new Point(606, 29);
            textBoxEmployeeTitle.Margin = new Padding(4);
            textBoxEmployeeTitle.Name = "textBoxEmployeeTitle";
            textBoxEmployeeTitle.Size = new Size(186, 31);
            textBoxEmployeeTitle.TabIndex = 3;
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeName.Enabled = false;
            textBoxEmployeeName.Location = new Point(124, 36);
            textBoxEmployeeName.Margin = new Padding(4);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(316, 31);
            textBoxEmployeeName.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(513, 31);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 1;
            label8.Text = "Position:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 42);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 0;
            label7.Text = "Emloyee:";
            // 
            // groupBoxInventory
            // 
            groupBoxInventory.BackColor = Color.PowderBlue;
            groupBoxInventory.Controls.Add(textBoxInventoryAddress);
            groupBoxInventory.Controls.Add(label11);
            groupBoxInventory.Controls.Add(comboBoxInventory);
            groupBoxInventory.Controls.Add(label10);
            groupBoxInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxInventory.Location = new Point(892, 305);
            groupBoxInventory.Margin = new Padding(4);
            groupBoxInventory.Name = "groupBoxInventory";
            groupBoxInventory.Padding = new Padding(4);
            groupBoxInventory.Size = new Size(926, 110);
            groupBoxInventory.TabIndex = 6;
            groupBoxInventory.TabStop = false;
            groupBoxInventory.Text = "INVENTORY";
            groupBoxInventory.Paint += groupBox2_Paint;
            groupBoxInventory.Enter += groupBox2_Enter;
            // 
            // textBoxInventoryAddress
            // 
            textBoxInventoryAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxInventoryAddress.Enabled = false;
            textBoxInventoryAddress.Location = new Point(591, 48);
            textBoxInventoryAddress.Margin = new Padding(4);
            textBoxInventoryAddress.Name = "textBoxInventoryAddress";
            textBoxInventoryAddress.Size = new Size(297, 31);
            textBoxInventoryAddress.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(498, 50);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 14;
            label11.Text = "Address:";
            // 
            // comboBoxInventory
            // 
            comboBoxInventory.FormattingEnabled = true;
            comboBoxInventory.Location = new Point(179, 48);
            comboBoxInventory.Margin = new Padding(2);
            comboBoxInventory.Name = "comboBoxInventory";
            comboBoxInventory.Size = new Size(281, 33);
            comboBoxInventory.TabIndex = 13;
            comboBoxInventory.SelectedIndexChanged += comboBoxInventory_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 54);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 5;
            label10.Text = "Name inventory:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DcDetailID, ProductID_, Price, Quantity, InventoryID_, TotalPrice, Delete });
            dataGridView1.Location = new Point(24, 513);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1794, 416);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DcDetailID
            // 
            DcDetailID.DataPropertyName = "DcDetailID";
            DcDetailID.HeaderText = "DcDetailID";
            DcDetailID.MinimumWidth = 6;
            DcDetailID.Name = "DcDetailID";
            DcDetailID.ReadOnly = true;
            // 
            // ProductID_
            // 
            ProductID_.DataPropertyName = "ProductID";
            ProductID_.HeaderText = "ProductID";
            ProductID_.MinimumWidth = 6;
            ProductID_.Name = "ProductID_";
            ProductID_.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // InventoryID_
            // 
            InventoryID_.DataPropertyName = "InventoryID";
            InventoryID_.HeaderText = "InventoryID";
            InventoryID_.MinimumWidth = 6;
            InventoryID_.Name = "InventoryID_";
            InventoryID_.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.PowderBlue;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBoxPriceCurrent);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(maskedTextBoxQuantity);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(maskedTextBoxPrice);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBoxCategory);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(comboBoxProduct);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(892, 25);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(926, 257);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "PRODUCT";
            groupBox3.Paint += groupBox3_Paint;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(660, 179);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(211, 52);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPriceCurrent
            // 
            textBoxPriceCurrent.BorderStyle = BorderStyle.FixedSingle;
            textBoxPriceCurrent.Enabled = false;
            textBoxPriceCurrent.Location = new Point(158, 176);
            textBoxPriceCurrent.Margin = new Padding(4);
            textBoxPriceCurrent.Name = "textBoxPriceCurrent";
            textBoxPriceCurrent.Size = new Size(302, 31);
            textBoxPriceCurrent.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 178);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(125, 25);
            label16.TabIndex = 22;
            label16.Text = "Market price:";
            // 
            // maskedTextBoxQuantity
            // 
            maskedTextBoxQuantity.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxQuantity.Location = new Point(630, 115);
            maskedTextBoxQuantity.Margin = new Padding(4);
            maskedTextBoxQuantity.Name = "maskedTextBoxQuantity";
            maskedTextBoxQuantity.Size = new Size(258, 31);
            maskedTextBoxQuantity.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(530, 117);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(92, 25);
            label15.TabIndex = 20;
            label15.Text = "Quantity:";
            // 
            // maskedTextBoxPrice
            // 
            maskedTextBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxPrice.Location = new Point(158, 113);
            maskedTextBoxPrice.Margin = new Padding(4);
            maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            maskedTextBoxPrice.Size = new Size(302, 31);
            maskedTextBoxPrice.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(91, 113);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(59, 25);
            label14.TabIndex = 18;
            label14.Text = "Price:";
            // 
            // textBoxCategory
            // 
            textBoxCategory.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategory.Enabled = false;
            textBoxCategory.Location = new Point(630, 52);
            textBoxCategory.Margin = new Padding(4);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(258, 31);
            textBoxCategory.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(527, 55);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 16;
            label13.Text = "Category:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 55);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(134, 25);
            label12.TabIndex = 15;
            label12.Text = "NameProduct:";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(158, 50);
            comboBoxProduct.Margin = new Padding(2);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(302, 33);
            comboBoxProduct.TabIndex = 14;
            comboBoxProduct.SelectedIndexChanged += comboBoxProduct_SelectedIndexChanged;
            // 
            // DocumentDetailsIm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1854, 953);
            Controls.Add(label6);
            Controls.Add(groupBox3);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxDocument);
            Controls.Add(groupBoxInventory);
            Controls.Add(Classify);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxPerson);
            Margin = new Padding(2);
            Name = "DocumentDetailsIm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xử lý chi tiết nhập kho";
            Load += DocumentDetails_Load_1;
            groupBoxPerson.ResumeLayout(false);
            groupBoxPerson.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxInventory.ResumeLayout(false);
            groupBoxInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxPerson;
        private TextBox PersonName;
        private Label label3;
        private TextBox PersonEmail;
        private TextBox PersonPhone;
        private TextBox PersonAddress;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox comboBoxDocument;
        private Label label6;
        private TextBox Classify;
        private GroupBox groupBox1;
        private TextBox textBoxEmployeeTitle;
        private TextBox textBoxEmployeeName;
        private Label label8;
        private Label label7;
        private TextBox textBoxCreateDate;
        private Label label9;
        private GroupBox groupBoxInventory;
        private Label label10;
        private ComboBox comboBoxInventory;
        private TextBox textBoxInventoryAddress;
        private Label label11;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox textBoxCategory;
        private Label label13;
        private Label label12;
        private ComboBox comboBoxProduct;
        private MaskedTextBox maskedTextBoxPrice;
        private Label label14;
        private MaskedTextBox maskedTextBoxQuantity;
        private Label label15;
        private TextBox textBoxPriceCurrent;
        private Label label16;
        private Button button1;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn DcDetailID;
        private DataGridViewTextBoxColumn ProductID_;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn InventoryID_;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewButtonColumn Delete;
        private TextBox UserEmail;
        private Label label17;
    }
}