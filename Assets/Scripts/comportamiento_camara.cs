using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamiento_camara : MonoBehaviour
{
    // Definición de variables
    public Transform camara;
    void Start()
    {
        
    }

    //------------------------------------
    void Update()
    {
        transform.position = new Vector3(camara.position.x, camara.position.y, -3.0f);
    }
}
