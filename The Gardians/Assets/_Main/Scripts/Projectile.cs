using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Bool para saber si el click es presionado
    private bool _isPressed = false;
    public Rigidbody2D _rigidB;
    public Rigidbody2D _hook;
    public float _maxDragDistance = 8.0f;
    // Valor para la cantidad de tiempo para liberar el proyectil del SpringJoint2D
    public float _releaseTime = .15f;
    private Instanciador instanciador;
    private void Update()
    {
        if (_isPressed)
        {
            //_rigidB.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);//

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(_hook.position, mousePos) > _maxDragDistance)
            {
                _rigidB.position = _hook.position + (mousePos - _hook.position).normalized * _maxDragDistance;
            }
            else
            {
                _rigidB.position = mousePos;
            }
        }
    }
    private void Start()
    { 
        instanciador = Instanciador.Instance;
    }
        

    // Propiedades del projectile si es click es presionado
    private void OnMouseDown()
    {
        _isPressed = true;
        _rigidB.isKinematic = true;
    }

    // Propiedades del proyectil si el click no es presionado
    private void OnMouseUp()
    {
        _isPressed = false;
        _rigidB.isKinematic = false;
        StartCoroutine(Release());
    }

    // Codigo para liberar el proyectil
    IEnumerator Release() 
    {
        yield return new WaitForSeconds(_releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {       
        Destroy(gameObject, 3f);
        instanciador.InstantiateProjectile();
    }
    */
}
