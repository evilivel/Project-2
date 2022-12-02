using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{

    // CARDS NEED TO HAVE BUTTONS ON THEM THAT CAN RUN A SCRIPT (MAKE CARDS CLICKABLE)

    //card atributes 
    private string color;
    private string shape;
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
        color = colors[Mathf.RoundToInt(Random.Range(1, 7))];
        shape = shapes[Mathf.RoundToInt(Random.Range(1, 7))];
        number = Mathf.RoundToInt(Random.Range(1, 6));
        //button = new Button();

    }
    
    //consturtor: color , shape , number 
    public Card(string tColor,string tShape, int tNumber)
    {
        color = tColor;
        shape = tShape;
        number = tNumber;
        //button = new Button();
    }
    
    //construtor: uses int insted of strings
    public Card(int tColor, int tShape, int tNumber)
    {
        if(tColor < 6)
        {
            color = colors[tColor];
        }
        if(tShape < 6)
        {
             shape = shapes[tShape];
        }

        number = tNumber;
        //button = new Button();
    }
    

    // return color of card
    public string Color()
    {
        return (color);
    }
    
    //return shape of card
    public string Shape()
    {
        return (shape);
    }

    //return number of card
    public int Number()
    {
        return (number);
    }

    //return if button is pressed
    public bool Button()
    {
        return (buttonPressed);
    }



    // set buttonPressed to true when clicked, cant get button to work without gameobject
    void Start()
    {
      //button.onClick.AddListener(TaskOnClick);
      
    }

    void TaskOnClick()
    {
        //buttonPressed=true;

    }
}
