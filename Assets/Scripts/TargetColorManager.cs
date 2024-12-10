using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class TargetColorManager : MonoBehaviour
{
    [SerializeField] TMP_Text ColorText;

    public static string targetColor;

    void Start()
    {
        SetRandomTargetColor();
    }

   public void SetRandomTargetColor()
   {
        string[] colors = { "Red", "Blue", "Green", "Yellow" };
        targetColor = colors[Random.Range(0, colors.Length)];
        Debug.Log("Target Color: " + targetColor);

        if (ColorText != null)
        {
            ColorText.text = "Target Color: " + targetColor;

            switch (targetColor)
            {
            case "Red":
                ColorText.color = Color.red;
                break;
            case "Blue":
                ColorText.color = Color.blue;
                break;
            case "Green":
                ColorText.color = Color.green;
                break;
            case "Yellow":
                ColorText.color = Color.yellow;
                break;
            default:
                ColorText.color = Color.white; 
                break;
            }
        }
    }
}
