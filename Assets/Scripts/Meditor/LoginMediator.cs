using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Mediator;
using PureMVC.Interfaces;

public class LoginMediator : Mediator
{

    public new const string NAME = "LoginMediator";


    private 
    public LoginMediator(GameObject viewComponent) : base(NAME, viewComponent)
    {
        
    }
    public override string[] ListNotificationInterests()
    {
        List<string> list = new List<string>();
        return base.ListNotificationInterests();
    }
    public override void HandleNotification(INotification notification)
    {
        base.HandleNotification(notification);
    }

    public override void OnRegister()
    {
        base.OnRegister();
    }

    public override void OnRemove()
    {
        base.OnRemove();
    }
}
