namespace Calculator
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
            btnPlus = new Button();
            txtA = new TextBox();
            btnMinus = new Button();
            txtB = new TextBox();
            lbResult = new Label();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPlus.ForeColor = Color.Blue;
            btnPlus.Location = new Point(680, 27);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(65, 62);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 14F);
            txtA.Location = new Point(45, 27);
            txtA.Name = "txtA";
            txtA.Size = new Size(237, 45);
            txtA.TabIndex = 1;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinus.ForeColor = Color.Blue;
            btnMinus.Location = new Point(680, 108);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(65, 62);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 14F);
            txtB.Location = new Point(307, 27);
            txtB.Name = "txtB";
            txtB.Size = new Size(237, 45);
            txtB.TabIndex = 3;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lbResult.ForeColor = Color.Coral;
            lbResult.Location = new Point(45, 108);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(145, 57);
            lbResult.TabIndex = 4;
            lbResult.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResult);
            Controls.Add(txtB);
            Controls.Add(btnMinus);
            Controls.Add(txtA);
            Controls.Add(btnPlus);
            Name = "MainForm";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private TextBox txtA;
        private Button btnMinus;
        private TextBox txtB;
        private Label lbResult;
    }
}
