using UnityEngine;

public class VidaGlass : MonoBehaviour
{
    // Variables necesarias para los puntos de vida del Muro
    [SerializeField] private float _HP; //Puntos de vida
    [SerializeField] private float _MaxHP = 3; // Vida Maxima

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
