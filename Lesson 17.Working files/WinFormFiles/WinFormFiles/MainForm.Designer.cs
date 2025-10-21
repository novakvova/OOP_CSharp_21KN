namespace WinFormFiles
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
            btnSelectFile = new Button();
            txtSelectFile = new TextBox();
            label1 = new Label();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(521, 66);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(194, 44);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Оберіть фото";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtSelectFile
            // 
            txtSelectFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSelectFile.Location = new Point(18, 71);
            txtSelectFile.Name = "txtSelectFile";
            txtSelectFile.Size = new Size(497, 39);
            txtSelectFile.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 2;
            label1.Text = "Ваше фото";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(18, 129);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(167, 165);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbImage);
            Controls.Add(label1);
            Controls.Add(txtSelectFile);
            Controls.Add(btnSelectFile);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private TextBox txtSelectFile;
        private Label label1;
        private PictureBox pbImage;
    }
}
