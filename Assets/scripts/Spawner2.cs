using UnityEngine;

public class Spawner2 : MonoBehaviour
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
        Instantiate(animalPrifab[animalIndex],new Vector3(22,0,Random.Range(0,15)),Quaternion.Euler(0, 90, 0) * animalPrifab[animalIndex].transform.rotation);

        int animalIndex2 = Random.Range(0,animalPrifab.Length);
        Instantiate(animalPrifab[animalIndex2],new Vector3(-22,0,Random.Range(0,15)),Quaternion.Euler(0, -90, 0) * animalPrifab[animalIndex2].transform.rotation);
    }
}
