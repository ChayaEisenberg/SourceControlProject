using SourceControlProject.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public abstract class Component
    {
        IState state = new Draft();
        public string Name;
        public void SetState(IState state)
        {
            this.state = state;
        }
        

    }
}
