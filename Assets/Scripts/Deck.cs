using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    //Create Card
    //Pass cards to Hand

    [SerializeField] CardObj cardObjPrefab;
    [SerializeField] Hand hand;
    [SerializeField] DiscardArea discardArea;
    [SerializeField] Text cardCountText;
    [SerializeField] CardData[] cardDataPool;

    List<CardObj> cards = new List<CardObj>();
    
    public void Setup()
    {
        for(int i = 0; i < 10; i++)
        {

            CardObj cardObj = Spawn();
            cardObj.gameObject.SetActive(false);
            
            cards.Add(cardObj);
            UpdateCardCountUI();

        }

        Shuffle();
    }

    CardObj Spawn()
    {
        CardObj card = Instantiate(cardObjPrefab, transform);

        int randomIndex = Random.Range(0, cardDataPool.Length);
        card.data = cardDataPool[randomIndex];
        return card;
    }

    public CardObj Draw()
    {
        if(cards.Count == 0)
        {
            RefillFromDiscard();
        }
        if(cards.Count == 0)
        {
            Debug.Log("Deck is Empty and no cards in discard");
            return null;
        }


        CardObj card = cards[0];
        cards.RemoveAt(0);
        UpdateCardCountUI();

        return card;
    }

    void RefillFromDiscard()
    {
        List<CardObj> discardCards = discardArea.TakeAllCards();

        foreach(CardObj card in discardCards)
        {
            card.transform.SetParent(transform);
            card.gameObject.SetActive(false);
            cards.Add(card);
            UpdateCardCountUI();


        }

        Shuffle();
        Debug.Log("Deck refilled from discard and shuffled");

    }

    void Shuffle()
    {
        for(int i = 0; i < cards.Count; i++)
        {
            CardObj temp = cards[i];
            int randomIndex = Random.Range(i, cards.Count);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        }
    }

    void UpdateCardCountUI()
    {
        if(cardCountText != null)
        {
            cardCountText.text = cards.Count.ToString();
        }
    }
    
}
