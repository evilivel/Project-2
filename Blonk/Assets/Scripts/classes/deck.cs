using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{

    //{"red", "yellow", "green", "blue", "purple", "grey"}
    //{"triangle", "diamond", "circle", "bolt", "star", "x"}
     
    private Card[] deck;
    private int cardCount;
    
    //constructor, returns deck of correct cards, 10 of each color / shape and 12 of each number 
    public Deck()
    {
        deck = new Card[60];
        cardCount = 60;
        int[] colorCounter = new int[6] {10,10,10,10,10,10};
        int[] shapeCounter = new int[6] {10,10,10,10,10,10};
        int[] numberCounter = new int[5] {12,12,12,12,12};
        
        for (int c = 0; c < 60; c++)
        {
            int currentColor = 0;
            int currentShape = 0;
            int currentNumber = 0;


            for (int a = 0; a < 3; a++)
            {
                bool aspectFound = false;
                while (aspectFound == false)
                {
                    int roll;
                    switch (a)
                    {
                        case 0:
                            roll = Mathf.RoundToInt(Random.Range(0, colorCounter.Length+1));
                            if (colorCounter[roll] > 0)
                            {
                                colorCounter[roll] = colorCounter[roll] - 1;
                                currentColor = roll;
                                aspectFound = true;
                            }
                            break;
                        
                        case 1:
                            roll = Mathf.RoundToInt(Random.Range(0, shapeCounter.Length+1));
                            if (shapeCounter[roll] > 0)
                            {
                                shapeCounter[roll] = shapeCounter[roll] - 1;
                                currentShape = roll;
                                aspectFound = true;
                            }
                            break;

                        case 2:
                            roll = Mathf.RoundToInt(Random.Range(0, numberCounter.Length+1));
                            if (numberCounter[roll] > 0)
                            {
                                numberCounter[roll] = numberCounter[roll] - 1;
                                currentNumber = roll;
                                aspectFound = true;
                            }
                            break;
                        default:
                            break;            
                    }
                }
            }

            deck[c] = new Card(currentColor, currentShape, currentNumber);
            Debug.Log(c);

        }
    
    }


    //simplified constructor with vairable size
    public Deck(int size)
    {
        deck = new Card[size];
        cardCount = 0;
    }

    //changes card in deck array with given card 
    public void setCard(int cardIndex, Card card)
    {
        deck[cardIndex] = card;
    }

    public void setCardCount(int count)
    {
        cardCount = count;
    }

    public int getCardCount()
    {
        return(cardCount);
    }

    //splits deck between two players *
    public void dealPlayers (Player p1, Player p2)
    {
        int pDeckSize = 30;
        Deck tDeck1 = new Deck(pDeckSize);
        Deck tDeck2 = new Deck(pDeckSize);
        tDeck1.setCardCount(30);
        tDeck2.setCardCount(30);

        

        for (int i = 0; i < deck.Length; i++)
        {
            if(i < pDeckSize)
            {
                tDeck1.setCard(i,deck[i]);
            }
            else
            {
                tDeck2.setCard(i-30,deck[i]); 
            }
        }

        p1.giveDeck(tDeck1);
        p2.giveDeck(tDeck2);
    }

    public Card deal()
    {
        //return top card and remove it from deck goes here
        return(new Card());
    }

    

    



}
