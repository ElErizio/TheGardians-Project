using Cinemachine;
using System.Collections;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public static Instanciador Instance { get; private set; }
    [SerializeField] private GameObject _projectilePrefab;
    // Valores de el tiempo de espera de la camara antes de moverse, El Proyectil Al que vamos a seguir y La camara que se va a mover
    [SerializeField] private int _tiempoEspera = 3;
    [SerializeField] private CinemachineVirtualCamera _camara;

    private void Awake()
    {
        Instance = this;
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(_tiempoEspera);
        InstantiateProjectile();
    }

    public void InstantiateProjectile()
    {
        var newProjectile = Instantiate(_projectilePrefab, transform.position, transform.rotation);
        _camara.Follow = newProjectile.transform.GetChild(0);
    }
}
