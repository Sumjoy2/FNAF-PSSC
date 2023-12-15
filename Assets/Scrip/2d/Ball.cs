using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public GameObject platform;
    
    [Header("HealthStuffs")]
    public int healthMax = 3;
    public int healthCurrent;
    Life health;

    [Header("SpeedVariables")]
    public float speed;
    public float initialX;

    // Awake is called on object initialization
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); // makes rigidbody work
        //Sets initial movement down and with a random X
        rigidbody2d.AddForce(new Vector2(Random.Range(-initialX,initialX), -speed)); 

        //Gets health script, Sets max health to healthMax, Sets current health to max health
        health = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<Life>();
        health.SetMaxHealth(healthMax);
        healthCurrent = healthMax;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Reset Brick Break with R
        if (Input.GetKeyDown (KeyCode.R) == true)
        {
            Reset();
        }

        //When life hits 0 restart level
        if (healthCurrent <= 0) Reset();

        if (gameObject.tag == "Brick")
        {
            LoadScene("ActualGame");
        }
    }

    //Checks if something collides with the ball
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Resets positions and make you loose 1 life
        if (collision.gameObject.tag == "DeathFloor")
        {
            transform.position = new Vector2(0, 0);
            platform.transform.position = new Vector2(transform.position.x, -7);
            healthCurrent--;
            health.SetHealth(healthCurrent);
        }
        else if (collision.gameObject.tag == "Brick")
        {
            collision.gameObject.SetActive(false);
        }
        else
        {
            rigidbody2d.AddForce(new Vector2(Random.Range(-initialX, initialX), 0));
        }
    }

    //Resets the Brick Break mini game. Could change to reset the entire scene
    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
