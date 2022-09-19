using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPared : MonoBehaviour
{
    // Variables necesarias para los puntos de vida del Muro
    public float HP; //Puntos de vida
    public float MaxHP = 5; // Vida Maxima

    // Start is called before the first frame update
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
