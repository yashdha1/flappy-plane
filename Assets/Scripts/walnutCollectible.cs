using UnityEngine;

public class walnutCollectilble : MonoBehaviour
{
    public float RotationSpeed;

    public GameObject onCollectEffect;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotationSpeed, 0);
    }

   private void OnTriggerEnter(Collider other) {

    
     // Destroy the collectible
       Destroy(gameObject);

       // instantiate the particle effect
Instantiate(onCollectEffect, transform.position, transform.rotation);
}

}
