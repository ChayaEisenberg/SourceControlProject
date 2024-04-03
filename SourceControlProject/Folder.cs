using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class Folder : Component, IFile
    {
        public Dictionary<string, Component> components = new Dictionary<string, Component>();

        public Folder(string name):base(name) 
        {
            components = new Dictionary<string, Component>();
        }

        public override Component Copy()
        {
            Folder folder = new(this.Name);
            folder.SetState(this.state);
            if (components != null)
            {
                foreach (Component item in this.components.Values)
                {
                    item.Copy();
                }
            }
            return folder;
        }

        public override Component Marge(Component other)
        {
            Component folder = base.Marge(other);
            if (folder == other)
            {
                foreach (var component in ((Folder)other).components)
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
