using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : StateBase
{
    void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();

    }
    public override void Enter()
    {
        Debug.Log("Patrol Enter ");
    }
    public override void Execute()
    {
        Debug.Log("Patrol Execute ");
    }
    public override void Exit()
    {
        Debug.Log("Patrol Exit ");
    }
}
