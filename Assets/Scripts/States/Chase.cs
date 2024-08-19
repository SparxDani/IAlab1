using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : StateBase
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
        Debug.Log("Chase Enter ");
    }
    public override void Execute()
    {
        Debug.Log("Chase Execute ");
    }
    public override void Exit()
    {
        Debug.Log("Chase Exit ");
    }
}
