using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using ToDoz.Models;

namespace ToDoz.ViewModels
{
    public class ProjectViewModel
    {

        public Image ProjectImage { get; set; }

        // Project Name
        public string ProjectName { get; set; }

        // Project Date
        public DateTime Created { get; set; }

        // Project Leader Name
        public virtual ApplicationUser ProjectLeader { get; set; }

        // Sub Process of the Project
        public SubProcess[] SubProcesses { get; set; }




    }
}
