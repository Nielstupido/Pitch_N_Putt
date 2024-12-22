using System;
using System.Collections.Generic;
using UnityEngine;

public class NormalPlay : MonoBehaviour
{
    public void Test()
    {
        List<Card> deck = CardDecks.Instance.GetCardDeck();
        foreach (Card card in deck)
        {
            Debug.Log(card.GetCardDets());
        }
    }
}
