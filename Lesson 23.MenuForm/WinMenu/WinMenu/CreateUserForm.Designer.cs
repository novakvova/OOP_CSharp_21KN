namespace WinMenu
{
    partial class CreateUserForm
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
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            pbImage = new PictureBox();
            txtImage = new TextBox();
            label5 = new Label();
            btnSelect = new Button();
            btnCreate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "Прізвище";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(25, 57);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(341, 34);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(25, 133);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(341, 34);
            txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 2;
            label2.Text = "Ім'я";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(25, 209);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(341, 34);
            txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 4;
            label3.Text = "Телефон";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(341, 34);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(25, 253);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 6;
            label4.Text = "Електронна пошта";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(411, 123);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(245, 205);
            pbImage.TabIndex = 8;
            pbImage.TabStop = false;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(411, 57);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(391, 34);
            txtImage.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(411, 26);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 9;
            label5.Text = "Фото";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(676, 123);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(126, 71);
            btnSelect.TabIndex = 11;
            btnSelect.Text = "Обрати фото";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(214, 374);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(169, 57);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Створити ✅";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(422, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 57);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Скасувати ❌";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 451);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(btnSelect);
            Controls.Add(txtImage);
            Controls.Add(label5);
            Controls.Add(pbImage);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateUserForm";
            Text = "Створити користувача";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private PictureBox pbImage;
        private TextBox txtImage;
        private Label label5;
        private Button btnSelect;
        private Button btnCreate;
        private Button btnCancel;
    }
}