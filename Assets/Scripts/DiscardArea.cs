using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscardArea : MonoBehaviour
{
    [SerializeField] Text discardCardCountText;

    List<CardObj> discardCards = new List<CardObj>();

    private void Awake()
    {
        discardCardCountText.text = discardCards.Count.ToString();
    }
    public void AddCard(CardObj card)
    {
        discardCards.Add(card);
        card.transform.SetParent(transform, false);
        card.transform.localScale = Vector3.one;
        card.gameObject.SetActive(false);
        UpdateCardCountUI();


    }

    public List<CardObj> TakeAllCards()
    {
        List<CardObj> all = new List<CardObj>(discardCards);

        discardCards.Clear();
        UpdateCardCountUI();
        return all;
    }

    void UpdateCardCountUI()
    {
        if (discardCardCountText != null)
        {
            discardCardCountText.text = discardCards.Count.ToString();
        }
    }

}
