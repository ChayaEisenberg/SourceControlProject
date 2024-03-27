using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Status;

public interface IState
{
    public void changeStatus(Component component);
    public string getStatus();

}
