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
        public virtual Component Marge(Component other)
        {
            if (other.state.getStatus() != "Ready To Marge")
            {
                Console.WriteLine("This file can't marged");
                return this;
            }
           return other;         
        }
        public virtual void commit()
        {
            if (state.getStatus() != "Staged")
            {
                Console.WriteLine("This file can't ready to commit");               
            }
            state.changeStatus(this);
            
        }


        //public Stack <IMemento>
        

    }
}
