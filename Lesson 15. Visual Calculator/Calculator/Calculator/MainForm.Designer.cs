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
            btnPlus.Location = new Point(544, 22);
            btnPlus.Margin = new Padding(2, 2, 2, 2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(52, 50);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 14F);
            txtA.Location = new Point(36, 22);
            txtA.Margin = new Padding(2, 2, 2, 2);
            txtA.Name = "txtA";
            txtA.Size = new Size(190, 39);
            txtA.TabIndex = 1;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinus.ForeColor = Color.Blue;
            btnMinus.Location = new Point(544, 86);
            btnMinus.Margin = new Padding(2, 2, 2, 2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(52, 50);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 14F);
            txtB.Location = new Point(246, 22);
            txtB.Margin = new Padding(2, 2, 2, 2);
            txtB.Name = "txtB";
            txtB.Size = new Size(190, 39);
            txtB.TabIndex = 3;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lbResult.ForeColor = Color.Coral;
            lbResult.Location = new Point(36, 86);
            lbResult.Margin = new Padding(2, 0, 2, 0);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(120, 47);
            lbResult.TabIndex = 4;
            lbResult.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lbResult);
            Controls.Add(txtB);
            Controls.Add(btnMinus);
            Controls.Add(txtA);
            Controls.Add(btnPlus);
            Margin = new Padding(2, 2, 2, 2);
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
