using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private int _secondsForWinScreen = 2;
    [SerializeField] private int _enemyAmount = default;
    void Start()
    {
        _enemyAmount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    public void SubstractEnemyCounter()
    {
        _enemyAmount--;
    }

    private void Update()
    {
        if (_enemyAmount == 0)
        {
            StartCoroutine(WinScreen());
        }
    }

    IEnumerator WinScreen()
    {
        yield return new WaitForSeconds(_secondsForWinScreen);
        SceneManager.LoadScene("WinScreen");
    }
}
