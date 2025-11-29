using UnityEngine;

public class BattlePlayerDrawState : BattleStateBase
{
    public BattlePlayerDrawState(BattleSystem owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        Debug.Log("DrawState OnEnter");
    }


}
