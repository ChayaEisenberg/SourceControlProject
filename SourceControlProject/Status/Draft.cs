using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Status;

public class Draft : IState
{
    private static Draft _instanse;
    public static Draft GetInstanse()
    {
        _instanse ??= new Draft();
        return _instanse;        
    }
    public void changeStatus(Component component)
    {
        component.SetState(Staged.GetInstanse());
    }

    public string getStatus()
    {
        return "Draft";       
    }
}
