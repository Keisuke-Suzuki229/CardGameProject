using UnityEngine;
using UnityEngine.XR;

public class BattlePlayerDrawState : BattleStateBase
{
    public BattlePlayerDrawState(BattleSystem owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        Debug.Log("DrawState OnEnter");
        for (int i = 0; i < 5; i++)
        {
            CardObj drawCard = Owner.Deck.Draw();
            //Pass cards
            Owner.Hand.AddCard(drawCard);

        }

        Owner.ChangeState(new BattleCardSelectionState(Owner));

    }

    public override void OnUpdate()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
           
        //}
    }


}
