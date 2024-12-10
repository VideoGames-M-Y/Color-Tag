using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class ReturnToGame : MonoBehaviour
{
    [SerializeField] [Tooltip("Time (in seconds) to wait before starting the game")] float delayBeforeStart = 2f;
    [SerializeField] [Tooltip("Name of the scene to move to when starting the game")] string sceneName;
    void Start()
    {
        StartCoroutine(returnToGame());
    }

    private IEnumerator returnToGame()
    {
        yield return new WaitForSeconds(delayBeforeStart);
        SceneManager.LoadScene(sceneName);
    }
}
