using UnityEngine;

public class DrawEffect : CardEffectBase
{
    public DrawEffect(CardData data) : base(data)
    {
    }
    public override void Execute(EnemyStatus target)
    {
        BattleSystem battle = Object.FindAnyObjectByType<BattleSystem>();

        for(int i = 0; i < data.value; i++)
        {
            CardObj c = battle.Deck.Draw();
            battle.Hand.AddCard(c);
        }

        Debug.Log($"{data.cardName} : Draw {data.value}");
    }
}
