using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPared : MonoBehaviour
{
    // Variables necesarias para los puntos de vida del Muro
    public float _HP; //Puntos de vida
    public float _MaxHP = 5; // Vida Maxima

    void Start()
    {
        // Indicamos recien ejecutado el proyecto que la vida del enemigo sea igual a la vida maxima
        _HP = _MaxHP;
    }

    public void TakeHit(float dmg)
    {
        _HP -= dmg;
        if (_HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
