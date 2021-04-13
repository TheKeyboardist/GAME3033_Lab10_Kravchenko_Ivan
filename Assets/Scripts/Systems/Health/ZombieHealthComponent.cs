using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealthComponent : HealthComponent
{

    private StateMachine zombieStateMachine;

    private void Awake()
    {
        zombieStateMachine.GetComponent<StateMachine>();
    }

    public override void Destroy()
    {
     

       // base.Destroy();
        zombieStateMachine.ChanceState(ZombieStateType.Dead);
    }
}
