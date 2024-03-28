using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Status;

public class Merged : IState
{
    private static Merged _instanse;
    public static Merged GetInstanse()
    {
        _instanse ??= new Merged();
        return _instanse;
    }
    public void changeStatus(Component component)
    {
        Console.WriteLine("marge complited");
    }
    private Merged()
    {
        
    }

    public string getStatus()
    {
        return "Marged";
    }
}
