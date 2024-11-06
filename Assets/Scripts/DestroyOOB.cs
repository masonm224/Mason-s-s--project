using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    private float topBounds = 50.0f;
    private float bottomBounds = -50.0f;
    private float leftBounds = -50.0f;
    private float rightBounds = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > topBounds)
        {

            Destroy(gameObject);

        }
        if (transform.position.z < bottomBounds)
        {

            Destroy(gameObject);

        }
        if (transform.position.x < leftBounds)
        {

            Destroy(gameObject);

        }
        if (transform.position.x > rightBounds)
        {

            Destroy(gameObject);

        }





    }
}
