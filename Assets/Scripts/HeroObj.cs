using System.Buffers;
using UnityEngine;
using UnityEngine.EventSystems;

public class HeroObj : MonoBehaviour, IDropHandler
{
    
    public void OnDrop(PointerEventData eventData)
    {
        CardObj card = eventData.pointerDrag.GetComponent<CardObj>();

        if(card != null)
        {
            BattleSystem owner = FindAnyObjectByType<BattleSystem>();

            owner.CurrentCardToPlay = card;
            owner.CurrentTarget = null;

            Debug.Log("card dropped to hero");

            owner.ChangeState(new BattleCardEffectState(owner));
        }

        
    }
}
