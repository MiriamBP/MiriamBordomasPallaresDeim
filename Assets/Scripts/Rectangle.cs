using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{

    //Zona de variables globales
    private float _widht;
    private float _height;

    
    // Start is called before the first frame update
    void Start()
    {

        _widht = 12.5f;
        _height = 6.1f; 

        _getArea();
        _getPerimeter();
        _getDiagonal();

    }

    private void _getArea()
    {

        //Variables locales
        float area = 0.0f;

        //calcular el area
        area = _widht * _height;

        //mostrar por consola el resultado del area del rect�ngulo
        Debug.Log ("El �rea de mi rect�ngulo es: " + area);
    }

    private void _getPerimeter()
    {

        //Variables locales
        float perimeter = 0.0f;

        //Calcular per�metro
        perimeter = 2 * (_widht + _height);

        //Monstrar por consola el resultado del per�metro del rect�ngulo
        Debug.Log("El  per�metro de mi rect�ngulo es: " +  perimeter);
    }


    private void _getDiagonal()
    {

        //Variables locales
        float diagonal = 0.0f;

        //calcular diagonal
        diagonal = Mathf.Sqrt(Mathf.Pow(_widht, 2) + Mathf.Pow(_height, 2));

        //Monstrar por consola el resultado de la diaonal del rect�ngulo
        Debug.Log("La diagonal de mi rect�ngulo es: " +  diagonal);
    }


}
