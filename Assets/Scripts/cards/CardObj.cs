
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

    public CardData data;

    public UnityAction OnEndDragAction; // variable that can register function which you want to implement at end drag

    public int Cost => data.cost;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    void Start()
    {
        SetupUI();

    }

    public void SetupUI()
    {
        if (data == null) return;

        nameText.text = data.cardName;
        descriptionText.text = data.description;
        icon.sprite = data.icon;
        costText.text = data.cost.ToString();

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

    public void PlayCard(EnemyStatus target)
    {
        CardEffectBase effect = CardEffectFactory.CreateEffect(data);
        effect.Execute(target);

        Debug.Log($"{data.cardName} Played");
    }
   
}
