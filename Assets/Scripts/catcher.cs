using UnityEngine;
using UnityEngine.SceneManagement;

public class Catcher : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private string gameOverSceneName = "GameOver"; 

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player caught! Game over!");
            SceneManager.LoadScene(gameOverSceneName);
        }
    }
}
