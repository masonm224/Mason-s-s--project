using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    public float horizontalInput;
    public float verticalInput;
    private int xBoundary = 22;
    private int zBoundary = 12;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");

      transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
      transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

      //Player Movement Boundaries
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
