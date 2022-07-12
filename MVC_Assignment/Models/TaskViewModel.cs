using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class TaskViewModel
    {
        public List<string> AssigneeNameList { get; set; }

        public List<Task> TasksList { get; set; }

        public string SelectedAssignee { get; set; }
    }
}
