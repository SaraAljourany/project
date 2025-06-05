using System.Collections.Generic;
using System.Linq;
using MvcTodoApp.Models;
using NTierTodoApp.Models;

namespace NTierTodoApp.DataAccess
{

    public class TaskRepository
    {

        private List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "مهمة أولى", IsComplete = false },
            new TaskItem { Id = 2, Title = "مهمة ثانية", IsComplete = false }
        };

        public List<TaskItem> GetAll() => tasks;

        public void Add(TaskItem task)
        {
            tasks.Add(task);
        }

        public TaskItem GetById(int id)
        {
            return tasks.FirstOrDefault(t => t.Id == id);
        }


        public void Delete(int id)
        {
            //TODO:idابحث عن المهمة باستخدام 
           //TODO:اذا كانت المهمة موجودة احذفها من القائمة
        }

        public void Add(TaskItem newTask)
        {
            throw new NotImplementedException();
        }
    }
    
}
