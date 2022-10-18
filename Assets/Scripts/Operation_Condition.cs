using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation_Condition : MonoBehaviour
{
    public int x = 10; //igusldad
    public int y = 4;
    private bool areEqual;

    public string name1 = "Eustaquio";// desigual
    public string name2 = "Celedonio";
    private bool areDifferent;

    public float X = 2.0f;
    public float Y = 0.5f;
    private bool isGreater;

    private void Start()
    {
        areEqual = x == y; //=
        Debug.Log(areEqual);

        areDifferent = name1 != name2;
        Debug.Log(areDifferent);

        isGreater = X > Y;
        Debug.Log(isGreater);

    }
}
