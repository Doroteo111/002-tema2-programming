using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{
    public int x = 7;
    public int y = 4;
    private void Start()
    {
        Debug.Log(x+y);
        Debug.Log(x-y);
        Debug.Log(x*y);
        Debug.Log(x/y);
        Debug.Log(x%y);


    }
}
