using UnityEngine;

public static class CardEffectFactory
{
    public static CardEffectBase CreateEffect(CardData data)
    {
        return data.effectType switch
        {
            CardEffectType.Attack => new AttackEffect(data),
            CardEffectType.Block => new BlockEffect(data),
            CardEffectType.Draw => new DrawEffect(data),
            CardEffectType.Heal => new HealEffect(data),
            _ => null
        };
    }
}
