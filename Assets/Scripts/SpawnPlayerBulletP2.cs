using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerBulletP2 : MonoBehaviour
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
        //P2
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {

            Instantiate(playerBulletFWPrefab, transform.position, playerBulletFWPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {

            Instantiate(playerBulletDWPrefab, transform.position, playerBulletDWPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {

            Instantiate(playerBulletLPrefab, transform.position, playerBulletLPrefab.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {

            Instantiate(playerBulletRPrefab, transform.position, playerBulletRPrefab.transform.rotation);

        }



    }
}
