using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody enemyRigidbody;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {

       //follow player stuff   
       enemyRigidbody = GetComponent<Rigidbody>();
       player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //follow player stuff
        enemyRigidbody.AddForce((player.transform.position - transform.position).normalized * speed/5);
        
        
    }
}
