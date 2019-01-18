namespace UnityClearProjects
{
    partial class frmUndelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUndelete));
            this.lstUnDelete = new System.Windows.Forms.ListBox();
            this.btnUnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUnDelete
            // 
            this.lstUnDelete.FormattingEnabled = true;
            this.lstUnDelete.Location = new System.Drawing.Point(12, 47);
            this.lstUnDelete.Name = "lstUnDelete";
            this.lstUnDelete.Size = new System.Drawing.Size(382, 199);
            this.lstUnDelete.TabIndex = 0;
            // 
            // btnUnRemove
            // 
            this.btnUnRemove.Location = new System.Drawing.Point(12, 252);
            this.btnUnRemove.Name = "btnUnRemove";
            this.btnUnRemove.Size = new System.Drawing.Size(75, 34);
            this.btnUnRemove.TabIndex = 1;
            this.btnUnRemove.Text = "UnRemove";
            this.btnUnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(319, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(465, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "This list is only available during this session. Once the program is closed, this" +
    " list will be removed.  ";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // frmUndelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 298);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUnRemove);
            this.Controls.Add(this.lstUnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUndelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UnRemove";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnDelete;
        private System.Windows.Forms.Button btnUnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMessage;
    }
}