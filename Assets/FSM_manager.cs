using UnityEngine;

public class FSM_manager : MonoBehaviour
{
    FSM_base actualState;
    public FSM_idle idle = new FSM_idle();
    public FSM_walk walk = new FSM_walk();
    public FSM_sleep sleep = new FSM_sleep();
    void Start()
    {

        //Ponemos un estado inicial
        actualState = idle;

        //Marcamos el enter como el estado actual
        actualState.Enter(this);
    }

   
    void Update()
    {
        actualState.Stay(this);
    }

    public void SwitchState(FSM_base newState)
    {
        actualState.Exit(this);
        actualState = newState;
        actualState.Enter(this);
    }
}
