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
        public IState state { get; private set; }
        public string Name { get; set; }
        public Component(string name)
        {
            this.Name = name;
            state = Draft.GetInstanse();
        }
        public void SetState(IState state)
        {
            this.state = state;
        }
        public abstract void Marge(Component other);
        

    }
}
