using UnityEngine;

public class FSM_idle : FSM_base
{
    public override void Enter(FSM_manager state)
    {
        Debug.Log("ENTER IDLE");
       
    }
    public override void Stay(FSM_manager state)
    {
        Debug.Log("STAY IDLE");
        timer += Time.deltaTime;
        if(timer >= 2)
        {
            state.SwitchState(state.walk);
            timer = 0;
        }
    }
    public override void Exit(FSM_manager state)
    {
        Debug.Log(" EXIT IDLE");
    }
}
