using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyToDo.Data;
using Microsoft.AspNetCore.Mvc;

namespace DailyToDo.Models
{
    public class ToDoViewModel
    {
        public List<ToDo> todos { get; set; }
    }
}
