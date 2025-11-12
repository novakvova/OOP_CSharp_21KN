namespace ListViewImageView
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
            myLv = new ListView();
            SuspendLayout();
            // 
            // myLv
            // 
            myLv.Location = new Point(21, 62);
            myLv.Name = "myLv";
            myLv.Size = new Size(657, 415);
            myLv.TabIndex = 0;
            myLv.View = View.LargeIcon;
            myLv.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 514);
            Controls.Add(myLv);
            Name = "MainForm";
            Text = "Файловий провідник";
            ResumeLayout(false);
        }

        #endregion

        private ListView myLv;
    }
}
