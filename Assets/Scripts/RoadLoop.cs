using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    public GameObject player; // Reference to the player
    public float roadLength = 1f; // Length of each road segment
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // If the player moves past the middle of this road segment
        if (player.transform.position.z > transform.position.z + roadLength / 2)
        {
            RepositionRoad();
        }
    }

    void RepositionRoad()
    {
        // Move this road segment to the end of the last segment
        transform.position += new Vector3(0, 0, roadLength * 2);
    }
}
