using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : Grounded
{
    private float horizontalInput;

    public Idle(Movement stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        horizontalInput = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontalInput) > Mathf.Epsilon)
            stateMachine.ChangeState(((Movement)stateMachine).movingState);
    }
}
