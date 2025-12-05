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
        Mana mana = Object.FindAnyObjectByType<Mana>();

        if(card == null || mana == null)
        {
            Finish();
            return;
        }

        if(!mana.UseMana(card.Cost))
        {
            Owner.Hand.ArrangeCards();
            Finish();
            return;
        }

        switch(card.data.effectType)
        {
            case CardEffectType.Attack:
                if(target != null)
                {
                    card.PlayCard(target);
                    Debug.Log($"Attack card played on {target.name}");
                }
                break;

            case CardEffectType.Block:
            case CardEffectType.Heal:
            case CardEffectType.Draw:

                card.PlayCard(null);
                Debug.Log($"{card.data.effectType} card played on player");
                break;
        }

        Owner.Hand.MoveToDiscard(card);
        Owner.Hand.ArrangeCards();

        Finish();
    }

    private void Finish()
    {
        Owner.CurrentCardToPlay = null;
        Owner.CurrentTarget = null;
        Owner.ChangeState(new BattleCardSelectionState(Owner));
    }


}
