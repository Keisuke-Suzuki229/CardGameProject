using UnityEngine;

public abstract class CardEffectBase
{
    protected CardData data;

    public CardEffectBase(CardData data)
    {
        this.data = data;
    }

    public abstract void Execute(EnemyStatus target);
}
