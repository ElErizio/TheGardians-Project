using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    // Variables necesarias para los puntos de vida del enemigo
    public float HP; //Puntos de vida
    public float MaxHP = 10; // Vida Maxima

    void Start()
    {
        // Indicamos recien ejecutado el proyecto que la vida del enemigo sea igual a la vida maxima
        HP = MaxHP; 
    }

    public void TakeHit(float dmg)
    { 
        HP -= dmg;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
