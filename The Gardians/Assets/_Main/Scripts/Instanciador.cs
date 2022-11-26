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

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "AcornProjectile")
        {
            Instantiate(NextProjectile, transform.position, transform.rotation);
        }
    }
}
