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
    }
}
