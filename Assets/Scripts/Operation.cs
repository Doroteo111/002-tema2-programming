using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{
    public int x = 7;
    public int y = 4;

    public bool isRaining;

    public int number;
    private void Start()
    {
        Debug.Log(x + y);
        Debug.Log(x - y);
        Debug.Log(x * y);
        Debug.Log(x / y);
        Debug.Log(x % y);

        if (isRaining == true) //decision operation

            Debug.Log("Recuerda pillar el paraguas");
        else Debug.Log("No esta lloviendo, puedes dejar el paraguas");

        if (number > 0)
            Debug.Log($"El número {number} es positivo");




    }
}
