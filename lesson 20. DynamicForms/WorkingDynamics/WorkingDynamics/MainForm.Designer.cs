namespace WorkingDynamics
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
            txtN = new TextBox();
            label1 = new Label();
            btnBuilder = new Button();
            btnCalculation = new Button();
            txtM = new TextBox();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(36, 63);
            txtN.Name = "txtN";
            txtN.Size = new Size(174, 39);
            txtN.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 1;
            label1.Text = "Кількість";
            // 
            // btnBuilder
            // 
            btnBuilder.Location = new Point(405, 56);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(124, 53);
            btnBuilder.TabIndex = 2;
            btnBuilder.Text = "Будувати";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // btnCalculation
            // 
            btnCalculation.Location = new Point(550, 56);
            btnCalculation.Name = "btnCalculation";
            btnCalculation.Size = new Size(159, 53);
            btnCalculation.TabIndex = 3;
            btnCalculation.Text = "Обчислити";
            btnCalculation.UseVisualStyleBackColor = true;
            btnCalculation.Click += btnCalculation_Click;
            // 
            // txtM
            // 
            txtM.Location = new Point(241, 63);
            txtM.Name = "txtM";
            txtM.Size = new Size(150, 39);
            txtM.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 541);
            Controls.Add(txtM);
            Controls.Add(btnCalculation);
            Controls.Add(btnBuilder);
            Controls.Add(label1);
            Controls.Add(txtN);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private Label label1;
        private Button btnBuilder;
        private Button btnCalculation;
        private TextBox txtM;
    }
}
