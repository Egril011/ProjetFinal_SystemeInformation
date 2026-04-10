using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal interface ITaskState
    {
        string GetName();
        ITaskState MoveNext();
        ITaskState MovePrevious();
    }
}
