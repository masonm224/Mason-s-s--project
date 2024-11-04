using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public Image healthBar;
    public float health = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //test damage

        if (Input.GetKeyDown(KeyCode.Return))
        {

            DealDamage(25);

        }
        
    }

    // Changes health bar to show damage
    public void DealDamage(float damage)
    {

        health -= damage;

        healthBar.fillAmount = health / 100.0f;

    }


    /*
    // Heals player
    public void Heal(float healing)
    {

        health += healing;
        health = Mathf.Clamp(healing, 0, 100);

        healthBar.fillAmount += healing / 100.0f;

    }
    */
}
