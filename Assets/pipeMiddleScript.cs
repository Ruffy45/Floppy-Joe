using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Uhm im not sure");
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("testtt");
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        
        
    }
}
