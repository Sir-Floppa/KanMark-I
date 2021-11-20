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
        public int posX;
        public int posY;

        public TaskCard(string taskName, string taskDescription, string taskStatus, int PosX, int PosY)
        {
            this.taskName=taskName;
            this.taskDescription=taskDescription;  
            this.taskStatus=taskStatus;
            this.posX = PosX;
            this.posY = PosY;
        }
    }
}
