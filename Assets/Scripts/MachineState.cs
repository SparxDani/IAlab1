using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineState : MonoBehaviour
{
    public List<StateBase> states = new List<StateBase> ();
    public StateBase currentState;

    // Start is called before the first frame update
    void Start()
    {
        StateBase[] statesarray = GetComponents<StateBase>();

        foreach (var item in statesarray)
            states.Add(item);

        DescactivarEstados();
        currentState = GetComponent<Patrol>();
    }
    private void DescactivarEstados()
    {
        foreach (var state in states)
        {
            state.enabled = false;
        }
    }
    public void ChangeState(StateBase next)
    {
        if (next != null)
        {

            currentState.Exit();
            currentState.enabled = false;

            currentState = next;

            currentState.Enter();
            currentState.enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (currentState != null && currentState.enabled)
            currentState.Execute();
    }
}
