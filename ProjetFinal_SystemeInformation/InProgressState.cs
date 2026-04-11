using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class InProgressState: ITaskState
    {
        private static InProgressState _instance = new InProgressState();
        public static InProgressState Instance => _instance;

        public string GetName()
        {
            return "In Progress";
        }
        public void MoveNext(Task task)
        {
            task.SetState(DoneState.Instance);
        }
        public void MovePrevious(Task task)
        {
            task.SetState(ToDoState.Instance);
        }
    }
}
