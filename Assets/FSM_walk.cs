using UnityEngine;

public class FSM_walk : FSM_base
{
    public override void Enter(FSM_manager state)
    {
        Debug.Log(" ENTER WALK");

    }
    public override void Stay(FSM_manager state)
    {
        Debug.Log("STAY WALK");
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            state.SwitchState(state.sleep);
            timer = 0;
        }
    }
    public override void Exit(FSM_manager state)
    {
        Debug.Log("EXIT WALK");
    }
}
