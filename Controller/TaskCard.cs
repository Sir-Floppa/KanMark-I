using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class TaskCard
    {
        public string taskName;
        public string taskDescription;
        public string taskStatus;

        public TaskCard(string taskName, string taskDescription)
        {
            this.taskName = taskName;
            this.taskDescription = taskDescription;
            this.taskStatus = "To do";
        }

        public TaskCard(string taskName, string taskDescription, string taskStatus)
        {
            this.taskName = taskName;
            this.taskDescription = taskDescription;
            this.taskStatus = taskStatus;
        }
    }
}
