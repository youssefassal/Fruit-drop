using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_Control : MonoBehaviour
{
    private string inthecloud = "y";

    void Start()
    {
        if (transform.position.y < 3.5)
        {
            inthecloud = "n";
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

    void Update()
    {
        if (inthecloud == "y")
        {
            GetComponent<Transform>().position = Cloud_Control.cloudxPos;
        }

        if(Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            inthecloud = "n";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            Cloud_Control.spawnPos = transform.position;
            Cloud_Control.newfruit = "y";
            Cloud_Control.whichFruit = int.Parse(gameObject.tag);
            Destroy(gameObject);
        }
    }
}
