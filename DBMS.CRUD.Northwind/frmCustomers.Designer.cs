namespace DBMS.CRUD.Northwind
{
    partial class frmCustomers
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
            txtCustomerID = new TextBox();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            btnSave = new Button();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(350, 112);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(172, 23);
            txtCustomerID.TabIndex = 0;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(350, 157);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(172, 23);
            txtCompanyName.TabIndex = 1;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(350, 206);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(172, 23);
            txtContactName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(229, 324);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(350, 254);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 23);
            txtPhone.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 120);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 6;
            label1.Text = "รหัสลูกค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 165);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "ชื่อบริษัท";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 214);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "ชื่อผู้ติดต่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 262);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "เบอร์โทร";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(492, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 38);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCustomers
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(btnSave);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCustomerID);
            Name = "frmCustomers";
            Text = "frmCustomers";
            Load += frmCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerID;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private Button btnSave;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancel;
    }
}