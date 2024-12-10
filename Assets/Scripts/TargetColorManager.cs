using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class TargetColorManager : MonoBehaviour
{
    [SerializeField] TMP_Text ColorText;

    public static string targetColor;
    // [SerializeField] [Tooltip("Name of the scene to move to when starting the game")] string Yellow;
    // [SerializeField] [Tooltip("Name of the scene to move to when starting the game")] string Red;
    // [SerializeField] [Tooltip("Name of the scene to move to when starting the game")] string Blue;
    // [SerializeField] [Tooltip("Name of the scene to move to when starting the game")] string Green;
    // [SerializeField] [Tooltip("Time (in seconds) to wait before starting the game")] float delayBeforeStart = 2f;

    void Start()
    {
        SetRandomTargetColor();
    }

   public void SetRandomTargetColor(){
        string[] colors = { "Red", "Blue", "Green", "Yellow" };
        targetColor = colors[Random.Range(0, colors.Length)];
        Debug.Log("Target Color: " + targetColor);

        if (ColorText != null){
            ColorText.text = "Target Color: " + targetColor;

            switch (targetColor){
            case "Red":
                ColorText.color = Color.red;
                // SceneManager.LoadScene(Red);
                break;
            case "Blue":
                ColorText.color = Color.blue;
                // SceneManager.LoadScene(Blue);
                break;
            case "Green":
                ColorText.color = Color.green;
                // SceneManager.LoadScene(Green);
                break;
            case "Yellow":
                ColorText.color = Color.yellow;
                // SceneManager.LoadScene(Yellow);
                break;
            default:
                ColorText.color = Color.white; 
                break;
            }
        }
    }

    // private IEnumerator StartGame()
    // {
    //     yield return new WaitForSeconds(delayBeforeStart);
    //     SceneManager.LoadScene(sceneName);
    // }
}