using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityClearProjects
{
    public partial class frmUndelete : Form
    {
        //public Projects ProjectList
        //{
        //    get { return frmMain.RegProjectList; }
        //}
        public Projects[] localFromMain;
        public frmUndelete(Projects[] FM)
        {
            localFromMain = FM;
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

            // Setup Tool Tips
            ToolTip toolTipInfo = new ToolTip();

            //Setup Delays of Tips
            toolTipInfo.AutoPopDelay = 5000;
            toolTipInfo.InitialDelay = 1000;
            toolTipInfo.ReshowDelay = 500;

            toolTipInfo.SetToolTip(this.btnUnRemove, "Adds selected project back to list");

            // establish the screen
            lblMessage.MaximumSize = new Size(340, 0);
            lblMessage.AutoSize = true;

            //string blah = localFromMain[0].ProjectLocation.ToString();

            // Get anything that has been deleted
            FindDelted();

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Reinstatekey(String Location)
        {
            foreach (Projects valuecount in localFromMain)
            {
                if (valuecount.ProjectLocation == Location.ToString())
                {
                    if (valuecount.Deleted == true)
                    {
                        // Add back to list
                        lstUnDelete.Items.Add(valuecount.ProjectLocation.ToString());
                        break;
                    }
                }
            }

        }

        public void FindDelted()
        {
            foreach (Projects valuecount in localFromMain)
            {
                if (valuecount != null)
                {
                    if (valuecount.Deleted == true)
                    {
                        // Add back to list
                        lstUnDelete.Items.Add(valuecount.ProjectLocation.ToString());

                    }
                }
            }
        }
    }
}
