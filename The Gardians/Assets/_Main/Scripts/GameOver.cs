using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int _SecondsForWinScreen = 3;
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
       StartCoroutine(WinScreen());
    }
    IEnumerator WinScreen()
    {
        // Codigo para poder cargar la escena de "Ganaste"
        if (_cantidadEnemigos == 0)
        {
            yield return new WaitForSeconds(_SecondsForWinScreen);
            SceneManager.LoadScene("WinScreen");
        }
    }
}
