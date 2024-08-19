using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Test : MonoBehaviour
{
    MachineState _MachineState;
    Patrol _Patrol;
    Dig _Dig;
    Chase _Chase;
    // Start is called before the first frame update
    void Start()
    {
        _MachineState = GetComponent<MachineState>();
        _Patrol = GetComponent<Patrol>();
        _Dig = GetComponent<Dig>();
        _Chase = GetComponent<Chase>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            _MachineState.ChangeState(_Patrol);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _MachineState.ChangeState(_Dig);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            _MachineState.ChangeState(_Chase);
        }
    }
}
