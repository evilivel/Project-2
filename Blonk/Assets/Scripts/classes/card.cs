using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card
{

    // CARDS NEED TO HAVE BUTTONS ON THEM THAT CAN RUN A SCRIPT (MAKE CARDS CLICKABLE)

    //card atributes 
    private int color;
    private int shape;
    private int number;
    private GameObject GO;
    private bool buttonPressed;


    //These arrays of the posible shapes and colors gives me more options for constructors 
    private string[] hats = new string[6] {"nohat", "partyhat", "crown", "tophat", "sombrero", "propellerhat"};
    private string[] shapes = new string[6] {"bonk", "chonk", "honk", "monk", "stonk", "stronk"};
    private string[] numbers = new string[6] {"single", "double", "triple", "four", "five",""};

    
    
    
    //defult construtor: random stats, only used for testing
    public Card()
    {


        color = Mathf.RoundToInt(Random.Range(0, 6));
        shape = Mathf.RoundToInt(Random.Range(0, 6));
        number = Mathf.RoundToInt(Random.Range(1, 6));
        

    }

    //consturtor: color , shape , number 
    public Card(Object texture)
    {
        string[] words = texture.name.Split(' ');
        foreach (var i in words)
        {
            for (int a = 0; a < 6; a++)
            {
                if (hats[a] == i)
                {
                    color = a;
                }

                if (shapes[a] == i)
                {
                    shape = a;
                }
                if (numbers[a] == i)
                {
                    number =a;
                }

            }
        }

        //LINE TO MAKE GAMEOBJECT AND PUT TEXTURE ON IT 



        Texture2D Texture = (Texture2D)texture;
        GO = GameObject.CreatePrimitive(PrimitiveType.Plane);
        GO.transform.localScale = new Vector3(.14f,.14f,.2f);
        
        
        GO.GetComponent<Renderer>().material.mainTexture = Texture;

        //RawImage pic = texture.AddComponent<GameObject>().AddComponent<RawImage>();
        //RawImage GOimage = GO.AddComponent<RawImage>();
        //GOimage.texture = texture;
        

        //color = tColor;
        //shape = tShape;
        //umber = tNumber;
        
    }

    //consturtor: color , shape , number 
    public Card(Object texture, Canvas canvas)
    {
        string[] words = texture.name.Split(' ');
        foreach (var i in words)
        {
            for (int a = 0; a < 6; a++)
            {
                if (hats[a] == i)
                {
                    color = a;
                }

                if (shapes[a] == i)
                {
                    shape = a;
                }
                if (numbers[a] == i)
                {
                    number =a;
                }

            }
        }

        //LINE TO MAKE GAMEOBJECT AND PUT TEXTURE ON IT 

      

        GameObject imgObject = new GameObject("card");
        


        RectTransform trans = imgObject.AddComponent<RectTransform>();
        imgObject.AddComponent<Button>();
        imgObject.GetComponent<Button>().onClick.AddListener(TaskOnClick);
        trans.transform.SetParent(canvas.transform); // setting parent
        trans.localScale = Vector3.one;
        trans.anchoredPosition = new Vector2(0f, 0f); // setting position, will be on center
        trans.sizeDelta= new Vector2(125, 175); // custom size
        trans.transform.localRotation = Quaternion.Euler(0, 0, 0);

        Image image = imgObject.AddComponent<Image>();
        Texture2D tex = (Texture2D)texture;
        image.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        imgObject.transform.SetParent(canvas.transform);

        GO = imgObject;

//my stuff

        //Texture2D Texture = (Texture2D)texture;
        //GO = GameObject.CreatePrimitive(PrimitiveType.Plane);
        //GO.transform.localScale = new Vector3(.14f,.14f,.2f);
        
        
        //GO.GetComponent<Renderer>().material.mainTexture = Texture;

        //RawImage pic = texture.AddComponent<GameObject>().AddComponent<RawImage>();
        //RawImage GOimage = GO.AddComponent<RawImage>();
        //GOimage.texture = texture;
        

        //color = tColor;
        //shape = tShape;
        //umber = tNumber;
        
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


    //returns game object
    public GameObject getGO()
    {
        return (GO);
    }

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

        void TaskOnClick()
    {
        ButtonFlip();
        //Debug.Log("You have clicked the button!");
    }







}
