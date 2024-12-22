using System;
using System.Collections.Generic;
using UnityEngine;


public enum CardRanks
{
    Ace,
    King,
    Queen,
    Rook,
    Bishop,
    Knight
}


public class Card
{
    public string cardRank;
    public string cardSuit;

    public Card(string newCardRank, string newCardSuit)
    {
        this.cardRank = newCardRank;
        this.cardSuit = newCardSuit;
    }


    public string GetCardDets()
    {
        return this.cardRank + " / " + this.cardSuit;
    }


    public int GetCardValue()
    {
        return 1;
    }
}


public class CardDecks : MonoBehaviour
{
    public static CardDecks Instance { get; private set; }

    private string[] cardRanks = {"Ace", "King", "Queen", "Rook", "Bishop", "Knight"};
    private string[] cardSuits = {"Green Clubs", "Red Hearts", "Blue Diamonds"};
    private int numOfCopies = 3;



    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }


    public List<Card> GetCardDeck()
    {
        List<Card> newDeck = new List<Card>();

        foreach (string cardRank in cardRanks)
        {
            foreach (string cardSuit in cardSuits)
            {
                for (int i = 1; i <= numOfCopies; i++)
                {
                    newDeck.Add(new Card(cardRank, cardSuit));
                }
            }
        }

        return newDeck;
    }
}



