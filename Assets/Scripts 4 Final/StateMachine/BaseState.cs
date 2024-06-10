using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState 
{
    //Virtual b/c BaseState shouldn't define all the behavior definitions rather, just declare that those methods exisit. Actual implementation will be in individual classes
    protected StateMachine stateMachine;

    public BaseState(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter() { }
    public virtual void UpdateLogic() { }
    public virtual void UpdatePhysics() { }
    public virtual void Exit() { }

}
