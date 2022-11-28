using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int _SecondsForWinScreen = 2;
    public int _cantidadEnemigos = default;
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
        if (_cantidadEnemigos == 0)
        {
            StartCoroutine(WinScreen());
        }
    }

    IEnumerator WinScreen()
    {
        yield return new WaitForSeconds(_SecondsForWinScreen);
        SceneManager.LoadScene("WinScreen");
    }
}
