using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class Branch:Component
    {
        public Dictionary<string, IFile> components = new Dictionary<string, IFile>();

        public Branch(string name):base (name)
        {
            
        }
        public override void Marge(Component other)
        {
          foreach (var component in components)
            {

            }
        }
    }
}
