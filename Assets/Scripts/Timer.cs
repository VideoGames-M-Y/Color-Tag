using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float roundTime = 30f;
    [SerializeField] TMP_Text TimeText; 
    private float timeRemaining;
    [SerializeField] [Tooltip("Game over")] string sceneName;

    public void Start(){
        timeRemaining = roundTime;
    }

    void Update(){
        if (timeRemaining > 0){
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else{
            EndGame(false);
        }
    }

    private void UpdateTimerDisplay(){
        if (TimeText != null){
            // Round time to the nearest whole number and display it
            TimeText.text = "Time: " + Mathf.RoundToInt(timeRemaining);
        }
    }

    void EndGame(bool won){
        if (won)
            Debug.Log("You won!");
        else
            SceneManager.LoadScene(sceneName);
    }
}