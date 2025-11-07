namespace WorkingListView
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
            ListViewItem listViewItem3 = new ListViewItem("Мої файли");
            ListViewItem listViewItem4 = new ListViewItem("Документи");
            myListView = new ListView();
            label1 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // myListView
            // 
            listViewItem3.UseItemStyleForSubItems = false;
            listViewItem4.UseItemStyleForSubItems = false;
            myListView.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            myListView.Location = new Point(12, 74);
            myListView.Name = "myListView";
            myListView.Size = new Size(1077, 495);
            myListView.TabIndex = 0;
            myListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 45);
            label1.TabIndex = 1;
            label1.Text = "Файлова система";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 45);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 581);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(myListView);
            Name = "MainForm";
            Text = "Відображення ListView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView myListView;
        private Label label1;
        private Button btnAdd;
    }
}
