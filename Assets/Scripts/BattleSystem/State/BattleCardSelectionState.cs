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

    public override void OnUpdate()
    {
        if(Owner.CurrentCardToPlay != null && Owner.CurrentTarget != null)
        {
            Owner.ChangeState(new BattleCardEffectState(Owner));
        }
        
    }
}
