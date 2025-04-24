using UnityEngine;
using System.Collections.Generic;

public class InfiniteObjectSpawner : MonoBehaviour
{
    public GameObject player;               // Reference to the player
    public GameObject[] objectsToSpawn;     
    public float spawnDistance = 50f;       // How far ahead of the player to spawn
    public float despawnDistance = 30f;     // How far behind the player before objects are destroyed
    public float spawnIntervalZ = 10f;      // Distance between spawns on Z axis
    public Vector2 spawnRangeX = new Vector2(-3f, 3f); // Random X range for objects

    private float lastSpawnZ;
    private List<GameObject> spawnedObjects = new List<GameObject>();

    void Start()
    {
        lastSpawnZ = player.transform.position.z;
    }

    void Update()
    {
        float playerZ = player.transform.position.z; 
        while (lastSpawnZ < playerZ + spawnDistance)
        {
            SpawnObject(lastSpawnZ + spawnIntervalZ);
            lastSpawnZ += spawnIntervalZ;
        } 
        for (int i = spawnedObjects.Count - 1; i >= 0; i--)
        {
            if (spawnedObjects[i].transform.position.z < playerZ - despawnDistance)
            {
                Destroy(spawnedObjects[i]);
                spawnedObjects.RemoveAt(i);
            }
        }
    }

    void SpawnObject(float zPos)
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector3 spawnPos = new Vector3(randomX, 0f, zPos);
        int randomIndex = Random.Range(0, objectsToSpawn.Length);

        GameObject obj = Instantiate(objectsToSpawn[randomIndex], spawnPos, Quaternion.identity);
        spawnedObjects.Add(obj);
    }
}