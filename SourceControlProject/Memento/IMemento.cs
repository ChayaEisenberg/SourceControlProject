using SourceControlProject.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Memento
{
    public interface IMemento
    {
        string GetName();

        IState GetState();

        DateTime GetDate();
    }
}
