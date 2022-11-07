using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    4 variables with the player information
     
    public int playerAge = 33; //This variable saves the player's age
    public float playerSpeed = 3.125f;
    public string playerName = "Isa De";
    public bool gameOver = false;

    public string message = "¡Hola Mundo!";
    public int points = 256;

    public float x = 2; //math operation
    public float y = 3;
   */

    public Vector3 InitialPos = new Vector3(1, 1, 1);
    public Vector3 up = new Vector3(0, 1, 0);
    public Vector3 down = new Vector3(0, -1, 0);

    private void Start()
    {
        /* Debug.Log(message);
         Debug.Log(points);
         Debug.Log($"Tengo {points} puntos");
         Debug.Log(string.Format("Tengo {0} puntos", points)); 

         Debug.Log(string.Format("Hola {0}, tienes {1} puntos", playerName, points));

         x = x + y;
         Debug.Log(x); 
        */
        transform.position = InitialPos;

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
         {
            transform.position += up;
         
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.position += down;
        }
    }





}
