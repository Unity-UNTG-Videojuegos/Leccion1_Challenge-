/*
Rosas Castillo Gabriela
GDGS2102
Desarrollo de videojuegos
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    // Limites 
    private float leftLimit = -38;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Se destruyen los perros en la linea X
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Se destruyen los balones del lado Y
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
