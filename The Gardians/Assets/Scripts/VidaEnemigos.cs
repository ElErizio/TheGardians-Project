using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    // Variables necesarias para los puntos de vida del enemigo
    public float HP; //Puntos de vida
    public float MaxHP = 10; // Vida Maxima

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
            // Aquí probablemente vamos a agregar una funcion para que le reste 1 al valor de CantidadEnemigos en "EjemploPerder"
            // y luego ejecutar un if para ver si Ganó el jugador y sacar la escena de "GameOver"

            Destroy(gameObject);
        }

    }
}
