//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//    Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int precio3;
    public int dinero_disponible;
    float suma;
    float resto;
    // Start is called before the first frame update
    void Start()
    {
        suma = (precio1 + precio2 + precio3);
        resto = (dinero_disponible - suma);

        if (suma > dinero_disponible)
        {
            Debug.Log("Suma supera dinero disponible ");
            Debug.Log(resto);

        }
        else
        {
            Debug.Log("Suma es menos que el dinero disponible");
            Debug.Log(resto);

        }
        Debug.Log("El resto es:  " + resto);
    }
        // Update is called once per frame
        void Update()
        {

        }
    }

