using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class TaskFacade
    {
        private TaskService _taskService;

        public TaskFacade(TaskService taskService)
        {
            _taskService = taskService;
        }

        public bool CreateTask(Task task)
        {
            return _taskService.CreateTask(task);
        }

        public List<Task> GetAllProjectTasks(int projectId)
        {
            return _taskService.GetAllProjectTasks(projectId);
        }

        public void MoveTask(Task task)
        {
            _taskService.MoveTask(task);
        } 

        public void MoveTaskBack(Task task)
        {
            _taskService.MoveTaskBack(task);
        }
    }
}