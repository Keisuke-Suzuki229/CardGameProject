using UnityEngine;

public class HealEffect : CardEffectBase
{
    public HealEffect(CardData data) : base(data)
    {
    }

    public override void Execute(EnemyStatus target)
    {
        PlayerStatus player = Object.FindAnyObjectByType<PlayerStatus>();

        player.Heal(data.value);

        Debug.Log($"{data.cardName} : Heal {data.value}");
    }
}
