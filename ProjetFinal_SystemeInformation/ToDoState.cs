using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ToDoState: ITaskState
    {
        public string GetName()
        {
            return "To Do";
        }

        public ITaskState MoveNext()
        {
            return new InProgressState();
        }

        public ITaskState MovePrevious()
        {
            return this;
        }
    }
}