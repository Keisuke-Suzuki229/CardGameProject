using UnityEngine;
using UnityEngine.UI;
public class BlockEffect : CardEffectBase
{
    
    public BlockEffect(CardData data) : base(data)
    {
    }

    public override void Execute(EnemyStatus target)
    {
        PlayerStatus player = Object.FindAnyObjectByType<PlayerStatus>();
        player.AddShield(data.value);
        
        Debug.Log($"{data.cardName} : Block {data.value}");
    }

}
