using UnityEngine;
using System.Linq;

public class Singleton : MonoBehaviour
{
    private void Awake()
    {
        string myName = gameObject.name;

        GameObject[] otherObjectsWithSameName =
            Resources.FindObjectsOfTypeAll<GameObject>()
                .Where(obj => obj.name == myName)
                .ToArray();

        Debug.Log("otherObjectsWithSameName.Length: " + otherObjectsWithSameName.Length);

        if (otherObjectsWithSameName.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
