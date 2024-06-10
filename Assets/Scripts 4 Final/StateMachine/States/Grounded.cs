using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : BaseState
{
    protected Movement mv;

    public Grounded(Movement stateMachine) : base(stateMachine)
    {
        mv = (Movement)stateMachine;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (Input.GetKeyDown(KeyCode.Space))
            stateMachine.ChangeState(mv.jumpingState);
    }
}
