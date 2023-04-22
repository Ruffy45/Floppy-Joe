using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapSpeed;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public Button resume;
    public GameObject Resume;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit Works");
            Application.Quit();
        }
        if (transform.position.y < -5)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Resume.active = true;
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive ==true)
        {
            myRigidBody.velocity = Vector2.up * flapSpeed; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
