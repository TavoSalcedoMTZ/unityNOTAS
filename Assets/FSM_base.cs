using UnityEngine;

public abstract class FSM_base 
{
    public abstract void Enter(FSM_manager state);
    public abstract void Stay(FSM_manager state);

    public abstract void Exit(FSM_manager state);


    protected float timer;
}
