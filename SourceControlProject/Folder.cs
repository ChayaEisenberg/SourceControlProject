using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    internal class Folder : Component, IFile
    {
        public Dictionary<string, IFile> components = new Dictionary<string, IFile>();

        public string Name { get; set; }
    }
}
