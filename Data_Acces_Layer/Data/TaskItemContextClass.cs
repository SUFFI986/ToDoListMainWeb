using Data_Transfer_Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces_Layer.Data
{
    public class TaskItemContextClass:DbContext
    {
        public TaskItemContextClass(DbContextOptions<TaskItemContextClass> options)
            :base(options)  
        {
                
        }
        public DbSet<TaskItem> taskItems { get; set;}
    }
}
