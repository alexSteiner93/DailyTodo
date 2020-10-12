using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyToDo.Data
{
    public class ToDo
    {

        public int Todo_id { get; set; }

        public string Description { get; set; }

      
        public int Priority { get; set; }

        public DateTime Creationdate {get; set;}

        public bool Done { get; set; }

        public ToDo(string Description, int Priority)
        {
            this.Description = Description;
            this.Priority = Priority;
            this.Done = Done;
            this.Creationdate = DateTime.Now;
            this.Todo_id = 5;
            this.Done = false;
        }
    }
}
