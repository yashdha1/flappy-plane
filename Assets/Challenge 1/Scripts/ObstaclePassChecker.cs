using UnityEngine;

public class ObstaclePassChecker : MonoBehaviour
{
    private Transform player;
    private ScoreManager scoreManager;
    private bool hasScored = false;

    public void Initialize(Transform playerTransform, ScoreManager manager)
    {
        player = playerTransform;
        scoreManager = manager;
    }

    void Update()
    {
        if (!hasScored && transform.position.z < player.position.z)
        {
            hasScored = true;
            scoreManager.AddPoint();
        }
    }
}
