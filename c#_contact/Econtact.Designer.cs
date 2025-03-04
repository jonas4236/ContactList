namespace c__contact
{
    partial class Econtact
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
            lbLogo = new Label();
            lbContactID = new Label();
            lbFirstName = new Label();
            lbLastName = new Label();
            lbContactNo = new Label();
            lblAddress = new Label();
            txtFirstName = new TextBox();
            txtContactID = new TextBox();
            txtLastName = new TextBox();
            txtContactNo = new TextBox();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            lbGender = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvContactList = new DataGridView();
            lbSearch = new Label();
            txtSearch = new TextBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            SuspendLayout();
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(546, 29);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(146, 45);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "EContact";
            // 
            // lbContactID
            // 
            lbContactID.AutoSize = true;
            lbContactID.Font = new Font("Segoe UI", 15.75F);
            lbContactID.Location = new Point(115, 116);
            lbContactID.Name = "lbContactID";
            lbContactID.Size = new Size(112, 30);
            lbContactID.TabIndex = 1;
            lbContactID.Text = "Contact ID";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Font = new Font("Segoe UI", 15.75F);
            lbFirstName.Location = new Point(115, 165);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(113, 30);
            lbFirstName.TabIndex = 2;
            lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Font = new Font("Segoe UI", 15.75F);
            lbLastName.Location = new Point(115, 220);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(112, 30);
            lbLastName.TabIndex = 3;
            lbLastName.Text = "Last Name";
            // 
            // lbContactNo
            // 
            lbContactNo.AutoSize = true;
            lbContactNo.Font = new Font("Segoe UI", 15.75F);
            lbContactNo.Location = new Point(115, 267);
            lbContactNo.Name = "lbContactNo";
            lbContactNo.Size = new Size(124, 30);
            lbContactNo.TabIndex = 4;
            lbContactNo.Text = "Contact No.";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 15.75F);
            lblAddress.Location = new Point(115, 323);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 30);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15.75F);
            txtFirstName.Location = new Point(266, 162);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(271, 35);
            txtFirstName.TabIndex = 6;
            // 
            // txtContactID
            // 
            txtContactID.Font = new Font("Segoe UI", 15.75F);
            txtContactID.Location = new Point(266, 113);
            txtContactID.Name = "txtContactID";
            txtContactID.ReadOnly = true;
            txtContactID.Size = new Size(271, 35);
            txtContactID.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15.75F);
            txtLastName.Location = new Point(266, 217);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(271, 35);
            txtLastName.TabIndex = 7;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 15.75F);
            txtContactNo.Location = new Point(266, 264);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(271, 35);
            txtContactNo.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15.75F);
            txtAddress.Location = new Point(266, 320);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(271, 163);
            txtAddress.TabIndex = 9;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 15.75F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(266, 503);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(271, 38);
            cmbGender.TabIndex = 10;
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 15.75F);
            lbGender.Location = new Point(115, 506);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(80, 30);
            lbGender.TabIndex = 11;
            lbGender.Text = "Gender";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Segoe UI", 15.75F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(96, 588);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Font = new Font("Segoe UI", 15.75F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(233, 588);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 46);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI", 15.75F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(381, 588);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Segoe UI", 15.75F);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(522, 588);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 46);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(564, 165);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.Size = new Size(673, 376);
            dgvContactList.TabIndex = 16;
            dgvContactList.CellContentClick += dgvContactList_CellContentClick;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(564, 118);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(75, 30);
            lbSearch.TabIndex = 17;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(645, 116);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(592, 35);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1154, 29);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 45);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 680);
            Controls.Add(btnExit);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(dgvContactList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lbGender);
            Controls.Add(cmbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtContactNo);
            Controls.Add(txtLastName);
            Controls.Add(txtContactID);
            Controls.Add(txtFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lbContactNo);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbContactID);
            Controls.Add(lbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EContact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogo;
        private Label lbContactID;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbContactNo;
        private Label lblAddress;
        private TextBox txtFirstName;
        private TextBox txtContactID;
        private TextBox txtLastName;
        private TextBox txtContactNo;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private Label lbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvContactList;
        private Label lbSearch;
        private TextBox txtSearch;
        private Button btnExit;
    }
}
