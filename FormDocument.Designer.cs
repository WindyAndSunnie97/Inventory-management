namespace QuanlyKho1
{
    partial class FormDocument
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btNew = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            comboBox1 = new ComboBox();
            btEx = new Button();
            panel1 = new Panel();
            btIm = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            DocumentID = new DataGridViewTextBoxColumn();
            NamePerson = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            EmployeeEmail = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btNew
            // 
            btNew.BackColor = Color.Navy;
            btNew.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btNew.ForeColor = SystemColors.ButtonHighlight;
            btNew.Location = new Point(46, 51);
            btNew.Margin = new Padding(4);
            btNew.Name = "btNew";
            btNew.Size = new Size(217, 78);
            btNew.TabIndex = 23;
            btNew.Text = "Add";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DocumentID, NamePerson, Address, Phone, Employee, EmployeeEmail, CreateDate, Delete, Edit });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(32, 34);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1367, 505);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(13, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 29);
            label4.TabIndex = 30;
            label4.Text = "Classify:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.AliceBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đơn nhập", "Đơn xuất" });
            comboBox1.Location = new Point(127, 21);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(407, 33);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // btEx
            // 
            btEx.BackColor = Color.Navy;
            btEx.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btEx.ForeColor = SystemColors.ButtonHighlight;
            btEx.Location = new Point(46, 301);
            btEx.Margin = new Padding(4);
            btEx.Name = "btEx";
            btEx.Size = new Size(217, 86);
            btEx.TabIndex = 31;
            btEx.Text = "Add Export detail";
            btEx.UseVisualStyleBackColor = false;
            btEx.Click += btEx_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btIm);
            panel1.Controls.Add(btEx);
            panel1.Controls.Add(btNew);
            panel1.Location = new Point(51, 438);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 445);
            panel1.TabIndex = 32;
            // 
            // btIm
            // 
            btIm.BackColor = Color.Navy;
            btIm.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btIm.ForeColor = SystemColors.ButtonHighlight;
            btIm.Location = new Point(46, 176);
            btIm.Margin = new Padding(4);
            btIm.Name = "btIm";
            btIm.Size = new Size(217, 84);
            btIm.TabIndex = 32;
            btIm.Text = "Add Import detail";
            btIm.UseVisualStyleBackColor = false;
            btIm.Click += btIm_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 27);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1865, 101);
            panel2.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(394, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(922, 99);
            label2.TabIndex = 33;
            label2.Text = "MANAGE DOCUMENT";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Location = new Point(0, 13);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1865, 17);
            panel3.TabIndex = 36;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Navy;
            panel5.Location = new Point(0, 121);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1865, 23);
            panel5.TabIndex = 38;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(1250, 281);
            panel4.Name = "panel4";
            panel4.Size = new Size(559, 75);
            panel4.TabIndex = 39;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(378, 378);
            panel6.Name = "panel6";
            panel6.Size = new Size(1431, 572);
            panel6.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(378, 274);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(465, 57);
            label6.TabIndex = 41;
            label6.Text = "LIST DOCUMENT";
            // 
            // DocumentID
            // 
            DocumentID.DataPropertyName = "DocumentID";
            DocumentID.HeaderText = "DocumentID";
            DocumentID.MinimumWidth = 8;
            DocumentID.Name = "DocumentID";
            // 
            // NamePerson
            // 
            NamePerson.DataPropertyName = "NamePerson";
            NamePerson.HeaderText = "Name";
            NamePerson.MinimumWidth = 8;
            NamePerson.Name = "NamePerson";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            // 
            // Employee
            // 
            Employee.DataPropertyName = "Employee";
            Employee.HeaderText = "Employee";
            Employee.MinimumWidth = 8;
            Employee.Name = "Employee";
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.DataPropertyName = "EmployeeEmail";
            EmployeeEmail.HeaderText = "EmployeeEmail";
            EmployeeEmail.MinimumWidth = 8;
            EmployeeEmail.Name = "EmployeeEmail";
            // 
            // CreateDate
            // 
            CreateDate.DataPropertyName = "CreateDate";
            CreateDate.HeaderText = "CreateDate";
            CreateDate.MinimumWidth = 8;
            CreateDate.Name = "CreateDate";
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
            // FormDocument
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1863, 1009);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Margin = new Padding(2);
            Name = "FormDocument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ PHIẾU NHẬP/XUẤT";
            WindowState = FormWindowState.Maximized;
            Activated += FormDocument_Activated;
            Load += FormDocument_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNew;
        private Label label3;
        private Label label2;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox comboBox1;
        private Button btEx;
        private Panel panel1;
        private Button btIm;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Label label6;
        private DataGridViewTextBoxColumn DocumentID;
        private DataGridViewTextBoxColumn NamePerson;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn EmployeeEmail;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Edit;
    }
}