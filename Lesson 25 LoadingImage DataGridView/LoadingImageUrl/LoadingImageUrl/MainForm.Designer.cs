namespace LoadingImageUrl
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
            pbImage = new PictureBox();
            btnLoadUrl = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(40, 67);
            pbImage.Margin = new Padding(2, 2, 2, 2);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(276, 293);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btnLoadUrl
            // 
            btnLoadUrl.Location = new Point(344, 67);
            btnLoadUrl.Margin = new Padding(2, 2, 2, 2);
            btnLoadUrl.Name = "btnLoadUrl";
            btnLoadUrl.Size = new Size(189, 51);
            btnLoadUrl.TabIndex = 1;
            btnLoadUrl.Text = "Завантажити";
            btnLoadUrl.UseVisualStyleBackColor = true;
            btnLoadUrl.Click += btnLoadUrl_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 445);
            Controls.Add(btnLoadUrl);
            Controls.Add(pbImage);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImage;
        private Button btnLoadUrl;
    }
}
