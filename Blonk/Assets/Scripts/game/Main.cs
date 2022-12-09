using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main : MonoBehaviour
{
    

    public Canvas canvas;
    public Table currentTable;
    public bool GameEnded;


    // Start is called before the first frame update
    void Start()
    {
        canvas = gameObject.GetComponent<Canvas>();
        currentTable = new Table(canvas);
        StartCoroutine(AI());
        GameEnded = false;
        
        //Deck test = new Deck(canvas);
    }

    // Update is called once per frame
    void Update()
    {

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
            Debug.Log(hit.point);

          }
        }



      
      currentTable.player1Play();
      
      






      if(currentTable.checkGameOver() == true)
      {
        //Debug.Log("Game Over");
        GameEnded = true;
                  
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
      }
      
    
    }

    IEnumerator AI()
    {
        while(GameEnded == false)
        {
            foreach (Card i in currentTable.getPlayer().getHand())
            {
              i.ButtonFlip();

              yield return new WaitForSeconds(1);
              currentTable.player2Play();

            }
          
        }


    }
      


}
