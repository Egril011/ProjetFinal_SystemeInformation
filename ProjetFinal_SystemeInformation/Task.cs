using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class Task
    {
        private int _id;
        private int _projectId;
        private int _createdByUserId;
        private string _title;
        private string _description;
        private TaskPriority _priority;
        private TaskStatus _status;
        private DateTime _dueDate;
        private DateTime _createdAt;

        public Task(int projectId, int createdByUserId, string title, string description, TaskPriority priority,
            TaskStatus status, DateTime dueDate)
        {
            _projectId = projectId;
            _createdByUserId = createdByUserId;
            _title = title;
            _description = description;
            _priority = priority;
            _status = status;
            _dueDate = dueDate;
            _createdAt = DateTime.Now;
        }

        public int Id => _id;
        public int ProjectId => _projectId;
        public int CreatedByUserId => _createdByUserId;
        public string Title => _title;
        public string Description => _description;
        public TaskPriority Priority => _priority;
        public TaskStatus Status => _status;
        public DateTime DueDate => _dueDate;
        public DateTime CreatedAt => _createdAt;
    }
}