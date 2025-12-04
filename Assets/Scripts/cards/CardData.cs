using UnityEngine;


public enum CardEffectType
{
    Attack,
    Block,
    Draw,
    Heal,
}

[CreateAssetMenu(fileName = "NewCard", menuName = "Card/CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public Sprite icon;
    public int cost;
    public CardEffectType effectType;

    public int value;
    public string description;
}
