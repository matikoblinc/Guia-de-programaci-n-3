using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    string texto = "hola";

    int numero = 5;

    float numeroF = 4.53f;

    int num1 = 2;
    int num2 = 4;
    int num3 = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            HelloWorld();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            DevuelveUnParametro(texto);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ConcatenaStringInt(texto, numero);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(FloataIntaString(numeroF));
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(MayorDeTres(num1,num2,num3));
        }
    }

    void HelloWorld()
    {
        Debug.Log("Hello World!!");
    }

    void DevuelveUnParametro(string text)
    {
        Debug.Log(text);
    }

    void ConcatenaStringInt(string text, int num)
    {
        Debug.Log(text + num);
    }

    string FloataIntaString (float num)
    {
        string num2;

        num = Mathf.Floor(num);
        num2 = num.ToString();

        return num2;
    }

    int MayorDeTres (int num1, int num2, int num3)
    {
        int Mayor;

        if (num1 > num2 && num1 > num3)
        {
            Mayor = num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            Mayor = num2;
        }
        else if (num3 > num1 && num3 > num2)
        {
            Mayor = num3;
        }
        else
        {
            Mayor = -1;
        }

        return Mayor;
    }
}
