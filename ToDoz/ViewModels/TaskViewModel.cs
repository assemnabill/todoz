using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ToDoz.ViewModels
{
    public class TaskViewModel
    {
        
        // Statues {Pending, In Progress, Done}
        public string Status { get; set; }

        // Task Name
        public string Name { get; set; }

        // Task Priority {0, 1, 2}
        public int Prio { get; set; }

        // Task Description
        public string Description { get; set; }

        // shows user that issued the Task
        public string Issuer { get; set; }

        // shows user working on the Task
        public string Handler { get; set; }

        public DateTime DateTime { get; set; }


    }
}
