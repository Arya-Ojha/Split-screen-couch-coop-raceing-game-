using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float topRangez;
    public float topRangex;
    public float lowerRangez;
    public float lowerRangex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topRangez) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerRangez) {
            Destroy(gameObject);
        }
        else if (transform.position.x > topRangex) {
            Destroy(gameObject);
        } else if (transform.position.x < lowerRangex) {
            Destroy(gameObject);
        }   
    }   
}
