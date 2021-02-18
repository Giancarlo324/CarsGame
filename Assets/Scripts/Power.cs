﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    void Start()
    {

    }

    //---------------------------------------------------
    void Update()
    {

    }
    //---------------------------------------------------
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colisionó con el objeto: " + other.tag);
      
        // Función para identificar cuando el objeto colisionó
        if (other.tag == "player1") // Controlo que la colisión se de únicamente con el objeto de fastPower
        {
            carroScript carro = other.GetComponent<carroScript>();
            if (carro != null)
            {
                carro.VelMaxEncendido();
            }

            Destroy(this.gameObject);
        }
        else if(other.tag == "player2")
        {
            carroScript player2 = other.GetComponent<carroScript>();
            if (player2 != null)
            {
                player2.VelMaxEncendido();
            }
            Destroy(this.gameObject);
        }

    }
}
