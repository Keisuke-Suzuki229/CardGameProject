using UnityEngine;

public class AttackEffect : CardEffectBase
{
    public AttackEffect(CardData data) : base(data)
    {
    }

    public override void Execute(EnemyStatus target)
    {
        target.TakeDamage(data.value);
        Debug.Log($"{data.cardName} deals {data.value} damage to ");
    }
}
