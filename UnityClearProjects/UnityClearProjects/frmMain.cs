using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;


namespace UnityClearProjects
{
    
    public partial class frmMain : Form
    {
        public string currSubKey2;

        public Projects[] RegProjectList = new Projects[75];
        int Projectcounter = 0; 

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var registrykeys = GetRegistrySubKeys();

            // Build the list
            GetProjectList();
            for (int i = 0; i < Projectcounter; i++)
            {
               lstProjects.Items.Add( RegProjectList[i].ProjectLocation.ToString());
            }

            // Select first list item (default selection)
            if (this.lstProjects.Items.Count > 0)
                this.lstProjects.SelectedIndex = 0;
            else
            {
                richInfoBox.Text = "No Local Projects found." + "\nYou will need to open or create a new project in Unity.";
            }

            lblMessages.Text = RandomMessage();

            // Setup Tool Tips
            ToolTip toolTipInfo = new ToolTip();

            //Setup Delays of Tips
            toolTipInfo.AutoPopDelay = 5000;
            toolTipInfo.InitialDelay = 1000;
            toolTipInfo.ReshowDelay = 500;

            toolTipInfo.SetToolTip(this.btnRemoveAll, "Remove All projects from list");
            toolTipInfo.SetToolTip(this.btnOpenFolder, "Open the project fodler location");
            toolTipInfo.SetToolTip(this.btnDeleteSingleKey, "Remove the selected project from list");
        }

        public void GetProjectList()
        {
            const string REGISTRY_ROOT = @"SOFTWARE\Unity Technologies\Unity Editor 5.x\";
            using (RegistryKey rootKey = Registry.CurrentUser.OpenSubKey(REGISTRY_ROOT))
            {
                if (rootKey != null)
                {
                    string[] valueNames = rootKey.GetValueNames();
                    foreach (string currSubKey in valueNames)
                    {
                        if (currSubKey.Contains("RecentlyUsedProjectPaths"))
                        {
                            object value = rootKey.GetValue(currSubKey);
                            byte[] tempBytes = (byte[])value;
                            string varstring = System.Text.Encoding.Default.GetString(tempBytes);
                            varstring = varstring.Replace("\0", "").Trim();

                            //Store them away
                            RegProjectList[Projectcounter] = new Projects();
                            RegProjectList[Projectcounter].ProjectBytes = tempBytes;
                            RegProjectList[Projectcounter].ProjectLocation = varstring;
                            RegProjectList[Projectcounter].ProjectOriginalReg = currSubKey;
                            RegProjectList[Projectcounter].ProjectObject = value;
                            RegProjectList[Projectcounter].Deleted = false;
                            Projectcounter++;
                        }
                    }
                }
            }
            // Update the Label Count
            UpdateProjectCount();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFolder();
        }

        public string RandomMessage()
        {
            string[] Messages = new string[10];
            Random rnd = new Random();
            string result;
            int msgnum = rnd.Next(0, 8);

            Messages[0] = "For best results - Make sure Unity is not running.";
            Messages[1] = "If you like this project please considering donating (in the HELP menu :))";
            Messages[2] = "Play awesome free games at www.nackadoo.com";
            Messages[3] = "For more tools check out our home page at www.grefugastudios.com";
            Messages[4] = "Consider donating for more tools like this for free (in the HELP menu :))";
            Messages[5] = "Thank you so much for using our product";
            Messages[6] = "Good luck on your Unity Project!!!";
            Messages[7] = "For best results - Make sure Unity is not running.";

            try
            {
                result = Messages[msgnum];
            }
            catch
            {
                result = Messages[0];
            }

            return result;

        }

        public void UpdateProjectCount()
        {
            lblProjectsCount.Text = "Projects found: " + Projectcounter.ToString();
        }

