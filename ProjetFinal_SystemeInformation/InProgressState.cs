using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class InProgressState: ITaskState
    {
        public string GetName()
        {
            return "In Progress";
        }
        public ITaskState MoveNext()
        {
            return new DoneState();
        }
        public ITaskState MovePrevious()
        {
            return new ToDoState();
        }

    }
}
