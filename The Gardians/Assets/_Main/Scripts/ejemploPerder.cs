using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ejemploPerder : MonoBehaviour
{
    private int _cantidadEnemigos = default; 

    void Start()
    {   
        _cantidadEnemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
}
