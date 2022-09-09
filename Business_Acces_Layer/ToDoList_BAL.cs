using Data_Transfer_Objects;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acces_Layer.Data;

namespace Business_Acces_Layer
{
    public class ToDoList_BAL
    {
        private Data_Acces_Layer.ToDoList_DAL _ListDAL;
        public ToDoList_BAL(Data_Acces_Layer.ToDoList_DAL toDoList_DAL)
        {
            _ListDAL = toDoList_DAL ;
        }
        public TaskItem Add(TaskItem taskItem)
        {
            taskItem = _ListDAL.AddItem(taskItem);
            return taskItem;
        }

    }
}
