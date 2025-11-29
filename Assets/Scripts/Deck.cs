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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
    private CardObj Draw()
    {
        CardObj card = cards[0];
        cards.RemoveAt(0);

        return card;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < 5; i++)
            {
                CardObj drawCard = Draw();
                drawCard.transform.SetParent(hand.transform);
                drawCard.gameObject.SetActive(true);
            }
            
            
        }
    }
}
