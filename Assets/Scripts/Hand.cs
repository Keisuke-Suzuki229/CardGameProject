
using UnityEngine;
using System.Collections.Generic;


public class Hand : MonoBehaviour
{


    

    List<CardObj> cards = new List<CardObj>();

    public void AddCard(CardObj card)
    {
        cards.Add(card);
        card.transform.SetParent(transform);
        card.gameObject.SetActive(true);
        ArrangeCards();
        card.OnEndDragAction += ArrangeCards;
    }

    void ArrangeCards()
    {

        int count = cards.Count;

        for (int i = 0; i < cards.Count; i++)
        {
            float center = (cards.Count - 1) / 2.0f;
            float interval = 12.0f;

            float x = (i - center) * interval;
            cards[i].transform.localPosition = new Vector3(x, 0, 0);
        }
    }

    public void RemoveCard(CardObj card)
    {
        cards.Remove(card);
        ArrangeCards();
    }

}

