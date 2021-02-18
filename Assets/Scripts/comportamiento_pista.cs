using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamiento_pista : MonoBehaviour
{
    // Definición de variables
    public float velocidad = 0.6f;
    Vector2 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(Time.time * velocidad, transform.position.y); 

        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
