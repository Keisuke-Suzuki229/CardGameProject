using UnityEngine;

public class TurnEndButton : MonoBehaviour
{
    public void OnTurnEndButton()
    {
        BattleSystem owner = FindAnyObjectByType<BattleSystem>();
        owner.ChangeState(new BattleEnemyPhaseState(owner));
    }
}
