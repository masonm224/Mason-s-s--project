using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerBullet : MonoBehaviour
{

    public GameObject playerBulletFWPrefab;
    public GameObject playerBulletRPrefab;
    public GameObject playerBulletDWPrefab;
    public GameObject playerBulletLPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Shooting in all directions for each player
        //P1
        
        if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.I)) 
        {

            Instantiate(playerBulletFWPrefab, transform.position, playerBulletFWPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.K)) 
        {

            Instantiate(playerBulletDWPrefab, transform.position, playerBulletDWPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J)) 
        {

            Instantiate(playerBulletLPrefab, transform.position, playerBulletLPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.L))
        {

            Instantiate(playerBulletRPrefab, transform.position, playerBulletRPrefab.transform.rotation);

        }

    }

    private IEnumerator Delay()
    {

        yield return new WaitForSeconds(1/4);

    }
}
