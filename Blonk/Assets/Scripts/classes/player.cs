using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    //player atributes 
    private Card[] hand;
    private Deck deck;
    private int handSize = 3;
    private int dificulty; 


    //defuat construtor: for testing, makes empty hand of handS
    public Player()
    {
        hand = new Card[handSize];
        deck = new Deck();
    }


    //constructor: pass the player a deck (after its been split) deal handSize cards to the players hand
    public Player(Deck tDeck)
    {
        deck = tDeck;
        hand = new Card[handSize];

        //deal hand size to hand
        /*
        for (i=0, i<handSize, i++)
        {
            hand[i] = deck.deal();
        }
        */
    }

    //replaces players deck with given deck
    public void giveDeck (Deck tDeck)
    {
        deck = tDeck;
    }

    public void handCheck ()
    {

    }


}
