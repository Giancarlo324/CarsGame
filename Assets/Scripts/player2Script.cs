using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Script : MonoBehaviour
{
    // Defición de variables

    public float velocidad = 10.0f;
    public float torque = -200.0f;

    public bool velocidadMax = false;
    public bool velocidadMin = false;
    public float velMax = 20.0f;
    public float velMin = 5.0f;

    public float factor = 0.9f;
    public float facrapidez = 0.1f;
    public float rapMax = 2.5f;
    public int nVueltas = 0;

    public int maxVueltas = 2;

    //---------------------------------------------
    void Start()
    {
        // Posición predeterminada del auto al iniciar el juego
        transform.position = new Vector3(1.66f, 8.63f, 0);

    }

    //---------------------------------------------
    void Update()
    {

        movimientoAuto();
    }
    //---------------------------------------------
    void movimientoAuto()
    {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        float auxfactor = factor;
        if (velDerecha().magnitude > rapMax)
        {
            auxfactor = facrapidez;
        }


        //-- VELOCIDAD DEL MOVIMIENTO PARA EL AUTO 2  --

        //--- Acelerar con la tecla F --
        if (velocidadMax == false && velocidadMin == false && Input.GetKey(KeyCode.F))
        {
            rb.AddForce(transform.up * velocidad);
        }
        else if (velocidadMax == true && velocidadMin == false && Input.GetKey(KeyCode.F))
        {
            rb.AddForce(transform.up * velMax);
        }
        else if (velocidadMax == false && velocidadMin == true && Input.GetKey(KeyCode.F))
        {
            rb.AddForce(transform.up * velMin);
        }

        float t = Mathf.Lerp(0, torque, rb.velocity.magnitude / 2);


        rb.angularVelocity = (Input.GetAxis("Vertical2") * torque);
    }

    //-----Control de velocidad ---------
    Vector2 velAdelante()
    {
        return transform.up * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.up);
    }
    //--
    Vector2 velDerecha()
    {
        return transform.up * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.right);
    }

    //--
    //----------------------------------------------------
    public void VelMaxEncendido()
    {
        velocidadMax = true;
        velocidadMin = false;
        StartCoroutine(poderVelMax());
    }
    public void fVueltas()
    {
        nVueltas += 1;

        if (nVueltas == maxVueltas)
        {
            Debug.Log("Terminooo");
        }
    }
    //----------------------------------------------------
    public IEnumerator poderVelMax()
    {
        yield return new WaitForSeconds(20.0f);
        velocidadMax = false; //  Terminar poder velocidad máxima
    }
    //----------------------------------------------------
    public void VelMinEncendido()
    {
        velocidadMin = true;
        velocidadMax = false;
        StartCoroutine(poderVelMin());
    }

    //----------------------------------------------------
    public IEnumerator poderVelMin()
    {
        yield return new WaitForSeconds(10.0f);
        velocidadMin = true; //  Terminar poder velocidad mínima
    }
}
