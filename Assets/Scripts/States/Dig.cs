using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dig : StateBase
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
        Debug.Log("Dig Enter ");
    }
    public override void Execute()
    {
        Debug.Log("Dig Execute ");
    }
    public override void Exit()
    {
        Debug.Log("Dig Exit ");
    }
}
