using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereadorEnemigo : MonoBehaviour
{
    // Definición de variables

    // objeto -> prefab ato
    public GameObject autop;
    public float maxPos = 6.6f;
    float temp;
    float delayTemp = 0.8f; // tiempo de espera para que aparezca otro auto
    //------------------------------------------
    void Start()
    {
        temp = delayTemp;
    }

    //------------------------------------------
    void Update()
    {
        temp = temp - Time.deltaTime; // decremento del temporizador
        if (temp <= 0)
        {
            Vector3 autoPos = new Vector3(Random.Range(-6.6f, 6.6f), transform.position.y, -1.26f);

            // Se crea la instancia del auto enemigo
            Instantiate(autop, autoPos, transform.rotation);
            temp = delayTemp;
        }
    }
}
