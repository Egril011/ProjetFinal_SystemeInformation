using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class ToDoState: ITaskState
    {
        private static ToDoState _instance = new ToDoState();
        public static ToDoState Instance => _instance;

        public string GetName()
        {
            return "To Do";
        }

        public void MoveNext(Task task)
        {
           task.SetState(InProgressState.Instance);
        }

        public void MovePrevious(Task task)
        {
            task?.SetState(this);
        }
    }
}