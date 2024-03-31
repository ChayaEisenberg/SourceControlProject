using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class Branch:Component
    {
        public Dictionary<string, Component> components = new Dictionary<string, Component>();

        public Branch(string name):base(name)
        {
            
        }
        //return after finish
        public override Component Marge(Component other)
        {
            Component branch = base.Marge(other);
            if (branch == other)
            {
                foreach (var component in ((Branch)other).components)
                {
                    if (components.ContainsKey(component.Key))
                    {
                        this.components[component.Key].Marge(component.Value);
                    }
                    else
                    {
                        components.Add(component.Key, component.Value);
                    }
                }
            }
            return this;
        }
    
    }
}
