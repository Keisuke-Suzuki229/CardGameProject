using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    //manage Phase
    //1.set up Deck
    //2.start battle : Draw 5 cards Phase
    //3.select cardf Phase
    //4.card effect phase
    //5.Enemy phase

    BattleSetupState setupState;
    BattlePlayerDrawState playerDrawState;
    BattleCardSelectionState cardSelectionState;
    BattleStateBase currentState;

    public BattlePlayerDrawState PlayerDrawState { get => playerDrawState; }
    public BattleSetupState SetupState { get => setupState; }

    public BattleCardSelectionState CardSelectionState { get => cardSelectionState; }

    void Start()
    {
        Debug.Log("Battle system start");
        setupState = new BattleSetupState(this);
        playerDrawState = new BattlePlayerDrawState(this);
        cardSelectionState = new BattleCardSelectionState(this);

        ChangeState(setupState);
    }

    public void ChangeState(BattleStateBase newState)
    {
        currentState = newState;
        currentState.OnEnter();
    }

}
