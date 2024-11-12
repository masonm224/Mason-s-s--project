using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterLeft : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody enemyShooterLRigidbody;
    private GameObject player;
    private int xBoundary = -16;


    // Start is called before the first frame update
    void Start()
    {

        //follow player stuff   
        enemyShooterLRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        //follow player stuff
        enemyShooterLRigidbody.AddForce((player.transform.position - transform.position).normalized * speed / 7);

        //enemy boundary to prevent them from walking to the player

        if (transform.position.x > xBoundary)
        {
            transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
        }

    }
}
