using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerControlarP2 : MonoBehaviour
{
    public float horizontalInput;
    public float horizontalSpeed;
    public float verticalInput;
    public float verticalSpeed;
    public float xRange;
    public GameObject ProjactilePrefab;
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

        if (transform.position.z < 0){
            transform.position = new Vector3 (transform.position.x,transform.position.y,0);
        } 
        if (transform.position.z > 15){
            transform.position = new Vector3 (transform.position.x,transform.position.y,15);
        }

        horizontalInput = Input.GetAxis("HorizontalP2");
        verticalInput = Input.GetAxis("VerticalP2");
        transform.Translate(Vector3.right*Time.deltaTime*horizontalInput*horizontalSpeed);
        transform.Translate(Vector3.forward*Time.deltaTime*verticalInput*verticalSpeed);
        if (Input.GetMouseButtonDown(0)) {
            Instantiate(ProjactilePrefab,new Vector3(transform.position.x, transform.position.y + 1, transform.position.z),ProjactilePrefab.transform.rotation);
        };
    }
}

