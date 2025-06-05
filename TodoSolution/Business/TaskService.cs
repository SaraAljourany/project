using MvcTodoApp.Models;
using NTierTodoApp.DataAccess;

namespace NTierTodoApp.Business
{
    /// <summary>
    /// طبقة المنطق التجاري لإدارة المهام.
    /// </summary>
    public class TaskService
    {
        private readonly TaskRepository repository;

        public TaskService(TaskRepository repo)
        {
            repository = repo;
        }

        public List<TaskItem> GetTasks() => repository.GetAll();

        public void AddTask(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return;

            var tasks = repository.GetAll();
            int newId = tasks.Any() ? tasks.Max(t => t.Id) + 1 : 1;
            var newTask = new TaskItem { Id = newId, Title = title, IsComplete = false };
            repository.Add(newTask);
        }

        public void CompleteTask(int id)
        {
            var task = repository.GetById(id);
            if (task != null)
                task.IsComplete = true;
        }

      //TODO:تنفيذ دالة حذف مهمة
        public void DeleteTask(int id)
        {
        //:TODO:DataAccess استدعاء دالة حذف في طبقة
       }
    }
}
