using UnityEngine;

public class BattleSetupState : BattleStateBase
{
    public BattleSetupState(BattleSystem battleSystem) : base(battleSystem)
    {

    }

    public override void OnEnter()
    {
        Debug.Log("Setup OnEnter");
        Owner.Deck.Setup();

        Owner.ChangeState(Owner.PlayerDrawState);
    }

    public override void OnUpdate()
    {
        
    }
}
