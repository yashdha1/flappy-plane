using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameOnCollision : MonoBehaviour
{
    public GameObject gameOverText;  // Drag your UI Text GameObject here in the Inspector
    bool gameEnded = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && !gameEnded)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
            gameEnded = true;

            if (gameOverText != null)
            {
                gameOverText.SetActive(true);  // Show the Game Over UI
            }
        }
    }

    void Update()
    {
        if (gameEnded && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
