using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Zona de variables globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {
        _isIncreasingOrder();
    }

    private void _isIncreasingOrder()
    {
        if (NumberOne < NumberTwo && NumberTwo < NumberThree)
        {
            Debug.Log("El orden de los n�meros es creciente.");
        }
        else
        {
            Debug.Log("El orden de los n�meros no es creciente.");
        }
    }
}
