using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody enemyRigidbody;
    private GameObject player2;
    private int xBoundary = 30;
    private int zBoundary = 20; 
    // Start is called before the first frame update
    void Start()
    {
         

        //follow player stuff   
       enemyRigidbody = GetComponent<Rigidbody>();
       
       player2 = GameObject.Find("Player2");

    }

    // Update is called once per frame
    void Update()
    {
        //follow player stuff
        enemyRigidbody.AddForce((player2.transform.position - transform.position).normalized * speed/7);
        
        //enemy boundary to prevent them from orbiting the player wayyyyy off the screen
       if (transform.position.x < -xBoundary){
          transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);
       }

       if (transform.position.x > xBoundary){
          transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
       }

       if (transform.position.z < -zBoundary){
          transform.position = new Vector3(transform.position.x, transform.position.y, -zBoundary);
       }

       if (transform.position.z > zBoundary){
          transform.position = new Vector3(transform.position.x, transform.position.y, zBoundary);
       }
    }
}
