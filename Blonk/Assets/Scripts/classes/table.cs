using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table
{
    private Deck tableDeck1;
    private Deck tableDeck2;

    private Player player1;
    private Player player2;

    private bool gameOver;
    private int fDeckIndex;

    public Table()
    {
       gameOver  = false;
       tableDeck1 = new Deck(60);
       tableDeck1 = new Deck(60);
       player1 = new Player();
       player2 = new Player();

       // creates a new deck using defult constructor and splits it between two players 
       new Deck().dealPlayers(player1, player2);

       //fills both players hand
       player1.dealHand();
       player2.dealHand();

       //move top card of each player deck to table deck 
       tableDeck1.addCard(player1.getDeck().deal());
       tableDeck2.addCard(player2.getDeck().deal());

        
    }
    

    // method that playes selected card onto correct deck if they match
    public void player1Play()
    {
        Card currentCard = player1.handCheck(tableDeck1.getTopCard(), tableDeck2.getTopCard(), fDeckIndex);

        if(fDeckIndex = 1)
        {
            tableDeck1.addCard(currentCard);
        }
        else if (fDeckIndex = 2)
        {
            tableDeck2.addCard(currentCard);
        }

        // if no cards where selected or the card did not match the top card of either deck
        //do nothing

    }

    public void player2Play()
    {
        //might put ai info here 
    }


    //checks if either players deck is empty, returns true if game is over and false if it is not
    // just relized i should add something to check if the hand is empty as well 
    public bool checkGameOver()
    {
        int p1DeckSize = player1.getDeck().getCardCount(); 
        int p2DeckSize = player2.getDeck().getCardCount();
        
        if(p1DeckSize < 1)
        {
            gameOver = true;
            Debug.Log("player 1 wins")
        }

        if(p2DeckSize < 1)
        {
            gameOver = true;
            Debug.Log("player 2 wins")
        }

        return (gameOver);
    }
    
    // probably need to add method to check if either player has a playable card (check if game is stuck and deal card from one of the players decks to unstick it)





}
