namespace UnityClearProjects
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnDeleteSingleKey = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unityFourmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.visitNackadooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitGrefugaStudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richInfoBox = new System.Windows.Forms.RichTextBox();
            this.lblProjectsCount = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProjects
            // 
            this.lstProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 18;
            this.lstProjects.Location = new System.Drawing.Point(13, 44);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(489, 238);
            this.lstProjects.TabIndex = 0;
            this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstProjects_SelectedIndexChanged);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(15, 408);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 48);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteSingleKey
            // 
            this.btnDeleteSingleKey.Location = new System.Drawing.Point(173, 408);
            this.btnDeleteSingleKey.Name = "btnDeleteSingleKey";
            this.btnDeleteSingleKey.Size = new System.Drawing.Size(75, 48);
            this.btnDeleteSingleKey.TabIndex = 2;
            this.btnDeleteSingleKey.Text = "Remove Project";
            this.btnDeleteSingleKey.UseVisualStyleBackColor = true;
            this.btnDeleteSingleKey.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem1.Text = "Open Selected Folder";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCurrentKeyToolStripMenuItem,
            this.removeAllProjectsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // deleteCurrentKeyToolStripMenuItem
            // 
            this.deleteCurrentKeyToolStripMenuItem.Name = "deleteCurrentKeyToolStripMenuItem";
            this.deleteCurrentKeyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.deleteCurrentKeyToolStripMenuItem.Text = "Remove Selected Project";
            this.deleteCurrentKeyToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentKeyToolStripMenuItem_Click);
            // 
            // removeAllProjectsToolStripMenuItem
            // 
            this.removeAllProjectsToolStripMenuItem.Name = "removeAllProjectsToolStripMenuItem";
            this.removeAllProjectsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.removeAllProjectsToolStripMenuItem.Text = "Remove All Projects";
            this.removeAllProjectsToolStripMenuItem.Click += new System.EventHandler(this.removeAllProjectsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuHelp,
            this.toolStripSeparator2,
            this.donateToolStripMenuItem,
            this.unityFourmsToolStripMenuItem,
            this.toolStripSeparator1,
            this.visitNackadooToolStripMenuItem,
            this.visitGrefugaStudiosToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuHelp
            // 
            this.helpToolStripMenuHelp.Name = "helpToolStripMenuHelp";
            this.helpToolStripMenuHelp.Size = new System.Drawing.Size(183, 22);
            this.helpToolStripMenuHelp.Text = "Help";
            this.helpToolStripMenuHelp.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // unityFourmsToolStripMenuItem
            // 
            this.unityFourmsToolStripMenuItem.Name = "unityFourmsToolStripMenuItem";
            this.unityFourmsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.unityFourmsToolStripMenuItem.Text = "Unity Fourms";
            this.unityFourmsToolStripMenuItem.Click += new System.EventHandler(this.unityFourmsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // visitNackadooToolStripMenuItem
            // 
            this.visitNackadooToolStripMenuItem.Name = "visitNackadooToolStripMenuItem";
            this.visitNackadooToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.visitNackadooToolStripMenuItem.Text = "Visit Nackadoo.com";
            this.visitNackadooToolStripMenuItem.Click += new System.EventHandler(this.visitNackadooToolStripMenuItem_Click);
            // 
            // visitGrefugaStudiosToolStripMenuItem
            // 
            this.visitGrefugaStudiosToolStripMenuItem.Name = "visitGrefugaStudiosToolStripMenuItem";
            this.visitGrefugaStudiosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.visitGrefugaStudiosToolStripMenuItem.Text = "Visit Grefuga Studios";
            this.visitGrefugaStudiosToolStripMenuItem.Click += new System.EventHandler(this.visitGrefugaStudiosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // richInfoBox
            // 
            this.richInfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.richInfoBox.Enabled = false;
            this.richInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richInfoBox.Location = new System.Drawing.Point(15, 285);
            this.richInfoBox.Name = "richInfoBox";
            this.richInfoBox.Size = new System.Drawing.Size(488, 118);
            this.richInfoBox.TabIndex = 4;
            this.richInfoBox.Text = "";
            // 
            // lblProjectsCount
            // 
            this.lblProjectsCount.AutoSize = true;
            this.lblProjectsCount.Location = new System.Drawing.Point(389, 24);
            this.lblProjectsCount.Name = "lblProjectsCount";
            this.lblProjectsCount.Size = new System.Drawing.Size(112, 13);
            this.lblProjectsCount.TabIndex = 5;
            this.lblProjectsCount.Text = "xxxxxxxxxxxxxxxxxxxxx";
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessages.Location = new System.Drawing.Point(12, 24);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(236, 13);
            this.lblMessages.TabIndex = 6;
            this.lblMessages.Text = "For best results - Make sure Unity is not running. ";
            this.lblMessages.Click += new System.EventHandler(this.lblMessages_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 47);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(254, 408);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 48);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 469);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lblProjectsCount);
            this.Controls.Add(this.richInfoBox);
            this.Controls.Add(this.btnDeleteSingleKey);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unity: Program Manager - Grefuga Studios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnDeleteSingleKey;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unityFourmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem visitGrefugaStudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitNackadooToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richInfoBox;
        private System.Windows.Forms.Label lblProjectsCount;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllProjectsToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuHelp;
    }
}

