using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Bool para saber si el click es presionado
    [SerializeField] private bool _isPressed = false;
    public Rigidbody2D _rigidBody;
    public Rigidbody2D _hook;
    [SerializeField] private float _maxDragDistance = 8.0f;
    // Valor para la cantidad de tiempo para liberar el proyectil del SpringJoint2D
    [SerializeField] private float _releaseTime = .15f;
    [SerializeField] private float _lifeSpan = 10f;

    private void Update()
    {
        if (_isPressed)
        {
            //_rigidB.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);//

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(_hook.position, mousePos) > _maxDragDistance)
            {
                _rigidBody.position = _hook.position + (mousePos - _hook.position).normalized * _maxDragDistance;
            }
            else
            {
                _rigidBody.position = mousePos;
            }
        }
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(_lifeSpan);
        DestroyProjectile();
    }

    private void DestroyProjectile()
    {
        Instanciador.Instance.InstantiateProjectile();
        Destroy(transform.parent.gameObject);
    }

    // Propiedades del projectile si es click es presionado
    private void OnMouseDown()
    {
        _isPressed = true;
        _rigidBody.isKinematic = true;
    }

    // Propiedades del proyectil si el click no es presionado
    private void OnMouseUp()
    {
        _isPressed = false;
        _rigidBody.isKinematic = false;
        StartCoroutine(Release());
    }

    // Codigo para liberar el proyectil
    IEnumerator Release()
    {
        yield return new WaitForSeconds(_releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            DestroyProjectile();
        }
    }
}
