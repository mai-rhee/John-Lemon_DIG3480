using UnityEngine;
using TMPro;  // Required for TextMeshPro

public class CountdownTimer : MonoBehaviour
{

    public GameEnding gameEnding; // Reference to the GameEnding script
    public float timeRemaining = 10f;            // Timer start value
    public TextMeshProUGUI timerText;           // Drag your UI Text here in Inspector
    private bool timerIsRunning = true;

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                TimerFinished();
            }
        }
    }

    void UpdateTimerDisplay()
    {
        timerText.text = Mathf.Ceil(timeRemaining).ToString();
    }

    void TimerFinished()
    {
        Debug.Log("Timer has finished!");
        gameEnding.CaughtPlayer(); // Call the method to handle game ending
        // You can also trigger any other game logic here, like showing a message or transitioning to another scene.
        // Trigger any logic you want here, like ending the level, spawning something, etc.
    }
}
