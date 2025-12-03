using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardObj : MonoBehaviour, IDragHandler,IEndDragHandler, IBeginDragHandler
{
    [SerializeField] Text nameText;
    [SerializeField] Text descriptionText;
    [SerializeField] Image icon;
    [SerializeField] Text costText;
    [SerializeField] int cost = 2;

    CanvasGroup canvasGroup;

    public UnityAction OnEndDragAction; // variable that can register function which you want to implement at end drag

    public int Cost => cost;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        OnEndDragAction?.Invoke();
    }

    public virtual void PlayCard(EnemyObj target)
    {
        Debug.Log($"{nameText.text} was played");
        //Take Damage
        //move to Discard Area
    }
}
