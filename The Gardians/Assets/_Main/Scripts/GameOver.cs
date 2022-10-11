using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private int _cantidadEnemigos = default; 
    void Start()
    {   
        _cantidadEnemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    public void SubstractEnemyCounter()
    {
        _cantidadEnemigos--;
    }
    private void Update()
    {
        GameOverScreen();
    }
    public void GameOverScreen()
    {
        // Codigo para poder cargar la escena de "Ganaste"
        if (_cantidadEnemigos == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
