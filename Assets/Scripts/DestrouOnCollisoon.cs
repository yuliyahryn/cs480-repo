using UnityEngine;

public class DestrouOnCollisoon : MonoBehaviour
{
    public bool destroyWithAnyObject = false;
    public string collisionTag = "";

    void OnCollisionEnter(Collision collision)
    {
        if (destroyWithAnyObject || collision.gameObject.CompareTag(collisionTag))
        {
            Destroy(gameObject);
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
