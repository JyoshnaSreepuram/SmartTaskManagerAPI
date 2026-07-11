using SmartTaskManagerAPI.Models;

namespace SmartTaskManagerAPI.Services
{
    public class TaskService
    {

        private static List<TaskItem> tasks = new List<TaskItem>()
        {
            new TaskItem
            {
                TaskId = 1,
                Title = "Learn ASP.NET Core",
                Description = "Build Web API project",
                Status = "In Progress",
                Priority = "High",
                CreatedDate = DateTime.Now
            }
        };


        public List<TaskItem> GetTasks()
        {
            return tasks;
        }


        public TaskItem GetTaskById(int id)
        {
            return tasks.FirstOrDefault(x => x.TaskId == id);
        }


        public TaskItem AddTask(TaskItem task)
        {
            task.TaskId = tasks.Count + 1;
            task.CreatedDate = DateTime.Now;

            tasks.Add(task);

            return task;
        }


        public bool DeleteTask(int id)
        {
            var task = GetTaskById(id);

            if(task == null)
                return false;

            tasks.Remove(task);

            return true;
        }


        public TaskItem UpdateTask(int id, TaskItem updatedTask)
        {
            var task = GetTaskById(id);

            if(task == null)
                return null;


            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.Status = updatedTask.Status;
            task.Priority = updatedTask.Priority;


            return task;
        }

    }
}
