using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilPiedra : MonoBehaviour
{
    // Bool para saber si el click es presionado
    private bool esPresionado = false;
    public Rigidbody2D rigidB;
    // Valor para la cantidad de tiempo para liberar el proyectil del SpringJoint2D
    public float tiempoparaLiberar = .15f;

    private void Update()
    {
        if (esPresionado)
        {
            rigidB.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    // Propiedades de la piedra si es click es presionado
    private void OnMouseDown()
    {
        esPresionado = true;
        rigidB.isKinematic = true;
    }
    // Propiedades de la piedra si el click no es presionado
    private void OnMouseUp()
    {
        esPresionado = false;
        rigidB.isKinematic = false;
        StartCoroutine(Release());
    }

    // Codigo para liberar el proyectil
    IEnumerator Release() {

        yield return new WaitForSeconds(tiempoparaLiberar);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 3f);
    }
}
