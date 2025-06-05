using System.Collections.Generic;
using System.Linq;
using MvcTodoApp.Models;


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
#pragma warning disable CS8603 // Possible null reference return.
            return tasks.FirstOrDefault(t => t.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }


        public void Delete(int id)
        {
            //TODO:idابحث عن المهمة باستخدام 
            //TODO:اذا كانت المهمة موجودة احذفها من القائمة
        }


    }
}
