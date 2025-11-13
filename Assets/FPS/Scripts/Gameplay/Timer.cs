using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    [Header("Time limit for the level (in seconds)")]
    public float timeLimit = 60f;

    private float timer;

    void Start()
    {
        timer = timeLimit;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        // Optional: show timer on console (or UI)
        // Debug.Log("Time left: " + timer.ToString("F1"));

        if (timer <= 0f)
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        // Reloads the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    // Optional: call this when player finishes level
    public void PlayerFinishedLevel()
    {
        // Stop the timer from counting down
        enabled = false;
    }
}
