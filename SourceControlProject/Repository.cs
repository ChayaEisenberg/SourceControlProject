using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class Repository
    {
        public Dictionary<string, Branch> branches = new Dictionary<string, Branch>() { { "main", new Branch() } };
        public Branch GetBranch(string name)
        {
            return branches[name];
        }
        
     
    }
}
