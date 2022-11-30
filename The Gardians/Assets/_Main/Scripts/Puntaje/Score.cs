using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private float score = 1200;
    [SerializeField] private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        score -= Time.deltaTime;
        textMesh.text = score.ToString("0");
    }

    public void AddingPoints(float pointsEnter)
    { 
        score += pointsEnter;
    }
}
