using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamiento_pista : MonoBehaviour
{
    // Definición de variables
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Se ha colisionado con: " + other.name);

        //Comunicacion entre scripts
        //Usar el nombre de la clase con la que me quiero comunicar
        //Crear un nuevo objeto que herede los atributos de navescript, llamar a la variables disparo triple y destruir el game object de powerUp
        
        

    }
}
