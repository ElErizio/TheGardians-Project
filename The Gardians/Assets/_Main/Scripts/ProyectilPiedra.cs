using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilPiedra : MonoBehaviour
{
    // Bool para saber si el click es presionado
    private bool _esPresionado = false;
    public Rigidbody2D _rigidB;
    // Valor para la cantidad de tiempo para liberar el proyectil del SpringJoint2D
    public float _tiempoparaLiberar = .15f;

    private void Update()
    {
        if (_esPresionado)
        {
            _rigidB.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    // Propiedades de la piedra si es click es presionado
    private void OnMouseDown()
    {
        _esPresionado = true;
        _rigidB.isKinematic = true;
    }

    // Propiedades de la piedra si el click no es presionado
    private void OnMouseUp()
    {
        _esPresionado = false;
        _rigidB.isKinematic = false;
        StartCoroutine(Release());
    }

    // Codigo para liberar el proyectil
    IEnumerator Release() 
    {
        yield return new WaitForSeconds(_tiempoparaLiberar);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 3f);
    }
}
