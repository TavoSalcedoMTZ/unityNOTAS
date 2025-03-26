using UnityEngine;

public class FSM_sleep : FSM_base
{

    public override void Enter(FSM_manager state)
    {
        Debug.Log("ENTER SLEEP");

    }
    public override void Stay(FSM_manager state)
    {
        Debug.Log("STAY SLEEP");
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            state.SwitchState(state.idle);
            timer = 0;
        }
     }
    public override void Exit(FSM_manager state)
    {
        Debug.Log("EXIT SLEEP");
    }
}
