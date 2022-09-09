using Data_Acces_Layer.Data;
using Data_Transfer_Objects;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces_Layer
{
    public class ToDoList_DAL
    {
        private readonly TaskItemContextClass context;
        private readonly ITaskItemRepository _taskItemRepository;
        public ToDoList_DAL(ITaskItemRepository taskItemRepository,
                            TaskItemContextClass context)
        {
            _taskItemRepository = taskItemRepository;
            this.context = context;
        }
        public TaskItem AddItem(TaskItem task)
        {
            try
            {
                var model = _taskItemRepository.Add(task);
                return model;
            }
            catch
            {
                throw;
            }
        }
    }
}
