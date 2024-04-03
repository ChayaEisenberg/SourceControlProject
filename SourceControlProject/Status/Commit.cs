using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Status;

internal class Commit : IState
{

    private static Commit _instanse;
    public static Commit GetInstanse()
    {
        _instanse ??= new Commit();
        return _instanse;
    }
    public void changeStatus(Component component)
    {
        if (Admin.confirmReview(component))
        {
            component.SetState(UnderReview.GetInstanse());
        }
    }
    private Commit()
    {
        
    }
    public string getStatus()
    {
        return "Commit";
    }
}
