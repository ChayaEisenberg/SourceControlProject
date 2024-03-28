using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class MyFile:Component,IFile
    {
        public MyFile(string name):base(name) 
        {
            
        }

        public override void Marge(Component other)
        {
            if(other.state.getStatus()!= "Ready To Marge")
            {
                Console.WriteLine("This file can't marged");
            }
            else
            {
                this = other;
            }


        }
    }
}
