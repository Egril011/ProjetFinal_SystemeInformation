using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class TaskService
    {
        private TaskRepository _taskRepository;

        public TaskService(TaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public bool CreateTask(Task task)
        {
            if (task == null)
                return false;

            _taskRepository.CreateTask(task);
            return true;
        }

        public List<Task> GetAllProjectTasks(int projectId)
        {
            return _taskRepository.GetAllProjectTasks(projectId);
        }

        public void MoveTask(Task task)
        {
            task.MoveNext();
            _taskRepository.UpdateStatus(task);
        }

        public void MoveTaskBack(Task task)
        {
            task.MovePrevious();
            _taskRepository.UpdateStatus(task);
        }
    }
}