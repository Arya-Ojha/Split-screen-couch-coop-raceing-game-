using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerControlar : MonoBehaviour
{
    public float horizontalInput;
    public float horizontalSpeed;
    public float xRange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange){
            transform.position = new Vector3 (-xRange,transform.position.y,transform.position.z);
        } 
        if (transform.position.x > xRange){
            transform.position = new Vector3 (xRange,transform.position.y,transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*horizontalInput*horizontalSpeed);
    }
}
