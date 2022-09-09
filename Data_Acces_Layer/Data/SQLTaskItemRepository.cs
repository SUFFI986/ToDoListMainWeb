using Data_Transfer_Objects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces_Layer.Data
{
    public class SQLTaskItemRepository:ITaskItemRepository
    {
        private readonly TaskItemContextClass context;
        private readonly ILogger<SQLTaskItemRepository> logger;

        public SQLTaskItemRepository(TaskItemContextClass context,
                                    ILogger<SQLTaskItemRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public TaskItem Add(TaskItem taskItem)
        {
            context.taskItems.Add(taskItem);
            context.SaveChanges();
            return taskItem;
        }
        public TaskItem Delete(int id)
        {
            TaskItem taskItem = context.taskItems.Find(id);
            if (taskItem != null)
            {
                context.taskItems.Remove(taskItem);
                context.SaveChanges();
            }
            return taskItem;
        }
        public IEnumerable<TaskItem> GetTaskItems()
        {
            return context.taskItems;
        }
        public TaskItem GetTaskItem(int Id)
        {

            return context.taskItems.Find(Id);
        }

        public TaskItem Update(TaskItem taskChanges)
        {
            var employee = context.taskItems.Attach(taskChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return taskChanges;
        }
    }
}
