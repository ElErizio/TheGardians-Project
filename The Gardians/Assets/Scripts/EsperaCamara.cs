using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EsperaCamara : MonoBehaviour
{
    // Valores de el tiempo de espera de la camara antes de moverse, El Proyectil Al que vamos a seguir y La camara que se va a mover
    public int tiempoEspera = 4;
    [SerializeField] private Transform proyectil;
    [SerializeField] private CinemachineVirtualCamera camara;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(esperarCamara());      
    }
    // Corrutina para inicializar la camara
    IEnumerator esperarCamara()
    {
        yield return new WaitForSeconds(tiempoEspera);
        camara.Follow = proyectil; 
        // GetComponent<CinemachineVirtualCamera>().Follow; <--- intento fallido de seguimiento de proyectil
    }
}
