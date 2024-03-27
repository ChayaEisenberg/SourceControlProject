using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Status;

public class ReadyToMerge : IState
{
    private static ReadyToMerge _instanse;
    public static ReadyToMerge GetInstanse()
    {
        _instanse ??= new ReadyToMerge();
        return _instanse;
    }
    public void changeStatus(Component component)
    {
        component.SetState(Merged.GetInstanse());
    }

    public string getStatus()
    {
        return "ReadyToMarge";
    }
}
