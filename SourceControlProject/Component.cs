using SourceControlProject.Memento;
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
        public Component Add()
        {
            if (state.getStatus() == "Draft")
            {
                state.changeStatus(this);
               

            }
            else
            {
                Console.WriteLine("cannot add - not draft");
            }
            return this;
        }
        public virtual Component Marge(Component other)
        {
            Console.WriteLine(other.state.getStatus());
            if (other.state.getStatus() != "Ready To Marge")
            {

                Console.WriteLine("This file can't marged");
                return this;
            }
            return other;
        }
        public virtual void commit()
        {
            if (state.getStatus() != "staged")
            {
                Console.WriteLine("This file can't ready to commit");
            }
            else
            {
                state.changeStatus(this);
                state.changeStatus(this);
            }

        }

        public IMemento Save()
        {
            return new ConcreteMemento(state, DateTime.Now);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this.state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {state.getStatus()}");
        }

        public Component RequestAReview()
        {

            if (state.getStatus() != "UnderReview")
            {
                Console.WriteLine("cant review yet");
            }
            else
            {
                state.changeStatus(this);
            }
            return this;
        }
        public abstract Component Copy();



    }
}
