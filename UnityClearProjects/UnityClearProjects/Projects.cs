using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnityClearProjects
{
   
    public class Projects
    {
        public void ProjectsData(string projectLocation, string projectName,  string projectOriginalReg, byte[] projectBytes, object projectRegObj, bool deleted)
        {
            this.ProjectLocation = projectLocation;
            this.ProjectName = projectName; 
            this.ProjectOriginalReg = projectOriginalReg;
            this.ProjectBytes = projectBytes;
            this.ProjectObject = projectOriginalReg;
            this.Deleted = deleted;
        }

        public string ProjectLocation { set; get; }
        public string ProjectName { set; get; }
        public string ProjectOriginalReg { set; get; }
        public byte[] ProjectBytes{set;get;}
        public object ProjectObject { set; get; }
        public bool Deleted { set; get; }
    }
}
