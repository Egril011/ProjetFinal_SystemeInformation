using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class DoneState: ITaskState
    {
        private static ITaskState _instance = new DoneState();
        public static ITaskState Instance => _instance;

        public string GetName()
        {
            return "Done";
        }
        public void MoveNext(Task task)
        {
            task.SetState(this);
        }
        public void MovePrevious(Task task)
        {
            task.SetState(InProgressState.Instance);
        }
    }
}