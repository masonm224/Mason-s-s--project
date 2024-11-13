using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterLeft : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody enemyShooterLRigidbody;
    private GameObject player;
    private int zBoundary = -16;

    public GameObject[] bulletPrefabs;
    private float startDelay = 1;
    public float spawnInterval = 1;


    // Start is called before the first frame update
    void Start()
    {

        //follow player stuff   
        enemyShooterLRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        InvokeRepeating("SpawnLBullet", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

        //follow player stuff
        enemyShooterLRigidbody.AddForce((player.transform.position - transform.position).normalized * speed / 7);

        //enemy boundary to prevent them from walking to the player

        if (transform.position.z > zBoundary)
        {
            transform.position = new Vector3(transform.position.z, transform.position.y, zBoundary);
        }

    }

    private void SpawnLBullet()
    {

        int bulletIndex = Random.Range(0, bulletPrefabs.Length);

        Instantiate(bulletPrefabs[bulletIndex], transform.position, bulletPrefabs[bulletIndex].transform.rotation);

    }

}
