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
        
        if (Input.GetKeyDown(KeyCode.X)) 
        {

            Instantiate(playerBulletFWPrefab, transform.position, playerBulletFWPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.V)) 
        {

            Instantiate(playerBulletDWPrefab, transform.position, playerBulletDWPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            Instantiate(playerBulletLPrefab, transform.position, playerBulletLPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.B))
        {

            Instantiate(playerBulletRPrefab, transform.position, playerBulletRPrefab.transform.rotation);

        }

    }

    private IEnumerator Delay()
    {

        yield return new WaitForSeconds(1/4);

    }
}
