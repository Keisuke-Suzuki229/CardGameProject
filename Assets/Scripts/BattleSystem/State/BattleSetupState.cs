using UnityEngine;

public class BattleSetupState : BattleStateBase
{
    public BattleSetupState(BattleSystem battleSystem) : base(battleSystem)
    {

    }

    public override void OnEnter()
    {
        Debug.Log("Setup OnEnter");
        Owner.ChangeState(Owner.PlayerDrawState);
    }
}
