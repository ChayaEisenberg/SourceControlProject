using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class Folder : Component, IFile
    {
        public Dictionary<string, IFile> components = new Dictionary<string, IFile>();

        public Folder(string name):base(name) 
        {
            components = new Dictionary<string, IFile>();
        }
     
        public override void Marge(Component other)
        {
            
        }
    }
}
