using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornDamage : MonoBehaviour
{
    public float _Dmg = 10f;

    // Funcion para que cuando colisione el poryectil haga X cantidad de daño
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<VidaEnemigos>();

        if (enemy)
        {
            enemy.TakeHit(_Dmg);
        }

        var stoneWall = collision.collider.GetComponent<VidaStone>();
        if (stoneWall)
        {
            stoneWall.TakeHit(_Dmg);
        }
        var iceWall = collision.collider.GetComponent<VidaIce>();
        if (iceWall)
        {
            iceWall.TakeHit(_Dmg);
        }
        var woodWall = collision.collider.GetComponent<VidaWood>();
        if (woodWall)
        {
            woodWall.TakeHit(_Dmg);
        }
        var glassWall = collision.collider.GetComponent<VidaGlass>();
        if (glassWall)
        {
            glassWall.TakeHit(_Dmg);
        }
        var bricksWall = collision.collider.GetComponent<VidaBricks>();
        if (bricksWall)
        {
            bricksWall.TakeHit(_Dmg);
        }
    }
}
