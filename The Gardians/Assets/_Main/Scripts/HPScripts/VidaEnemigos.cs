using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    // Variables necesarias para los puntos de vida del enemigo
    [SerializeField] private float hp; //Puntos de vida
    [SerializeField] private float _maxHP = 10; // Vida Maxima
    [SerializeField] private GameOver _gameOver;

    void Start()
    {
        // Indicamos recien ejecutado el proyecto que la vida del enemigo sea igual a la vida maxima
        hp = _maxHP; 
    }

    public void TakeHit(float damage)
    { 
        hp -= damage;
        if (hp <= 0)
        {           
            _gameOver.SubstractEnemyCounter();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D colliInfo)
    {
        if (colliInfo.relativeVelocity.magnitude > hp)
        {
            Die();
        }
    }
    void Die()
    {
        _gameOver.SubstractEnemyCounter();
        Destroy(gameObject);
    }
}
