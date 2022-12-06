using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      public Table currentTable = new Table();
        
    }

    // Update is called once per frame
    void Update()
    {

      currentTable.player1Play();
      
      // something to make AI player work goes here

      if(currentTable.checkGameOver() == true)
      {
        Debug.Log("Game Over");
        GameEnded = true;
                  
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }

      


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

}
