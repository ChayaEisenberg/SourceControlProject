using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Status;

public class UnderReview : IState
{
    private static UnderReview _instanse;
    public static UnderReview GetInstanse()
    {
        _instanse ??= new UnderReview();
        return _instanse;
    }
    public void changeStatus(Component component)
    {
        component.SetState(ReadyToMerge.GetInstanse());
    }
    public string getStatus()
    {
        throw new NotImplementedException();
    }
}
