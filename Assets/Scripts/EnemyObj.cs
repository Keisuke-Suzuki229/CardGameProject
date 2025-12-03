using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyObj : MonoBehaviour, IDropHandler
{
    //output log when the card is droped
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDropEvent");
        CardObj card = eventData.pointerDrag.GetComponent<CardObj>();

        if(card != null)
        {
            BattleSystem owner = FindAnyObjectByType<BattleSystem>();
            owner.CurrentCardToPlay = card;
            owner.CurrentTarget = this;

            
        }
    }


}
