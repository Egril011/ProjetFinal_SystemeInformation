using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class Task
    {
        public int Id { get; private set; }
        public int ProjectId { get; private set; }
        public int CreatedByUserId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public TaskPriority Priority { get; private set; }
        public TaskStatus Status { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private ITaskState _state;
        public ITaskState State => _state;

        public Task(int projectId, int createdByUserId, string title, string description,
            TaskPriority priority, TaskStatus status, DateTime dueDate)
        {
            ProjectId = projectId;
            CreatedByUserId = createdByUserId;
            Title = title;
            Description = description;
            Priority = priority;
            Status = status;
            _state = ConvertStatusToState(status);
            DueDate = dueDate;
            CreatedAt = DateTime.Now;
        }

        public Task(int id, int projectId, int createdByUserId, string title, string description,
            TaskPriority priority, TaskStatus status, DateTime dueDate, DateTime createdAt)
        {
            Id = id;
            ProjectId = projectId;
            CreatedByUserId = createdByUserId;
            Title = title;
            Description = description;
            Priority = priority;
            Status = status;
            _state = ConvertStatusToState(status);
            DueDate = dueDate;
            CreatedAt = createdAt;
        }

        public void SetState(ITaskState newState)
        {
            _state = newState;
            Status = ConvertStateToStatus(newState);
        }

        public TaskStatus ConvertStateToStatus(ITaskState taskState)
        {
            return taskState switch
            {
                ToDoState => TaskStatus.ToDo,
                InProgressState => TaskStatus.InProgress,
                DoneState => TaskStatus.Done,
                _ => throw new InvalidOperationException("Invalid task state")
            };
        }

        public ITaskState ConvertStatusToState(TaskStatus status)
        {
            return status switch
            {
                TaskStatus.ToDo => new ToDoState(),
                TaskStatus.InProgress => new InProgressState(),
                TaskStatus.Done => new DoneState(),
                _ => throw new InvalidOperationException("Invalid task status")
            };
        }

        public void MoveNext()
        {
            _state.MoveNext(this);
        }

        public void MovePrevious()
        {
            _state.MovePrevious(this);
        }

        public override string ToString()
        {
            return $"Task: {Title}";
        }
    }
}