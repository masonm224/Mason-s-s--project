using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private float moveSpeed = 10;
    public float horizontalInput;
    public float verticalInput;
    private Vector3 movement;
    private int xBoundary = 22;
    private int zBoundary = 12;
    private HealthManager healthManager;
    // Start is called before the first frame update
    void Start()
    {
      healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();   
    }

    // Update is called once per frame
    void Update()
    {
      movement = Vector3.zero;

        // Handle forward and backward movement (W and S)
        if (Input.GetKey(KeyCode.UpArrow)) // Move forward
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow)) // Move backward
        {
            movement += Vector3.back;
        }

        // Handle left and right movement (A and D)
        if (Input.GetKey(KeyCode.LeftArrow)) // Move left
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow)) // Move right
        {
            movement += Vector3.right;
        }

        // Normalize movement to prevent faster diagonal movement
        movement = movement.normalized * moveSpeed * Time.deltaTime;

        // Apply the movement using transform.Translate
        transform.Translate(movement);

        //player boundary
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
      public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            healthManager.DealDamageP2(20);

        }
    }

}
