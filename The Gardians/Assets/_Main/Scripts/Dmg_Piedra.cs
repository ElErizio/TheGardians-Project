using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmg_Piedra : MonoBehaviour
{
    // Variable con la cantidad de da�o que puede hacer el proyectil
    public float _Dmg = 12f;

    // Funcion para que cuando colisione el poryectil haga X cantidad de da�o
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<VidaEnemigos>();

        if (enemy)
        {
            enemy.TakeHit(_Dmg);
        }

        var paredLadrillo = collision.collider.GetComponent<VidaPared>();
        if (paredLadrillo)
        {
            paredLadrillo.TakeHit(_Dmg);
        }
        /* Todav�a estoy por ver despues de cuanto vamos a hacer que desaparezca el proyectil lanzado
        Destroy(gameObject):
        */
    }
}
