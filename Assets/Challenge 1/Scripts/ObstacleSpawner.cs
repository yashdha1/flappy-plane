using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;  // Assign your obstacle prefabs here
    public float spawnInterval = 2f;      // Time between spawns
    public float spawnRangeX = 10f;       // Left-right spawn range
    public float spawnZOffset = 70f;     // How far ahead of the player to spawn
    public ScoreManager scoreManager; // Set this in the inspector


    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Tag your Plane as "Player"
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        if (player == null) return;

        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        float randomY = Random.Range(-8f, 8f);
        float spawnZ = player.position.z + spawnZOffset;

        Vector3 spawnPos = new Vector3(randomX, randomY, spawnZ);
        int index = Random.Range(0, obstaclePrefabs.Length);

        GameObject obstacle = Instantiate(obstaclePrefabs[index], spawnPos, Quaternion.identity);

        ObstaclePassChecker checker = obstacle.GetComponent<ObstaclePassChecker>();
        if (checker != null)
        {
            checker.Initialize(player, scoreManager);
        }
    }


}
