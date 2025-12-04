using UnityEngine;


public class BattleCardEffectState : BattleStateBase
{
    public BattleCardEffectState(BattleSystem owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        CardObj card = Owner.CurrentCardToPlay;
        EnemyStatus target = Owner.CurrentTarget;

        if(card != null && target != null)
        {
            Mana mana = Object.FindAnyObjectByType<Mana>();
            
            if(mana != null)
            {
                if(mana.UseMana(card.Cost))
                {
                    card.PlayCard(target);
                    Debug.Log($"Playing card Cost = {card.Cost}");
                    Owner.Hand.MoveToDiscard(card);
                    Owner.Hand.ArrangeCards();
                }
                else
                {
                    Owner.Hand.ArrangeCards();
                }
            }
        }

        Owner.CurrentCardToPlay = null;
        Owner.CurrentTarget = null;
        Owner.ChangeState(new BattleCardSelectionState(Owner));
    }


}
