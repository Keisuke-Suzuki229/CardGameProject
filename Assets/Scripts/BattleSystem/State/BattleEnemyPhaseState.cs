using UnityEngine;

public class BattleEnemyPhaseState : BattleStateBase
{
    public BattleEnemyPhaseState(BattleSystem owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        Debug.Log("====Enemy Phase Start====");

        Owner.Hand.DiscardAll();

        //enemy.DoAction();

        Owner.Mana.ResetMana();

        Owner.ChangeState(new BattlePlayerDrawState(Owner));
        
    }
}
