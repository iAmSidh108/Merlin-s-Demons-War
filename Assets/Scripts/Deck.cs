using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Deck 
{
    public List<CardData> cardDatas = new List<CardData>();

    public void Create()
    {
        //Create list of all cards in order
        List<CardData> cardDataInOrder = new List<CardData>();
        foreach(CardData cardData in GameController.instance.cards)
        {
            for (int i = 0; i < cardData.numberInDeck; i++)
                cardDataInOrder.Add(cardData);

        }

        //theen randomize the generated cards order
        while (cardDataInOrder.Count > 0)
        {
            int randomIndex = Random.Range(0, cardDataInOrder.Count);
            cardDatas.Add(cardDataInOrder[randomIndex]);
            cardDataInOrder.RemoveAt(randomIndex);
        }

    }
}
