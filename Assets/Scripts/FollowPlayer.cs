using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offse the camera behind the player by adding to the player's position
        transform.position = Player.transform.position + offset ;
    }
}
