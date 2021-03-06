using System.Collections;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using UnityEngine;

public class LoadSceneCompleteCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        string sceneName = (string) notification.Body;
        switch (sceneName)
        {
            case "Login":
                break;
            case "Hall":
                break;
            case "DDZ":
                break;
            case "MJ":
                break;
            default:
                break;
        }
    }
}
