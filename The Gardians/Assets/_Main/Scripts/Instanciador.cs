using Cinemachine;
using System.Collections;
using UnityEngine;

public class Instanciador : Singleton<Instanciador>
{
    public GameObject NextProjectile;
    // Valores de el tiempo de espera de la camara antes de moverse, El Proyectil Al que vamos a seguir y La camara que se va a mover
    public int _tiempoEspera = 3;
    [SerializeField] private CinemachineVirtualCamera _camara;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(_tiempoEspera);
        var newProjectile = Instantiate(NextProjectile, transform.position, transform.rotation);
        _camara.Follow = newProjectile.transform;
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        /*
        Destroy(gameObject, 3f);
        InstantiateProjectile();
        
        if (col.gameObject.tag == "AcornProjectile")
        {
            var newProjectile = Instantiate(NextProjectile, transform.position, transform.rotation);
            _camara.Follow = newProjectile.transform;
        }
        */
    }
    
    public void InstantiateProjectile()
    {
            var newProjectile = Instantiate(NextProjectile, transform.position, transform.rotation);
            _camara.Follow = newProjectile.transform;

    }

}
