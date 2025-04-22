using UnityEngine;
using UnityEngine.SceneManagement;  // To reload the scene

public class PlayerCollision : MonoBehaviour
{
    private bool gameEnded = false;  // Flag to ensure game over happens only once

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && !gameEnded)
        {
            Debug.Log("Game Over");  // Immediately print Game Over message in the console
            Time.timeScale = 0f;     // Pause the game
            gameEnded = true;        // Set flag to true to avoid repeated game over
        }
    }

    void Update()
    { 
        if (gameEnded && Input.GetKeyDown(KeyCode.R))  // Restart the game when 'R' is pressed
        {
            Time.timeScale = 1f;  // Unpause the game
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  // Reload the current scene
        }
    }
}
