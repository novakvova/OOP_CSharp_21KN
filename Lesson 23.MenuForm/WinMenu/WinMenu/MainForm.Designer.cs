namespace WinMenu
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
            msMain = new MenuStrip();
            msMain_File = new ToolStripMenuItem();
            msMain_FileExit = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(24, 24);
            msMain.Items.AddRange(new ToolStripItem[] { msMain_File });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(800, 33);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // msMain_File
            // 
            msMain_File.DropDownItems.AddRange(new ToolStripItem[] { msMain_FileExit });
            msMain_File.Name = "msMain_File";
            msMain_File.Size = new Size(54, 29);
            msMain_File.Text = "File";
            // 
            // msMain_FileExit
            // 
            msMain_FileExit.Name = "msMain_FileExit";
            msMain_FileExit.ShortcutKeys = Keys.Control | Keys.X;
            msMain_FileExit.Size = new Size(270, 34);
            msMain_FileExit.Text = "Exit";
            msMain_FileExit.Click += msMain_FileExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "MainForm";
            Text = "Form1";
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem msMain_File;
        private ToolStripMenuItem msMain_FileExit;
        
    }
}
