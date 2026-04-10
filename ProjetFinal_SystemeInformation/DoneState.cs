using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class DoneState: ITaskState
    {
        public string GetName()
        {
            return "Done";
        }
        public ITaskState MoveNext()
        {
            return this;
        }
        public ITaskState MovePrevious()
        {
            return new InProgressState();
        }
    }
}