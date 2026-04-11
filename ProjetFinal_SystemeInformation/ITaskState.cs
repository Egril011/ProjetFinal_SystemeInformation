using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public interface ITaskState
    {
        string GetName();
        void MoveNext(Task task);
        void MovePrevious(Task task);
    }
}
