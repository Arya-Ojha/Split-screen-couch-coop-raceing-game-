using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrifab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandamAnimal",3,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandamAnimal () {
        int animalIndex = Random.Range(0,animalPrifab.Length);
        Instantiate(animalPrifab[animalIndex],new Vector3(Random.Range(-15,15),0,20),animalPrifab[animalIndex].transform.rotation );
    }
}

    
