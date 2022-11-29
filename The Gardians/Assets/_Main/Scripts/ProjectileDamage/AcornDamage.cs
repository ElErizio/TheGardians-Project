using UnityEngine;

public class AcornDamage : MonoBehaviour
{
    [SerializeField] private float _damage = 10f;

    // Funcion para que cuando colisione el poryectil haga X cantidad de daño
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<VidaEnemigos>();

        if (enemy)
        {
            enemy.TakeHit(_damage);
        }

        var stoneWall = collision.collider.GetComponent<VidaStone>();
        if (stoneWall)
        {
            stoneWall.TakeHit(_damage);
        }
        var iceWall = collision.collider.GetComponent<VidaIce>();
        if (iceWall)
        {
            iceWall.TakeHit(_damage);
        }
        var woodWall = collision.collider.GetComponent<VidaWood>();
        if (woodWall)
        {
            woodWall.TakeHit(_damage);
        }
        var glassWall = collision.collider.GetComponent<VidaGlass>();
        if (glassWall)
        {
            glassWall.TakeHit(_damage);
        }
        var bricksWall = collision.collider.GetComponent<VidaBricks>();
        if (bricksWall)
        {
            bricksWall.TakeHit(_damage);
        }
    }
}
