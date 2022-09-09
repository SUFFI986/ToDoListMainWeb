using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class ToDoListStatusPriorityViewModel
    {
        public List<TaskItem>? ToDoLists { get; set; }
        public SelectList? Statuses { get; set; }
        public string? ToDoListStatus { get; set; }
        public SelectList? Priorities { get; set; }
        public string? ToDoListPriority { get; set; }
        public string? SearchString { get; set; }
    }
}
