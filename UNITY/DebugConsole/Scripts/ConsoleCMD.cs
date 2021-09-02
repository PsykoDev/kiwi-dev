using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCMD
{
    private string commandId;
    private string commandDescription;

    public string Id { get { return commandId; } }
    public string Description { get { return commandDescription; } }

    public BaseCMD(string commandId, string commandDescription)
    {
        this.commandId = commandId;
        this.commandDescription = commandDescription;
    }

    public abstract void Invoke(string[] args);
}

public class ConsoleCMD : BaseCMD
{
    Action<string[]> action;
    public ConsoleCMD(string commandId, string commandDescription, Action<string[]> action) 
        : base(commandId, commandDescription)
    {
        this.action = action;
    }

    public override void Invoke(string[] args)
    {
        action.Invoke(args);
    }
}