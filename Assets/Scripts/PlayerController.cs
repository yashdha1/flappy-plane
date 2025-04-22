using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Va
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is where we get Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 
      
        //transform.Translate(0, 0, 1); or below

        //we Move the Vehicle Forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // we turn the vahical
        transform.Rotate(Vector3.up , turnSpeed * horizontalInput * Time.deltaTime);

    }
}
