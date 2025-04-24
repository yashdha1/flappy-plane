using UnityEngine;

public class FollowChacter 
{
    public GameObject Player;

    private Vector3 offset = new Vector3(0,8,-15); 
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset ;
    }
}
