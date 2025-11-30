using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    //Create Card
    //Pass cards to Hand

    [SerializeField] CardObj cardObjPrefab;
    [SerializeField] Hand hand;
    List<CardObj> cards = new List<CardObj>();
    
    public void Setup()
    {
        for(int i = 0; i < 10; i++)
        {

            CardObj cardObj = Spawn();
            cardObj.gameObject.SetActive(false);
            cards.Add(cardObj);

        }
    }

    CardObj Spawn()
    {
        return Instantiate(cardObjPrefab, transform);
    }
    public CardObj Draw()
    {
        CardObj card = cards[0];
        cards.RemoveAt(0);

        return card;
    }

   
    
}
