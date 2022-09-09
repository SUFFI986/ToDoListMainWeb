using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public interface ITaskItemRepository
    {
        TaskItem GetTaskItem(int id);
        IEnumerable<TaskItem> GetTaskItems();
        TaskItem Add(TaskItem taskItem);
        TaskItem Update(TaskItem taskChanges);
        TaskItem Delete(int id);
    }
}
