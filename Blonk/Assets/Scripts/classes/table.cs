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

    }
    





}
