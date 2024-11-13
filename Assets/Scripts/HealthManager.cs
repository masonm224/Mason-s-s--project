using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class HealthManager : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    public float time = 120.0f;
    public bool isGameActive = true;
    public Image healthBarP1;
    public Image healthBarP2;
    public float healthP1 = 100.0f;
    public float healthP2 = 100.0f;
    private GameObject player;
    private GameObject player2;
    private Rigidbody playerRigidbody;
    private Rigidbody player2Rigidbody;
    private SpawnManager spawnManager;

    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI restartPrompt;
    public RawImage WinScreen;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        player2 = GameObject.Find("Player2");
        playerRigidbody = GetComponent<Rigidbody>();
        player2Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //runs timer
        Timer();

        if (Input.GetKeyUp(KeyCode.Escape)) 
        { 
	        Application.Quit();
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            RestartGame();
        }

        if (healthP1 == 0 && isGameActive)
        {
            Destroy(player);
            
            if(healthP2 <= 0)
            {

                GameOver();

            }

            GameObject kill = GameObject.Find("Enemy(Clone)");

            Destroy(kill);

            spawnManager.spawnInterval /= 2;

        }
        else if (healthP2 == 0 && isGameActive)
        {
            Destroy(player2);
            
            if(healthP1 <= 0)
            {

                GameOver();

            }

            GameObject kill = GameObject.Find("Enemy 2 Variant(Clone)");

            Destroy(kill);

            spawnManager.spawnInterval /= 2;

        }
     
    }

    // sets up game over screen
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartPrompt.gameObject.SetActive(true);
        isGameActive = false;
        Time.timeScale = 0; 
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

            WinScreen.gameObject.SetActive(true);
            isGameActive = false;
            Time.timeScale = 0; 

        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
