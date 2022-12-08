using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main : MonoBehaviour
{

    private Object[] textures;
    private GameObject go;
    private string c1;
    private string c2;
    private string c3;





    // Start is called before the first frame update
    void Start()
    {
        Table currentTable = new Table();
        textures = Resources.LoadAll("cards", typeof(Texture2D));

        foreach (var t in textures)
        {
          string[] words = t.name.Split(' ');
          foreach (var i in words)
          {
            Debug.Log(i);
          }
        }
        
    }

    // Update is called once per frame
    void Update()
    {



      /*
      currentTable.player1Play();
      
      // something to make AI player work goes here

      if(currentTable.checkGameOver() == true)
      {
        Debug.Log("Game Over");
        GameEnded = true;
                  
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
      }
      */

      


        /*
        if (Input.GetMouseButtonDown(0))
        {
          // get the position of the mouse cursor on the screen
          Vector3 mousePosition = Input.mousePosition;

          // convert the mouse position to world coordinates
          Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

          // create a raycast to check if the player clicked on a card
          RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);

          if (hit.collider != null)
          {
            // if the player clicked on a card, check if it can be moved

            // if the card can be moved, move it and update the game state
          }
        }
        */




        /*public void LoseLevel()
         * {
         *      if(GameEnded == false)
         *      {
         *          Debug.Log("Game Over");
         *          GameEnded = true;
         *          
         *          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         *      }
         * }
         * */
    }





/*
 * public class CardController : Monobehaviour 
 * {
 *      public Card card;
 *      public Image illustration;
 *      
 *      private void Awake()
 *      {
 *         Initialize(card);
 *      }
 *      
 *      private void Start()
 *      {
 *      
 *      }
 *      
 *      public void Initialize(Card card)
 *      {
 *          illustration.sprite =  card.illustration;
 *      }
 *      
 *      private void Update()
*/  
}
