using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public GameObject forma;
    public GameObject esfera;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ObjetoaOrigen(forma);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(NegativoPosiciónY(esfera));
        }
    }

        void ObjetoaOrigen(GameObject form)
        {
            form.transform.position = Vector3.zero; // (0,0,0)
        }

        bool NegativoPosiciónY(GameObject obj)
        {
            bool NoEsNegativo = false;

            if (obj.transform.position.y > 0)
            {
                NoEsNegativo = true;
            }

            return NoEsNegativo;
        }
    
}
