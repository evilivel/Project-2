using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{

    // CARDS NEED TO HAVE BUTTONS ON THEM THAT CAN RUN A SCRIPT (MAKE CARDS CLICKABLE)

    //card atributes 
    private int color;
    private int shape;
    private int number;
    private bool buttonPressed;
    // need to add button to constructors, might also need to add gameobject
    //private Button button;

    //These arrays of the posible shapes and colors gives me more options for constructors 
    private string[] colors = new string[6] {"red", "yellow", "green", "blue", "purple", "grey"};
    private string[] shapes = new string[6] {"triangle", "diamond", "circle", "bolt", "star", "x"};

    //defult construtor: random stats, only used for testing
    public Card()
    {
        color = Mathf.RoundToInt(Random.Range(0, 6));
        shape = Mathf.RoundToInt(Random.Range(0, 6));
        number = Mathf.RoundToInt(Random.Range(1, 6));
        

    }
    
    //consturtor: color , shape , number 
    public Card(int tColor,int tShape, int tNumber)
    {
        color = tColor;
        shape = tShape;
        number = tNumber;
        
    }
    

    //MAIN CARD METHODS

    public bool CompCard (Card tcard)
    {
        if(color == tcard.Color() || shape == tcard.Shape() || number == tcard.Number())
        {
            return(true);
        }
        else
        {
            return(false);
        }

    }





    //GET / SET METHODS

    // return color of card

    public bool Button()
    {
        return(buttonPressed);
    }

    // return color of card

    public int Color()
    {
        return (color);
    }
    
    //return shape of card

    public int Shape()
    {
        return (shape);
    }

    //return number of card
    
    public int Number()
    {
        return (number);
    }

    // sets true if false and false if true (toggle)
    public void ButtonFlip()
    {
        if (buttonPressed == true)
        {
            buttonPressed = false;
        }
        else
        {
            buttonPressed = true;
        }
    }






}
