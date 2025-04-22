using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
       // Rotate the propeller around the Z-axis continuously
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
