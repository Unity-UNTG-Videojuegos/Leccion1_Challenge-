/*
Rosas Castillo Gabriela
GDGS2102
Desarrollo de videojuegos
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
      private float tiemEsp =1;
    private float tiemDisparo = 0;

    void Update()
    {
      
        //Tiempo considerado para disparar 
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiemDisparo)
        {   
            //Mostrar un perro
            tiemDisparo = Time.time + tiemEsp;
            //Lanzar copias del perro
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }
}
