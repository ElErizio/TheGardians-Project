using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private int _SecondsForWinScreen = 2;
    [SerializeField] private int _EnemyAmount = default;
    void Start()
    {
        _EnemyAmount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    public void SubstractEnemyCounter()
    {
        _EnemyAmount--;
    }

    private void Update()
    {
        if (_EnemyAmount == 0)
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
