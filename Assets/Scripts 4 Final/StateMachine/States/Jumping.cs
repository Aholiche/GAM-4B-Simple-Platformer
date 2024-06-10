using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : BaseState
{
    protected Movement mv;
    private bool grounded;

    //Couldn't figure out how to apply layer editing on scripts. Looked this up online but not entirely sure how it works

    private int groundLayer = 1 << 6;

    public Jumping(Movement stateMachine) : base(stateMachine)
    {
        mv = (Movement)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Vector2 vec = mv.rigidbody.velocity;
        vec.y += mv.jumpForce;
        mv.rigidbody.velocity = vec;
        AudioManager.Instance.PlaySFX("Jump");
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (grounded)
            stateMachine.ChangeState(mv.idleState);
        //If player is grounded, swap to idle state
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        grounded = mv.rigidbody.velocity.y < Mathf.Epsilon && mv.rigidbody.IsTouchingLayers(groundLayer);
        //If I'm falling down and touching the ground, then player is grounded
    }
}
