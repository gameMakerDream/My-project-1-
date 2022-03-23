using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns.Facade;
using UnityEngine;

public class AppFacade : Facade
{
    public AppFacade() : base()
    {

    }

    protected override void InitializeFacade()
    {
        base.InitializeFacade();
        RegisterCommand(PublicDefine.frameWorkCmd_StartUp,()=>new StartUpCommand());
        SendNotification(PublicDefine.frameWorkCmd_StartUp);
        RemoveCommand(PublicDefine.frameWorkCmd_StartUp);
    }
}
