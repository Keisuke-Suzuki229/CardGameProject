using UnityEngine;

public class BattleCardSelectionState : BattleStateBase
{
    public BattleCardSelectionState(BattleSystem owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        Debug.Log("Selection OnEnter");
    }
}
