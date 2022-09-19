using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmg_Piedra : MonoBehaviour
{
    // Variable con la cantidad de daño que puede hacer el proyectil
    public float Dmg = 12f;

    // Funcion para que cuando colisione el poryectil haga X cantidad de daño
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<VidaEnemigos>();

        if (enemy)
        {
            enemy.TakeHit(Dmg);
        }

        /* Todavía estoy por ver despues de cuanto vamos a hacer que desaparezca el proyectil lanzado
        Destroy(gameObject):
        */
    }

}
