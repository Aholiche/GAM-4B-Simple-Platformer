using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : Grounded
{
    private float horizontalInput;

    public Moving(Movement stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        horizontalInput = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontalInput) < Mathf.Epsilon)
            stateMachine.ChangeState(mv.idleState);
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Vector2 vec = mv.rigidbody.velocity;
        vec.x = horizontalInput * mv.speed;
        mv.rigidbody.velocity = vec;
    }
}
