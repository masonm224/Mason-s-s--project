using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float startDelay = 1;
    private float spawnInterval = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], GenerateRandomVector(), enemyPrefabs[enemyIndex].transform.rotation);

    }

    Vector3 GenerateRandomVector()
    {
        // Generate a random float between -25 and 25 for the x component
        float randomX = Random.Range(-25f, 25f);

        // Fixed values for y and z
        float y = 0.5f;
        float z = Random.Range(0, 2) == 0 ? 18f : -18f;

        // Return the random Vector3
        return new Vector3(randomX, y, z);

    }
}
