using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class Repository
    {
        public string Name { get; set; }
        public Dictionary<string, Branch> branches = new Dictionary<string, Branch>() { { "main", new Branch("main") } };
        public Repository(string name)
        {
            this.Name = name;
            branches =  new(){ { "main", new Branch("main") } };
        }
        public Branch GetBranch(string name)
        {
            return branches[name];
        }
        
     
    }
}
