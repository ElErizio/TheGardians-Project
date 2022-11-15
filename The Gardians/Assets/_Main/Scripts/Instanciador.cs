using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject NextProjectile;
    void Start()
    {
        Instantiate(NextProjectile, transform.position, transform.rotation);
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "EggProjectile")
        {
            Instantiate(NextProjectile, transform.position, transform.rotation);
        }
    }
}
