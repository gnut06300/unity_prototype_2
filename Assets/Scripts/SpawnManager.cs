using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
        // public int animalIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnAnimals()
    {
        // randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosZ, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Debug.Log("Instatiate animal");
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
