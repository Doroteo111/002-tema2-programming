using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR_Script : MonoBehaviour
{
    [SerializeField] private int Wheels = 4; //amount of wheels the vehicle has 
    [SerializeField] private string Name = "motobike";

    private void Start()
    {
        Debug.Log(string.Format("The {0} has {1} Wheels", Name, Wheels));
    }
}                                                                                    