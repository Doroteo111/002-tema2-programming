using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR_Script : MonoBehaviour
{
    [SerializeField] private int Wheels = 4; //amount of wheels the vehicle has 
    [SerializeField] private string Name = "motobike";


    [SerializeField] private bool isOn; //motor

    public string Sound;

    [SerializeField] private float gasoline;

    public bool canGetBigger;
    public Vector3 localScale = new Vector3(1, 1, 1);

    private void Start()
    {
        /* Debug.Log(string.Format("The {0} has {1} Wheels", Name, Wheels));

         if (isOn == true)                                   //encendido o no
             Debug.Log($"El {Name} esta encendido");

         else
             Debug.Log($"El {Name} esta apagado"); */

        /* if (isOn == false)                              //operation decision
         {
             Debug.Log($"El {Name} esta apagado");
         }


         else if (Sound != "")
         {
             Debug.Log($"El {Name} esta encendido y hace {Sound}");
         }

         else
         {
             Debug.Log($"El {Name} esta en marcha"); */

        /* if (isOn == true) {
             Debug.Log($"El {Name} esta encendido");

             if (gasoline <= 10)
             {
                 Debug.Log($"¡A {Name} le queda poca gasolina!");
             }


         }  */

       /* if (isOn == true && gasoline <= 10)
        {
            Debug.Log($"¡A {Name} le queda poca gasolina!");
        }
       */

    }

    private void Update()
    {
        if (canGetBigger == false)
        {
            if(Input.GetMouseButtonDown(0))
                {
                transform.localScale += Vector3.one;
            }
            
            
               if (Input.GetMouseButtonDown(1))
                {
                    transform.localScale -= Vector3.one;

                }
            
        }
    }
}                                                                                 