namespace ModalDialogSpeak.MyForms
{
    partial class LoginForm
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
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLoginRequest = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(284, 30);
            label1.Name = "label1";
            label1.Size = new Size(368, 65);
            label1.TabIndex = 0;
            label1.Text = "Вхід у систему";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(35, 119);
            label2.Name = "label2";
            label2.Size = new Size(325, 45);
            label2.TabIndex = 1;
            label2.Text = "Електронна пошта";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtEmail.Location = new Point(391, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 51);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(35, 196);
            label3.Name = "label3";
            label3.Size = new Size(132, 45);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(391, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(494, 51);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLoginRequest
            // 
            btnLoginRequest.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLoginRequest.ForeColor = Color.MediumBlue;
            btnLoginRequest.Location = new Point(181, 311);
            btnLoginRequest.Name = "btnLoginRequest";
            btnLoginRequest.Size = new Size(233, 73);
            btnLoginRequest.TabIndex = 3;
            btnLoginRequest.Text = "Вхід";
            btnLoginRequest.UseVisualStyleBackColor = true;
            btnLoginRequest.Click += btnLoginRequest_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.Magenta;
            btnCancel.Location = new Point(495, 311);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(233, 73);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 431);
            Controls.Add(btnCancel);
            Controls.Add(btnLoginRequest);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вхід у систему";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLoginRequest;
        private Button btnCancel;
    }
}