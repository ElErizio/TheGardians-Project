using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornDamage : MonoBehaviour
{
    public float _Dmg = 7f;

    // Funcion para que cuando colisione el poryectil haga X cantidad de daño
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
    }
}
