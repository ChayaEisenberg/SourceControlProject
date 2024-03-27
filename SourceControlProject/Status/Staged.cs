﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlProject.Status;

public class Staged : IState
{
    private static Staged _instanse;
    public static Staged GetInstanse()
    {
        _instanse ??= new Commit();
        return _instanse;
    }
    public void changeStatus(Component component)
    {

        component.SetState(Staged.GetInstanse());
    }

    public string getStatus()
    {
        return "staged";
    }
}
