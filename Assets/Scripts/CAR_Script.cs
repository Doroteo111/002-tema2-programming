using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR_Script : MonoBehaviour
{
    [SerializeField] private int Wheels = 4; //amount of wheels the vehicle has 
    [SerializeField] private string Name = "motobike";


    [SerializeField] private bool isOn;

    public string Sound;

    private void Start()
    {
        Debug.Log(string.Format("The {0} has {1} Wheels", Name, Wheels));

       /* if (isOn == true) //encendido o no
            Debug.Log($"El {Name} esta encendido");

        else
            Debug.Log($"El {Name} esta apagado"); */

        if (isOn == false)
        {
            Debug.Log($"El {Name} esta apagado");
        }


        else if (Sound != "")
        {
            Debug.Log($"El {Name} esta encendido y hace {Sound}");
        }
           
        else
        {
            Debug.Log($"El {Name} esta en marcha");
        }







    }
}                                                                                    