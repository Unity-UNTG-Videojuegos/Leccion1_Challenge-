/*
Rosas Castillo Gabriela
GDGS2102
Desarrollo de videojuegos
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

// Se genera el objecto para destruir los objetos
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
