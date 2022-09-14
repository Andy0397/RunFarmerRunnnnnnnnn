using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPefabs;
    private float spawnRangeX = 15;
    private int spawnPostZ = 20;
    private float starDelay = 2f;
    private float spawnInterval = 1.5f; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", starDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPostZ);
        int animalIndex = Random.Range(0, animalPefabs.Length);
        Instantiate(animalPefabs[animalIndex], spawnPos, animalPefabs[animalIndex].transform.rotation);
    }
}
