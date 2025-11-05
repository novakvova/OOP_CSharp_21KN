namespace MyDataGridView
{
    partial class MainForm
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
            dgvUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUserPIB = new DataGridViewTextBoxColumn();
            colUserPhone = new DataGridViewTextBoxColumn();
            colUserEmail = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUserPIB, colUserPhone, colUserEmail });
            dgvUsers.Location = new Point(12, 124);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(1188, 506);
            dgvUsers.TabIndex = 0;
            // 
            // colUserId
            // 
            colUserId.HeaderText = "Id";
            colUserId.MinimumWidth = 8;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Width = 150;
            // 
            // colUserPIB
            // 
            colUserPIB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUserPIB.HeaderText = "ПІБ";
            colUserPIB.MinimumWidth = 8;
            colUserPIB.Name = "colUserPIB";
            colUserPIB.ReadOnly = true;
            // 
            // colUserPhone
            // 
            colUserPhone.HeaderText = "Телефон";
            colUserPhone.MinimumWidth = 8;
            colUserPhone.Name = "colUserPhone";
            colUserPhone.ReadOnly = true;
            colUserPhone.Width = 200;
            // 
            // colUserEmail
            // 
            colUserEmail.HeaderText = "Пошта";
            colUserEmail.MinimumWidth = 8;
            colUserEmail.Name = "colUserEmail";
            colUserEmail.ReadOnly = true;
            colUserEmail.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(418, 26);
            label1.Name = "label1";
            label1.Size = new Size(350, 45);
            label1.TabIndex = 1;
            label1.Text = "Список користувачів";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(1028, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 55);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 642);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dgvUsers);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Користувачі";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Label label1;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUserPIB;
        private DataGridViewTextBoxColumn colUserPhone;
        private DataGridViewTextBoxColumn colUserEmail;
        private Button btnAdd;
    }
}
