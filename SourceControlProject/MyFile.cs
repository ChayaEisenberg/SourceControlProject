using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject
{
    public class MyFile : Component
    {
        public string Content;
        public MyFile(string name, string content) : base(name)
        {
            this.Content = content;
        }

        public override Component Copy()
        {
            MyFile file = (MyFile)this.MemberwiseClone();
            file.SetState(this.state); 
            return file;
        }

        public override Component Marge(Component other)
        {
            Component myFile = base.Marge(other);
            if (myFile == other)
            {
                if (((MyFile)myFile).Content.Equals(((MyFile)other).Content))
                {
                    Console.WriteLine("The files are same");
                }
                else
                {
                    Console.WriteLine("The marge be succsesfully");
                }
            }
            return myFile;

        }
    }
}
