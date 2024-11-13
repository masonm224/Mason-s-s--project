using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterRight : MonoBehaviour
{

    public float speed = 1;
    private Rigidbody enemyShooterRRigidbody;
    private GameObject player;
    private int zBoundary = 16;

    public GameObject[] bulletPrefabs;
    private float startDelay = 1;
    public float spawnInterval = 1;


    // Start is called before the first frame update
    void Start()
    {

        //follow player stuff   
        enemyShooterRRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        InvokeRepeating("SpawnBullet", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

        //follow player stuff
        enemyShooterRRigidbody.AddForce((player.transform.position - transform.position).normalized * speed / 7);

        //enemy boundary to prevent them from walking to the player

        if (transform.position.z > zBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundary);
        }

    }


    private void SpawnBullet()
    {

        int bulletIndex = Random.Range(0, bulletPrefabs.Length);

        Instantiate(bulletPrefabs[bulletIndex], transform.position, bulletPrefabs[bulletIndex].transform.rotation);

    }


}
