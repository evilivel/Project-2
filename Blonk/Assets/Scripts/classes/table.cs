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



}
