using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Name of the scene to move to when the correct color is triggered")]
    private string nextSceneName;

    [SerializeField]
    [Tooltip("Name of the scene to load on game over")]
    private string gameOverSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Expected target color: " + TargetColorManager.targetColor);
        if (other.CompareTag(TargetColorManager.targetColor))
        {
            Debug.Log("Correct color! Moving to the next level.");
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log("Wrong color! Game over.");
            SceneManager.LoadScene(gameOverSceneName);
        }
    }
}