        public void RemoveProjectCount()
        {
            // Lower the count

            Projectcounter = Projectcounter - 1;

            // Select first list item (default selection)
            if (this.lstProjects.Items.Count > 0)
                this.lstProjects.SelectedIndex = 0;
            else
            {
                richInfoBox.Text = "No Local Projects found." + "\nYou will need to open or create a new project in Unity.";
            }
        }

        public void DeleteKey()
        {
            int selectedIndex;
            byte[] RegKeyByte; // Byte Version
            //object currSubKey; // Key Value //rootKey.GetValue(currSubKey);
            string currSubKey; // Key Value //rootKey.GetValue(currSubKey);
            string varstring;  // Hold the readable
            string captureList; // Hold item from list
            bool deletedProject; 

            selectedIndex = lstProjects.SelectedIndex; // Get the selected item to remove it from the list


            if (selectedIndex != -1)
            {

                foreach (Projects valuecount in RegProjectList)
                {
                    if (lstProjects.SelectedItem.ToString() == valuecount.ProjectLocation.ToString())
                    {
                        currSubKey = valuecount.ProjectOriginalReg;
                        currSubKey2 = currSubKey;
                        varstring = valuecount.ProjectLocation;
                        RegKeyByte = valuecount.ProjectBytes;
                        valuecount.Deleted = true; //Set this item as deleted
                        deletedProject = valuecount.Deleted;
                        captureList = lstProjects.SelectedItem.ToString();
                        break;
                    }
                }

                var results = MessageBox.Show(string.Format("You are about to remove '{0}' from your project list in Unity.\nDon't worry this will not remove the project from your system or repository. It will only be removed from your list.\n\nDo you wish to remove the file from your list?", lstProjects.SelectedItem.ToString()), "Delete Project Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (results == DialogResult.Yes)
                {
                    lstProjects.Items.Remove(lstProjects.SelectedItem);

                    lstProjects.Refresh();
                   try
                    {
                        // Try to delete the reg value
                        const string REGISTRY_ROOT = @"SOFTWARE\Unity Technologies\Unity Editor 5.x\";
                        RegistryKey Proj = Registry.CurrentUser.OpenSubKey(REGISTRY_ROOT, true);
                        Proj.DeleteValue(currSubKey2);
                        Proj.Close();
                    }
                    catch (Exception e)
                    {
                        //Soomething bad happened
                        MessageBox.Show(e.ToString());
                       
                    }
                    RemoveProjectCount();
                    UpdateProjectCount();
                    ///FindDelted(); //Coming Soon
                }
            }
            else
            {
                MessageBox.Show("You do not have anything selected to Remove.", "Unity: Project Manager", MessageBoxButtons.OK);
            }
        }


        public void DeleteAllKey()
        {
                           
                byte[] RegKeyByte; // Byte Version
                                   //object currSubKey; // Key Value //rootKey.GetValue(currSubKey);
                string currSubKey; // Key Value //rootKey.GetValue(currSubKey);
                string varstring;  // Hold the readable
                //string captureList; // Hold item from list
                bool deletedProject;

            //selectedIndex = lstProjects.SelectedIndex; // Get the selected item to remove it from the list


            if (this.lstProjects.Items.Count > 0)
            {
                var results = MessageBox.Show(string.Format("You are about to remove all projects in your Unity Project List. \nDon't worry this will not remove the projects from your system or repository. They will only be removed from your list.\n\nDo you wish to remove the files from your list?"), "Delete Project Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (results == DialogResult.Yes)
                {

                    foreach (Projects valuecount in RegProjectList)
                    {

                        if (valuecount != null)
                        {
                            if (valuecount.Deleted == false)
                            {
                                currSubKey = valuecount.ProjectOriginalReg;
                                currSubKey2 = currSubKey;
                                varstring = valuecount.ProjectLocation;
                                RegKeyByte = valuecount.ProjectBytes;
                                valuecount.Deleted = true; //Set this item as deleted
                                deletedProject = valuecount.Deleted;





                                // Find list item
                                int curIndex = lstProjects.Items.IndexOf(varstring);

                                //captureList = lstProjects.SelectedItem.ToString();
                                lstProjects.Items.Remove(lstProjects.Items[curIndex].ToString());

                                lstProjects.Refresh();
                                try
                                {
                                    // Try to delete the reg value
                                    const string REGISTRY_ROOT = @"SOFTWARE\Unity Technologies\Unity Editor 5.x\";
                                    RegistryKey Proj = Registry.CurrentUser.OpenSubKey(REGISTRY_ROOT, true);
                                    Proj.DeleteValue(currSubKey2);
                                    Proj.Close();
                                }
                                catch (Exception e)
                                {
                                    //Soomething bad happened
                                    MessageBox.Show(e.ToString());

                                }
                                RemoveProjectCount();
                                UpdateProjectCount();
                            }
                            ///FindDelted(); //Coming Soon
                            ///
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You do not have anything available to Remove.", "Unity: Project Manager", MessageBoxButtons.OK);
            }

        }

        public void OpenFolder()
        {
            // Open Path
            try
            {
                System.Diagnostics.Process.Start(@lstProjects.SelectedItem.ToString());
            }
            catch
            {
                // Do nothing -- this should not happen...I guess. It isn't bad. Just mean nothing 
                // was selected
                if (lstProjects.SelectedIndex < 0)
                {
                    MessageBox.Show("You do not have a project selected to Open.", "Unity: Project Manager", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("The selected folder '" + @lstProjects.SelectedItem.ToString() + "' may have been removed.", "Unity: Project Manager", MessageBoxButtons.OK);
                }
               
            }
        }

        public void FindDelted()
        {
            foreach (Projects valuecount in RegProjectList)
            {
                if (valuecount != null)
                {
                    if (valuecount.Deleted == true)
                    {
                     // Coming soon
                    }
                }
            }
        }

        private void lstProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

            var myFile = "NA";
            string ProjAccessTime;
            string fileCount;

            //Get FileCount
            try
            {
                fileCount = (from file in Directory.EnumerateFiles(lstProjects.SelectedItem.ToString(), "*.*", SearchOption.AllDirectories)
                             select file).Count().ToString();
            }
            catch
            {
                fileCount = "NA";
            }

            //Get last access

            try
            {

                var directory = new DirectoryInfo(lstProjects.SelectedItem.ToString());

                myFile = (from f in directory.GetFiles()
                          orderby f.LastWriteTime descending
                          select f).First().ToString();
                          //*/
            

                ProjAccessTime = File.GetLastWriteTime(lstProjects.SelectedItem.ToString() + "\\" + myFile).ToString();
            }
            catch
            {

                myFile = "NA";
                ProjAccessTime = "NA";
            }

            try
            {
                //Write out stats
                richInfoBox.Text = "Project Location: " + lstProjects.SelectedItem.ToString() + "\n";
                richInfoBox.Text = richInfoBox.Text + "File Count: " + fileCount + "\n";
                richInfoBox.Text = richInfoBox.Text + "Last File on Main Rooot Accessed: " + myFile.ToString() + "\n";
                richInfoBox.Text = richInfoBox.Text + "Last File on Main Root Access Time: " + ProjAccessTime.ToString() + "\n";
            }
            catch
            {
                richInfoBox.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteKey();

        }

        private void unityFourmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.unity3d.com/");
        }

        private void visitNackadooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://nackadoo.com/");
        }

        private void visitGrefugaStudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.grefugastudios.com/");
        }
    
        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.grefugastudios.com/donate/");
        }

        private void lblMessages_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aBox = new AboutBox();
            aBox.ShowDialog();
        }

  

        private void deleteCurrentKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteKey();
        }

      


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFolder();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            DeleteAllKey();
        }

        private void removeAllProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllKey();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.grefugastudios.com/Download/UnityProjectManager/");
        }
    }


}
