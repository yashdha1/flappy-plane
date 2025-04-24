using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    public GameObject player; 
    public float roadLength = 1f; 
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    { 
        if (player.transform.position.z > transform.position.z + roadLength / 2)
        {
            RepositionRoad();
        }
    }
    void RepositionRoad()
    {
        transform.position += new Vector3(0, 0, roadLength * 2);
    }
}
