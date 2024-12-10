using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float roundTime = 30f;
    [SerializeField] private TMP_Text TimeText;
    private float timeRemaining;

    [SerializeField]
    [Tooltip("Game over")]
    private string sceneName;

    public void Start()
    {
        timeRemaining = roundTime;
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            EndGame(false);
        }
    }

    private void UpdateTimerDisplay()
    {
        if (TimeText != null)
        {
            TimeText.text = "Time: " + Mathf.RoundToInt(timeRemaining);
        }
    }

    private void EndGame(bool won)
    {
        if (won)
        {
            Debug.Log("You won!");
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
