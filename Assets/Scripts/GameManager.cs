using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Timer timer;

    void Start(){
        StartNewRound();
    }

    void StartNewRound(){
        timer.Start();
    }

    public void EndGame(bool won){
        if (won){
            Debug.Log("Level Complete! Starting next round...");
            StartNewRound();
        }
        else{
            Debug.Log("Game Over! Restarting...");
        }
    }
}