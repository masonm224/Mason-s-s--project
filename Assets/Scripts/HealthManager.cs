using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    private float time = 120.0f;
    public bool isGameActive = true;
    public Image healthBarP1;
    public Image healthBarP2;
    public TextMeshProUGUI gameOverText;
    public float healthP1 = 100.0f;
    public float healthP2 = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //runs timer
        Timer();


        //test damage

        if (Input.GetKeyDown(KeyCode.Return))
        {

            DealDamageP1(25);
            DealDamageP2(25);

        }

        if (healthP1 <= 0 && healthP2 <= 0)
        {

            GameOver();

        }
        
    }

    // sets up game over screen
    public void GameOver()
    {

        gameOverText.gameObject.SetActive(true);

    }

    // Changes health bar to show damage
    public void DealDamageP1(float damage)
    {

        healthP1 -= damage;

        healthBarP1.fillAmount = healthP1 / 100.0f;

    }

    // Damage for player 2
    public void DealDamageP2(float damage)
    {

        healthP2 -= damage;

        healthBarP2.fillAmount = healthP2 / 100.0f;

    }

    // sets and runs a 2 minute timer
    public void Timer()
    {

        if (time > 0.0f && isGameActive)
        {

            time -= Time.deltaTime;
            int timer = Mathf.FloorToInt(time);
            timerText.text = "Survive: " + timer;

        }
        else if (time < 1.0f)
        {

            GameOver();

        }

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
