using UnityEngine;

public class VidaStone : MonoBehaviour
{
    // Variables necesarias para los puntos de vida del Muro
    [SerializeField] private float _hp; //Puntos de vida
    [SerializeField] private float _maxHP = 20; // Vida Maxima

    void Start()
    {
        // Indicamos recien ejecutado el proyecto que la vida del enemigo sea igual a la vida maxima
        _hp = _maxHP;
    }

    public void TakeHit(float damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
