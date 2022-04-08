//1.Crea un programa que permita ingresar por Inspector 
//dos valores enteros y responda si son iguales o no lo son.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{

    public int n1;
    public int n2;

    // Start is called before the first frame update
    void Start()
    {
        if (n1 == n2)
        {
            Debug.Log("Si son iguales");
        }
        else
        {
            Debug.Log("No son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
