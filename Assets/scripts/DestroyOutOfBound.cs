using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float topRange;
    public float lowerRange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topRange) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerRange) {
            Destroy(gameObject);
        }
    }
}
