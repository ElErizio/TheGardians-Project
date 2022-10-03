using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ejemploPerder : MonoBehaviour
{
    private int CantidadEnemigos; 

    // Update is called once per frame
    void Start()
    {   
        CantidadEnemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
}
