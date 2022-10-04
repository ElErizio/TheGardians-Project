using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ejemploPerder : MonoBehaviour
{
    private int cantidadEnemigos = default; 

    void Start()
    {   
        cantidadEnemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
}
