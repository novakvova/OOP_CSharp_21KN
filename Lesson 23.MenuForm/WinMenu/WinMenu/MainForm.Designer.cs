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
            sm_Operations = new ToolStripMenuItem();
            smMain_OperationsCreateUser = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(24, 24);
            msMain.Items.AddRange(new ToolStripItem[] { msMain_File, sm_Operations });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Padding = new Padding(5, 2, 0, 2);
            msMain.Size = new Size(1095, 28);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // msMain_File
            // 
            msMain_File.DropDownItems.AddRange(new ToolStripItem[] { msMain_FileExit });
            msMain_File.Name = "msMain_File";
            msMain_File.Size = new Size(46, 24);
            msMain_File.Text = "File";
            // 
            // msMain_FileExit
            // 
            msMain_FileExit.Name = "msMain_FileExit";
            msMain_FileExit.ShortcutKeys = Keys.Control | Keys.X;
            msMain_FileExit.Size = new Size(167, 26);
            msMain_FileExit.Text = "Exit";
            msMain_FileExit.Click += msMain_FileExit_Click;
            // 
            // sm_Operations
            // 
            sm_Operations.DropDownItems.AddRange(new ToolStripItem[] { smMain_OperationsCreateUser });
            sm_Operations.Name = "sm_Operations";
            sm_Operations.Size = new Size(96, 24);
            sm_Operations.Text = "Operations";
            // 
            // smMain_OperationsCreateUser
            // 
            smMain_OperationsCreateUser.Name = "smMain_OperationsCreateUser";
            smMain_OperationsCreateUser.Size = new Size(224, 26);
            smMain_OperationsCreateUser.Text = "CreateUser";
            smMain_OperationsCreateUser.Click += smMain_OperationsCreateUser_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 623);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem msMain_File;
        private ToolStripMenuItem msMain_FileExit;
        private ToolStripMenuItem sm_Operations;
        private ToolStripMenuItem smMain_OperationsCreateUser;
    }
}
